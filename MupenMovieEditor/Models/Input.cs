#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenMovieEditor
// File Name: Input.cs
// 
// Current Data:
// 2020-05-12 11:28 AM
// 
// Creation Date:
// 2020-05-12 11:25 AM

#endregion

using System;

namespace MupenMovieEditor.Models
{
  [Flags]
  internal enum Input
  {
    CRight = 0x0001,
    CLefts = 0x0002,
    CDown = 0x0004,
    CUp = 0x0008,
    R = 0x0010,
    L = 0x0020,
    Reserved1 = 0x0040,
    Reserved2 = 0x0080,
    DigitalPadRight = 0x0100,
    DigitalPadLeft = 0x0200,
    DigitalPadDown = 0x0400,
    DigitalPadUp = 0x0800,
    Start = 0x1000,
    Z = 0x2000,
    B = 0x4000,
    A = 0x8000
  }
}