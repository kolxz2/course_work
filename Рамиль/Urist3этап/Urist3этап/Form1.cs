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

namespace Urist3этап
{
    
    public partial class Form1 : Form
    {
        Firm voenik = new Firm("Призыва Нет!", 10);
        public Form1()
        {
            InitializeComponent();
        }
        private void textFamUrist_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textServiceClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textNameClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textClientCost_TextChanged(object sender, EventArgs e)
        {
            textClientCost.MaxLength = 6;
        }
        private void textClientCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void AddUrist_Click(object sender, EventArgs e)
        {
            if (textFamUrist.Text != "")
            {
                voenik.AddUrist(textFamUrist.Text);
                dataGridView1.Rows.Add(textFamUrist.Text);
            }
            else MessageBox.Show("Добавление не выполнено");
        }
        private void DeleteUrist_Click(object sender, EventArgs e)
        {
            if (voenik.Count > 0)
            {
                voenik.DellUrist();
                dataGridView1.Rows.RemoveAt(0);
                dataGridView2.Rows.Clear();
            }
            else MessageBox.Show("Удалять нечего");
        }
        private void ChangeUrist_Click(object sender, EventArgs e)
        {
            if (textFamUrist.Text != "" && dataGridView1.CurrentCell.Value != null)
            {
                string text = dataGridView1.CurrentCell.Value.ToString();
                voenik.SearchUrist(text).SurnameUrist = textFamUrist.Text;
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value = textFamUrist.Text;
            }
            else MessageBox.Show("Выберите нужный элемент");
        }
        private void AddClient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null )
            {
                if (textClientCost.Text != "" && textNameClient.Text != "" && textServiceClient.Text != "")
                {
                    string text = dataGridView1.CurrentCell.Value.ToString();
                    voenik.SearchUrist(text).AddClient(textNameClient.Text, textServiceClient.Text, int.Parse(textClientCost.Text));
                    dataGridView2.Rows.Add(textNameClient.Text, textServiceClient.Text, textClientCost.Text);
                }
            }
            else MessageBox.Show("Добавление не выполнено");
        }
        private void DeleteClient_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            string text2= dataGridView2.CurrentCell.Value.ToString();
            if (text != "" && text2 != "")
            {
                int index = dataGridView2.CurrentRow.Index;
                voenik.SearchUrist(text).DellClient(text2);
                dataGridView2.Rows.RemoveAt(index);
            }
            else MessageBox.Show("Удаление не выполнено");
        }
        private void ChangeClient_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            string text2 = dataGridView2.CurrentCell.Value.ToString();
            if (text != "" && text2 != "" && textClientCost.Text != "" && textNameClient.Text != "" && textServiceClient.Text != "")
            { 
                voenik.SearchUrist(text).SearchCl(text2).Surname = textNameClient.Text;
                voenik.SearchUrist(text).SearchCl(textNameClient.Text).Service = textServiceClient.Text;
                voenik.SearchUrist(text).SearchCl(textNameClient.Text).Cost = Convert.ToInt32(textClientCost.Text);
            }
            else MessageBox.Show("Изменение не выполнено");
        }
        private void Form1_Load(object sender, EventArgs e){}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null)
            {
                dataGridView2.Rows.Clear();
                Urist vspom = voenik.SearchUrist(dataGridView1.CurrentCell.Value.ToString());
                if (vspom != null)
                {
                    List pTemp = vspom.Head;
                    int chet = voenik.SearchUrist(dataGridView1.CurrentCell.Value.ToString()).Count;
                    for (int i = 0; i < chet; i++)
                    {
                        dataGridView2.Rows.Add(pTemp.cClient.Surname, pTemp.cClient.Service, pTemp.cClient.Cost);
                        pTemp = pTemp.Second;
                    }
                }
            }
            else MessageBox.Show("Выбрана пустая строчка");
        }
        private void SaVeinFile_Click(object sender, EventArgs e)
        {
            string path;
            string fileText = "Призыва нет!\n";
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    path = saveFile.FileName;
                    fileText += voenik.GetInfoForSave();
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
        private void LoaDinFile_Click(object sender, EventArgs e)
        {
            string path = "", doIt = "";
            int Count, CusCount;
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
                if (doIt == "Призыва нет!")
                {
                    for (int i = 0; i <= voenik.Count; i++)
                    {
                        voenik.DellUrist();
                        dataGridView1.Rows.Clear();
                        dataGridView2.Rows.Clear();
                    }
                    Count = int.Parse(stream3.ReadLine());
                    for (int i = 1; i <= Count;)
                    {
                        string Surname = stream3.ReadLine();
                        voenik.AddUrist(Surname);
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i - 1].Cells[0].Value = Surname;
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
                                string surname = stream3.ReadLine();
                                string service = stream3.ReadLine();
                                int cost = int.Parse(stream3.ReadLine());
                                string name = Convert.ToString(dataGridView1.Rows[hall].Cells[0].Value);
                                voenik.SearchUrist(name).AddClient(surname, service, cost);
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
