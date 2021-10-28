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
    public partial class DisplaySavedPlans : ContentPage
    {
        ObservableCollection<MealClass> mealstosave;

        ObservableCollection<MealClass> allMeals = new ObservableCollection<MealClass>();
        DatabaseManager dbManager = new DatabaseManager();
        public DisplaySavedPlans(ObservableCollection<MealClass> dmeals)
        {
            InitializeComponent();
            mealstosave = dmeals;
        }

        protected async override void OnAppearing()
        {
            allMeals = await dbManager.CreateTable();
            MySavedMealList.ItemsSource = allMeals;
            base.OnAppearing();
        }

        public void saveMealplan(object sender, EventArgs e)
        {
            int amount = mealstosave.Count();
            for(int i = 0; i <amount; i++)
            {
                dbManager.InsertNewMealplan(mealstosave.ElementAt(i));
                allMeals.Add(mealstosave.ElementAt(i));
                MySavedMealList.ItemsSource = null;
                MySavedMealList.ItemsSource = allMeals;
            }
        }

        public void deleteMealplan(object sender, EventArgs e)
        {
            if ( MySavedMealList.SelectedItem == null)
            {
                DisplayAlert("Error  ", "You have to select a meal to delete", "OK");
            }
            else
            {
                //delete meal
                MealClass m = MySavedMealList.SelectedItem as MealClass;
                dbManager.deleteMealplan(m);
                MySavedMealList.ItemsSource = null;
                MySavedMealList.ItemsSource = allMeals;
            }
        }

        private void MySavedMealList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           
        }
    }
}