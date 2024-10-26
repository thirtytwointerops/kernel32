using System.Runtime.InteropServices;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct SmallRectangle :
      IEquatable<SmallRectangle>
  {
    #region Public Members

    public short Left;
    public short Top;
    public short Right;
    public short Bottom;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      SmallRectangle firstStructure,
      SmallRectangle secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return
        firstStructure.Left == secondStructure.Left &&
        firstStructure.Top == secondStructure.Top &&
        firstStructure.Right == secondStructure.Right &&
        firstStructure.Bottom == secondStructure.Bottom
      ;
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      SmallRectangle firstStructure,
      SmallRectangle secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return
        firstStructure.Left != secondStructure.Left ||
        firstStructure.Top != secondStructure.Top ||
        firstStructure.Right != secondStructure.Right ||
        firstStructure.Bottom != secondStructure.Bottom
      ;
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Sum) => SmallRectangle

    public static SmallRectangle operator +(
      SmallRectangle firstStructure,
      SmallRectangle secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new SmallRectangle
        {
          Left = 0, // standard value
          Top = 0, // standard value
          Right = 0, // standard value
          Bottom = 0, // standard value
        };
      }

      return new SmallRectangle
      {
        Left = firstStructure.Left + secondStructure.Left > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.Left + secondStructure.Left ),

        Top = firstStructure.Top + secondStructure.Top > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.Top + secondStructure.Top ),

        Right = firstStructure.Right + secondStructure.Right > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.Right + secondStructure.Right ),

        Bottom = firstStructure.Bottom + secondStructure.Bottom > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.Bottom + secondStructure.Bottom ),
      };
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Subtract) => SmallRectangle

    public static SmallRectangle operator -(
      SmallRectangle firstStructure,
      SmallRectangle secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new SmallRectangle
        {
          Left = 0, // standard value
          Top = 0, // standard value
          Right = 0, // standard value
          Bottom = 0, // standard value
        };
      }

      return new SmallRectangle
      {
        Left = firstStructure.Left - secondStructure.Left < short.MinValue
        ? short.MinValue : (short)( firstStructure.Left - secondStructure.Left ),

        Top = firstStructure.Top - secondStructure.Top < short.MinValue
        ? short.MinValue : (short)( firstStructure.Top - secondStructure.Top ),

        Right = firstStructure.Right - secondStructure.Right < short.MinValue
        ? short.MinValue : (short)( firstStructure.Right - secondStructure.Right ),

        Bottom = firstStructure.Bottom - secondStructure.Bottom < short.MinValue
        ? short.MinValue : (short)( firstStructure.Bottom - secondStructure.Bottom ),
      };
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Multiply) => SmallRectangle

    public static SmallRectangle operator *(
      SmallRectangle firstStructure,
      SmallRectangle secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new SmallRectangle
        {
          Left = 0, // standard value
          Top = 0, // standard value
          Right = 0, // standard value
          Bottom = 0, // standard value
        };
      }

      return new SmallRectangle
      {
        Left = firstStructure.Left * secondStructure.Left > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.Left * secondStructure.Left ),

        Top = firstStructure.Top * secondStructure.Top > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.Top * secondStructure.Top ),

        Right = firstStructure.Right * secondStructure.Right > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.Right * secondStructure.Right ),

        Bottom = firstStructure.Bottom * secondStructure.Bottom > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.Bottom * secondStructure.Bottom ),
      };
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Divide) => SmallRectangle

    public static SmallRectangle operator /(
      SmallRectangle firstStructure,
      SmallRectangle secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new SmallRectangle
        {
          Left = 0, // standard value
          Top = 0, // standard value
          Right = 0, // standard value
          Bottom = 0, // standard value
        };
      }

      return new SmallRectangle
      {
        Left = firstStructure.Left / secondStructure.Left < short.MinValue
        ? short.MinValue : (short)( firstStructure.Left / secondStructure.Left ),

        Top = firstStructure.Top / secondStructure.Top < short.MinValue
        ? short.MinValue : (short)( firstStructure.Top / secondStructure.Top ),

        Right = firstStructure.Right / secondStructure.Right < short.MinValue
        ? short.MinValue : (short)( firstStructure.Right / secondStructure.Right ),

        Bottom = firstStructure.Bottom / secondStructure.Bottom < short.MinValue
        ? short.MinValue : (short)( firstStructure.Bottom / secondStructure.Bottom ),
      };
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(SmallRectangle other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is SmallRectangle smallRect)
      {
        return this == smallRect;
      }

      return base.Equals(obj);
    }

    #endregion

    // @

    #region To String => string

    public override string ToString()
    {
      return
        @"{ " +
        $"Left: {Left}, " +
        $"Top: {Top}, " +
        $"Right: {Right}, " +
        $"Bottom: {Bottom} " +
        @"}"
      ;
    }

    #endregion

    // @

    #region GetHashCode => int

    public override int GetHashCode()
    {
      return
        Left.GetHashCode() ^
        Top.GetHashCode() ^
        Right.GetHashCode() ^
        Bottom.GetHashCode()
      ;
    }

    #endregion
  }
}
