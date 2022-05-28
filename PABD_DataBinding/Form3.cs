using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            dataGridView1.Columns[0].HeaderText = "No Mahasiswa";
            dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
            dataGridView1.Columns[2].HeaderText = "Alamat Mahasiswa";
            dataGridView1.Columns[3].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[4].HeaderText = "No Telepon";


            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Pink;
            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightPink;

            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Purple;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Lavender;

            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.SkyBlue;
            dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.LightGreen;


            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Red;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this.Hide();

            Form5 F5 = new Form5();

            F5.label8.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            F5.label9.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            F5.label10.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            F5.label11.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            F5.label12.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            F5.Show();


        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
    