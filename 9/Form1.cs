﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = Convert.ToString(textBox1.Text);
            label1.Text = "первое " + t.IndexOf(",") + "\n" + "последнее " + t.LastIndexOf(",");
            /*9.Дана строка, содержащая, по крайней мере, две запятые. 
             * Написать номер первого и последнего вхождения запятой в эту строку.*/
        }

      
    }
}
