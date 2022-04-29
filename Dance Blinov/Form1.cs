using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dance_Blinov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "танццентрDataSet.Личные_данные". При необходимости она может быть перемещена или удалена.
            this.личные_данныеTableAdapter.Fill(this.танццентрDataSet.Личные_данные);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "танццентрDataSet.Список". При необходимости она может быть перемещена или удалена.
            this.списокTableAdapter.Fill(this.танццентрDataSet.Список);

        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            личные_данныеTableAdapter.Update(танццентрDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
