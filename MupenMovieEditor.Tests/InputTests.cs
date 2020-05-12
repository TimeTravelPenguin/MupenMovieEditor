#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenMovieEditor.Tests
// File Name: InputTests.cs
// 
// Current Data:
// 2020-05-12 4:00 PM
// 
// Creation Date:
// 2020-05-12 12:35 PM

#endregion

using System.Linq;
using AllOverIt.Fixture;
using FluentAssertions;
using MupenMovieEditor.Models;
using Xunit;

namespace MupenMovieEditor.Tests
{
  public class InputTests : AoiFixtureBase
  {
    [Fact]
    public void InputConversionCorrect()
    {
      var bytes = CreateMany<byte>(4).ToArray();
      var input = new InputModel(bytes);

      var convInt = (byte[]) input;

      bytes.Should().Equal(convInt);
      input.Should().BeEquivalentTo((InputModel) convInt);
    }
  }
}