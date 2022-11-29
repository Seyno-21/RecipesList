using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MyRecipesApp;
using MyRecipesApp.Models;
using Xamarin.Forms;

namespace MyRecipesApp.Views
{
    public partial class RecipePage : ContentPage
    {
        public RecipePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Retrieve all the recipes from the database, and set them as the
            // data source for the CollectionView.
            collectionView.ItemsSource = await App.Database.GetRecipesAsync();
        }

        async void AddClicked(object sender, EventArgs e)
        {
            // Navigate to the RecipeEntryPage, without passing any data.
            await Shell.Current.GoToAsync(nameof(RecipeEntryPage));
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                // Navigate to the RecipeEntryPage, passing the ID as a query parameter.
                Recipe recipe = (Recipe)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync($"{nameof(RecipeEntryPage)}?{nameof(RecipeEntryPage.ItemId)}={recipe.ID.ToString()}");
            }
        }
    }
}