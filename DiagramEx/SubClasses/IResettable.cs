namespace DiagramEx.SubClasses
{
    /// <summary>Объект, позволяющий осуществлять сброс своего состояния</summary>
    internal interface IResettable
    {
        /// <summary>Сброс состояния</summary>
        void Reset();
    }
}