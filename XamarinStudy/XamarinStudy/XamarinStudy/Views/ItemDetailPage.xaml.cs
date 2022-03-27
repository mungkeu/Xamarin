using System.ComponentModel;
using Xamarin.Forms;
using XamarinStudy.ViewModels;

namespace XamarinStudy.Views
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