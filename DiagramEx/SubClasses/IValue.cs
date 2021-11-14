namespace DiagramEx.SubClasses
{
    /// <summary>Объект, позволяющий читать и устанавливать значение</summary>
    /// <typeparam name="T">Тип значения объекта</typeparam>
    internal interface IValue<T> : IValueRead<T>, IValueWrite<T>
    {
        /// <summary>Значение объекта</summary>
        new T Value { get; set; }
    }
}