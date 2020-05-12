#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: ConsoleTesting
// File Name: Program.cs
// 
// Current Data:
// 2020-05-12 1:57 PM
// 
// Creation Date:
// 2020-05-12 11:32 AM

#endregion

using System;
using System.Linq;
using MupenMovieEditor.Extensions;
using MupenMovieEditor.Models;

namespace ConsoleTesting
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var num = BitConverter.GetBytes(0xC0182541).Reverse().ToArray();
      var input = new InputModel(num);
      Console.WriteLine(input.X);
      Console.WriteLine(input.Y);
      Console.WriteLine(input.Buttons);
      Console.WriteLine(string.Join(", ", input.GetInputs()));

      Console.ReadKey();
    }
  }
}