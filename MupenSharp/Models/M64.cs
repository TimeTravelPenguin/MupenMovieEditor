#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenSharp
// File Name: M64.cs
// 
// Current Data:
// 2020-05-13 10:25 AM
// 
// Creation Date:
// 2020-05-12 5:07 PM

#endregion

using System.Collections.Generic;

namespace MupenSharp.Models
{
  // Header information: http://tasvideos.org/EmulatorResources/Mupen/M64.html
  public class M64
  {
    public uint Version { get; set; }
    public uint VerticalInterrupts { get; set; }
    public uint RerecordCount { get; set; }
    public byte ViPerSecond { get; set; }
    public byte NumberOfControllers { get; set; }
    public uint InputFrames { get; set; }
    public ushort MovieStartType { get; set; }
    public uint ControllerFlags { get; set; }
    public string NameOfRom { get; set; }
    public uint Crc32 { get; set; }
    public ushort CountryCode { get; set; }
    public string Author { get; set; }
    public string MovieDescription { get; set; }
    public IList<InputModel> Inputs { get; set; } = new List<InputModel>();
  }
}