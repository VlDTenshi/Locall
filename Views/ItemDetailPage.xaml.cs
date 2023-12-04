using Locall.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Locall.Views
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