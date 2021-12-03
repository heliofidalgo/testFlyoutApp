using System.ComponentModel;
using Xamarin.Forms;
using testFlyoutApp.ViewModels;

namespace testFlyoutApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
