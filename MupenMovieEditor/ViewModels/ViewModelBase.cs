#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenMovieEditor
// File Name: ViewModelBase.cs
// 
// Current Data:
// 2020-06-30 2:07 PM
// 
// Creation Date:
// 2020-06-30 1:17 PM

#endregion

using System.Windows;
using Microsoft.Expression.Interactivity.Core;
using MupenMovieEditor.Base;

namespace MupenMovieEditor.ViewModels
{
  internal class ViewModelBase : PropertyChangedBase
  {
    private string _windowTitle;

    public string WindowTitle
    {
      get => _windowTitle;
      set => SetValue(ref _windowTitle, value);
    }

    public ActionCommand CloseWindow { get; }
    public ActionCommand MinimizeWindow { get; }
    public ActionCommand MaximizeWindow { get; }

    protected ViewModelBase(Window window)
    {
      CloseWindow = new ActionCommand(window.Close);
      MinimizeWindow = new ActionCommand(() => window.WindowState = WindowState.Minimized);
      MaximizeWindow = new ActionCommand(() => window.WindowState = WindowState.Maximized);
    }
  }
}