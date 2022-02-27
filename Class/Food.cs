using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Food // Открытый класс Food 
    {
        public string Title;
        public decimal Price;
        public string Description;
        // поля класса 
        public Food(decimal Price) // Конструктор класса Person с входными параметрами
        {
            this.Price = Price;
        }
    }
    
}
