﻿#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenSharp
// File Name: IM64.cs
// 
// Current Data:
// 2020-06-15 1:54 PM
// 
// Creation Date:
// 2020-06-15 1:51 PM

#endregion

using PenguinLib.Observable;

namespace MupenSharp.Models
{
  public interface IM64
  {
    /// <summary>
    ///   Version number. Should be 3.
    /// </summary>
    uint Version { get; set; }

    /// <summary>
    ///   The number of frames (vertical interrupts).
    /// </summary>
    uint VerticalInterrupts { get; set; }

    /// <summary>
    ///   The number of file rerecords.
    /// </summary>
    uint RerecordCount { get; set; }

    /// <summary>
    ///   Frames (vertical interrupts) per second.
    /// </summary>
    byte ViPerSecond { get; set; }

    /// <summary>
    ///   The number of controllers enabled for the file.
    /// </summary>
    byte NumberOfControllers { get; set; }

    /// <summary>
    ///   The movie start type.
    ///   <list type="table">
    ///     <listheader>
    ///       <term>
    ///         Value
    ///       </term>
    ///       <term>
    ///         Description
    ///       </term>
    ///     </listheader>
    ///     <item>
    ///       <term>1</term>
    ///       <term>
    ///         movie begins from snapshot (the snapshot will be loaded from an external file with the movie filename.
    ///         and a .st extension)
    ///       </term>
    ///     </item>
    ///     <item>
    ///       <term> 2</term>
    ///       <term>
    ///         movie begins from power-on
    ///       </term>
    ///     </item>
    ///     <item>
    ///       <term>other values</term>
    ///       <term>
    ///         invalid movie
    ///       </term>
    ///     </item>
    ///   </list>
    /// </summary>
    ushort MovieStartType { get; set; }

    /// <summary>
    ///   Flags set for each controller.
    ///   <list type="bullet">
    ///     <item>
    ///       <term>bit 0</term>
    ///       <description>
    ///         Controller 1 present
    ///       </description>
    ///     </item>
    ///     <item>
    ///       <term>bit 4</term>
    ///       <description>
    ///         Controller 1 has mempak
    ///       </description>
    ///     </item>
    ///     <item>
    ///       <term>bit 8</term>
    ///       <description>
    ///         Controller 1 has rumblepak
    ///       </description>
    ///     </item>
    ///   </list>
    ///   +1..3 for controllers 2..4.
    /// </summary>
    uint ControllerFlags { get; set; }

    /// <summary>
    ///   The internal name of ROM used when recording, directly from ROM.
    /// </summary>
    string NameOfRom { get; set; }

    /// <summary>
    ///   CRC32 of ROM used when recording, directly from ROM.
    /// </summary>
    uint Crc32 { get; set; }

    /// <summary>
    ///   The country code of ROM used when recording, directly from ROM.
    /// </summary>
    ushort CountryCode { get; set; }

    /// <summary>
    ///   The movie description info.
    /// </summary>
    string MovieDescription { get; set; }

    /// <summary>
    ///   The input for every input frame, containing analogue x, y positions and buttons pressed.
    /// </summary>
    ObservingCollection<InputModel> Inputs { get; }

    /// <summary>
    ///   The number of input samples from the controllers.
    /// </summary>
    uint InputFrames { get; set; }

    /// <summary>
    ///   The Author info of the movie.
    /// </summary>
    string Author { get; set; }
  }
}