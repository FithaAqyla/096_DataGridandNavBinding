﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD_DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String user = "kila";
            String pwd = "123";

            if (username.Text == user && password.Text == pwd)
            {
                this.Hide();
                MessageBox.Show("Login Berhasil");
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Login Gagal!");
            }

        }
    }
}
