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
    public partial class MealPlanGenerator : ContentPage
    {
        string query1;
        string query2;
        string query3;
        string query4;
        String diet;
        String intolerances;
        NetworkingManager manager = new NetworkingManager();
        ObservableCollection<MealClass> meals;
        public MealPlanGenerator(String d, String i)
        {
            InitializeComponent();
            diet = d;
            intolerances = i;
        }

        async void Generate_MealPlan(object sender, EventArgs e)
        {
            query1 = "day"; 
            query2 = calories.Text;
            query3 = diet;
            query4 = intolerances;

            var listFromAPI = await manager.getPlan(query1, query2, query3, query4);
            meals = new ObservableCollection<MealClass>();
            foreach (MealClass i in listFromAPI)
            {
                meals.Add(new MealClass(i.id, i.imageType, i.title, i.readyInMinutes, i.servings, i.sourceUrl));
            }

            //display plan on new page
            await Navigation.PushAsync(new DisplayPlan(meals));
        }
    }
}