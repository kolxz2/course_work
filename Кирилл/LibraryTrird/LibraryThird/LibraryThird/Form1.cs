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

namespace LibraryThird
{
    public partial class Form1 : Form
    {
        Library libs = new Library("NKC", 10);
        public Form1()
        {
            InitializeComponent();
            
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            textBox4.MaxLength = 8;
        }
        private void BookAdd_Click(object sender, EventArgs e)
        {
            libs.addBook(textBoxBook.Text,textBoxAuthor.Text);
            dataGridView1.Rows.Add(textBoxBook.Text, textBoxAuthor.Text);
            textBoxBook.Clear();
            textBoxAuthor.Clear();
        }
        private void BookShange_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            int index = dataGridView1.CurrentRow.Index;
            libs.searchBook(text).Author = textBoxAuthor.Text;
            libs.searchBook(text).Title = textBoxBook.Text;
            dataGridView1.Rows[index].Cells[0].Value = textBoxBook.Text;
            dataGridView1.Rows[index].Cells[1].Value = textBoxAuthor.Text;
        }
        private void BookDelete_Click(object sender, EventArgs e)
        {
            if (libs.Count != 0)
            {
                int count = libs.Count;
                dataGridView1.Rows.RemoveAt(count-1);
                libs.delBook();
                dataGridView2.Rows.Clear();
            }
            else { MessageBox.Show("Нечего удалять."); }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Clear();
            string text = dataGridView1.CurrentCell.Value.ToString();
            Book vspom = libs.searchBook(text);
            if (vspom != null)
            {
                List copy1 = vspom.PFirst;
                int chet = libs.searchBook(text).Count;
                for (int i = 0; i < chet; i++)
                {
                    dataGridView2.Rows.Add(copy1._surname.Surname, copy1._surname.Days);
                    copy1 = copy1.getNext();
                }
            }
        }
        private void SurAdd_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            int i = libs.searchBook(text).addReader(textBox3.Text, Convert.ToInt32(textBox4.Text));
            if (i >= 0)
            {
                dataGridView2.Rows.Add();

                if (dataGridView2.Rows[i].Cells[0].Value == null)
                {
                    dataGridView2.Rows[i].Cells[0].Value = textBox3.Text;
                    dataGridView2.Rows[i].Cells[1].Value = textBox4.Text;
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else
                {
                    for (int j = libs.searchBook(text).Count; j > i; j--)
                    {
                        dataGridView2.Rows[j].Cells[0].Value = dataGridView2.Rows[j - 1].Cells[0].Value;
                        dataGridView2.Rows[j].Cells[1].Value = dataGridView2.Rows[j - 1].Cells[1].Value;
                        dataGridView2.Rows[j - 1].Cells[0].Value = null;
                        dataGridView2.Rows[j - 1].Cells[1].Value = null;
                    }
                    dataGridView2.Rows[i].Cells[0].Value = textBox3.Text;
                    dataGridView2.Rows[i].Cells[1].Value = textBox4.Text;
                }
                dataGridView2.Rows.Clear();
                string text1 = dataGridView1.CurrentCell.Value.ToString();
                Book vspom = libs.searchBook(text1);
                if (vspom != null)
                {
                    List copy1 = vspom.PFirst;
                    int chet = libs.searchBook(text1).Count;
                    for (int t = 0; t < chet; t++)
                    {
                        dataGridView2.Rows.Add(copy1._surname.Surname, copy1._surname.Days);
                        copy1 = copy1.getNext();
                    }
                }
            }
            else MessageBox.Show("Добавить не получилось");
        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(libs.getInfoLib());
        }
        private void SurDelete_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            string text2 = dataGridView2.CurrentCell.Value.ToString();
            int i = libs.searchBook(text).FindReaderIndex(text2) - 1;
            libs.searchBook(text).delReader(text2);
            dataGridView2.Rows.RemoveAt(i);
        }
        private void SurChange_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            int index = dataGridView2.CurrentRow.Index;
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                libs.searchBook(text).FindReader(dataGridView2.CurrentCell.Value.ToString()).Surname = textBox3.Text;
                libs.searchBook(text).FindReader(textBox3.Text).Days = Convert.ToInt32(textBox4.Text);
                dataGridView2.Rows[index].Cells[0].Value = textBox3.Text;
                dataGridView2.Rows[index].Cells[1].Value = textBox4.Text;
            }
            else { MessageBox.Show("Введите оба параметра для изменения"); }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           string path;
            string fileText = "Файл\n";
            //Создание экземпляра диалогового окна (Для того чтобы не занимать поток) + фильтр на создание текстовых файлов
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    path = saveFile.FileName;
                    fileText += libs.getName() + "\n";
                    //for (int i = 0; i < libs.Count; i++)
                    //{
                        fileText += libs.getForInfo();
                    //}
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
        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
           string path = "", doIt = "";
            int Count, LCount, gName;
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
                if (doIt == "Файл")
                {
                    for (int i = 0; i <= libs.Count; i++)
                    {
                        libs.delBook();
                        dataGridView1.Rows.Clear();
                        dataGridView2.Rows.Clear();
                    }
                    Count = int.Parse(stream3.ReadLine());
                    for (int i = 1; i <= Count;)
                    {
                        string name = stream3.ReadLine();
                        string Aut = stream3.ReadLine();
                        libs.addBook(name, Aut);
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i - 1].Cells[0].Value = name;
                        dataGridView1.Rows[i - 1].Cells[1].Value = Aut;
                        if (i != Count)
                            i++;
                        else
                            break;
                    }
                    stream3.ReadLine(); int hall = 0;
                    while (stream3.Peek() != -1)
                    {
                        LCount = int.Parse(stream3.ReadLine());
                        if (LCount != 0)
                        {
                            for (int i = 1; i <= LCount;)
                            {
                                string inf = stream3.ReadLine();
                                gName = int.Parse(stream3.ReadLine());
                                string name = Convert.ToString(dataGridView1.Rows[hall].Cells[0].Value);
                                libs.searchBook(name).addReader(inf, gName);
                                if (i != LCount)
                                    i++;
                                else
                                    break;
                            }
                            hall++;
                        }
                    }
                }
                else { MessageBox.Show("Данный файл не подходит для работы с программой"); }
                stream3.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBoxBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textBoxAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }  
    }
}
