#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: ConsoleTesting
// File Name: Program.cs
// 
// Current Data:
// 2020-05-12 7:36 PM
// 
// Creation Date:
// 2020-05-12 11:32 AM

#endregion

using System;
using MupenSharp.FileParsing;

namespace ConsoleTesting
{
  internal static class Program
  {
    private static void Main()
    {
      const string path = @"D:\ForkRepos\SM64TASArchive\ILs\SM64\WF - Whomp's Fortress\Shoot Into the Wild Blue\7s57ms\Shoot Into the Wild Blue.m64";
      var parser = new M64Parser();
      parser.SetFile(path);
      var m64 = parser.Parse();

      var i = 1;
      foreach (var input in m64.Inputs)
      {
        Console.WriteLine($"{i++}: {input}");
      }

      Console.ReadKey();
    }
  }
}