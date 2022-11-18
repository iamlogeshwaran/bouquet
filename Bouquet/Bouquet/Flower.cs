using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet
{
    class Flower
    {
        Billingdetail b = new Billingdetail();
        string _flowername;
       
        public string Flowername
        {
            get { return _flowername; }
            set { _flowername = value; }
        }

        float _flowerprize;

        public float Flowerprize
        {
            get { return _flowerprize; }
            set { _flowerprize = value; }
        }
        public int _floqty;
       
       
        public int Floqty
        {
            get { return _floqty; }
            set { _floqty = value; }
        }
        public float  Fcost()
        {
            return _flowerprize * _floqty;
        }
        public override string ToString()
        {
            Billingdetail b =new Billingdetail();
            return string.Format("{0}  \t\t {1}\t  {2} \t {3}" ,this._flowername,this.Flowerprize,this.Floqty,Fcost()); 
        }
    }
}
