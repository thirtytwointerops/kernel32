﻿using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Defines the coordinates of a character cell in a console screen buffer. The
  /// origin of the coordinate system (0, 0) is at the top, left cell of the buffer.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct Coordinate :
      IEquatable<Coordinate>
  {
    #region Public Members

    /// <summary>
    /// The horizontal coordinate or column value. The units depend on the function call.
    /// </summary>
    public short X;

    /// <summary>
    /// The vertical coordinate or row value. The units depend on the function call.
    /// </summary>
    public short Y;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
    public static bool operator ==(
      Coordinate firstStructure,
      Coordinate secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return
        firstStructure.X == secondStructure.X &&
        firstStructure.Y == secondStructure.Y
      ;
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    /// <inheritdoc />
    public static bool operator !=(
      Coordinate firstStructure,
      Coordinate secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return
        firstStructure.X != secondStructure.X ||
        firstStructure.Y != secondStructure.Y
      ;
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Sum) => Coordinate

    /// <inheritdoc />
    public static Coordinate operator +(
      Coordinate firstStructure,
      Coordinate secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new Coordinate
        {
          X = 0, // standard value
          Y = 0, // standard value
        };
      }

      return new Coordinate
      {
        X = firstStructure.X + secondStructure.X > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.X + secondStructure.X ),

        Y = firstStructure.Y + secondStructure.Y > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.Y + secondStructure.Y ),
      };
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Subtract) => Coordinate

    /// <inheritdoc />
    public static Coordinate operator -(
      Coordinate firstStructure,
      Coordinate secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new Coordinate
        {
          X = 0, // standard value
          Y = 0, // standard value
        };
      }

      return new Coordinate
      {
        X = firstStructure.X - secondStructure.X < short.MinValue
        ? short.MinValue : (short)( firstStructure.X - secondStructure.X ),

        Y = firstStructure.Y - secondStructure.Y < short.MinValue
        ? short.MinValue : (short)( firstStructure.Y - secondStructure.Y ),
      };
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Multiply) => Coordinate

    /// <inheritdoc />
    public static Coordinate operator *(
      Coordinate firstStructure,
      Coordinate secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new Coordinate
        {
          X = 0, // standard value
          Y = 0, // standard value
        };
      }

      return new Coordinate
      {
        X = firstStructure.X * secondStructure.X > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.X * secondStructure.X ),

        Y = firstStructure.Y * secondStructure.Y > short.MaxValue
        ? short.MaxValue : (short)( firstStructure.Y * secondStructure.Y ),
      };
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Divide) => Coordinate

    /// <inheritdoc />
    public static Coordinate operator /(
      Coordinate firstStructure,
      Coordinate secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new Coordinate
        {
          X = 0, // standard value
          Y = 0, // standard value
        };
      }

      return new Coordinate
      {
        X = firstStructure.X / secondStructure.X < short.MinValue
        ? short.MinValue : (short)( firstStructure.X / secondStructure.X ),

        Y = firstStructure.Y / secondStructure.Y < short.MinValue
        ? short.MinValue : (short)( firstStructure.Y / secondStructure.Y ),
      };
    }

    #endregion

    // @

    #region Equals => bool

    /// <inheritdoc />
    public bool Equals(Coordinate other)
    {
      return this == other;
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      if (obj is Coordinate coord)
      {
        return this == coord;
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
        $"X: {X}, " +
        $"Y: {Y} " +
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
        X.GetHashCode() ^
        Y.GetHashCode()
      ;
    }

    #endregion
  }
}
