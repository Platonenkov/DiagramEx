namespace DiagramEx.SubClasses
{
    /// <summary>Объект, обладающий значением</summary>
    /// <typeparam name="T">Тип значения объекта</typeparam>
    internal interface IValueRead<out T>
    {
        /// <summary>Значение объекта</summary>
        T Value { get; }
    }
}