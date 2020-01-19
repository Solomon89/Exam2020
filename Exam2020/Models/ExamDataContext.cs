using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2020.Models
{
    public class ExamDataContext: DbContext
    {
        public DbSet<T1Manufacturer> T1Manufacturers { get; set; }
        public DbSet<T1Auto> T1Auto { get; set; }
        public DbSet<T1Garage> T1Garage { get; set; }
        public DbSet<T1CarModel> T1CarModels { get; set; }
        public ExamDataContext(DbContextOptions<ExamDataContext> options) : base(options)
        {
            Database.EnsureCreated();
            InitT1();
        }

        private void InitT1()
        {
            if (!T1Garage.Any())
            {
                T1Manufacturers.AddRange( new T1Manufacturer[]
                    {
                    new T1Manufacturer { Name = "Mersedes" },
                    new T1Manufacturer { Name = "BMW" },
                    new T1Manufacturer { Name = "Audi" },
                    new T1Manufacturer { Name = "ВАЗ" }
                    }
                    );
                SaveChanges();
                T1CarModels.AddRange
                    ( new T1CarModel[]
                        {
                            new T1CarModel{ Name = "600",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "Mersedes") },
                            new T1CarModel{ Name = "300",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "Mersedes") },
                            new T1CarModel{ Name = "200",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "Mersedes") },
                            new T1CarModel{ Name = "M4",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "BMW") },
                            new T1CarModel{ Name = "M3",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "BMW") },
                            new T1CarModel{ Name = "M5",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "BMW") },
                            new T1CarModel{ Name = "5",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "BMW") },
                            new T1CarModel{ Name = "Q3",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "Audi") },
                            new T1CarModel{ Name = "Q4",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "Audi") },
                            new T1CarModel{ Name = "Q5",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "Audi") },
                            new T1CarModel{ Name = "2107",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "ВАЗ") },
                            new T1CarModel{ Name = "2110",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "ВАЗ") },
                            new T1CarModel{ Name = "2114",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "ВАЗ") },
                            new T1CarModel{ Name = "Granda",T1Manufacturer = T1Manufacturers.First(i=>i.Name == "ВАЗ") },
                        }
                    );
                SaveChanges();
                T1Auto.AddRange(
                    new T1Auto[]
                    {
                        new T1Auto() {Color = Color.Red.ToString() ,T1Car = T1CarModels.First(i=>i.Name=="600")},
                        new T1Auto() {Color = Color.Green.ToString() ,T1Car = T1CarModels.First(i=>i.Name=="600")},
                        new T1Auto() {Color = Color.Gray.ToString() ,T1Car = T1CarModels.First(i=>i.Name=="600")},
                        new T1Auto() {Color = Color.Gray.ToString() ,T1Car = T1CarModels.First(i=>i.Name=="Q3")},
                        new T1Auto() {Color = Color.Gray.ToString() ,T1Car = T1CarModels.First(i=>i.Name=="Q5")},
                        new T1Auto() {Color = Color.White.ToString() ,T1Car = T1CarModels.First(i=>i.Name=="2107")},
                        new T1Auto() {Color = Color.Red.ToString() ,T1Car = T1CarModels.First(i=>i.Name=="Granda")},
                    }
                    );
                SaveChanges();
                T1Garage.AddRange(
                    new T1Garage[]
                    {
                        new T1Garage()
                        {
                            Name = "Гараж 1",
                            Cars = T1Auto.Where(i=>i.Color == Color.Gray.ToString()).ToList()
                        },
                        new T1Garage()
                        {
                            Name = "Гараж 2",
                            Cars = T1Auto.Where(i=>i.Color!= Color.Gray.ToString()).ToList()
                        }
                    });
                SaveChanges();
            }
        }
    }
}
