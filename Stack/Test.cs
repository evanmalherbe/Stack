using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    // Got this code from a forum
    public class Storage
    {
        private ArrayList _array = new ArrayList();

        public ArrayList List
        {
            get { return _array; }
        }
        public object this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
    }
}
