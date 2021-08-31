using System;

namespace NamedArguments
{
    class Program
    {
       public class Product
        {
            int ordernum;
            string productname;
            string sellername;
            public void Printorderdetails(int ordernum,string productname,string sellername)
            {
                Console.WriteLine("y {0},{1},{2}",ordernum,productname,sellername);
            }
        }
        static void Main(string[] args)
        {
            Product obj = new Product();
            obj.Printorderdetails(ordernum:8,productname:"Laptop",sellername:"Abc");
        }
    }
}
