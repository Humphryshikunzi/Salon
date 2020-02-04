using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Salon.Models;

namespace Salon.Helpers
{
    class DeleteDatabases
    {
        public void Delete(string databaseName)
        {
            using (var conn = new SQLiteConnection(App.Databasepath))
            {
                switch (databaseName)
                {
                    case "Product":
                        conn.DropTable<Product>();
                        break;
                    case "Salonist":
                        conn.DropTable<Salonist>();
                        break;
                    case "SalonOwnerAccount":
                        conn.DropTable<SalonOwnerAccount>();
                        break;
                    case "Services":
                        conn.CreateTable<Services>();
                        break;
                    case "SignUp":
                        conn.CreateTable<SignUp>();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
