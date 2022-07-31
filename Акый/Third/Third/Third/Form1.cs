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

namespace Third
{
    public partial class Form1 : Form
    {
        Company Akyi = new Company("Company Akyi");
        public Form1()
        {
            InitializeComponent();
        }
        private void textSurUrist_Click(object sender, EventArgs e)
        {
            textSurUrist.Clear();
        }
        private void textCost_Click(object sender, EventArgs e)
        {
            textCost.Clear();
        }
        private void testNumber_Click(object sender, EventArgs e)
        {
            textNumber.Clear();
        }
        private void textSurClient_Click(object sender, EventArgs e)
        {
            textSurClient.Clear();
        }
        private void textService_Click(object sender, EventArgs e)
        {
            textService.Clear();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Clear();
            string text = dataGridView2.CurrentCell.Value.ToString();
            Lawyer vspom = Akyi.searchLaw(text);
            if (vspom != null)
            {
                Customers[] copy1 = vspom.Queue;
                int chet = Akyi.searchLaw(text).Count;
                for (int i = 0; i < chet; i++)
                {
                    dataGridView1.Rows.Add(copy1[i].Surname, copy1[i].Service,copy1[i].Cost);
                }
            }
        }
        private void textSurUrist_TextChanged(object sender, EventArgs e)
        {

        }
        private void butAddUrist_Click(object sender, EventArgs e)
        {
            Akyi.addLaw(textSurUrist.Text, Convert.ToInt64(textNumber.Text), 10);
            dataGridView2.Rows.Add(textSurUrist.Text, textNumber.Text);
            textSurUrist.Clear();textNumber.Clear();
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void butAddCli_Click(object sender, EventArgs e)
        {
            string info = dataGridView2.CurrentCell.Value.ToString();
            Akyi.searchLaw(info).addCust(textSurClient.Text,textService.Text,Convert.ToInt32(textCost.Text));
            dataGridView1.Rows.Add(textSurClient.Text, textService.Text, textCost.Text);
        }
        private void textNumber_TextChanged(object sender, EventArgs e)
        {
            textNumber.MaxLength = 11;
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
        private void textNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void textCost_TextChanged(object sender, EventArgs e)
        {
            textCost.MaxLength = 10;
        }
        private void butChUrist_Click(object sender, EventArgs e)
        {
            string info = dataGridView2.CurrentCell.Value.ToString();
            Akyi.searchLaw(info).Surname = textSurUrist.Text;
            Akyi.searchLaw(textSurUrist.Text).Number = Convert.ToInt64(textNumber.Text);
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value = textSurUrist.Text;
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value = textNumber.Text;
            textSurClient.Clear();textNumber.Clear();
        }
        private void butDelUr_Click(object sender, EventArgs e)
        {
            Akyi.delLaw();
            dataGridView2.Rows.RemoveAt(Akyi.Count);
            dataGridView1.Rows.Clear();
        }
        private void butPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Akyi.getInfoComp());
        }
        private void butChCli_Click(object sender, EventArgs e)
        {
            string infoUrist = dataGridView2.CurrentCell.Value.ToString();
            string infoClient = dataGridView1.CurrentCell.Value.ToString();
            Akyi.searchLaw(infoUrist).Search(infoClient).Surname = textSurClient.Text;
            Akyi.searchLaw(infoUrist).Search(textSurClient.Text).Cost = Convert.ToInt32(textCost.Text);
            Akyi.searchLaw(infoUrist).Search(textSurClient.Text).Service = textService.Text;
            dataGridView1.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value = textSurClient.Text;
            dataGridView1.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value = textService.Text;
            dataGridView1.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value = textCost.Text;
        }
        private void butDelCli_Click(object sender, EventArgs e)
        {
            string infoUr = dataGridView2.CurrentCell.Value.ToString();
            Akyi.searchLaw(infoUr).delCust();
            dataGridView1.Rows.RemoveAt(0);
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            string path;
            string fileText = "Akyi Company\n";
            //Создание экземпляра диалогового окна (Для того чтобы не занимать поток) + фильтр на создание текстовых файлов
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    path = saveFile.FileName;
                    fileText += Akyi.Info() + "\n";
                    fileText += Akyi.getInfoFor();
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
            int Count, CusCount, gName;
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
                if (doIt == "Akyi Company")
                {
                    for (int i = 0; i <= Akyi.Count; i++)
                    {
                        Akyi.delLaw();
                        dataGridView1.Rows.Clear();
                        dataGridView2.Rows.Clear();
                    }
                    Count = int.Parse(stream3.ReadLine());
                    for (int i = 1; i <= Count;)
                    {
                        string SurnameUrist = stream3.ReadLine();
                        long Number = long.Parse(stream3.ReadLine());
                        Akyi.addLaw(SurnameUrist, Number, 10);
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[i - 1].Cells[0].Value = SurnameUrist;
                        dataGridView2.Rows[i - 1].Cells[1].Value = Number;
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
                                string SurnCli = stream3.ReadLine();
                                string Service = stream3.ReadLine();
                                gName = int.Parse(stream3.ReadLine());
                                string name = Convert.ToString(dataGridView2.Rows[hall].Cells[0].Value);
                                Akyi.searchLaw(name).addCust(SurnCli, Service, gName);
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
