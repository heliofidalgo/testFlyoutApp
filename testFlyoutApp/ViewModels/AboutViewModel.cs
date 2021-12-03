using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace testFlyoutApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Google Books";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://books.google.com/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
