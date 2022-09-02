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

    }
    class Мotorbike : Vehicle {
        public Мotorbike() {
            name = "Мотоцикл \"Урал\"";
            motion = 120;
            size = "длина 2420. ширина 1650. высота 1100";
            wheelCount = 2;
           
        }
        public int wheelCount { get; set; }

        public override void Move() {
            Console.WriteLine("Название: {0}.\nMаксимальная скорость: до {1} км\\ч.\nГабаритные размеры: {2}.\nКоличество колёс: {3} шт.\n", name, motion, size, wheelCount);
        }
    }
    class Car : Мotorbike {
        public Car() {
            name = "Легковой автомобиль \"ВАЗ-2106\"";
            motion = 140;
            size = "длина 4166. ширина 1611. высота 1444"; 
            wheelCount = 4;
            wheelCount = 425;
        }
        public int loadСapacity { get; set; }

    }
    class Program {
        static void Main(string[] args) {
            Мotorbike MR = new Мotorbike(); 
            MR.Move();
            Car c = new Car();
            c.Move();
        }
    }
}
