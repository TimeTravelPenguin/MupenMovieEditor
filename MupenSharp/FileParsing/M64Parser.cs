#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenSharp
// File Name: M64Parser.cs
// 
// Current Data:
// 2020-05-12 7:18 PM
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
        reader.BaseStream.Seek(0x400, SeekOrigin.Begin);
        var inputs = new List<InputModel>();

        while (reader.BaseStream.Position != reader.BaseStream.Length)
        {
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