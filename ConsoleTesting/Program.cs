﻿#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: ConsoleTesting
// File Name: Program.cs
// 
// Current Data:
// 2020-06-10 12:40 PM
// 
// Creation Date:
// 2020-05-12 11:32 AM

#endregion

using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using MupenSharp.Enums;
using MupenSharp.FileParsing;

namespace ConsoleTesting
{
  internal class Program
  {
    private static string _baseDir;

    public static void Main()
    {
      Console.WriteLine(@"DO NOT USE THIS IF YOU HAVE NO BACKUP FILES");
      Console.WriteLine(@"Enter parent TAS directory. All child m64 and st files will be renamed: ");
      var path = Console.ReadLine();
      Console.WriteLine();

      if (path is null || !Directory.Exists(path))
      {
        Console.WriteLine(@"That is not a valid directory...");
      }
      else
      {
        BeginRename(path);
      }

      //var p = new M64Parser();
      //var m64 = p.Parse(@"D:\ForkRepos\SM64TASArchive\Full Game\1 Key\04m20s30ms\1 Key.m64");
      //Console.WriteLine($"{m64.Crc32:X}");

      Console.ReadKey(true);
    }

    private static void BeginRename(string baseDir)
    {
      // Search current directory down; find all files ending in .m64 and .st.
      // If files end in (U).m64, for example, all is fine.
      // If not, scan files, and add the appropriate code.
      var renameCount = 0;

      var allFiles = Directory
        .GetFiles(baseDir, "*.*",
          SearchOption.AllDirectories).Where(f => f.EndsWith(".m64"));

      // Check each dir if m64 files have correct name. If not, correct and check for st. If st is found, rename it

      var invalidFiles = allFiles.Where(fileName => !Regex.IsMatch(fileName, @"\(\w+\)[.](m64|st)$"));

      var parser = new M64Parser();
      foreach (var file in invalidFiles)
      {
        var originalName = Path.GetFileNameWithoutExtension(file);
        var parent = Directory.GetParent(file).FullName;

        // Read m64 file
        var m64 = parser.Parse(file);

        // Check for U or J region code
        var knownRegion = Enum.TryParse(m64.Crc32.ToString(CultureInfo.InvariantCulture),
          out RegionCode regionCode);

        // New file name format
        var newName = $"{originalName} ({(!knownRegion ? "Unknown" : regionCode.ToString())})";

        // Rename
        Directory.Move(file, Path.Combine(parent, $"{newName}.m64"));

        Console.WriteLine($@"""{Path.GetFileName(file)}"" => ""{newName}.m64""");
        ++renameCount;

        // Check for .st file to rename
        var stDir = Path.Combine(parent, $"{originalName}.st");
        if (File.Exists(stDir))
        {
          var newSt = Path.Combine(parent, $"{newName}.st");
          Directory.Move(stDir, newSt);
          Console.WriteLine($@"""{originalName}.st"" => ""{newName}.st""");
          ++renameCount;
        }

        Console.WriteLine();
      }

      Console.WriteLine($@"Total files renamed: {renameCount}");
    }
  }
}