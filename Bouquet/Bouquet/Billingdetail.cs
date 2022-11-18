using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet
{
    class Billingdetail
    {
        Customerdetail _cusdet;
        public Customerdetail Cusdet
        {
            get { return _cusdet; }
            set { _cusdet = value; }
        } 

        List<Flower> _flower = new List<Flower>();
        public List<Flower> Flower
        {
            get { return _flower; }
            set { _flower = value; }
        }
        List<Bouquet> bouquet = new List<Bouquet>();
        public List<Bouquet> Bouquet
        {
            get { return bouquet; }
            set { bouquet = value; }
        }
        public float Total
   {
            get
            {
                float temp = 0;
                float total = 0;
                foreach (Flower f in _flower)
                {
                    temp = f.Flowerprize * f.Floqty;
                    total = total + temp;
                    
                }
                foreach (Bouquet b in bouquet)
                {
                    temp = b.Bouquetprize * b.Bouqty;
                    total = total + temp;
                }
                return total;
            }
   
   }
      
    

        public override string ToString()
        {
            string x = "";
            x += "Bill: \n" + this.Cusdet + "\n\n";
            x += "Product \tRate \t Qty \tAmount\n";
            foreach (Flower f in _flower)
            {
                x += f+"\n";
            }
            foreach (Bouquet b in bouquet)
            {
                x += b+ "\n";
            }
            x += "      \t\t\t Total: " + this.Total;
            return x;
        }
    }
}
