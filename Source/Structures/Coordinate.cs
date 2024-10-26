using System.Runtime.InteropServices;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct Coordinate :
      IEquatable<Coordinate>
  {
    #region Public Members

    public short X;
    public short Y;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

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

    public static bool operator !=(
      Coordinate firstStructure,
      Coordinate secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return
        firstStructure.X != secondStructure.X ||
        firstStructure.Y != secondStructure.Y
      ;
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Sum) => Coordinate

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

    public bool Equals(Coordinate other)
    {
      return this == other;
    }

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
