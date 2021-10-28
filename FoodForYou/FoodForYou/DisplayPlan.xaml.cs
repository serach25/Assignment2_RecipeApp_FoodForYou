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
    public partial class DisplayPlan : ContentPage

    {
        ObservableCollection<MealClass> dmeals;

        public DisplayPlan(ObservableCollection<MealClass> meals)
        {
            InitializeComponent();
            dmeals = meals;
            MyMealList.ItemsSource = dmeals;
        }

        private void Save_Mealplan(object sender, EventArgs e)
        {
            //navigate to saved plans page
            Navigation.PushAsync(new DisplaySavedPlans(dmeals));
        }
    }
}