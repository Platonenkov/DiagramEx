using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace System.Linq
{
    internal static class IEnumerableExtensions
    {
        /// <summary>Выполнение указанного действия на каждом шаге перебора последовательности после выдачи элемента</summary>
        /// <typeparam name="T">Тип элементов последовательности</typeparam>
        /// <param name="collection">Последовательность элементов</param>
        /// <param name="action">Действие, выполняемое после выдачи элемента последовательности</param>
        /// <returns>Исходная последовательность элементов</returns>
        public static IEnumerable<T> ForeachLazyLast<T>(this IEnumerable<T> collection, Action<T> action)
        {
            if (action is null)
                foreach (var value in collection) yield return value;
            else
                foreach (var value in collection)
                {
                    yield return value;
                    action(value);
                }
        }
    }
}
