using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle001 {
    abstract class Vehicle {
        public string name { get; set; }
        public int  motion { get; set; }
        public string size { get; set; }

        public abstract void Move();
        public virtual void ShowInformation()
        {
            
            Console.WriteLine("\nНазвание: {0}.", name);
            Move();
            Console.WriteLine("\nMаксимальная скорость: до {0} км\\ч.\nГабаритные размеры: {1}.", motion, size);
           
        }

    }
    class Мotorbike : Vehicle {
        public Мotorbike() {
            name = "Мотоцикл \"Урал\"";
            motion = 120;
            size = "длина 2420. ширина 1650. высота 1100";
            wheelCount = 2;
           
        }
        public int wheelCount { get; set; }

        public override void Move()
        {
            Console.Write("Передвижение: {0} - Ездит по твёрдой горизонтальной поверхности.", name);
        }
        public new void ShowInformation() {
            base.ShowInformation();
            Console.WriteLine("Количество колёс: {0} шт.", wheelCount);
        }
    }
    class Car : Мotorbike {
        public Car() {
            name = "Легковой автомобиль \"ВАЗ-2106\"";
            motion = 140;
            size = "длина 4166. ширина 1611. высота 1444"; 
            wheelCount = 4;
            passengerCapacity = "Водитель + 4 пассажира";
        }
        public string passengerCapacity { get; set; }

        public new void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Пассажировместимость: {0}", passengerCapacity);
        }
    }
    class Truck : Car
    { 
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\t\tТранспортные средства:");
            Мotorbike MR = new Мotorbike(); 
            MR.ShowInformation();
            Car c = new Car();
            c.ShowInformation();
            Truck truck = new Truck();  
            truck.ShowInformation();
            Console.WriteLine();
        }
    }
}
