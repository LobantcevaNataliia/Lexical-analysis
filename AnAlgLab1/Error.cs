using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnAlgLab1
{
    class Error
    {
        public string masErr;
        public int rowErr;
        public int colErr;

        public Error(string masErr, int rowErr,int colErr)
        {
            this.masErr = masErr;
            this.rowErr = rowErr;
            this.colErr = colErr;
        }
    }
}
