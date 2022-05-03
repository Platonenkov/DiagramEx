namespace DiagramEx.Enums.Lines
{
    public enum LineFillType
    {
        None,
        In,
        LeftIn, LeftInRightOut, LeftInRightConnect,
        RightIn, RightInLeftOut, RightInLeftConnect,
        Out,
        LeftOut, LeftOutRightConnect,
        RightOut, RightOutLeftConnect,
        Connect, LeftConnect, RightConnect,
        Central,
        TopLeftBottomLeft, TopLeftBottomRight, TopLeftBottomCenter,
        TopRightBottomLeft, TopRightBottomRight, TopRightBottomCenter,
        TopCenterBottomLeft, TopCenterBottomRight, TopCenterBottomCenter

    }
}