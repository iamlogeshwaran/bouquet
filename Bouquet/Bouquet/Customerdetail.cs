using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet
{
     class Customerdetail
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _mobilenumber;

        public string Mobilenumber
        {
            get { return _mobilenumber; }
            set
            {
                if (value.Length > 10)
                {
                    throw new Exception("Invalid Length Mobile number");
                }
                else
                {

                    _mobilenumber = value;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Customer Name: {0}\t \t \t \tMobile number: {1}" ,this.Name,this.Mobilenumber);
        }
    }
}
