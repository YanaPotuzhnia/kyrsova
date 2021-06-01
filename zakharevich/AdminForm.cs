using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace zakharevich
{
    public partial class AdminForm : Form
    {
        AuthForm authForm; // форма-родитель
        public AdminForm(AuthForm authForm) // конструктор формы
        {
            InitializeComponent();
            this.authForm = authForm;
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            authForm.Close(); //при закрытии выйти из программы полностью
        }

        private void управлениеУслугамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicesControlForm servicesControlForm = new ServicesControlForm(this);
            servicesControlForm.Show();
            this.Hide();
        }

        private void управлениеНомерамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppartamentsControlForm appartamentsControlForm = new AppartamentsControlForm(this);
            appartamentsControlForm.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        List<int> appsIDs = new List<int>();
        List<int> servIDs = new List<int>();
        List<string[]> services = new List<string[]>();

        private void AdminForm_Activated(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void refreshAll()
        {
            this.комнатыTableAdapter.Fill(this.dbDataSet.Комнаты);
            this.выбранные_услугиTableAdapter.Fill(this.dbDataSet.Выбранные_услуги);
            this.клиентыTableAdapter.Fill(this.dbDataSet.Клиенты);

            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.dbConnectionString);
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Код_услуги, Название, Стоимость FROM Услуги";
            OleDbDataReader cmdResult = cmd.ExecuteReader();

            comboBox3.Items.Clear();
            servIDs.Clear();
            while (cmdResult.Read())
            {
                servIDs.Add(int.Parse(cmdResult["Код_услуги"].ToString()));
                comboBox3.Items.Add(cmdResult["Название"].ToString() + ", " + cmdResult["Стоимость"].ToString()+" грн ");
            }
            cmdResult.Close();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd.CommandText = "SELECT Код_услуги FROM Выбранные_услуги WHERE Код_клиента = " + dataGridView1.Rows[i].Cells[0].Value.ToString();
                cmdResult = cmd.ExecuteReader();
                while (cmdResult.Read())
                {
                    OleDbCommand cmd2 = conn.CreateCommand();
                    cmd2.CommandText = "SELECT Стоимость FROM Услуги WHERE Код_услуги = " + cmdResult["Код_услуги"];
                    int cmdResult2 = int.Parse(cmd2.ExecuteScalar().ToString());
                    int cureInt = 0;
                    if (dataGridView1.Rows[i].Cells[7].Value != null)
                    {
                        cureInt = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value.ToString());
                    }
                    dataGridView1.Rows[i].Cells[7].Value = (cureInt + cmdResult2 * ((Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value.ToString()) - Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString())).Days + 1)).ToString();
                }
                cmdResult.Close();
            }

            cmd.CommandText = "SELECT Код_услуги, Название, Стоимость FROM Услуги";
            cmdResult = cmd.ExecuteReader();
            while (cmdResult.Read())
            {
                services.Add(new string[3] { cmdResult["Код_услуги"].ToString(), cmdResult["Название"].ToString(), cmdResult["Стоимость"].ToString() });
            }
            cmdResult.Close();

            cmd.CommandText = "SELECT Код_комнаты, Номер_комнаты, Стоимость_за_место FROM Комнаты";
            cmdResult = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            searchClientAppartament.Items.Clear();
            appsIDs.Clear();
            while (cmdResult.Read())
            {
                appsIDs.Add(int.Parse(cmdResult["Код_комнаты"].ToString()));
                comboBox1.Items.Add("Комната " + cmdResult["Номер_комнаты"].ToString() + ", " + cmdResult["Стоимость_за_место"].ToString() + " грн. за добу");
                comboBox2.Items.Add("Комната " + cmdResult["Номер_комнаты"].ToString() + ", " + cmdResult["Стоимость_за_место"].ToString() + " грн. за добу");
                searchClientAppartament.Items.Add(cmdResult["Номер_комнаты"].ToString());
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value.ToString() == cmdResult["Код_комнаты"].ToString())
                    {
                        dataGridView1.Rows[i].Cells[6].Value = cmdResult["Номер_комнаты"].ToString();
                        int cureInt = 0;
                        if (dataGridView1.Rows[i].Cells[7].Value != null)
                        {
                           cureInt = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value.ToString());
                        }
                        dataGridView1.Rows[i].Cells[7].Value = (cureInt + (int.Parse(cmdResult["Стоимость_за_место"].ToString()) * ((Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value.ToString()) - Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString())).Days+1))).ToString();
                    }
                }
            }
            cmdResult.Close();
            conn.Close();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int j = 0;
                foreach (int app in appsIDs)
                {
                    if (app.ToString() == dataGridView1.SelectedRows[0].Cells[3].Value.ToString())
                    {
                        comboBox1.SelectedIndex = j;
                    }
                    j++;
                }
                foreach (string[] service in services)
                {
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[2].Value.ToString() == service[0])
                        {
                            dataGridView2.Rows[i].Cells[3].Value = service[1];
                            dataGridView2.Rows[i].Cells[4].Value = service[2];
                        }
                    }
                }
            }
        }

        private void saveClientChanges()
        {
            клиентыBindingSource.EndEdit();
            клиентыTableAdapter.Update(dbDataSet);
            dbDataSet.AcceptChanges();
            refreshAll();
        }

        private void saveServicesChanges()
        {
            клиентыВыбранныеуслугиBindingSource.EndEdit();
            выбранные_услугиTableAdapter.Update(dbDataSet);
            dbDataSet.AcceptChanges();
            refreshAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbDataSet.КомнатыRow room = dbDataSet.Комнаты.NewКомнатыRow();
            room.Код_комнаты = appsIDs[comboBox2.SelectedIndex];
            dbDataSet.Клиенты.AddКлиентыRow(textBox4.Text, textBox3.Text, room, dateTimePicker4.Value.Date, dateTimePicker3.Value.Date);
            this.saveClientChanges();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int j = 0;
                foreach (int app in appsIDs)
                {
                    if (app.ToString() == dataGridView1.SelectedRows[0].Cells[3].Value.ToString())
                    {
                        comboBox1.SelectedIndex = j;
                    }
                    j++;
                }


                foreach (string[] service in services)
                {
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[2].Value.ToString() == service[0])
                        {
                            dataGridView2.Rows[i].Cells[3].Value = service[1];
                            dataGridView2.Rows[i].Cells[4].Value = service[2];
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbDataSet.КлиентыRow client = dbDataSet.Клиенты.NewКлиентыRow();
            client.Код_клиента = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            dbDataSet.УслугиRow service = dbDataSet.Услуги.NewУслугиRow();
            service.Код_услуги = servIDs[comboBox3.SelectedIndex];
            dbDataSet.Выбранные_услуги.AddВыбранные_услугиRow(client, service);
            this.saveServicesChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Cells[3].Value = appsIDs[comboBox1.SelectedIndex];
            }
            foreach (Control c in panel1.Controls)
            {
                foreach (Binding b in c.DataBindings)
                {
                    b.WriteValue();
                }
            }
            this.saveClientChanges();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обраного клієнта? \n Цю дію неможливо скасувати.", "Підтвердіть видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    клиентыBindingSource.RemoveAt(item.Index);
                }
                this.saveClientChanges();
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити вибрану послугу?\nЦю дію неможливо скасувати", "Підтвердіть видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView2.SelectedRows)
                {
                    клиентыВыбранныеуслугиBindingSource.RemoveAt(item.Index);
                }
                this.saveServicesChanges();
            }
        }

        private void показатьСвободныеКомнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowCollection rows = dbDataSet.Tables["Комнаты"].Rows;
            string output = "";
            int counter = 0;
            foreach (DataRow row in rows)
            {
                var clientInf = dbDataSet.Tables["Клиенты"].Select("Код_комнаты = " + row[0].ToString());
                if (clientInf.Length == 0)
                {
                    counter++;
                    output += "\n\n" + counter.ToString() + ". Номер кімнати: " + row[3].ToString() + ". Тип: \"" + row[1].ToString() + "\". Вартість: " + row[2].ToString();
                }
            }
            MessageBox.Show("Список вільних кімнат (" + counter.ToString() + " кімнат):" + output, "Список вільних кімнат");
        }

        private void показатьВсеКомнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataRowCollection rows = dbDataSet.Tables["Комнаты"].Rows;
            string output = "";
            int counter = 0;
            foreach (DataRow row in rows)
            {
                counter++;
                var clientInf = dbDataSet.Tables["Клиенты"].Select("Код_комнаты = " + row[0].ToString());
                if (clientInf.Length > 0)
                {
                    output += "\n\n" + counter.ToString() + ". Номер кімнати: " + row[3].ToString() + ". Тип: \"" + row[1].ToString() + "\". Вартість: " + row[2].ToString() + ". Проживающих: " + clientInf.Length.ToString();
                }
                else
                {
                    output += "\n\n" + counter.ToString() + ". Номер кімнати: " + row[3].ToString() + ". Тип: \"" + row[1].ToString() + "\". Вартість: " + row[2].ToString();
                }
            }
            MessageBox.Show("Список кімнат(" + counter.ToString() + " кімнати):" + output, "Список кімнати");
        }

        private void показатьПоискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            показатьПоискToolStripMenuItem.Checked = !показатьПоискToolStripMenuItem.Checked;
            panel5.Visible = показатьПоискToolStripMenuItem.Checked;
            if (показатьПоискToolStripMenuItem.Checked)
            {
                this.Height = 734;
            }
            else
            {
                this.Height = 625;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchClient_Click(object sender, EventArgs e)
        {
            refreshAll();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (searchByName.Checked && dataGridView1.Rows[i].Cells[1].Value.ToString().IndexOf(searchClientName.Text) < 0)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
                if (searchByArrivalDate.Checked)
                {
                    if (searchFClientArrivalDate.Items[searchFClientArrivalDate.SelectedIndex].ToString() == "=")
                    {
                        if (Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString()) != searchClientArrivalDate.Value)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                        }
                    }
                    if (searchFClientArrivalDate.Items[searchFClientArrivalDate.SelectedIndex].ToString() == ">")
                    {
                        if (Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString()) <= searchClientArrivalDate.Value)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                        }
                    }
                    if (searchFClientArrivalDate.Items[searchFClientArrivalDate.SelectedIndex].ToString() == "<")
                    {
                        if (Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString()) >= searchClientArrivalDate.Value)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                        }
                    }
                    if (searchFClientArrivalDate.Items[searchFClientArrivalDate.SelectedIndex].ToString() == "<=")
                    {
                        if (Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString()) > searchClientArrivalDate.Value)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                        }
                    }
                    if (searchFClientArrivalDate.Items[searchFClientArrivalDate.SelectedIndex].ToString() == ">=")
                    {
                        if (Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString()) < searchClientArrivalDate.Value)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                        }
                    }
                }
                if (searchByRoom.Checked && dataGridView1.Rows[i].Cells[6].Value.ToString() != searchClientAppartament.Text)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void изменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassForm changePassForm = new ChangePassForm(this);
            changePassForm.Show();
            this.Hide();
        }
    }
}
