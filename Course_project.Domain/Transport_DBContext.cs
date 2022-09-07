using System;
using Course_project.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql;


#nullable disable

namespace Course_project.DAL
{
    public partial class Transport_DBContext : DbContext
    {

        //TODO: Нужно перепроверить все ограничения на поля, 
        public Transport_DBContext()
        {
        }

        public Transport_DBContext(DbContextOptions<Transport_DBContext> options)
            : base(options)
        {
            
        }
       

        public virtual DbSet<Address> Addresses { get; set; }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarDriver> CarDrivers { get; set; }
        public virtual DbSet<CarMaintaince> CarMaintainces { get; set; }
        public virtual DbSet<CfWithCp> CfWithCps { get; set; }
        public virtual DbSet<Dcontract> Dcontracts { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Farmer> Farmers { get; set; }
        public virtual DbSet<FsContract> FsContracts { get; set; }
        public virtual DbSet<Fsuggention> Fsuggentions { get; set; }
        public virtual DbSet<Pcontract> Pcontracts { get; set; }
        public virtual DbSet<Port> Ports { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<PriceLog> PriceLogs { get; set; }
        public virtual DbSet<WC> WCs { get; set; }
        public virtual DbSet<WFc> WFcs { get; set; }
        public virtual DbSet<WPc> WPcs { get; set; }
        public virtual DbSet<Waybill> Waybills { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost; Port=5432;Database=Transport_DB; UserName=postgres; Password=qwerty");
                
            }
        }



        //TODO: добавить для полей id свойство ValueGeneratedOnAdd
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

                entity.Property(e => e.AccurateDestination).HasColumnName("accurate_destination");

                entity.Property(e => e.MainDestination)
                    .IsRequired()
                    .HasColumnName("main_destination");

                entity.Property(e => e.NextId).HasColumnName("next_id");

                entity.HasOne(d => d.Next)
                    .WithMany(p => p.InverseNext)
                    .HasForeignKey(d => d.NextId)
                    .HasConstraintName("address_next_id_fkey");
            });


            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("car");

                entity.Property(e => e.CarId)
                .ValueGeneratedOnAdd()
                .HasColumnName("car_id");

                entity.Property(e => e.Brand)
                   .IsRequired()
                   .HasMaxLength(40)
                   .HasColumnName("brand");

                entity.Property(e => e.LiftingCapacity)
                    .HasColumnName("lifting_capacity")
                    .HasDefaultValueSql("27");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("model");

