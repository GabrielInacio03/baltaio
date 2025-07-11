using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuApp
{
    public struct Product
    {
        //Propriedades
        public int Id;
        public string Title;
        public float Price;

        //Métodos
        public Product(int id, string title, float price)
        {
            Id = id;
            Title = title;
            Price = price;
        }
        public float PriceInDolar(float dolar)
        {
            return Price * dolar;
        }
    }
}