using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(FoodForYou.Droid.SQLiteDB))]
namespace FoodForYou.Droid
{
    public class SQLiteDB : SQLiteDBinterface
    {
        public SQLiteAsyncConnection createSQLiteDB()
        {
            var document_path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = System.IO.Path.Combine(document_path, "mealDB.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}
