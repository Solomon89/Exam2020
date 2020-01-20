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
        public DbSet<T2Manufecturer> T2Manufecturers { get; set; }
        public DbSet<T2Model> T2Models { get; set; }
        public DbSet<T2Shop> T2Shops { get; set; }
        public DbSet<T2ShopItems> T2ShopItems { get; set; }
        public ExamDataContext(DbContextOptions<ExamDataContext> options) : base(options)
        {
            Database.EnsureCreated();
            InitT1();
            InitT2();
        }

        private void InitT2()
        {
            if (!T2Shops.Any())
            {
                T2Manufecturers.AddRange(
                    new T2Manufecturer[]
                    {
                        new T2Manufecturer() {Name = "Canon" },
                        new T2Manufecturer() {Name = "Nikon" },
                        new T2Manufecturer() {Name = "Sony" }
                    });
                SaveChanges();
                T2Models.AddRange(
                    new T2Model[]
                    {
                        new T2Model() {Name = "D500",T2Manufecturer = T2Manufecturers.First(i=>i.Name == "Canon") },
                        new T2Model() {Name = "D600",T2Manufecturer = T2Manufecturers.First(i=>i.Name == "Canon") },
                        new T2Model() {Name = "D700",T2Manufecturer = T2Manufecturers.First(i=>i.Name == "Canon") },
                        new T2Model() {Name = "T2",T2Manufecturer = T2Manufecturers.First(i=>i.Name == "Nikon") },
                        new T2Model() {Name = "T1",T2Manufecturer = T2Manufecturers.First(i=>i.Name == "Nikon") },
                        new T2Model() {Name = "T7",T2Manufecturer = T2Manufecturers.First(i=>i.Name == "Nikon") },
                        new T2Model() {Name = "Alpha 2",T2Manufecturer = T2Manufecturers.First(i=>i.Name == "Sony") },
                        new T2Model() {Name = "Alpha 3",T2Manufecturer = T2Manufecturers.First(i=>i.Name == "Sony") },
                        new T2Model() {Name = "Alpha 4",T2Manufecturer = T2Manufecturers.First(i=>i.Name == "Sony") },
                    }
                    );
                SaveChanges();
                T2Shops.AddRange
                    (
                     new T2Shop[]
                     {
                         new T2Shop() {Name = "Citilink"},
                         new T2Shop() {Name = "Eldorado"},

                     }
                    );
                SaveChanges();
                T2ShopItems.AddRange(
                    new T2ShopItems[]
                    {
                        new T2ShopItems() {Numbers = 2, T2Shop  = T2Shops.First(i=>i.Name == "Citilink"), Coast=200000,T2Model = T2Models.First(i=>i.Name == "Alpha 4") },
                        new T2ShopItems() {Numbers = 2, T2Shop  = T2Shops.First(i=>i.Name == "Citilink"), Coast=400000,T2Model = T2Models.First(i=>i.Name == "Alpha 3") },
                        new T2ShopItems() {Numbers = 2, T2Shop  = T2Shops.First(i=>i.Name == "Citilink"), Coast=40000,T2Model = T2Models.First(i=>i.Name == "T1") },
                        new T2ShopItems() {Numbers = 2, T2Shop  = T2Shops.First(i=>i.Name == "Citilink"), Coast=15000,T2Model = T2Models.First(i=>i.Name == "D600") },
                        new T2ShopItems() {Numbers = 2, T2Shop  = T2Shops.First(i=>i.Name == "Eldorado"), Coast=21000,T2Model = T2Models.First(i=>i.Name == "Alpha 4") },
                        new T2ShopItems() {Numbers = 2, T2Shop  = T2Shops.First(i=>i.Name == "Eldorado"), Coast=20000,T2Model = T2Models.First(i=>i.Name == "D700") },
                        new T2ShopItems() {Numbers = 2, T2Shop  = T2Shops.First(i=>i.Name == "Eldorado"), Coast=12000,T2Model = T2Models.First(i=>i.Name == "D500") },
                    }
                    );
                SaveChanges();
            }
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
