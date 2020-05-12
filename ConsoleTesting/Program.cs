#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: ConsoleTesting
// File Name: Program.cs
// 
// Current Data:
// 2020-05-12 6:31 PM
// 
// Creation Date:
// 2020-05-12 11:32 AM

#endregion

using System;
using MupenSharp.Extensions;
using MupenSharp.FileParsing;

namespace ConsoleTesting
{
  internal static class Program
  {
    private static void Main()
    {
      const string path = @"D:\_Data\Desktop\test.m64";
      var parser = new M64Parser();
      parser.SetFile(path);
      var m64 = parser.Parse();

      var i = 1;
      foreach (var input in m64.Inputs)
      {
        var buttons = input.GetInputs().Join(", ");
        Console.WriteLine($"{i++}: {buttons}");
      }

      Console.ReadKey();
    }
  }
}