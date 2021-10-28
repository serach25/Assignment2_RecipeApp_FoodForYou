using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodForYou
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Diet : ContentPage
    {
        String selectedDiet = "";
        public Diet()
        {
            InitializeComponent();
        }

        private void NextPressed(object sender, EventArgs e)
        {
            if (selectedDiet == "")
            {
                DisplayAlert("ERROR", "Please select a diet", "OK");
            }
            else
            {
                String diet = selectedDiet.ToLower();
                Navigation.PushAsync(new Intolerances(diet));
            }
        }

        private void Diet_Selected(object sender, EventArgs e)
        {
           //save selected diet
            selectedDiet = (sender as Button).Text;

            if(selectedDiet == "GLUTEN FREE")
            {
                gluten.BackgroundColor = Color.LightGray;
                keto.BackgroundColor = Color.White;
                vegetarian.BackgroundColor = Color.White;
                lacto.BackgroundColor = Color.White;
                ovo.BackgroundColor = Color.White;
                vegan.BackgroundColor = Color.White;
                pescetarian.BackgroundColor = Color.White;
                paleo.BackgroundColor = Color.White;
                primal.BackgroundColor = Color.White;
                lowfodmap.BackgroundColor = Color.White;
                whole30.BackgroundColor = Color.White;
             //   all.BackgroundColor = Color.White;
            }
            if (selectedDiet == "KETOGENIC")
            {
                keto.BackgroundColor = Color.LightGray;
                gluten.BackgroundColor = Color.White;
                vegetarian.BackgroundColor = Color.White;
                lacto.BackgroundColor = Color.White;
                ovo.BackgroundColor = Color.White;
                vegan.BackgroundColor = Color.White;
                pescetarian.BackgroundColor = Color.White;
                paleo.BackgroundColor = Color.White;
                primal.BackgroundColor = Color.White;
                lowfodmap.BackgroundColor = Color.White;
                whole30.BackgroundColor = Color.White;
               // all.BackgroundColor = Color.White;
            }
            if (selectedDiet == "VEGETARIAN")
            {
                vegetarian.BackgroundColor = Color.LightGray;
                gluten.BackgroundColor = Color.White;
                keto.BackgroundColor = Color.White;
                lacto.BackgroundColor = Color.White;
                ovo.BackgroundColor = Color.White;
                vegan.BackgroundColor = Color.White;
                pescetarian.BackgroundColor = Color.White;
                paleo.BackgroundColor = Color.White;
                primal.BackgroundColor = Color.White;
                lowfodmap.BackgroundColor = Color.White;
                whole30.BackgroundColor = Color.White;
                //all.BackgroundColor = Color.White;
            }
            if (selectedDiet == "LACTO-VEGETARIAN")
            {
                lacto.BackgroundColor = Color.LightGray;
                gluten.BackgroundColor = Color.White;
                keto.BackgroundColor = Color.White;
                vegetarian.BackgroundColor = Color.White;
                ovo.BackgroundColor = Color.White;
                vegan.BackgroundColor = Color.White;
                pescetarian.BackgroundColor = Color.White;
                paleo.BackgroundColor = Color.White;
                primal.BackgroundColor = Color.White;
                lowfodmap.BackgroundColor = Color.White;
                whole30.BackgroundColor = Color.White;
              //  all.BackgroundColor = Color.White;
            }
            if (selectedDiet == "OVO-VEGETARIAN")
            {
                ovo.BackgroundColor = Color.LightGray;
                gluten.BackgroundColor = Color.White;
                keto.BackgroundColor = Color.White;
                vegetarian.BackgroundColor = Color.White;
                lacto.BackgroundColor = Color.White;
                vegan.BackgroundColor = Color.White;
                pescetarian.BackgroundColor = Color.White;
                paleo.BackgroundColor = Color.White;
                primal.BackgroundColor = Color.White;
                lowfodmap.BackgroundColor = Color.White;
                whole30.BackgroundColor = Color.White;
                //all.BackgroundColor = Color.White;
            }
            if (selectedDiet == "VEGAN")
            {
                vegan.BackgroundColor = Color.LightGray;
                gluten.BackgroundColor = Color.White;
                keto.BackgroundColor = Color.White;
                vegetarian.BackgroundColor = Color.White;
                lacto.BackgroundColor = Color.White;
                ovo.BackgroundColor = Color.White;
                pescetarian.BackgroundColor = Color.White;
                paleo.BackgroundColor = Color.White;
                primal.BackgroundColor = Color.White;
                lowfodmap.BackgroundColor = Color.White;
                whole30.BackgroundColor = Color.White;
                //all.BackgroundColor = Color.White;
            }
            if (selectedDiet == "PESCETARIAN")
            {
                pescetarian.BackgroundColor = Color.LightGray;
                gluten.BackgroundColor = Color.White;
                keto.BackgroundColor = Color.White;
                vegetarian.BackgroundColor = Color.White;
                lacto.BackgroundColor = Color.White;
                ovo.BackgroundColor = Color.White;
                vegan.BackgroundColor = Color.White;
                paleo.BackgroundColor = Color.White;
                primal.BackgroundColor = Color.White;
                lowfodmap.BackgroundColor = Color.White;
                whole30.BackgroundColor = Color.White;
                //all.BackgroundColor = Color.White;
            }
            if (selectedDiet == "PALEO")
            {
                paleo.BackgroundColor = Color.LightGray;
                gluten.BackgroundColor = Color.White;
                keto.BackgroundColor = Color.White;
                vegetarian.BackgroundColor = Color.White;
                lacto.BackgroundColor = Color.White;
                ovo.BackgroundColor = Color.White;
                vegan.BackgroundColor = Color.White;
                pescetarian.BackgroundColor = Color.White;               
                primal.BackgroundColor = Color.White;
                lowfodmap.BackgroundColor = Color.White;
                whole30.BackgroundColor = Color.White;
                //all.BackgroundColor = Color.White;
            }
            if (selectedDiet == "PRIMAL")
            {
                primal.BackgroundColor = Color.LightGray;
                gluten.BackgroundColor = Color.White;
                keto.BackgroundColor = Color.White;
                vegetarian.BackgroundColor = Color.White;
                lacto.BackgroundColor = Color.White;
                ovo.BackgroundColor = Color.White;
                vegan.BackgroundColor = Color.White;
                pescetarian.BackgroundColor = Color.White;
                paleo.BackgroundColor = Color.White;
                lowfodmap.BackgroundColor = Color.White;
                whole30.BackgroundColor = Color.White;
                //all.BackgroundColor = Color.White;
            }
            if (selectedDiet == "LOW FODMAP")
            {
                lowfodmap.BackgroundColor = Color.LightGray;
                gluten.BackgroundColor = Color.White;
                keto.BackgroundColor = Color.White;
                vegetarian.BackgroundColor = Color.White;
                lacto.BackgroundColor = Color.White;
                ovo.BackgroundColor = Color.White;
                vegan.BackgroundColor = Color.White;
                pescetarian.BackgroundColor = Color.White;
                paleo.BackgroundColor = Color.White;
                primal.BackgroundColor = Color.White;
                whole30.BackgroundColor = Color.White;
                //all.BackgroundColor = Color.White;
            }
            if (selectedDiet == "WHOLE30")
            {
                whole30.BackgroundColor = Color.LightGray;
                gluten.BackgroundColor = Color.White;
                keto.BackgroundColor = Color.White;
                vegetarian.BackgroundColor = Color.White;
                lacto.BackgroundColor = Color.White;
                ovo.BackgroundColor = Color.White;
                vegan.BackgroundColor = Color.White;
                pescetarian.BackgroundColor = Color.White;
                paleo.BackgroundColor = Color.White;
                primal.BackgroundColor = Color.White;
                lowfodmap.BackgroundColor = Color.White;
                //all.BackgroundColor = Color.White;

            }
         /*   if (selectedDiet == "ALL RECIPES")
            {
                all.BackgroundColor = Color.LightGray;
                whole30.BackgroundColor = Color.White;
                gluten.BackgroundColor = Color.White;
                keto.BackgroundColor = Color.White;
                vegetarian.BackgroundColor = Color.White;
                lacto.BackgroundColor = Color.White;
                ovo.BackgroundColor = Color.White;
                vegan.BackgroundColor = Color.White;
                pescetarian.BackgroundColor = Color.White;
                paleo.BackgroundColor = Color.White;
                primal.BackgroundColor = Color.White;
                lowfodmap.BackgroundColor = Color.White;

            }*/
        }
    }
}