#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenMovieEditor
// File Name: M64.cs
// 
// Current Data:
// 2020-05-12 11:12 AM
// 
// Creation Date:
// 2020-05-12 10:46 AM

#endregion

using System.Collections.Generic;

namespace MupenMovieEditor.Models
{
  internal class M64
  {
    public uint Version { get; set; }
    public uint VerticalInterrupts { get; set; }
    public uint RerecordCount { get; set; }
    public byte FramesPerSecond { get; set; }
    public byte NumberOfControllers { get; set; }
    public uint InputFrames { get; set; }
    public ushort StartType { get; set; }
    public uint ControllerFlag { get; set; }
    public string NameOfROM { get; set; }
    public uint CRC32 { get; set; }
    public ushort CountryCode { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public IEnumerable<InputModel> Inputs { get; set; }
  }
}