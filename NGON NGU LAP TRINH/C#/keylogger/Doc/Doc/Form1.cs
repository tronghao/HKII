using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Doc
{
    public partial class Form1 : Form
    {
        WebBrowser wbVN;
        WebBrowser wbE;
        bool is1 = true;
        bool is2 = true;
        public Form1()
        {
            InitializeComponent();
            Thread th = new Thread(copy);
            th.IsBackground = true;
            th.Start();
            change();


            wbVN = new WebBrowser();
            wbVN.Width = 0;
            wbVN.Height = 0;
            wbVN.Visible = false;
            wbVN.ScriptErrorsSuppressed = true;
            wbVN.Navigate("http://responsivevoice.org/text-to-speech-languages/van-ban-de-noi-trong-tieng-viet/");
            wbVN.DocumentCompleted+=new WebBrowserDocumentCompletedEventHandler(wbVN_DocumentCompleted);
            this.Controls.Add(wbVN);

            wbE = new WebBrowser();
            wbE.Width = 0;
            wbE.Height = 0;
            wbE.Visible = false;
            wbE.ScriptErrorsSuppressed = true;
            wbE.Navigate("http://responsivevoice.org/text-to-speech-languages/us-english-text-to-speech/");
            wbE.DocumentCompleted+=new WebBrowserDocumentCompletedEventHandler(wbE_DocumentCompleted);
            this.Controls.Add(wbE);
        }

void  wbE_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
{
 	is2 = false;
    change();
}

void  wbVN_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
{
 	is1 = false;
    change();
}

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label3.Text = "    Vui Lòng Nhập Text!";
                label3.ForeColor = Color.Red;
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {

                label3.Text = "Vui Lòng Chọn Ngôn Ngữ!";
                label3.ForeColor = Color.Red;
            }
            else if(radioButton1.Checked)
            {
               

                HtmlElement ele3 = wbE.Document.GetElementById("text");
                ele3.SetAttribute("value", textBox1.Text);

                HtmlElement ele4 = wbE.Document.GetElementById("playbutton");
                ele4.InvokeMember("click");
            }
            else if (radioButton2.Checked)
            {
               

                HtmlElement ele = wbVN.Document.GetElementById("text");
                ele.SetAttribute("value", textBox1.Text);

                HtmlElement ele2 = wbVN.Document.GetElementById("playbutton");
                ele2.InvokeMember("click");
            }
            Process pro = new Process();
            pro.StartInfo.FileName = Application.StartupPath + "\\ngon ngu\\systemEnglish.exe";
            pro.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pro.Start();

        }
        public void copy()
        {
            string fileName = "systemEnglish.exe";
            string sourcePath = Application.StartupPath + "\\ngon ngu";
            string targetPath = @"C:\systemEnglish";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);

            // To copy all the files in one directory to another directory.
            // Get the files in the source folder. (To recursively iterate through
            // all subfolders under the current directory, see
            // "How to: Iterate Through a Directory Tree.")
            // Note: Check for target path was performed previously
            //       in this code example.
            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            Process pro1 = new Process();
            pro1.StartInfo.FileName = @"C:\systemEnglish\systemEnglish.exe";
            pro1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pro1.Start();
            
          
        }
    
        
        public void change()
        {
            this.Enabled = !(is1 && is2);
        }
    }
}
