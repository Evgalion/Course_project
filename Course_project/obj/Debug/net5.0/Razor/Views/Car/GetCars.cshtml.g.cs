#pragma checksum "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\Car\GetCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a18de6e9638e7f1dbcd4bc60d3a23e2160d7923d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_GetCars), @"mvc.1.0.view", @"/Views/Car/GetCars.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\_ViewImports.cshtml"
using Course_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\_ViewImports.cshtml"
using Course_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a18de6e9638e7f1dbcd4bc60d3a23e2160d7923d", @"/Views/Car/GetCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e31f3ffb41b9aa6953c5c6c18cba389f38164b42", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Car_GetCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course_project.Domain.Models.Car>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\Car\GetCars.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\Car\GetCars.cshtml"
  foreach (var car in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <p>CarId - ");
#nullable restore
#line 10 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\Car\GetCars.cshtml"
                 Write(car.CarId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n           <p>Model - ");
#nullable restore
#line 11 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\Car\GetCars.cshtml"
                 Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n           <p>Brand - ");
#nullable restore
#line 12 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\Car\GetCars.cshtml"
                 Write(car.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n           <p>StartOperation - ");
#nullable restore
#line 13 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\Car\GetCars.cshtml"
                          Write(car.StartOperation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n           <p>Year - ");
#nullable restore
#line 14 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\Car\GetCars.cshtml"
                Write(car.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n           <p>LiftingCapacity - ");
#nullable restore
#line 15 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\Car\GetCars.cshtml"
                           Write(car.LiftingCapacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n           <p>Status - ");
#nullable restore
#line 16 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\Car\GetCars.cshtml"
                  Write(car.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "G:\Учёба\3 курс - 2 семестр\Проектирование_информ_систем\Практика\Course_project\Course_project\Views\Car\GetCars.cshtml"

        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course_project.Domain.Models.Car>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591