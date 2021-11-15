using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramEx.Enums
{
    /// <summary> Позиционирование элемента (слева/справа) </summary>
    public enum PositionLR
    {
        Left, Right
    }
    /// <summary> Позиционирование элемента (сверху/снизу) </summary>
    public enum PositionTB
    {
        Top,Bottom
    }
    /// <summary> Позиционирование элемента </summary>
    public enum PositionGeneral
    {
        LeftTop,LeftCenter,LeftBottom,
        RightTop,RightCenter,RightBottom,
        CenterTop,Center,CenterBottom
    } 
}
