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
    public partial class Intolerances : ContentPage
    {
        String diet;
        String intolerances ="";
        Boolean isDairy;
        Boolean isEggs;
        Boolean isFish;
        Boolean isGluten;
        Boolean isGrain;
        Boolean isPeanuts;
        Boolean isSesame;
        Boolean isShellfish;
        Boolean isSoy;
        Boolean isSulphites;
        Boolean isTreenuts;
        Boolean isWheat;
        ObservableCollection<RecipeClass> recipes;
        NetworkingManager manager = new NetworkingManager();
        public Intolerances(String dietSelected)
        {
            InitializeComponent();
            diet = dietSelected;
        }

        async void ShowRecipesPressed(object sender, EventArgs e)
        {
            //check food intolerances selected
            if (isDairy == true) { intolerances = "dairy"; }
            if (isEggs == true) { intolerances = intolerances + ",eggs"; }
            if (isFish == true) { intolerances = intolerances + ",fish"; }
            if (isGluten == true) { intolerances = intolerances + ",gluten"; }
            if (isGrain == true) { intolerances = intolerances + ",grain"; }
            if (isPeanuts == true) { intolerances = intolerances + ",peanuts"; }
            if (isSesame == true) { intolerances = intolerances + ",sesame"; }
            if (isShellfish == true) { intolerances = intolerances + ",shellfish"; }
            if (isSoy == true) { intolerances = intolerances + ",soy"; }
            if (isSulphites == true) { intolerances = intolerances + ",sulphites"; }
            if (isTreenuts == true) { intolerances = intolerances + ",treenuts"; }
            if (isWheat == true) { intolerances = intolerances + ",wheat"; }


            var listFromAPI = await manager.getRecipes(diet, intolerances);
            recipes = new ObservableCollection<RecipeClass>();
            foreach (RecipeClass i in listFromAPI)
            {
                recipes.Add(new RecipeClass(i.id, i.title, i.calories, i.carbs, i.fat, i.image, i.imageType, i.protein));
            }

            //display recipes on new page
            await Navigation.PushAsync(new DisplayRecipes(recipes, diet, intolerances));
        }

        private void Intolerances_Selected(object sender, EventArgs e)
        {
            //save selected diet
            String intolerances = (sender as Button).Text;

            if (intolerances == "DAIRY")
            {
                if (dairy.BackgroundColor == Color.White)
                {
                    dairy.BackgroundColor = Color.LightGray;
                    isDairy = true;
                }
                else
                {
                    dairy.BackgroundColor = Color.White;
                    isDairy = false;
                }

            }
            if (intolerances == "EGGS")
            {
                if (eggs.BackgroundColor == Color.White)
                {
                    eggs.BackgroundColor = Color.LightGray;
                    isEggs = true;
                }
                else
                {
                    eggs.BackgroundColor = Color.White;
                    isEggs = false;
                }
            }
            if (intolerances == "FISH")
            {
                if (fish.BackgroundColor == Color.White)
                {
                    fish.BackgroundColor = Color.LightGray;
                    isFish = true;
                }
                else
                {
                    fish.BackgroundColor = Color.White;
                    isFish = false;
                }
            }
            if (intolerances == "GLUTEN")
            {
                if (gluten.BackgroundColor == Color.White)
                {
                    gluten.BackgroundColor = Color.LightGray;
                    isGluten = true;
                }
                else
                {
                    gluten.BackgroundColor = Color.White;
                    isGluten = false;
                }
            }
            if (intolerances == "GRAIN")
            {
                if (grain.BackgroundColor == Color.White)
                {
                    grain.BackgroundColor = Color.LightGray;
                    isGrain = true;
                }
                else
                {
                    grain.BackgroundColor = Color.White;
                    isGrain = false;
                }
            }
            if (intolerances == "PEANUTS")
            {
                if (peanuts.BackgroundColor == Color.White)
                {
                    peanuts.BackgroundColor = Color.LightGray;
                    isPeanuts = true;
                }
                else
                {
                    peanuts.BackgroundColor = Color.White;
                    isPeanuts = false;
                }

            }
            if (intolerances == "SESAME")
            {
                if (sesame.BackgroundColor == Color.White)
                {
                    sesame.BackgroundColor = Color.LightGray;
                    isSesame = true;
                }
                else
                {
                    sesame.BackgroundColor = Color.White;
                    isSesame = false;
                }
            }
            if (intolerances == "SHELLFISH")
            {
                if (shellfish.BackgroundColor == Color.White)
                {
                    shellfish.BackgroundColor = Color.LightGray;
                    isShellfish = true;
                }
                else
                {
                    shellfish.BackgroundColor = Color.White;
                    isShellfish = false;
                }
            }
            if (intolerances == "SOY")
            {
                if (soy.BackgroundColor == Color.White)
                {
                    soy.BackgroundColor = Color.LightGray;
                    isSoy = true;
                }
                else
                {
                    soy.BackgroundColor = Color.White;
                    isSoy = false;
                }
            }
            if (intolerances == "SULPHITES")
            {
                if (sulphites.BackgroundColor == Color.White)
                {
                    sulphites.BackgroundColor = Color.LightGray;
                    isSulphites = true;
                }
                else
                {
                    sulphites.BackgroundColor = Color.White;
                    isSulphites = false;
                }
            }
            if (intolerances == "TREENUTS")
            {
                if (treenuts.BackgroundColor == Color.White)
                {
                    treenuts.BackgroundColor = Color.LightGray;
                    isTreenuts = true;
                }
                else
                {
                    treenuts.BackgroundColor = Color.White;
                    isTreenuts = false;
                }
            }
            if (intolerances == "WHEAT")
            {
                if (wheat.BackgroundColor == Color.White)
                {
                    wheat.BackgroundColor = Color.LightGray;
                    isWheat = true;
                }
                else
                {
                    wheat.BackgroundColor = Color.White;
                    isWheat = false;
                }
            }
          
        }
    }
}
  