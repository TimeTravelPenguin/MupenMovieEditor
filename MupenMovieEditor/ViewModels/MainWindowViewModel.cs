#region Title Header

// Name: Phillip Smith
// 
// Solution: MupenMovieEditor
// Project: MupenMovieEditor
// File Name: MainWindowViewModel.cs
// 
// Current Data:
// 2020-06-30 5:23 PM
// 
// Creation Date:
// 2020-06-30 1:08 PM

#endregion

using System.Windows;
using System.Windows.Controls;
using MupenMovieEditor.Views;

namespace MupenMovieEditor.ViewModels
{
  internal class MainWindowViewModel : ViewModelBase
  {
    private Page _currentPage;

    public Page CurrentPage
    {
      get => _currentPage;
      set => SetValue(ref _currentPage, value);
    }

    public MainWindowViewModel(Window window) : base(window)
    {
      CurrentPage = new MainPageView();
    }
  }
}