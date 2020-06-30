#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenMovieEditor
// File Name: App.xaml.cs
// 
// Current Data:
// 2020-05-12 5:11 PM
// 
// Creation Date:
// 2020-05-12 10:27 AM

#endregion

using System.Windows;

namespace MupenMovieEditor
{
  /// <summary>
  ///   Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private void App_OnStartup(object sender, StartupEventArgs e)
    {
      ApplicationShell.Start();
    }
  }
}