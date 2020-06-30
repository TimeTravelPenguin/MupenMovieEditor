#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenMovieEditor
// File Name: ApplicationShell.cs
// 
// Current Data:
// 2020-06-30 1:43 PM
// 
// Creation Date:
// 2020-06-30 1:36 PM

#endregion

using MupenMovieEditor.ViewModels;
using MupenMovieEditor.Views;

namespace MupenMovieEditor
{
  internal static class ApplicationShell
  {
    public static void Start()
    {
      var main = new MainWindowView();
      var vm = new MainWindowViewModel(main)
      {
        WindowTitle = "Mupen64 Editor"
      };

      main.DataContext = vm;

      main.Show();
    }
  }
}