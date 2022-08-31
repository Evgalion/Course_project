using System;
using System.Net;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Linq;

namespace Course_project.Helper
{
    public static class GetDisplayName
    {
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
           where TAttribute : Attribute
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<TAttribute>();
        }
    }
}
