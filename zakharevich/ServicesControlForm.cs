using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace zakharevich
{
    public partial class ServicesControlForm : Form
    {
        AdminForm adminForm;
        public ServicesControlForm(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        private void saveChanges()
        {
            услугиBindingSource.EndEdit();
            услугиTableAdapter.Update(dbDataSet);
            dbDataSet.AcceptChanges();
            this.услугиTableAdapter.Fill(this.dbDataSet.Услуги);
        }

        private void ServicesControlForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.dbDataSet.Услуги);

        }

        private void ServicesControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                foreach (Binding b in c.DataBindings)
                {
                    b.WriteValue();
                }
            }
            this.saveChanges();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранную услугу?\nЭто действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    услугиBindingSource.RemoveAt(item.Index);
                }
                saveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbDataSet.Услуги.AddУслугиRow(textBox4.Text, Convert.ToInt32(numericUpDown1.Value));
            this.saveChanges();
        }
    }
}
