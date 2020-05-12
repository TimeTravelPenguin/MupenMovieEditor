#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenSharp
// File Name: M64Parser.cs
// 
// Current Data:
// 2020-05-12 8:30 PM
// 
// Creation Date:
// 2020-05-12 5:22 PM

#endregion

using System;
using System.Collections.Generic;
using System.IO;
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

      M64 m64;
      using (var reader = new BinaryReader(_mupenFile.Open(FileMode.Open, FileAccess.Read)))
      {
        var inputs = new List<InputModel>();

        // Is this how you offset to 0x400, then ready 4-bytes at a time??
        // According to the documentation this is the case.
        reader.BaseStream.Seek(400, SeekOrigin.Begin);
        while (reader.BaseStream.Position != reader.BaseStream.Length)
        {
          // InputModel has implicit cast operator for byte[]
          // Unit testing shows this works
          inputs.Add(reader.ReadBytes(4));
        }

        m64 = new M64
        {
          Inputs = inputs
        };
      }

      return m64;
    }
  }
}