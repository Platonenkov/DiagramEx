using System;

namespace DiagramEx.SubClasses
{
    /// <summary>Объект поддерживает клонирование</summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    internal interface ICloneable<out T> : ICloneable
    {
        /// <summary>Клонирование объекта</summary>
        /// <returns>Клонированный экземпляр объекта</returns>
        new T Clone();
    }
}