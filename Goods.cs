using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CW_Catalog
{
    public class Goods
    {
        string Name;
        string Producer;
        double Price;
        public string _name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string _producer
        {
            get { return Producer; }
            set { Producer = value; }
        }
        public double _price
        {
            get { return Price; }
            set
            {
                if (Price < 0) throw new Exception("Введите цену больше 0");
                else Price = value;
            }
        }

        public Goods()
        {
            _name = " ";
            _producer = " ";
            _price = 0;

        }
        public Goods(string name, string producer, double price)
        {
            _name = name;
            _producer = producer;
            _price = price;
        }

        public override string ToString()
        {
            return $"Название товара: {_name}, Производитель: {_producer}, " +
                $"Стоимость: {_price}  ";
        }


    }
}
