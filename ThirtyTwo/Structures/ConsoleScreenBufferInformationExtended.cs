﻿using System.Runtime.InteropServices;
using System;

using ThirtyTwo.Kernel32.Enumerations;

namespace ThirtyTwo.Kernel32.Structures
{
  /// <summary>
  /// Contains extended information about a console screen buffer.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct ConsoleScreenBufferInformationExtended :
      IEquatable<ConsoleScreenBufferInformationExtended>
  {
    #region Public Members

    /// <summary>
    /// The size of this structure, in bytes.
    /// </summary>
    public static uint cbSize = (uint)Marshal.SizeOf(
      typeof(ConsoleScreenBufferInformationExtended)
    );

    /// <summary>
    /// A "Coordinate" structure that contains the size of the console screen buffer, in
    /// character columns and rows.
    /// </summary>
    public Coordinate dwSize;

    /// <summary>
    /// A "Coordinate" structure that contains the column and row coordinates of the cursor
    /// in the console screen buffer.
    /// </summary>
    public Coordinate dwCursorPosition;

    /// <summary>
    /// The attributes of the characters written to a screen buffer by the "WriteFile"
    /// and "WriteConsole" functions, or echoed to a screen buffer by the "ReadFile" and
    /// "ReadConsole" functions. This member can be zero or a combination of values ​​from
    /// the "CharacterAttributes" enumeration.
    /// </summary>
    public CharacterAttributes wAttributes;

    /// <summary>
    /// A "SmallRectangle" structure that contains the console screen buffer coordinates of
    /// the upper-left and lower-right corners of the display window.
    /// </summary>
    public SmallRectangle srWindow;

    /// <summary>
    /// A "Coordinate" structure that contains the maximum size of the console window, in
    /// character columns and rows, given the current screen buffer size and font and
    /// the screen size.
    /// </summary>
    public Coordinate dwMaximumWindowSize;

    /// <summary>
    /// The fill attribute for console pop-ups.
    /// </summary>
    public ushort wPopupAttributes;

    /// <summary>
    /// If this member is "TRUE", full-screen mode is supported; otherwise, it is not.
    /// This will always be "FALSE" for systems after Windows Vista with the WDDM driver
    /// model as true direct VGA access to the monitor is no longer available.
    /// </summary>
    public bool bFullscreenSupported;

    /// <summary>
    /// An array of "COLORREF (DWORD)" values that describe the console's color settings.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public uint[] ColorTable;

    #endregion

    // @

    #region Logical Operator: Comparison (Equals) => bool

    /// <inheritdoc />
    public static bool operator ==(
      ConsoleScreenBufferInformationExtended firstStructure,
      ConsoleScreenBufferInformationExtended secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.dwSize == secondStructure.dwSize &&
        firstStructure.dwCursorPosition == secondStructure.dwCursorPosition &&
        firstStructure.wAttributes == secondStructure.wAttributes &&
        firstStructure.srWindow == secondStructure.srWindow &&
        firstStructure.dwMaximumWindowSize == secondStructure.dwMaximumWindowSize &&
        firstStructure.wPopupAttributes == secondStructure.wPopupAttributes &&
        firstStructure.bFullscreenSupported == secondStructure.bFullscreenSupported &&
        firstStructure.ColorTable == secondStructure.ColorTable
      );
    }

    #endregion

    // @

    #region Logical Operator: Comparison (Different) => bool

    /// <inheritdoc />
    public static bool operator !=(
      ConsoleScreenBufferInformationExtended firstStructure,
      ConsoleScreenBufferInformationExtended secondStructure
    )
    {
      if (firstStructure == null || secondStructure == null)
      {
        return false;
      }

      return (
        firstStructure.dwSize != secondStructure.dwSize ||
        firstStructure.dwCursorPosition != secondStructure.dwCursorPosition ||
        firstStructure.wAttributes != secondStructure.wAttributes ||
        firstStructure.srWindow != secondStructure.srWindow ||
        firstStructure.dwMaximumWindowSize != secondStructure.dwMaximumWindowSize ||
        firstStructure.wPopupAttributes != secondStructure.wPopupAttributes ||
        firstStructure.bFullscreenSupported != secondStructure.bFullscreenSupported ||
        firstStructure.ColorTable != secondStructure.ColorTable
      );
    }

    #endregion

    // @

    #region Equals => bool

    /// <inheritdoc />
    public bool Equals(ConsoleScreenBufferInformationExtended other)
    {
      return this == other;
    }

    /// <inheritdoc />
    public override bool Equals(object obj)
    {
      if (obj is ConsoleScreenBufferInformationExtended consoleScreenBufferInfoEx)
      {
        return this == consoleScreenBufferInfoEx;
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
        $"cbSize: {cbSize}, " +
        $"dwSize: {dwSize}, " +
        $"dwCursorPosition: {dwCursorPosition}, " +
        $"wAttributes: {wAttributes}, " +
        $"srWindow: {srWindow}, " +
        $"dwMaximumWindowSize: {dwMaximumWindowSize}, " +
        $"wPopupAttributes: {wPopupAttributes}, " +
        $"bFullscreenSupported: {bFullscreenSupported}, " +
        $"ColorTable: {ColorTable} " +
        @"}";
    }

    #endregion

    // @

    #region GetHashCode => int

    /// <inheritdoc />
    public override int GetHashCode()
    {
      return
        cbSize.GetHashCode() ^
        dwSize.GetHashCode() ^
        dwCursorPosition.GetHashCode() ^
        wAttributes.GetHashCode() ^
        srWindow.GetHashCode() ^
        dwMaximumWindowSize.GetHashCode() ^
        wPopupAttributes.GetHashCode() ^
        bFullscreenSupported.GetHashCode() ^
        ColorTable.GetHashCode()
      ;
    }

    #endregion
  }
}
