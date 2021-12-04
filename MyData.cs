using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement
{
    public class MyData
    {
        public string myString = "";
        public int myTag = 0;

        public MyData(string myString, int myTag = 0)
        {
            this.myString = myString;
            this.myTag = myTag;
        }
        public override string ToString()
        {
            return myString.ToString();
        }
    }
}
