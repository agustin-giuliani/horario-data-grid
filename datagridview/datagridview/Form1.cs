using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(dataGridView1);
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].HeaderCell.Value = "lunes";
            dataGridView1.Columns[1].HeaderCell.Value = "martes";
            dataGridView1.Columns[2].HeaderCell.Value = "miercoles";
            dataGridView1.Columns[3].HeaderCell.Value = "jueves";

            dataGridView1.RowCount = 8;

            dataGridView1.Rows[0].HeaderCell.Value = "8:30-09:10";
            dataGridView1.Rows[1].HeaderCell.Value = "09:10-09:50";
            dataGridView1.Rows[2].HeaderCell.Value = "10:00-10:40";
            dataGridView1.Rows[3].HeaderCell.Value = "10:40-11:20";
            dataGridView1.Rows[4].HeaderCell.Value = "11:30-12:10";
            dataGridView1.Rows[5].HeaderCell.Value = "12:10-12:50";
            dataGridView1.Rows[6].HeaderCell.Value = "13:00-13:40";
            dataGridView1.Rows[7].HeaderCell.Value = "13:40-14:20";




        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            dataGridView1.CurrentRow.Cells[0].Value=textBox1.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
