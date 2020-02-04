using System;
using System.Collections.Generic;
using System.Text;
using Salon.Models;
using SQLite;

namespace Salon.Helpers
{
     static  class  CreateDatabases
    {
        public static void Create()
        {
            using (var conn = new SQLiteConnection(App.Databasepath))
            {
                conn.CreateTable<Product>();
                conn.CreateTable<Salonist>();
                conn.CreateTable<SalonOwnerAccount>();
                conn.CreateTable<Services>();
                conn.CreateTable<SignUp>();
            }
        }
        
    }
}
