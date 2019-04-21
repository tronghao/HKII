using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anh_Viet
{
    class speakText
    {
        private WebBrowser wbE;

        public WebBrowser WbE
        {
            get { return wbE; }
            set { wbE = value; }
        }
        public void Add(WebBrowser wb)
        {
            this.WbE = wb;
        }
        public void setText(string Text)
        {
            HtmlElement element = wbE.Document.GetElementById("text");
            element.SetAttribute("value", Text);
        }
        public void setplay()
        {
            HtmlElement element = wbE.Document.GetElementById("playbutton");
            element.InvokeMember("click");
        }
        public void speak(string text)
        {
            setText(text);
            setplay();
        }
    }
}
