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

namespace step3
{
    public partial class Form1 : Form
    {
        registry reg = new registry("Мой Налог", 5);
        public Form1()
        {
            InitializeComponent();
        }
        //Настройка текстовых полей для правильного добавления
        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string text = "Information:\n";
            richTextBox1.Text = text + "\n" + reg.Info();
        }
        private void textINN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void textSUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void textSur_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success  && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textTAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textSUR_TextChanged(object sender, EventArgs e)
        {

        }
        private void textINN_TextChanged(object sender, EventArgs e)
        {
            textINN.MaxLength = 16;
        }
        private void textSUM_TextChanged(object sender, EventArgs e)
        {
            textSUM.MaxLength = 7;
        }

        //настройка кнопок для налогоплательщика
        private void butAddSur_Click(object sender, EventArgs e)
        {
            if (textSUR.Text != "" && textINN.Text != "")
            {
                reg.addtaxpayer(textSUR.Text, Convert.ToInt64(textINN.Text));
                dataGridView1.Rows.Add(textSUR.Text, textINN.Text);
                textSUR.Clear();textINN.Clear();
            }
            else { MessageBox.Show("Добавление не выполнено!\nЗаполните все нужные данные."); }
        }
        private void butChSur_Click(object sender, EventArgs e)
        {
            if (textSUR.Text != "" && textINN.Text != "" && dataGridView1.CurrentCell.Value != null)
            {
                reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).Surname = textSUR.Text;
                reg.searchtaxpayer(textSUR.Text).IINN = Convert.ToInt64(textINN.Text);
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value = textSUR.Text;
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = textINN.Text;
                textINN.Clear();textSUR.Clear();
            }
            else { MessageBox.Show("Изменение не выполнено!\nЗаполните все нужные данные,\nили выберите изменяемый элемент."); }
        }
        private void butDelSur_Click(object sender, EventArgs e)
        {
            if (reg.Count != 0)
            {
                reg.deltaxpayer();
                dataGridView1.Rows.RemoveAt(0);
                dataGridView2.Rows.Clear();
            }
            else { MessageBox.Show("Удаление не выполнено!\nНечего удалять."); }
        }

        //настройка кнопок для налогов
        private void butAddTax_Click(object sender, EventArgs e)
        {
            if (textSUM.Text != "" && textTAX.Text != "" && dataGridView1.CurrentCell.Value != null)
            {
                dataGridView2.Rows.Add();
                    int index = dataGridView2.CurrentRow.Index;
                    if(reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).Count == 0 && radioButAddAfter.Checked == false && radioButAddBefore.Checked == false)
                    {
                        reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).addtaxVtoroe("", textTAX.Text, Convert.ToInt32(textSUM.Text),4);
                        dataGridView2.Rows[0].Cells[0].Value = textTAX.Text;
                        dataGridView2.Rows[0].Cells[1].Value = textSUM.Text;
                    }
                    else if (radioButAddBefore.Checked == true)
                    {
                        if(index == 0)
                        {
                            reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).addtaxVtoroe(dataGridView2.CurrentCell.Value.ToString(), textTAX.Text, Convert.ToInt32(textSUM.Text), 3);
                            for (int i = (reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).Count - 1); i >= index; i--)
                            {
                                dataGridView2.Rows[i + 1].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                                dataGridView2.Rows[i + 1].Cells[1].Value = dataGridView2.Rows[i].Cells[1].Value;
                            }
                            dataGridView2.Rows[index].Cells[0].Value = textTAX.Text;
                            dataGridView2.Rows[index].Cells[1].Value = textSUM.Text;
                        }
                        else {
                            reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).addtaxVtoroe(dataGridView2.CurrentCell.Value.ToString(), textTAX.Text, Convert.ToInt32(textSUM.Text), 1);
                            for (int i = (reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).Count - 1); i >= index; i--)
                            {
                                dataGridView2.Rows[i + 1].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                                dataGridView2.Rows[i + 1].Cells[1].Value = dataGridView2.Rows[i].Cells[1].Value;
                            }
                            dataGridView2.Rows[index].Cells[0].Value = textTAX.Text;
                            dataGridView2.Rows[index].Cells[1].Value = textSUM.Text;
                        }
                    }
                    else if(radioButAddAfter.Checked == true)
                    {
                        reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).addtaxVtoroe(dataGridView2.CurrentCell.Value.ToString(), textTAX.Text, Convert.ToInt32(textSUM.Text), 2);
                        for (int i = (reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).Count-1); i > index; i--)
                        {
                            dataGridView2.Rows[i + 1].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                            dataGridView2.Rows[i + 1].Cells[1].Value = dataGridView2.Rows[i].Cells[1].Value;
                        }
                        dataGridView2.Rows[index+1].Cells[0].Value = textTAX.Text;
                        dataGridView2.Rows[index+1].Cells[1].Value = textSUM.Text;
                    }
                    else { MessageBox.Show("Выберите куда добавить налог."); }
                
            }
        }
        private void butChTax_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null && dataGridView2.CurrentCell.Value != null && textTAX.Text != "" && textSUM.Text != "")
            {
                reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).Search(dataGridView2.CurrentCell.Value.ToString()).setTypeTax(textTAX.Text);
                reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).Search(textTAX.Text).setAmount(Convert.ToInt32(textSUM.Text));
                dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value = textTAX.Text;
                dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value = textSUM.Text;
            }
            else MessageBox.Show("Изменить не получилось!\nВведите нужные данные.\nИли выберите изменяемый объект.");
        }
        private void butDelTax_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell.Value != null && dataGridView2.CurrentCell.Value != null)
            {
                string text = dataGridView1.CurrentCell.Value.ToString();
                int index = dataGridView2.CurrentRow.Index;
                reg.searchtaxpayer(text).delltax(dataGridView2.Rows[index].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView2.Rows[index].Cells[1].Value));
                dataGridView2.Rows.RemoveAt(index);
                dataGridView2.AllowUserToAddRows = false;
            }
            else { MessageBox.Show("Удалить не получилось.\nВыберите удаляемый объект."); }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != null)
            {
                dataGridView2.Rows.Clear();
                radioButAddAfter.Checked = false;
                radioButAddBefore.Checked = false;
                taxpayer vspom = reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString());
                if (vspom != null)
                {
                    dinList pTemp = vspom.PHead;
                    int chet = reg.searchtaxpayer(dataGridView1.CurrentCell.Value.ToString()).Count;
                    for (int i = 0; i < chet; i++)
                    {
                        dataGridView2.Rows.Add(pTemp.typeTax.getTypeTax(), pTemp.typeTax.getAmount());
                        pTemp = pTemp.Next;
                    }
                }
            }
            else MessageBox.Show("Выбрана пустая строчка");
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            string path;
            string fileText = "Tax\n";
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    path = saveFile.FileName;
                    fileText += reg.InfoForSave();
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
                if (doIt == "Tax")
                {
                    for (int i = 0; i <= reg.Count; i++)
                    {
                        reg.deltaxpayer();
                        dataGridView1.Rows.Clear();
                        dataGridView2.Rows.Clear();
                    }
                    Count = int.Parse(stream3.ReadLine());
                    for (int i = 1; i <= Count;)
                    {
                        string Surname = stream3.ReadLine();
                        long INN = long.Parse(stream3.ReadLine());
                        reg.addtaxpayer(Surname, INN);
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i - 1].Cells[0].Value = Surname;
                        dataGridView1.Rows[i - 1].Cells[1].Value = INN;
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
                                string atypeTax = stream3.ReadLine();
                                int aMount = int.Parse(stream3.ReadLine());
                                string name = Convert.ToString(dataGridView1.Rows[hall].Cells[0].Value);
                                reg.searchtaxpayer(name).addForUpload(atypeTax, aMount);
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
