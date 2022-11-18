using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet
{
    class Program
    {
        static void Main(string[] args)
        {
         
       
            Customerdetail c = new Customerdetail();
            c.Name = "Logesh";
            c.Mobilenumber = "6383470063";
           //Console.WriteLine(c);

            Flower fl = new Flower();
            Bouquet bo = new Bouquet();
            fl.Flowername = "rose";
            fl.Flowerprize =Cost.rose;
            fl.Floqty = 5;
            Flower f2 = new Flower();
            f2.Flowername = "lotus";
            f2.Flowerprize = Cost.lotus;
            f2.Floqty = 1;
            bo.Bouquetname = "Wedding bouquet";
            bo.Bouquetprize = Cost.Weddingbouquet;
            bo.Bouqty = 1;

            Billingdetail bd = new Billingdetail();
            bd.Cusdet = c;
            bd.Flower.Add(fl);
            bd.Flower.Add(f2);
            bd.Bouquet.Add(bo);
            Console.WriteLine(bd.ToString());
           

        }
    
     
    }
}
