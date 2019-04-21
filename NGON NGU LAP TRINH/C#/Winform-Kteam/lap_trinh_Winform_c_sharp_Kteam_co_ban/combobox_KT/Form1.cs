using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace combobox_KT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addCBX();
            textBox1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "PriceF"));
            
        }
        List<Food> food;
        List<CBLClass> cl;
        void addCBX()
        {
            food = new List<Food>()
            {
                new Food(){nameF = "Mực một nắng sa tế", priceF=200000},
                new Food(){nameF = "Vú dê nướng sữa", priceF=75000},
                new Food(){nameF = "Ếch núp lùm", priceF=50000}
            };

            comboBox1.DataSource = food;
            comboBox1.DisplayMember = "nameF";

            cl = new List<CBLClass>();
            cl.Add( new CBLClass()
            {
                nameClass = "DA17TT",
                student= new List<string>{"Đổ Trọng Hảo", "Võ Lê Khánh Duy"}
            });
            cl.Add( new CBLClass()
            {
                nameClass = "DA17QTM",
                student= new List<string>{"Lê Hoàng Duy", "Nguyễn Khánh Duy"}
            });
            CBClass.DataSource = cl;
            CBClass.DisplayMember = "nameClass";
        }

        private void CBClass_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                CBLClass cl = cb.SelectedValue as CBLClass;
                CBStudent.DataSource = cl.student;
            }
        }

    }
    public class Food
    {
        public string nameF { get; set; }
        public float priceF { get; set; }
    }
    public class CBLClass
    {
        public string nameClass { get; set; }
        public List<string> student { get; set; }
    }
}
