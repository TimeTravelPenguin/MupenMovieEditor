#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenSharp
// File Name: RegionCode.cs
// 
// Current Data:
// 2020-06-10 11:37 AM
// 
// Creation Date:
// 2020-06-10 11:37 AM

#endregion

using System;

namespace MupenSharp.Enums
{
  // These are based off the ROM CRC
  public enum RegionCode : uint
  {
    U = 0xFF2B5A63,
    J = 0xE3DAA4E,
    Ghost = 0x95ED43A4
  }
}