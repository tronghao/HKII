using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace caro
{
    public class player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Image mark;

        public Image Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public player(string name, Image mark)
        {
            this.Name = name;
            this.Mark = mark;
        }
    }
}
