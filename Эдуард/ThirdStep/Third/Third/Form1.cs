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

namespace Third
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EmploymentService mains = new EmploymentService(10);

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butAddOrg_Click(object sender, EventArgs e)
        {
            mains.addComp(textOrg.Text);
            dataGridView1.Rows.Add(textOrg.Text);
        }

        private void butChOrg_Click(object sender, EventArgs e)
        {
            mains.FindComp(dataGridView1.CurrentCell.Value.ToString()).NameOrganization = textOrg.Text;
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value = textOrg.Text;
        }

        private void butDelOrg_Click(object sender, EventArgs e)
        {
            if (mains.getSP != 0)
            {
                mains.delComp();
                dataGridView1.Rows.RemoveAt(mains.getSP);
            }
            else MessageBox.Show("Нечего удалять");
        }

        private void butAddSer_Click(object sender, EventArgs e)
        {
            mains.FindComp(dataGridView1.CurrentCell.Value.ToString()).AddVacantion(textWork.Text, Convert.ToInt32(textSal.Text), textName.Text);
            dataGridView2.Rows.Add(textName.Text, textWork.Text, textSal.Text);
        }

        private void butChSer_Click(object sender, EventArgs e)
        {
            string data1 = dataGridView1.CurrentCell.Value.ToString();
            string data2 = dataGridView2.CurrentCell.Value.ToString();
            Vacantion vspom = mains.FindComp(data1).search(data2);
            vspom.SetName(textName.Text);
            vspom.SetSalary(Convert.ToInt32(textSal.Text));
            vspom.SetWork(textWork.Text);
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value = textName.Text;
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value = textWork.Text;
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value = textSal.Text;
        }

        private void butDelSer_Click(object sender, EventArgs e)
        {
            string data1 = dataGridView1.CurrentCell.Value.ToString();
            string data2 = dataGridView2.CurrentCell.Value.ToString();
            mains.FindComp(data1).DeleteVacantion(data2);
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            string path;
            string fileText = "Файл\n";
            //Создание экземпляра диалогового окна (Для того чтобы не занимать поток) + фильтр на создание текстовых файлов
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    path = saveFile.FileName;
                    fileText += mains.getName() + "\n";
                    fileText += mains.getQueueFor();
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
            string path = "", doIt = "";
            int Count, LCount, salary;
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
                    for (int i = 0; i <= mains.getSP; i++)
                    {
                        mains.delComp();
                        dataGridView1.Rows.Clear();
                        dataGridView2.Rows.Clear();
                    }
                    Count = int.Parse(stream3.ReadLine());
                    for (int i = 1; i <= Count;)
                    {
                        string name = stream3.ReadLine();
                        mains.addComp(name);
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
                                string _work = stream3.ReadLine();
                                string _name = stream3.ReadLine();
                                salary = int.Parse(stream3.ReadLine());
                                string name = Convert.ToString(dataGridView1.Rows[hall].Cells[0].Value);
                                mains.FindComp(name).AddVacantion(_work, salary,_name);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Clear();
            string text = dataGridView1.CurrentCell.Value.ToString();
            Organizations vspom = mains.FindComp(text);
            if (vspom != null)
            {
                SList copy = vspom.SHeader;
                int chet = mains.FindComp(text).Count;
                for (int i = 0; i < chet; i++)
                {
                    dataGridView2.Rows.Add(copy.data.GetName(), copy.data.GetWork(),copy.data.GetSalary());
                }
            }
        }
    }
}
