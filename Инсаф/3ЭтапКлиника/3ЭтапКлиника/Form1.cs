using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _3ЭтапКлиника
{
   
    public partial class Form1 : Form
    {
        Clinic Ptn = new Clinic("insaf", 10);
        public Form1()
        {
            InitializeComponent();
        }

        private void AddUsluga_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoaDinFile_Click(object sender, EventArgs e)
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
                    for (int i = 0; i <= Ptn.GetSp(); i++)
                    {
                        Ptn.delPatient();
                        dataGridView1.Rows.Clear();
                        dataGridView2.Rows.Clear();
                    }
                    Count = int.Parse(stream3.ReadLine());
                    for (int i = 1; i <= Count;)
                    {
                        string name = stream3.ReadLine();
                        Ptn.addPatient(name);
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
                        {
                            dataGridView2.Rows.Add();
                            for (int i = 1; i <= LCount;)
                            {
                                                       
                                string inf = stream3.ReadLine();//услуга
                                int gdata = int.Parse(stream3.ReadLine()); //дата
                                int gsalaty = int.Parse(stream3.ReadLine());// цена 
                                string name = Convert.ToString(dataGridView1.Rows[hall].Cells[0].Value);
                                Ptn.search(name).addVisit(inf, gdata,gsalaty);
                                dataGridView2.Rows[hall].Cells[0].Value = inf; 
                                dataGridView2.Rows[hall].Cells[1].Value= gdata;
                                dataGridView2.Rows[hall].Cells[2].Value = gsalaty;
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

        private void AddPatient_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Ptn.addPatient(name);
            dataGridView1.Rows.Add(name);
            
        }

        private void AllData_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Ptn.info());
        }

        private void Deletepatient_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            Ptn.delPatient();
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.RemoveAt(index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddVisit_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            Ptn.search(text).addVisit(textBox2.Text,Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox4.Text));
            int i = Ptn.search(text).SearchInt(textBox2.Text);
            if (i >= 0)
            {
                dataGridView2.Rows.Add();

                if (dataGridView2.Rows[i].Cells[0].Value == null)
                {
                    dataGridView2.Rows[i].Cells[0].Value = textBox2.Text;
                    dataGridView2.Rows[i].Cells[1].Value = textBox3.Text;
                    dataGridView2.Rows[i].Cells[2].Value = textBox4.Text;
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else
                {
                    for (int j = Ptn.search(text).VisitCount; j > i; j--)
                    {
                        dataGridView2.Rows[j].Cells[0].Value = dataGridView2.Rows[j - 1].Cells[0].Value;
                        dataGridView2.Rows[j].Cells[1].Value = dataGridView2.Rows[j - 1].Cells[1].Value;
                        dataGridView2.Rows[j].Cells[2].Value = dataGridView2.Rows[j - 1].Cells[2].Value;
                        dataGridView2.Rows[j - 1].Cells[0].Value = null;
                        dataGridView2.Rows[j - 1].Cells[1].Value = null;
                        dataGridView2.Rows[j - 1].Cells[2].Value = null;
                    }
                    dataGridView2.Rows[i].Cells[0].Value = textBox2.Text;
                    dataGridView2.Rows[i].Cells[1].Value = textBox3.Text;
                    dataGridView2.Rows[i].Cells[2].Value = textBox4.Text;
                }
            }
            else MessageBox.Show("Добавить не получилось"); ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            dataGridView2.Rows.Clear();
            string text = dataGridView1.CurrentCell.Value.ToString();
            Patient vspom = Ptn.search(text);
            List help = vspom.GetpHead();
            while(help != null)
            {
                dataGridView2.Rows.Add(help.info.getService(),help.info.getDate(),help.info.getCost());
                help = help.Next;
            }
           
        }

        private void Change_Click(object sender, EventArgs e)
        {
            string choose=dataGridView1.CurrentCell.Value.ToString();
            int index = dataGridView1.CurrentRow.Index;
            Ptn.search(choose).setName = textBox1.Text;
            dataGridView1.Rows[index].Cells[0].Value = textBox1.Text;
           
        }

        private void SaVeinFile_Click(object sender, EventArgs e)
        {
            string path;
            string fileText = "Файл";
            //Создание экземпляра диалогового окна (Для того чтобы не занимать поток) + фильтр на создание текстовых файлов
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    path = saveFile.FileName;
                    // fileText += Ptn.Getname() + "\n";
                    fileText+= "\n"+ Ptn.GetSp();

                    fileText += Ptn.infoLoad();
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
    }
}
