// Form1
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

namespace _3
{
    public partial class Form1 : Form
    {
        Organization comp = new Organization("HART");
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Clear();
            string text = dataGridView1.CurrentCell.Value.ToString();
            ListCompany vspom = comp.FindComp(text);
            if (vspom != null)
            {
                ListVacantion[] copy1 = vspom.QUeue;
                int chet = comp.FindComp(text).Count;
                for (int i = 0; i < chet; i++)
                {
                    dataGridView2.Rows.Add(copy1[i].Work, copy1[i].Salary);
                }
            }
        }
        private void textOrg_Click(object sender, EventArgs e)
        {
            textOrg.Clear();
        }
        private void textWork_Click(object sender, EventArgs e)
        {
            textWork.Clear();
        }
        private void textSal_Click(object sender, EventArgs e)
        {
            textSal.Clear();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comp.addComp(textOrg.Text,10);
            dataGridView1.Rows.Add(textOrg.Text);
            textOrg.Clear();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            int index = dataGridView1.CurrentRow.Index;
            comp.FindComp(text).NameCompany = textOrg.Text;
            dataGridView1.Rows[index].Cells[0].Value = textOrg.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (comp.Count != 0)
            {
                string text = dataGridView1.CurrentCell.Value.ToString();
                int index = dataGridView1.CurrentRow.Index;
                StructList vspom = comp.PHead.First;
                for(int i = 0; i<comp.Count; i++)
                {
                    if (vspom.Name.NameCompany.Equals(text))
                    {
                        comp.delComp(text);
                        dataGridView1.Rows.RemoveAt(index);
                        break;
                    }
                    else vspom = vspom.Next;
                }
            }
            else { MessageBox.Show("Нечего удалять."); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string info = dataGridView1.CurrentCell.Value.ToString();
            comp.FindComp(info).AddVacantion(textWork.Text, Convert.ToInt32(textSal.Text));
            dataGridView2.Rows.Add(textWork.Text,textSal.Text);
            textSal.Clear();textWork.Clear();
        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comp.getQueue());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            int index = dataGridView2.CurrentRow.Index;
            if (textSal.Text != "" && textWork.Text != "")
            {
                comp.FindComp(text).FindVacantion(dataGridView2.CurrentCell.Value.ToString()).Work = textWork.Text;
                comp.FindComp(text).FindVacantion(textWork.Text).Salary = Convert.ToInt32(textSal.Text);
                dataGridView2.Rows[index].Cells[0].Value = textWork.Text;
                dataGridView2.Rows[index].Cells[1].Value = textSal.Text;
            }
            else { MessageBox.Show("Введите оба параметра для изменения"); }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            comp.FindComp(text).DeleteVacantion();
            dataGridView2.Rows.RemoveAt(0);
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                    fileText += comp.getQueueName() + "\n";
                    fileText += comp.getQueueAll();
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
                    
                        comp.delAllComp();
                        dataGridView1.Rows.Clear();
                        dataGridView2.Rows.Clear();
                    
                    Count = int.Parse(stream3.ReadLine());
                    for (int i = 1; i <= Count;)
                    {
                        string name = stream3.ReadLine();
                        comp.addComp(name,10);
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i - 1].Cells[0].Value = name;
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
                            for (int i = 1; i <= LCount;)
                            {
                                string inf = stream3.ReadLine();
                                gName = int.Parse(stream3.ReadLine());
                                string name = Convert.ToString(dataGridView1.Rows[hall].Cells[0].Value);
                                comp.FindComp(name).AddVacantion(inf, gName);
                                if (i != LCount)
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
