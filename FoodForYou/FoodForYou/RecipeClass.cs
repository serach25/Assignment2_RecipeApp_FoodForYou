using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForYou
{
    public class RecipeClass
    {
        public int id { set; get; }
        public string title { set; get; }
        public int calories { set; get; }
        public string carbs { set; get; }
        public string fat { set; get; }
        public string image { set; get; }
        public string imageType { set; get; }
        public string protein { set; get; }

        public RecipeClass(int i, string t, int c, string ca, string f, string img, string imgt, string p)
        {
            id = i;
            title = t;
            calories = c;
            carbs = ca;
            fat = f;
            image = img;
            imageType = imgt;
            protein = p;
        }
    }
}
