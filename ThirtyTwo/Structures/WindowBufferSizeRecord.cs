using System.Runtime.InteropServices;
using System;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Describes a change in the size of the console screen buffer.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct WindowBufferSizeRecord :
      IEquatable<WindowBufferSizeRecord>
  {
    #region Public Members

    /// <summary>
    /// A "Coordinate" structure that contains the size of the console screen buffer, in
    /// character cell columns and rows.
    /// </summary>
    public Coordinate dwSize;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
    public bool Equals(WindowBufferSizeRecord other)
    {
      return this == other;
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
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

    /// <inheritdoc />
    public override int GetHashCode()
    {
      return dwSize.GetHashCode();
    }

    #endregion
  }
}
