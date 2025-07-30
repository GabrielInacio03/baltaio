using System;
using System.Collections.Generic;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var articles = new List<Article>();
            articles.Add(new Article("POO", "balta.io"));

            foreach (var item in articles)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Url);
            }
        }
    }
}
