using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace DiagramEx.Extensions
{
    internal static class TypeExtensions
    {
        private static readonly ConcurrentDictionary<(Type SourceType, Type TargetType), Func<object, object>> __CastersDictionary = new();

        private static readonly ParameterExpression __ConvParameter = Expression.Parameter(typeof(object), "value");
        public static Func<object, object> GetCasterTo(this Type SourceType, Type TargetType) => TargetType.GetCasterFrom(SourceType);
        public static Func<object, object> GetCasterFrom(this Type TargetType, Type SourceType) =>
            __CastersDictionary.GetOrAdd((SourceType, TargetType), ((Type Source, Type Target) vv) => Expression.Lambda<Func<object, object>>(
                    Expression.Convert(
                        Expression.Convert(
                            Expression.Convert(__ConvParameter, vv.Source),
                            vv.Target),
                        typeof(object)),
                    __ConvParameter)
               .Compile());
    }
}
