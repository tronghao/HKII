using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anh_Viet
{
    public class DictionaryData
    {
        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        private string meaning;

        public string Meaning
        {
            get { return meaning; }
            set { meaning = value; }
        }

        private string explaination;

        public string Explaination
        {
            get { return explaination; }
            set { explaination = value; }
        }
    }
}
