using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramEx.Enums
{
    public enum FillType
    {
        None, In, Out, Connect,Central
    }

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
