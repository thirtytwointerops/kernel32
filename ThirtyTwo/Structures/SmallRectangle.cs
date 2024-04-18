using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Defines the coordinates of the upper left and lower right corners of a rectangle.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct SmallRectangle :
      IEquatable<SmallRectangle>
  {
    #region Public Members

    /// <summary>
    /// The x-coordinate of the upper left corner of the rectangle.
    /// </summary>
    public short Left;

    /// <summary>
    /// The y-coordinate of the upper left corner of the rectangle.
    /// </summary>
    public short Top;

    /// <summary>
    /// The x-coordinate of the lower right corner of the rectangle.
    /// </summary>
    public short Right;

    /// <summary>
    /// The y-coordinate of the lower right corner of the rectangle.
    /// </summary>
    public short Bottom;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
    public bool Equals(SmallRectangle other)
    {
      return this == other;
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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
