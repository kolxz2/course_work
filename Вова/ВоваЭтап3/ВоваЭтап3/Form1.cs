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

namespace Этап3

{
    public partial class Form1 : Form
    {
        department Dep = new department("Вова");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddEmpl_Click(object sender, EventArgs e)
        {
            int exp = Convert.ToInt32(textBox3.Text);
            int salary = Convert.ToInt32(textBox4.Text);
            Dep.AddEmployee(textBox1.Text, textBox2.Text,exp,salary);
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, exp, salary);
        }

        private void DeleteEmpl_Click(object sender, EventArgs e)
        {   
            string chose = dataGridView1.CurrentCell.Value.ToString();
            Dep.DeleteEmployee(chose);
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void VivoDinf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dep.getInfo());
        }

        private void Change_Click(object sender, EventArgs e)
        {
            string nameEmployee = dataGridView1.CurrentCell.Value.ToString();
            int index = dataGridView1.CurrentRow.Index;
            Dep.FindEmployee(nameEmployee).Fam = textBox1.Text;
            dataGridView1.Rows[index].Cells[0].Value = textBox1.Text;

            Dep.FindEmployee(textBox1.Text).Work = textBox2.Text;
            dataGridView1.Rows[index].Cells[1].Value = textBox2.Text;

            Dep.FindEmployee(textBox1.Text).Exp = Convert.ToInt32(textBox3.Text);
            dataGridView1.Rows[index].Cells[2].Value = Convert.ToInt32(textBox3.Text);

            Dep.FindEmployee(textBox1.Text).Salary = Convert.ToInt32(textBox4.Text);
            dataGridView1.Rows[index].Cells[3].Value = textBox4.Text;



        }

        private void SavEinFile_Click(object sender, EventArgs e)
        {
            string path;
            string fileText = "Файл";
            //Создание экземпляра диалогового окна (Для того чтобы не занимать поток) + фильтр на создание текстовых файлов
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    path = saveFile.FileName;
                   // fileText += Dep.getNameDep() + "\n";
                    fileText += Dep.getLoadInfo();
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

        private void LoaDinGrid_Click(object sender, EventArgs e)
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
                    for (int i = 0; i <= Dep.getCount(); i++)
                    {
                        Dep.DeleteAll();
                        dataGridView1.Rows.Clear();
                    }
                    Count = int.Parse(stream3.ReadLine());
                    for (int i = 1; i <= Count;)//первая колонка
                    {
                        string name = stream3.ReadLine();
                        int Loadsalary = int .Parse(stream3.ReadLine());
                        int LoadExp = int.Parse(stream3.ReadLine());
                        string Loadwork = stream3.ReadLine();

                        Dep.AddEmployee(name,Loadwork,LoadExp,Loadsalary);
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i - 1].Cells[0].Value = name;
                        dataGridView1.Rows[i - 1].Cells[1].Value = Loadwork;
                        dataGridView1.Rows[i - 1].Cells[2].Value = LoadExp;
                        dataGridView1.Rows[i - 1].Cells[3].Value = Loadsalary;
                        if (i != Count)
                            i++;
                        else
                            break; 
                    }
                }
                else { MessageBox.Show("Данный файл не подходит для работы с программой"); }
                stream3.Close();
            }
        }
    }
}
