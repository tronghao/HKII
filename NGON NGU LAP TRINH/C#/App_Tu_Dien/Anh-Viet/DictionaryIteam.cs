using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anh_Viet
{
    [Serializable]
    public class DictionaryItem
    {
        
        private List<DictionaryData> items;

        public List<DictionaryData> Items
        {
            get { return items; }
            set { items = value; }
        }
    }
}
