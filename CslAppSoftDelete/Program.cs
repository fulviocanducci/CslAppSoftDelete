using Canducci.SoftDelete.Extensions;
using Canducci.SoftDelete.Interceptors;
using CslAppSoftDelete.Models;
using CslAppSoftDelete.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CslAppSoftDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<DatabaseService> builder =
                new DbContextOptionsBuilder<DatabaseService>();
            builder.UseSqlServer("Server=127.0.0.1;Database=MySources;User Id=sa;Password=123456;");
            builder.AddInterceptorSoftDeleteBool();
            builder.AddInterceptorSoftDeleteChar();
            builder.AddInterceptorSoftDeleteDateTime();

            using (DatabaseService db = new DatabaseService(builder.Options))
            {
                //db.Database.EnsureDeleted();
                //db.Database.EnsureCreated();

                //People p0 = new People
                //{
                //    Name = "Romário dos Santos"
                //};
                //People p1 = new People
                //{
                //    Name = "Bebeto de Freitas"
                //};

                //Source s0 = new Source
                //{
                //    Name = "Computer"
                //};
                //Source s1 = new Source
                //{
                //    Name = "MotherBoard"
                //};

                //House h0 = new House
                //{
                //    Name = "Computer"
                //};
                //House h1 = new House
                //{
                //    Name = "MotherBoard"
                //};

                //db.AddRange(p0, p1, s0, s1, h0, h1);
                //db.SaveChanges();

                People pu = db.People.Find(1);
                Source su = db.Source.Find(2);
                House hu = db.House.Find(2);
                

                db.RemoveRange(pu, su, hu);
                db.SaveChanges();

                var peoples = db.People.AsNoTrackingWithIdentityResolution().ToList();
                var sources = db.Source.AsNoTrackingWithIdentityResolution().ToList();
                var houses = db.House.AsNoTrackingWithIdentityResolution().ToList();
            }
            Console.WriteLine("Done!");
        }
    }
}
