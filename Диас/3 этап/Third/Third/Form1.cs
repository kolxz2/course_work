using System;
using System.IO;
using System.Windows.Forms;

namespace Third
{
    public partial class Form1 : Form
    {
        Cinema news = new Cinema();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            Film vspom = news.FindFilm(text);
            if (vspom != null)
            {
                vspom.delSeans();
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
            else { MessageBox.Show("Выберите фильм, сеанс которого хотите удалить"); }
        }

        private void butAddFilm_Click(object sender, EventArgs e)
        {
            news.addFilm(textBox.Text, Convert.ToInt32(textBox1.Text));
            dataGridView1.Rows.Add(textBox.Text, textBox1.Text);
            textBox.Clear();
            textBox1.Clear();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e){}

        private void butAddSeans_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            news.getSeansToEdit(textBox.Text, Convert.ToInt32(textBox1.Text), text);
            dataGridView2.Rows.Add(textBox.Text, textBox1.Text);
            textBox.Clear();
            textBox1.Clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Clear();
            string text = dataGridView1.CurrentCell.Value.ToString();
            Film vspom = news.FindFilm(text);
            if (vspom != null)
            {
                Stack pTemp = vspom.getSPEl;
                int chet = news.FindFilm(text).Count;
                for (int i = 0; i < chet; i++)
                {
                    dataGridView2.Rows.Add(pTemp._aDate.getDate(), Convert.ToString(pTemp._aDate.getTime()));
                    pTemp = pTemp.getPred();
                }
            }
        }

        private void butIzm_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            int index = dataGridView1.CurrentRow.Index;
            news.FindFilm(text).Name = textBox.Text;
            news.FindFilm(textBox.Text).Durat = Convert.ToInt32(textBox1.Text);
            dataGridView1.Rows[index].Cells[0].Value = textBox.Text;
            dataGridView1.Rows[index].Cells[1].Value = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            int index = dataGridView2.CurrentRow.Index;
            news.FindFilm(text).FindSeans(dataGridView2.CurrentCell.Value.ToString()).setDate(textBox.Text);
            news.FindFilm(text).FindSeans(textBox.Text).setTime(Convert.ToInt32(textBox1.Text));
            dataGridView2.Rows[index].Cells[0].Value = textBox.Text;
            dataGridView2.Rows[index].Cells[1].Value = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = dataGridView1.CurrentCell.Value.ToString();
            if (news.getFirst().Name.Equals(text))
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                news.delFilm();
            }
            else { MessageBox.Show("Выберите первый в списке фильм для удаления"); }
        }

        
        private void butUpload_Click(object sender, EventArgs e)
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
                    for (int i = 0; i <= news.COUNT; i++)
                    {
                        news.delFilm();
                    }
                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();
                    Count = int.Parse(stream3.ReadLine());
                    for (int i = 1; i <= Count;)
                    {
                        string nameLH = stream3.ReadLine();
                        int seats = int.Parse(stream3.ReadLine());
                        news.addFilm(nameLH, seats);
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i - 1].Cells[0].Value = nameLH;
                        dataGridView1.Rows[i - 1].Cells[1].Value = seats;
                        if (i != Count)
                            i++;
                        else
                            break;
                    }
                    stream3.ReadLine();
                    int hall = 0;
                    while (stream3.Peek() != -1)
                    {
                        LCount = int.Parse(stream3.ReadLine());
                        if (LCount != 0)
                            for (int i = 1; i <= LCount;)
                            {
                                string inf = stream3.ReadLine();
                                gName = int.Parse(stream3.ReadLine());
                                string name = Convert.ToString(dataGridView1.Rows[hall].Cells[0].Value);
                                news.FindFilm(name).addSeans(inf,gName);
                                if (i != LCount)
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
                    fileText += news.getinfoName() + "\n";
                    for(int i = 0; i < news.COUNT; i++)
                    {
                        fileText += news.getinfo();
                    }
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

    }
}