                entity.Property(e => e.StartOperation)
                    .HasColumnType("date")
                    .HasColumnName("start_operation");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Year)
                    .HasColumnType("date")
                    .HasColumnName("year");
            });

            modelBuilder.Entity<CarDriver>(entity =>
            {
                entity.ToTable("car_driver");

                entity.Property(e => e.CarDriverId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("car_driver_id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("date_start");

                entity.Property(e => e.DriverId).HasColumnName("driver_id");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.CarDrivers)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("car_driver_car_id_fkey");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.CarDrivers)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("car_driver_driver_id_fkey");
            });

            modelBuilder.Entity<CarMaintaince>(entity =>
            {
                entity.ToTable("car_maintaince");

                entity.Property(e => e.CarMaintainceId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("car_maintaince_id");

                entity.Property(e => e.CarDriverId).HasColumnName("car_driver_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.Costs)
                    .HasPrecision(10, 2)
                    .HasColumnName("costs");

                entity.Property(e => e.EndMaintaince)
                    .HasColumnType("date")
                    .HasColumnName("end_maintaince");

                entity.Property(e => e.StartMaintaince)
                    .HasColumnType("date")
                    .HasColumnName("start_maintaince");

                entity.HasOne(d => d.CarDriver)
                    .WithMany(p => p.CarMaintainces)
                    .HasForeignKey(d => d.CarDriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("car_maintaince_car_driver_id_fkey");
            });

            modelBuilder.Entity<CfWithCp>(entity =>
            {
                entity.HasKey(e => new { e.FsuggentionId, e.PcontractId })
                    .HasName("cf_with_cp_pkey");

                entity.ToTable("cf_with_cp");

                entity.Property(e => e.FsuggentionId).HasColumnName("fsuggention_id");

                entity.Property(e => e.PcontractId).HasColumnName("pcontract_id");

                entity.HasOne(d => d.Fsuggention)
                    .WithMany(p => p.CfWithCps)
                    .HasForeignKey(d => d.FsuggentionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cf_with_cp_fsuggention_id_fkey");

                entity.HasOne(d => d.Pcontract)
                    .WithMany(p => p.CfWithCps)
                    .HasForeignKey(d => d.PcontractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cf_with_cp_pcontract_id_fkey");
            });

            modelBuilder.Entity<Dcontract>(entity =>
            {
                entity.HasKey(e => e.ContractId)
                    .HasName("dcontract_pkey");

                entity.ToTable("dcontract");

                entity.Property(e => e.ContractId)
                .ValueGeneratedOnAdd()
                .HasColumnName("contract_id");

                entity.Property(e => e.DriverId).HasColumnName("driver_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Salary)
                    .HasPrecision(10, 2)
                    .HasColumnName("salary");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.Dcontracts)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dcontract_driver_id_fkey");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("driver");

                entity.HasIndex(e => e.PhoneNumber, "driver_phone_number_key")
                    .IsUnique();

                entity.Property(e => e.DriverId)
                .ValueGeneratedOnAdd()
                .HasColumnName("driver_id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("first_name")
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("phone_number")
                    .IsFixedLength(true);

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("second_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Farmer>(entity =>
            {
                entity.ToTable("farmer");

                entity.HasIndex(e => e.FarmName, "farmer_farm_name_key")
                    .IsUnique();

                entity.HasIndex(e => e.PhoneNumber, "farmer_phone_number_key")
                    .IsUnique();

                entity.Property(e => e.FarmerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("farmer_id");

                entity.Property(e => e.AccurateAddress).HasColumnName("accurate_address");

                entity.Property(e => e.FarmName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("farm_name")
                    .IsFixedLength(true);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("first_name")
                    .IsFixedLength(true);

                entity.Property(e => e.MainAddress)
                    .IsRequired()
                    .HasColumnName("main_address");

                entity.Property(e => e.NumberOfHectares)
                    .HasPrecision(10, 2)
                    .HasColumnName("number_of_hectares");

                entity.Property(e => e.PercentOfSanity)
                    .HasPrecision(5, 2)
                    .HasColumnName("percent_of_sanity")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("phone_number")
                    .IsFixedLength(true);

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("second_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<FsContract>(entity =>
            {
                entity.HasKey(e => e.FsuggentionId)
                     .HasName("fs_contract_pkey");

                entity.ToTable("fs_contract");

                entity.Property(e => e.FsuggentionId)
                    .ValueGeneratedNever()
                    .HasColumnName("fsuggention_id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FarmerId).HasColumnName("farmer_id");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TotalPrice).HasColumnName("total_price");

                entity.Property(e => e.Weight)
                    .HasPrecision(6, 2)
                    .HasColumnName("weight");

                entity.HasOne(d => d.Farmer)
                    .WithMany(p => p.FsContracts)
                    .HasForeignKey(d => d.FarmerId)
                    .HasConstraintName("fs_contract_farmer_id_fkey");

                entity.HasOne(d => d.Fsuggention)
                    .WithOne(p => p.FsContract)
                    .HasForeignKey<FsContract>(d => d.FsuggentionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fs_contract_fsuggention_id_fkey");
            });


            modelBuilder.Entity<Fsuggention>(entity =>
            {
                entity.HasKey(e => e.SuggentionId)
                    .HasName("fsuggention_pkey");

                entity.ToTable("fsuggention");

                entity.Property(e => e.SuggentionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("suggention_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Product).HasColumnName("product");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.Property(e => e.Weight)
                    .HasPrecision(6, 2)
                    .HasColumnName("weight")
                    .HasDefaultValueSql("26");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Fsuggentions)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fsuggention_staff_id_fkey");
            });

            modelBuilder.Entity<Pcontract>(entity =>
            {
                entity.ToTable("pcontract");

                entity.Property(e => e.PcontractId)
                .ValueGeneratedOnAdd()
                .HasColumnName("pcontract_id");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.OwnPrice).HasColumnName("own_price");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.Property(e => e.Status)
                  .HasColumnName("status")
                  .HasDefaultValueSql("1");

                entity.Property(e => e.TotalWeight).HasColumnName("total_weight");

                entity.HasOne(d => d.Log)
                    .WithMany(p => p.Pcontracts)
                    .HasForeignKey(d => d.LogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pcontract_log_id_fkey");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Pcontracts)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pcontract_staff_id_fkey");
            });

            modelBuilder.Entity<Port>(entity =>
            {
                entity.ToTable("port");

                entity.HasIndex(e => e.Telephone, "port_telephone_key")
                    .IsUnique();

                entity.Property(e => e.PortId)
                .ValueGeneratedOnAdd()
                .HasColumnName("port_id");

                entity.Property(e => e.AccurateAddress).HasColumnName("accurate_address");

                entity.Property(e => e.MainAddress)
                    .IsRequired()
                    .HasColumnName("main_address");

                entity.Property(e => e.NameOfTerminal)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("name_of_terminal");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("telephone")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("position");

                entity.HasIndex(e => e.Pname, "position_pname_key")
                    .IsUnique();

                entity.Property(e => e.PositionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("position_id");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("pname")
                    .IsFixedLength(true);

                entity.Property(e => e.Salary)
                    .HasPrecision(6, 2)
                    .HasColumnName("salary");
            });

            modelBuilder.Entity<PriceLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("price_log_pkey");

                entity.ToTable("price_log");

                entity.Property(e => e.LogId)
                .ValueGeneratedOnAdd()
                .HasColumnName("log_id");

                entity.Property(e => e.Deadline)
                    .HasColumnType("date")
                    .HasColumnName("deadline");

                entity.Property(e => e.MaxWeight).HasColumnName("max_weight");

                entity.Property(e => e.PortId).HasColumnName("port_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.Tproduct).HasColumnName("tproduct");

                entity.HasOne(d => d.Port)
                    .WithMany(p => p.PriceLogs)
                    .HasForeignKey(d => d.PortId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("price_log_port_id_fkey");
            });

            modelBuilder.Entity<WC>(entity =>
            {
                entity.HasKey(e => new { e.WaybillId, e.CarId })
                    .HasName("w_c_pkey");

                entity.ToTable("w_c");

                entity.Property(e => e.WaybillId).HasColumnName("waybill_id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.WCs)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("w_c_car_id_fkey");

                entity.HasOne(d => d.Waybill)
                    .WithMany(p => p.WCs)
                    .HasForeignKey(d => d.WaybillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("w_c_waybill_id_fkey");
            });

            modelBuilder.Entity<WFc>(entity =>
            {
                entity.HasKey(e => new { e.WaybillId, e.FsuggentionId })
                    .HasName("w_fc_pkey");

                entity.ToTable("w_fc");

                entity.Property(e => e.WaybillId).HasColumnName("waybill_id");

                entity.Property(e => e.FsuggentionId).HasColumnName("fsuggention_id");

                entity.HasOne(d => d.Fsuggention)
                    .WithMany(p => p.WFcs)
                    .HasForeignKey(d => d.FsuggentionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("w_fc_fsuggention_id_fkey");

                entity.HasOne(d => d.Waybill)
                    .WithMany(p => p.WFcs)
                    .HasForeignKey(d => d.WaybillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("w_fc_waybill_id_fkey");
            });

            modelBuilder.Entity<WPc>(entity =>
            {
                entity.HasKey(e => new { e.WaybillId, e.PcontractId })
                    .HasName("w_pc_pkey");

                entity.ToTable("w_pc");

                entity.Property(e => e.WaybillId).HasColumnName("waybill_id");

                entity.Property(e => e.PcontractId).HasColumnName("pcontract_id");

                entity.HasOne(d => d.Pcontract)
                    .WithMany(p => p.WPcs)
                    .HasForeignKey(d => d.PcontractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("w_pc_pcontract_id_fkey");

                entity.HasOne(d => d.Waybill)
                    .WithMany(p => p.WPcs)
                    .HasForeignKey(d => d.WaybillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("w_pc_waybill_id_fkey");
            });

            modelBuilder.Entity<Waybill>(entity =>
            {
                entity.ToTable("waybill");

                entity.Property(e => e.WaybillId)
                .ValueGeneratedOnAdd()
                .HasColumnName("waybill_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.Status)
                  .HasColumnName("status")
                  .HasDefaultValueSql("1");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Waybills)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("waybill_address_id_fkey");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasIndex(e => e.PhoneNumber, "staff_phone_number_key")
                    .IsUnique();

                entity.Property(e => e.StaffId)
                .ValueGeneratedOnAdd()
                .HasColumnName("staff_id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("first_name")
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("phone_number")
                    .IsFixedLength(true);

                entity.Property(e => e.PositionId).HasColumnName("position_id");

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("second_name")
                    .IsFixedLength(true);

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("staff_position_id_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
