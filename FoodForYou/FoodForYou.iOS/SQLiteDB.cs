using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using SQLite;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(FoodForYou.iOS.SQLiteDB))]
namespace FoodForYou.iOS
{
    public class SQLiteDB : SQLiteDBinterface
    {
        public SQLiteAsyncConnection createSQLiteDB()
        {
            var document_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(document_path, "mealDB.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}