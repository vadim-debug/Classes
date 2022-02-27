using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Person // Открытый ("публичный") класс Person для хранения информации о клиенте.
    {
        public int id;
        public string name; 
        public int age;
        // Поля класса
        public Person(string name) // Конструктор класса Person с входным параметром
        {
            this.name = name;
        }
    }
}
