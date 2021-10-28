using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodForYou
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayRecipes : ContentPage
    {
        ObservableCollection<RecipeClass> drecipes;
        String diet;
        String intolerances;
        public DisplayRecipes(ObservableCollection<RecipeClass> recipes, String d, String i)
        {
            InitializeComponent();
            drecipes = recipes;
            diet = d;
            intolerances = i;
            MyRecipeList.ItemsSource = drecipes;
        }

        private void MyRecipeList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
         //   Navigation.PushAsync(new RecipeDetails(e.SelectedItem as RecipeClass));
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MealPlanGenerator(diet, intolerances));
        }
    }
}