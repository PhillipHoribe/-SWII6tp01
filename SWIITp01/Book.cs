using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWIITp01
{
    class Book
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public Author[] Authors { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Book(string name, Author[] author, double price)
        {
            Name = name;
            Authors = author;
            Price = price;
            Qty = 0;

        }
        public Book(string name, Author[] author, double price, int qty)
        {
            Name = name;
            Authors = author;
            Price = price;
            Qty = qty;
        }

        public override string ToString()
        {

            string aux = "";

            foreach (Author a in Authors)
            {
                aux += $"[name={a.Name},email={a.Email},gender={a.Gender}]";

                if (a != Authors.Last())
                {
                    aux += ",";
                }
            }

            string stringFormatada = "Book[" + Name + ",authors={Authors" + aux + "},price=" + Price + ",qty=" + Qty + "]";

            return stringFormatada;
        }
        public string getAuthorNames()
        {
            string aux = "";

            foreach (Author a in Authors)
            {
                aux += a.Name;

                if (a != Authors.Last())
                {
                    aux += ",";
                }

            }
            return aux;

        }
    }
}
