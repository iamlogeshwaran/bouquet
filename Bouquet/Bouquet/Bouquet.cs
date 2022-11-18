using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet
{
     class Bouquet
    {
         Billingdetail b = new Billingdetail();
        string _bouquetname;

        public string Bouquetname
        {
            get { return _bouquetname; }
            set { _bouquetname = value; }
        }
        float _bouquetprize;

        public float Bouquetprize
        {
            get { return _bouquetprize; }
            set { _bouquetprize = value; }
        }
        public int _bouqty;

        public int Bouqty
        {
            get { return _bouqty; }
            set { _bouqty = value; }
        }
        public float Bcost()
        {
            return _bouqty*_bouquetprize;
        }
    public override string ToString()
        {
            return string.Format("{0} {1} \t  {2}\t {3}", this._bouquetname, this.Bouquetprize, this.Bouqty,Bcost());
        }
    
    }
}
