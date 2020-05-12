#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenMovieEditor
// File Name: EnumExtensions.cs
// 
// Current Data:
// 2020-05-12 1:46 PM
// 
// Creation Date:
// 2020-05-12 1:44 PM

#endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace MupenMovieEditor.Extensions
{
  /// <summary>
  ///   Extension methods for type <see cref="Enum" />.
  /// </summary>
  internal static class EnumExtensions
  {
    /// <summary>
    ///   Returns an array of type <typeparamref name="T" /> containing <see cref="Enum" /> values.
    /// </summary>
    /// <typeparam name="T">
    ///   The element type of the array
    /// </typeparam>
    /// <returns>
    ///   Returns an array of type <typeparamref name="T" />
    /// </returns>
    public static IEnumerable<T> EnumToArray<T>() where T : Enum
    {
      return Enum.GetValues(typeof(T)).Cast<T>();
    }
  }
}