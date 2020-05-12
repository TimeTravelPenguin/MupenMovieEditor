#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenMovieEditor
// File Name: InputExtension.cs
// 
// Current Data:
// 2020-05-12 1:51 PM
// 
// Creation Date:
// 2020-05-12 1:42 PM

#endregion

using System.Collections.Generic;
using System.Linq;
using MupenMovieEditor.Models;

namespace MupenMovieEditor.Extensions
{
  internal static class InputExtension
  {
    public static IEnumerable<Input> GetInputs(this InputModel inputModel)
    {
      return EnumExtensions.EnumToArray<Input>()
        .Where(input => ((Input) inputModel.Buttons).HasFlag(input));
    }
  }
}