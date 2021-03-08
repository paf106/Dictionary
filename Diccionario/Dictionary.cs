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
        private String name;
        private Dictionary<String,String> words = new Dictionary<string, string>();

        public Dictionary(string name, Dictionary<string, string> words)
        {
            this.name = name;
            this.words = words;
        }


    }
}
