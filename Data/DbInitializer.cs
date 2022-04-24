
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M3Q1.Data
{
    public class DbInitializer
    {
        public static void Initialize(RestaurantContext context)
        {
            context.Database.EnsureCreated();

            // don't need do it
            //if (context.MenuItems.Any())
            //{
            //    return;   // DB has been seeded
            //}

            //var menuItems = new MenuItem[]
            //{
            //    new MenuItem { Name="Spaghetti",Price=14.99m }

            //};
            //foreach (MenuItem m in menuItems)
            //{
            //    context.MenuItems.Add(m);
            //}
            //context.SaveChanges();

            //var reservations = new Reservation[]
            //{
            //    new Reservation{ Name= "Bob Loblaw",Date=DateTime.Parse("2020-01-01"), MenuItems= new MenuItem { Name="Spaghetti",Price=14.99m } }
            //};
            //foreach (Reservation r in reservations)
            //{
            //    context.Reservations.Add(r);
            //}
            //context.SaveChanges();

            
        }
    }
}
