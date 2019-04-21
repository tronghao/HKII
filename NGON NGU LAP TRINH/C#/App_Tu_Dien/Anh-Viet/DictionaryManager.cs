using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Anh_Viet
{
    public class DictionaryManager
    {
        public string path = "data.xml";
        private DictionaryItem items;
       

        public DictionaryItem Items
        {
            get { return items; }
            set { items = value; }
        }
        public DictionaryManager()
        {
           
            items = (DictionaryItem)DocXML(path);
        }
        public void loadtoCB(ComboBox cb)
        {
            cb.DataSource = items.Items;
            cb.DisplayMember = "Key";
        }
        public void them(TextBox a, TextBox b, TextBox c, ComboBox d)
        {
           DictionaryData dt = new DictionaryData();
                dt.Key = a.Text;
                dt.Meaning = b.Text;
                dt.Explaination = c.Text;
            items.Items.Add(dt);
            GhiXML(Items, path);
            items = (DictionaryItem)DocXML(path);
            loadtoCB(d);
        }
       
        public void ghi()
        {
            GhiXML(Items, path);
        }

        public void GhiXML(object data, string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));
            sr.Serialize(fs, data);
            fs.Close();
        }

        public object DocXML(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));
            object obj = sr.Deserialize(fs);

            fs.Close();

            return obj;
        }
    }
}
