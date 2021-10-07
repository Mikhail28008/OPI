using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadriDataSet1.Doljn". При необходимости она может быть перемещена или удалена.
            this.doljnTableAdapter.Fill(this.kadriDataSet1.Doljn);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadriDataSet1.Sotrud". При необходимости она может быть перемещена или удалена.
            this.sotrudTableAdapter1.Fill(this.kadriDataSet1.Sotrud);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kadriDataSet.Sotrud". При необходимости она может быть перемещена или удалена.
            this.sotrudTableAdapter.Fill(this.kadriDataSet.Sotrud);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            KadriDataSet1.SotrudRow row =
            kadriDataSet1.Sotrud.NewSotrudRow();
            row.Работник = textBox7.Text;
            row.Специальность = textBox2.Text;
            row.Дата_поступления_на_работу = Convert.ToDateTime(textBox1.Text);
            row.Должность = textBox4.Text;
            row.Отдел = textBox3.Text;
            kadriDataSet1.Sotrud.Rows.Add(row);
            sotrudTableAdapter1.Update(kadriDataSet1.Sotrud);
            kadriDataSet1.Sotrud.AcceptChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sotrudBindingSource1.Filter = "[Работник] LIKE '" + textBox6.Text + "%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sotrudTableAdapter1.Update(kadriDataSet1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            doljnBindingSource.Filter = "[Работник] LIKE '" + textBox14.Text + "%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doljnTableAdapter.Update(kadriDataSet1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KadriDataSet1.SotrudRow row =
            kadriDataSet1.Sotrud.NewSotrudRow();
            row.Работник = textBox13.Text;
            row.Должность = textBox10.Text;
            row.Отдел = textBox9.Text;
            kadriDataSet1.Sotrud.Rows.Add(row);
            sotrudTableAdapter1.Update(kadriDataSet1.Sotrud);
            kadriDataSet1.Sotrud.AcceptChanges();
        }
    }
}
