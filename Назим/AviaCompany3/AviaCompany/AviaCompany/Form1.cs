using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviaCompany
{
    public partial class Form1 : Form
    {
        Company company = new Company("American Airlines", 11);
        public Form1()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Clear();
            string text = dataGridView1.CurrentCell.Value.ToString();
            Passenger vspom = company.Search(text);
            if (vspom != null)
            {
                List pTemp = vspom.getListGol;
                int chet = company.Search(text).Count;
                for (int i = 0; i < chet; i++)
                {
                    if (pTemp != null)
                    {
                        dataGridView2.Rows.Add(pTemp.info.Date, pTemp.info.Cost);
                        pTemp = pTemp.Second;
                    }
                }
            }
        }
        private void butAddSur_Click(object sender, EventArgs e)
        {
            if (textSurname.Text != null)
            {
                company.AddPas(textSurname.Text);
                dataGridView1.Rows.Add(textSurname.Text);
            }
        }
        private void butChSurn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null && textSurname.Text != null)
            {
                company.Search(dataGridView1.CurrentCell.Value.ToString()).Surname = textSurname.Text;
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value = textSurname.Text;
            }
        }
        private void butDelSur_Click(object sender, EventArgs e)
        {
            company.DelPas();
            dataGridView1.Rows.RemoveAt(0);
        }
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void butAddPol_Click(object sender, EventArgs e)
        {
            company.Search(dataGridView1.CurrentCell.Value.ToString()).AddPolet(monthCalendar.SelectionRange.Start, Convert.ToInt32(textCost.Text));
            DateTime date = monthCalendar.SelectionRange.Start;
            //dataGridView2.Rows.Add(date.ToShortDateString(), textCost.Text);

            int year = Convert.ToInt32(monthCalendar.SelectionStart.Year.ToString());
            int mounth = Convert.ToInt32(monthCalendar.SelectionStart.Month.ToString());
            int day = Convert.ToInt32(monthCalendar.SelectionStart.Day.ToString());
            
            DateTime dateTime1 = new DateTime(year, mounth, day, 0, 0, 0);

            int i = company.Search(dataGridView1.CurrentCell.Value.ToString()).getIndex(date);
                if (i >= 0)
                {
                    if (dataGridView2.Rows[i].Cells[0].Value == null)
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[i].Cells[0].Value = dateTime1;
                        dataGridView2.Rows[i].Cells[1].Value = textCost.Text;
                    }
                    else
                    {
                        dataGridView2.Rows.Add();
                        for (int j = company.Search(dataGridView1.CurrentCell.Value.ToString()).Count; j > i;)
                        {
                            dataGridView2.Rows[j].Cells[0].Value = dataGridView2.Rows[j - 1].Cells[0].Value;
                            dataGridView2.Rows[j].Cells[1].Value = dataGridView2.Rows[j - 1].Cells[1].Value;
                            dataGridView2.Rows[j - 1].Cells[0].Value = null;
                            dataGridView2.Rows[j - 1].Cells[1].Value = null;
                            j--;
                        }
                        dataGridView2.Rows[i].Cells[0].Value = dateTime1;
                        dataGridView2.Rows[i].Cells[1].Value = textCost.Text;
                    }
                }
                else if (i == -1)
                {
                    MessageBox.Show("В данном промежутке времени идет занятие.");
                }
                else
                    MessageBox.Show("Ошибка времени");
        }
        private void butInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(company.GetInfoCom());
        }
        private void butChPol_Click(object sender, EventArgs e)
        {
            company.Search(dataGridView1.CurrentCell.Value.ToString()).Search(monthCalendar.SelectionRange.Start).Cost = Convert.ToInt32(textCost.Text);
            company.Search(dataGridView1.CurrentCell.Value.ToString()).Search(monthCalendar.SelectionRange.Start).Date = monthCalendar.SelectionRange.Start;
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value = monthCalendar.SelectionRange.Start.ToShortDateString();
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value = textCost.Text;
        }
        private void butDelPol_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[0].Value);
            company.Search(dataGridView1.CurrentCell.Value.ToString()).DelPolet(date);
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            string path;
            string fileText = "11 Сентября.Помним.\n";
            //Создание экземпляра диалогового окна (Для того чтобы не занимать поток) + фильтр на создание текстовых файлов
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path = saveFile.FileName;
                    fileText = fileText + company.GetInfoCompany();
                    //Та же работа с экземплярами файла и записи файла
                    using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
                    using (StreamWriter stream = new StreamWriter(file))
                    {
                        stream.Write(fileText);
                        stream.Close();
                        file.Close();
                    }
                }
            }
        }
        private void butUpload_Click(object sender, EventArgs e)
        {
            DateTime dateTime;
            string path = "", doIt = "";
            int SCount,PCount, year, mouth, day, cost;
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
                //Проверка на пригодность файла для работы с программой
                if (doIt == "11 Сентября.Помним.")
                {
                    for (int i = 0; i <= company.Count;)
                    {
                        company.DelPas();
                        i++;
                    }
                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();
                    SCount = int.Parse(stream3.ReadLine());
                    for (int i = 1; i <= SCount;)
                    {
                        string surname = stream3.ReadLine();
                        company.AddPas(surname);
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i - 1].Cells[0].Value = surname;
                        if (i != SCount)
                            i++;
                        else
                            break;
                    }
                    stream3.ReadLine();
                    int hall = 0;
                    while (stream3.Peek() != -1)
                    {
                        PCount = int.Parse(stream3.ReadLine());
                        if (PCount != 0)
                            for (int i = 1; i <= PCount;)
                            {
                                year = int.Parse(stream3.ReadLine());
                                mouth = int.Parse(stream3.ReadLine());
                                day = int.Parse(stream3.ReadLine());
                                cost = int.Parse(stream3.ReadLine());
                                string name = Convert.ToString(dataGridView1.Rows[hall].Cells[0].Value);
                                dateTime = new DateTime(year, mouth, day, 0, 0, 0);
                                company.Search(name).AddPolet(dateTime, cost);
                                if (i != PCount)
                                    i++;
                                else
                                    break;
                            }
                        hall++;
                    }
                }
                else
                {
                    MessageBox.Show("Данный файл не подходит для работы с программой");
                }
                stream3.Close();
            }
        }
        private void textSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            textCost.MaxLength = 8;
        }
    }
}
