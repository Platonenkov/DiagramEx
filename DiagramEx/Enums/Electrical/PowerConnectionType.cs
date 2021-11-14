namespace DiagramEx.Enums.Electrical
{
    /// <summary>
    /// Соединение между аварийной шиной переменного тока и источниками питания
    /// </summary>
    public enum PowerConnectionType
    {
        Ncd,
        NoConnection,
        GenL,
        GenR,
        ApuGen,
        ExtPwr,
        RatGen
    }
}
