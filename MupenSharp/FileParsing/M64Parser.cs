#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenSharp
// File Name: M64Parser.cs
// 
// Current Data:
// 2020-05-13 12:02 PM
// 
// Creation Date:
// 2020-05-12 5:22 PM

#endregion

using System;
using System.IO;
using MupenSharp.Extensions;
using MupenSharp.Models;

namespace MupenSharp.FileParsing
{
  public class M64Parser
  {
    private FileInfo _mupenFile;

    public void SetFile(string path)
    {
      if (string.IsNullOrWhiteSpace(path))
      {
        throw new ArgumentException("Value cannot be null or whitespace.", nameof(path));
      }

      if (File.Exists(path))
      {
        _mupenFile = new FileInfo(path);
      }
      else
      {
        _mupenFile = null;
        throw new FileNotFoundException("The file path was invalid", nameof(path));
      }
    }

    public M64 Parse()
    {
      if (!_mupenFile.Exists)
      {
        throw new FileNotFoundException("The file path was invalid", nameof(_mupenFile));
      }

      using var reader = new BinaryReader(_mupenFile.Open(FileMode.Open, FileAccess.Read));

      var m64 = new M64
      {
        Version = reader.ReadBytesAndConvertUInt32(0x4),
        VerticalInterrupts = reader.ReadBytesAndConvertUInt32(0xC),
        RerecordCount = reader.ReadBytesAndConvertUInt32(0x10),
        ViPerSecond = reader.ReadByte(0x15),
        NumberOfControllers = reader.ReadByte(0x16),
        InputFrames = reader.ReadBytesAndConvertUInt32(0x18),
        MovieStartType = reader.ReadBytesAndConvertUInt16(0x1C),
        ControllerFlags = reader.ReadBytesAndConvertUInt32(0x20),
        NameOfRom = reader.ReadBytesAndConvertString(0xC4, Encoding.ASCII),
        Crc32 = reader.ReadBytesAndConvertUInt32(0xE4),
        CountryCode = reader.ReadBytesAndConvertUInt16(0xE8),
        Author = reader.ReadBytesAndConvertString(0x222, Encoding.UTF8),
        MovieDescription = reader.ReadBytesAndConvertString(0x222, Encoding.UTF8)
      };


      // Is this how you offset to 0x400, then ready 4-bytes at a time??
      // According to the documentation this is the case.
      var frame = 0;
      reader.BaseStream.Seek(0x400, SeekOrigin.Begin);
      while (reader.BaseStream.Position != reader.BaseStream.Length && frame < m64.InputFrames)
      {
        // InputModel has implicit cast operator for byte[]
        // Unit testing shows this works
        m64.Inputs.Add(reader.ReadBytes(4));
        frame++;
      }

      return m64;
    }
  }
}