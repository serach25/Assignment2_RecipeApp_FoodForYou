using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodForYou
{
    public class DatabaseManager
    {
        SQLiteAsyncConnection _connection;
        public DatabaseManager()
        {
            //create connection
            _connection = DependencyService.Get<SQLiteDBinterface>().createSQLiteDB();
        }

        public async Task<ObservableCollection<MealClass>> CreateTable()
        {
            //create new table if it does not exist
           await _connection.CreateTableAsync<MealClass>();
            var mealplansFromDB = await _connection.Table<MealClass>().ToListAsync();
            var allMealplans = new ObservableCollection<MealClass>(mealplansFromDB);
            return allMealplans;
        }

        //Insert
        public async void InsertNewMealplan(MealClass newMeal)
        {
            //insert into table
            await _connection.InsertAsync(newMeal);
        }

        //Delete
        public async void deleteMealplan(MealClass toDelete)
        {
            //delete meal plan from table
            await _connection.DeleteAsync(toDelete);
        }
    }
}
