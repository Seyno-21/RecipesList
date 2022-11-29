using MyRecipesApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyRecipesApp.Views
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