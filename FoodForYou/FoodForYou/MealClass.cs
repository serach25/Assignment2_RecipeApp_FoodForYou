using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FoodForYou
{
    public class MealClass
    {
        //all public properties will be columns in your table
       [PrimaryKey, AutoIncrement]
        public int ID_database { set; get; }
        public int id { set; get; }
        public string imageType { set; get; }
        public string title { set; get; }
        public int readyInMinutes { set; get; }
        public int servings { set; get; }
        public string sourceUrl { set; get; }

        public MealClass(int i, string imgt, string t, int r, int s, string source)
        {
            id = i;
            imageType = imgt;
            title = t;
            readyInMinutes = r;
            servings = s;
            sourceUrl = source;
        }

        public MealClass()
        { }
    }
}
