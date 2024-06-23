using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
  [StructLayout(LayoutKind.Sequential)]
  public struct WindowBufferSizeRecord :
    IEquatable<WindowBufferSizeRecord>
  {
    #region Public Members

    public Coordinate dwSize;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    public static bool operator ==(
      WindowBufferSizeRecord firstStructure,
      WindowBufferSizeRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return firstStructure.dwSize == secondStructure.dwSize;
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    public static bool operator !=(
      WindowBufferSizeRecord firstStructure,
      WindowBufferSizeRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return true;
      }

      return firstStructure.dwSize != secondStructure.dwSize;
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Sum) => WindowBufferSizeRecord

    public static WindowBufferSizeRecord operator +(
      WindowBufferSizeRecord firstStructure,
      WindowBufferSizeRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new WindowBufferSizeRecord
        {
          dwSize = new Coordinate
          {
            X = 0, // standard value
            Y = 0, // standard value
          }
        };
      }

      return new WindowBufferSizeRecord
      {
        dwSize = firstStructure.dwSize + secondStructure.dwSize,
      };
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Subtract) => WindowBufferSizeRecord

    public static WindowBufferSizeRecord operator -(
      WindowBufferSizeRecord firstStructure,
      WindowBufferSizeRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new WindowBufferSizeRecord
        {
          dwSize = new Coordinate
          {
            X = 0, // standard value
            Y = 0, // standard value
          }
        };
      }

      return new WindowBufferSizeRecord
      {
        dwSize = firstStructure.dwSize - secondStructure.dwSize,
      };
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Multiply) => WindowBufferSizeRecord

    public static WindowBufferSizeRecord operator *(
      WindowBufferSizeRecord firstStructure,
      WindowBufferSizeRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new WindowBufferSizeRecord
        {
          dwSize = new Coordinate
          {
            X = 0, // standard value
            Y = 0, // standard value
          }
        };
      }

      return new WindowBufferSizeRecord
      {
        dwSize = firstStructure.dwSize * secondStructure.dwSize,
      };
    }

    #endregion

    // @

    #region Logical Operator: Arithmetic (Divide) => WindowBufferSizeRecord

    public static WindowBufferSizeRecord operator /(
      WindowBufferSizeRecord firstStructure,
      WindowBufferSizeRecord secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return new WindowBufferSizeRecord
        {
          dwSize = new Coordinate
          {
            X = 0, // standard value
            Y = 0, // standard value
          }
        };
      }

      return new WindowBufferSizeRecord
      {
        dwSize = firstStructure.dwSize / secondStructure.dwSize,
      };
    }

    #endregion

    // @

    #region Equals => bool

    public bool Equals(WindowBufferSizeRecord other)
    {
      return this == other;
    }

    public override bool Equals(object obj)
    {
      if (obj is WindowBufferSizeRecord windowBufferSizeRecord)
      {
        return this == windowBufferSizeRecord;
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
        $"dwSize: {dwSize} " +
        @"}"
      ;
    }

    #endregion

    // @

    #region GetHashCode => int

    public override int GetHashCode()
    {
      return dwSize.GetHashCode();
    }

    #endregion
  }
}
