using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tretie
{
    public partial class Form1 : Form
    {
        Clinic doctor = new Clinic("Клиника Доктора Бубновского", 5);
        public Form1()
        {
            InitializeComponent();
        }
        private void textCost_Click(object sender, EventArgs e)
        {
            textCost.Clear();
        }
        private void textDate_Click(object sender, EventArgs e)
        {
            textDate.Clear();
        }
        private void textPat_Click(object sender, EventArgs e)
        {
            textPat.Clear();
        }
        private void textServ_Click(object sender, EventArgs e)
        {
            textServ.Clear();
        }
        private void textCost_TextChanged(object sender, EventArgs e)
        {
            textCost.MaxLength = 7;
        }
        private void textCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null)
            {
                dataGridView2.Rows.Clear();
                Patient vspom = doctor.search(dataGridView1.CurrentCell.Value.ToString());
                if (vspom != null)
                {
                    List pTemp = vspom.GHeader;
                    int chet = doctor.search(dataGridView1.CurrentCell.Value.ToString()).Count;
                    for (int i = 0; i < chet; i++)
                    {
                        dataGridView2.Rows.Add(pTemp.data.Date, pTemp.data.Service, pTemp.data.Cost);
                        pTemp = pTemp.Next;
                    }
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = chet;
                }
            }
            else MessageBox.Show("Выбрана пустая строчка");
        }
        private void butAddPat_Click(object sender, EventArgs e)
        {
            doctor.addPatient(textPat.Text);
            dataGridView1.Rows.Add(textPat.Text);
        }
        private void butChaPat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null && textPat.Text != null)
            {
                doctor.search(dataGridView1.CurrentCell.Value.ToString()).Name = textPat.Text;
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value = textPat.Text;
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = doctor.search(textPat.Text).Count;
            }
            else MessageBox.Show("Выберите пациента, которого хотите изменить, или напишите новое имя для пациента.");
        }
        private void butDelPat_Click(object sender, EventArgs e)
        {
            doctor.delPatient();
            dataGridView1.Rows.RemoveAt(0);
            dataGridView2.Rows.Clear();
        }
        private void butAddVis_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null && textCost.Text != null && textDate.Text != null && textServ.Text != null)
            {
                doctor.search(dataGridView1.CurrentCell.Value.ToString()).addVisit(textDate.Text, textServ.Text, int.Parse(textCost.Text));
                dataGridView2.Rows.Add(textDate.Text, textServ.Text, textCost.Text);
            }
            else MessageBox.Show("Выберите пациента, или впишите недостающие параметры");
        }
        private void butChek_Click(object sender, EventArgs e)
        {
            MessageBox.Show(doctor.Info());
        }
        private void butChVis_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null && textCost.Text != null && textDate.Text != null && textServ.Text != null)
            {
                doctor.search(dataGridView1.CurrentCell.Value.ToString()).search(textDate.Text, textServ.Text).Date = textDate.Text;
                doctor.search(dataGridView1.CurrentCell.Value.ToString()).search(textDate.Text, textServ.Text).Service = textServ.Text;
                doctor.search(dataGridView1.CurrentCell.Value.ToString()).search(textDate.Text, textServ.Text).Cost = int.Parse(textCost.Text);
                dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value = textDate.Text;
                dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value = textServ.Text;
                dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value = textCost.Text;
            }
            else MessageBox.Show("Выберите пациента, или впишите недостающие параметры");
        }
        private void butDelVis_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null && dataGridView2.CurrentCell.Value != null)
            {
                doctor.search(dataGridView1.CurrentCell.Value.ToString()).delVisit(dataGridView2.CurrentCell.Value.ToString());
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
            else MessageBox.Show("Выберите пациента, или его посещения в клинику");
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            string path;
            string textInFile = "Клиника Доктора Бубновского\n";
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    path = saveFile.FileName;
                    textInFile += doctor.InfoSave();
                    using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
                    using (StreamWriter stream = new StreamWriter(file))
                    {
                        stream.Write(textInFile);
                        stream.Close();
                        file.Close();
                    }
                }
            }
        }
        private void butUpload_Click(object sender, EventArgs e)
        {
            string path = "", doIt = "";
            int Count, CusCount, _cost;
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    path = openFile.FileName;
                }
            }
            using (StreamReader stream3 = new StreamReader(path))
            {
                doIt = stream3.ReadLine();
                if (doIt == "Клиника Доктора Бубновского")
                {
                    for (int i = 0; i <= doctor.Count; i++)
                    {
                        doctor.delPatient();
                        dataGridView1.Rows.Clear();
                        dataGridView2.Rows.Clear();
                    }
                    Count = int.Parse(stream3.ReadLine());
                    for (int i = 1; i <= Count;)
                    {
                        string SurnamePat = stream3.ReadLine();
                        doctor.addPatient(SurnamePat);
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i - 1].Cells[0].Value = SurnamePat;
                        dataGridView1.Rows[i - 1].Cells[1].Value = doctor.search(SurnamePat).Count;
                        if (i != Count)
                            i++;
                        else
                            break;
                    }
                    stream3.ReadLine(); int hall = 0;
                    while (stream3.Peek() != -1)
                    {
                        CusCount = int.Parse(stream3.ReadLine());
                        if (CusCount != 0)
                            for (int i = 1; i <= CusCount;)
                            {
                                string _date = stream3.ReadLine();
                                string _service = stream3.ReadLine();
                                _cost = int.Parse(stream3.ReadLine());
                                string name = Convert.ToString(dataGridView1.Rows[hall].Cells[0].Value);
                                doctor.search(name).addVisit(_date,_service,_cost);
                                if (i != CusCount)
                                    i++;
                                else
                                    break;
                            }
                        hall++;
                    }
                }
                else { MessageBox.Show("Данный файл не подходит для работы с программой"); }
                stream3.Close();
            }
        }
    }
}
