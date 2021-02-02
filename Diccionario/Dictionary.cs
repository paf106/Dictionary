using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class Dictionary
    {
        private string name;
        private ArrayList words = new ArrayList();
        public Dictionary(string name,ArrayList words)
        {
            this.name = name;
            this.words = words;
        }
    }
}
