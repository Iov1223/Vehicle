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
            Console.WriteLine("\nНазвание: {0}:\nMаксимальная скорость: до {1} км\\ч.\nГабаритные размеры: {2} в миллиметрах.", name, motion, size);
           
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
            Console.Write("Передвижение: {0} - Ездит по твёрдой горизонтальной поверхности. Управляется человкеом.\n", name);
        }
        public override void ShowInformation() {
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

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Пассажировместимость: {0}", passengerCapacity);
        }
    }
    class Truck : Car
    {
        public Truck()
        {
            name = "Грузовой автомобиль \"KAMAZ - 6520 - 53\"";
            motion = 90;
            size = "длина 7830.ширина 2550. высота 3070";
            wheelCount = 10;
            passengerCapacity = "Водитель + 2 пассажира";
            LoadСapacity = "20 тонн";
        }
        public string LoadСapacity { get; set; }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Грузоподьёмность: {0}", LoadСapacity);
        }
    }
    class Speedboat : Мotorbike
    {
        public Speedboat() 
        {
            name = "Катер \"Spirit Of Australia\"";
            motion = 511;
            size = "длина 6380. ширина 1560. высота 1630";
            wheelCount = 0;
        }
        public new void Move()
        {
            Console.WriteLine("Передвижение: {0} - ходит по морю (потому что плавает только всем известная субстанция в прорубе). " +
                "Управляется человкеом.\n", name);
        }

    }
    class Airplane : Truck
    {
        public Airplane()
        {
            name = "Пассажирский самолёт \"Boeing 777-200\"";
            motion = 945;
            size = "длина 63700.ширина 60900. высота 18520";
            wheelCount = 14;
            passengerCapacity = "Экипаж: 2 человека + 440 пассажиров";
            LoadСapacity = "262480 кг.";
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
        }
        public override void Move()
        {
            Console.WriteLine("Передвижение: {0} - Летает по небу. Управляется человкеом.\n", name);
        }
    }
    class SpiderMan : Airplane
    {
        public SpiderMan()
        {
            name = "Человек-паук";
            motion = 145;
            size = "длина 1780.ширина 900.";
            wheelCount = 0;
            passengerCapacity = "1 пассажир на спину";
            LoadСapacity = "500 кг.";
        }
        public new void ShowInformation()
        {
            base.ShowInformation();
        }
        public new void Move()
        {
            Console.WriteLine("Передвижение: {0} - Передвигается по любым поверхностям в любых пространственных положениях. Управляет сам собой\n", name);
        }
    }
    class Person
    {
        string name;
        public Person()
        {
            name = "Человек";
        }
        public void Drive(Vehicle[] vehicle)
        {
            Console.WriteLine("Я {0} - я управлю всеми этими транспортными средствами:\n{1}, {2}, {3}, {4}, {5}, кроме {6}.\n", name, vehicle[0].name, 
                vehicle[1].name, vehicle[2].name, vehicle[3].name, vehicle[4].name, vehicle[5].name);
        }
    }

    class Program {
        static void Main(string[] args) {   
            Console.WriteLine("\t\tТранспортные средства:");
            Мotorbike MR = new Мotorbike(); 
            MR.ShowInformation();
            MR.Move();
            Car C = new Car();
            C.ShowInformation();
            C.Move();
            Truck Truck = new Truck();  
            Truck.ShowInformation();
            Truck.Move();
            Speedboat speedboat = new Speedboat();
            speedboat.ShowInformation();
            speedboat.Move();
            Airplane airplane = new Airplane();
            airplane.ShowInformation();
            airplane.Move();
            SpiderMan spiderman = new SpiderMan();
            spiderman.ShowInformation();
            spiderman.Move();
            Person person = new Person();
            Vehicle[] vehicles = { MR, C, Truck, speedboat, airplane, spiderman};
            person.Drive(vehicles);
        }
    }
}
