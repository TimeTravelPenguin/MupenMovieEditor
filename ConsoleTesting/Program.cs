#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: ConsoleTesting
// File Name: Program.cs
// 
// Current Data:
// 2020-06-09 10:39 PM
// 
// Creation Date:
// 2020-05-12 11:32 AM

#endregion

using System;
using MupenSharp.FileParsing;

namespace ConsoleTesting
{
  internal class Program
  {
    public static void Main()
    {
      const string path = @"D:\_Data\Desktop\To the Top of the Fortress.m64";

      var parser = new M64Parser();
      parser.SetFile(path);
      var m64 = parser.Parse();

      Console.WriteLine(m64.Author);
      Console.WriteLine(m64.RerecordCount);

      Console.ReadKey(true);
    }
  }
}