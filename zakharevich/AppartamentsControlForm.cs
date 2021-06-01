using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace zakharevich
{
    public partial class AppartamentsControlForm : Form
    {
        AdminForm adminForm;
        public AppartamentsControlForm(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        private void saveChanges()
        {
            комнатыBindingSource.EndEdit();
            комнатыTableAdapter.Update(dbDataSet);
            dbDataSet.AcceptChanges();
            this.комнатыTableAdapter.Fill(this.dbDataSet.Комнаты);
        }

        private void AppartamentsControlForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Комнаты". При необходимости она может быть перемещена или удалена.
            this.комнатыTableAdapter.Fill(this.dbDataSet.Комнаты);

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

            if (MessageBox.Show("Ви дійсно хочете видалити обрану кімнату? \n Цю дія неможливо скасувати.", "Підтвердіть видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    комнатыBindingSource.RemoveAt(item.Index);
                }
                saveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbDataSet.Комнаты.AddКомнатыRow(comboBox2.Text, Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value), 0);
            this.saveChanges();

        }

        private void AppartamentsControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminForm.Show();
        }
    }
}
