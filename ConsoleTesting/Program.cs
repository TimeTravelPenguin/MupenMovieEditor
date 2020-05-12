#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: ConsoleTesting
// File Name: Program.cs
// 
// Current Data:
// 2020-05-12 11:46 AM
// 
// Creation Date:
// 2020-05-12 11:32 AM

#endregion

using System;
using MupenMovieEditor.Models;

namespace ConsoleTesting
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var buttonsPressed = InputMask.A | InputMask.CUp | InputMask.CDown;
      Console.WriteLine(buttonsPressed.HasFlag(InputMask.Z));
      Console.WriteLine(buttonsPressed.HasFlag(InputMask.A));
      Console.WriteLine(buttonsPressed.HasFlag(InputMask.CDown));

      Console.ReadKey();
    }
  }
}