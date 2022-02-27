using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Order // открытый класс Order  
    {
        public int Id; 
        public Food food; // поле класса Order типа Food, с названием food
        public Person person;
        // поля класса 
        public Order(int Id) // конструктор класса Order с входными параметрами 
        {
            this.Id = Id;
        }
    }
}
