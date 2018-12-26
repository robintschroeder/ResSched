﻿using ResSched.Interfaces;
using SQLite;
using System.IO;

namespace ResSched.Droid.Services
{
    public class DroidSQLite : ISQLite
    {
        private string DBName = $"ResSched.db3";

        public SQLiteAsyncConnection GetAsyncConnection()
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, DBName);
            // Create the connection
            var conn = new SQLite.SQLiteAsyncConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);
            // Return the database connection
            return conn;
        }

        public SQLiteConnection GetConnection()
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, DBName);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);
            // Return the database connection
            return conn;
        }
    }
}