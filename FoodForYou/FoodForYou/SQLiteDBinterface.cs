using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace FoodForYou
{
    public interface SQLiteDBinterface
    {
        SQLiteAsyncConnection createSQLiteDB();
    }
}