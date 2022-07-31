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

namespace _3rdstep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Syne", 10, FontStyle.Bold);
            // настройка шрифта у 1 таблицы
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Syne", 10, FontStyle.Bold);
            // настройка шрифта у 2 таблицы
        }
        NewsPortal Container = new NewsPortal("Country News");//создание контейнера новостного раздела
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//обновление второй таблицы при выборе элемента в первой
        {
            if (dataGridView1.CurrentCell.Value != null)//проверка на "случайный" клик
            {
                dataGridView2.Rows.Clear();//очистка полностью второй таблицы
                string text = dataGridView1.CurrentCell.Value.ToString();//запись в строку выбранного пользователем названия раздела
                ThemeSection vspom = Container.FindTheme(text);//поиск выбранного пользователем раздела
                if (vspom != null)//проверка на пустое нахождение объекта
                {
                    NewsSet[] copy1 = vspom.Queue;//копирование массива-очереди в вспомогательный массив
                    int chet = Container.FindTheme(text).Count;//получение количества новостей в найденном разделе
                    for (int i = 0; i < chet; i++)
                    {
                        dataGridView2.Rows.Add(copy1[i].Title, copy1[i].Date);//с помощью цикла добавление
                        //во вторую таблицу обьектов(новостей) данного раздела
                    }
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = Container.FindTheme(text).Count;
                    //обновление количества элементов у n-го раздела
                }
            }
        }
        private void TextTheme_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void TextTheme_Click(object sender, EventArgs e)
        {
            TextTheme.Clear();//очищение данного текст бокса, так как изначально там был текст
            //для ориентации ввода клиента
        }
        private void TextTheme_KeyPress(object sender, KeyPressEventArgs e)
        {//обработчик текста у текстового поля, отвечающего за название раздела
            //принимает максимум 20 символов и только буквы Руссого и Английского алфавитов обоих литеров
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            TextTheme.MaxLength = 20;
        }
        private void TextNews2_KeyPress(object sender, KeyPressEventArgs e)
        {//обработчик длины текста в текстовом поле, отвечающего за дату публикации новости
            TextNews2.MaxLength = 20;
        }
        private void TextNews1_KeyPress(object sender, KeyPressEventArgs e)
        {//обработчик текста у текстового поля, отвечающего за название новости
            //принимает максимум 40 символов и только буквы Руссого и Английского алфавитов обоих литеров
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            TextNews1.MaxLength = 40;
        }
        private void TextNews1_Click(object sender, EventArgs e)
        {
            TextNews1.Clear();//очищение данного текст бокса, так как изначально там был текст
            //для ориентации ввода клиента
        }
        private void TextNews2_Click(object sender, EventArgs e)
        {
            TextNews2.Clear();//очищение данного текст бокса, так как изначально там был текст
            //для ориентации ввода клиента
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void AddTheme_Click(object sender, EventArgs e)//добавление новостного раздела
        {
            Container.addTheme(TextTheme.Text);//добавление раздела именно в структуру
            int i = Container.FindThemeForInt(TextTheme.Text); //при вызове метода поиска возвращает i
            //для индекса добавления во 1 табличку
            if (i >= 0)
            {
                dataGridView1.Rows.Add();//добавление в 1 таблицу пустой строки

                if (dataGridView1.Rows[i].Cells[0].Value == null)//проверка на первое добавление в строку по индексу i
                {
                    dataGridView1.Rows[i].Cells[0].Value = TextTheme.Text;//присваивание в первый столбец данной
                    //строки значение текстового поля(название раздела)
                    dataGridView1.Rows[i].Cells[1].Value = Container.FindTheme(TextTheme.Text).Count;//присваивание в первый столбец данной
                    //(количество элементов в этом разделе)
                    TextTheme.Clear();//очищение текстбокса для дальнейшего удобства                   
                }
                else
                {
                    for (int j = Container.Count; j > i; j--)//с помощью цикла for смещение строк вниз, для 
                                                             //добавления объекта в нужную строку
                    {
                        dataGridView1.Rows[j].Cells[0].Value = dataGridView1.Rows[j - 1].Cells[0].Value;
                        dataGridView1.Rows[j].Cells[1].Value = dataGridView1.Rows[j - 1].Cells[1].Value;
                        dataGridView1.Rows[j - 1].Cells[0].Value = null;
                        dataGridView1.Rows[j - 1].Cells[1].Value = null;
                    }
                    //добавление самой строки по индексу i
                    dataGridView1.Rows[i].Cells[0].Value = TextTheme.Text;
                    dataGridView1.Rows[i].Cells[1].Value = Container.FindTheme(TextTheme.Text).Count;
                }
            }
            else MessageBox.Show("Adding is not successful");//если что то не введено или не выбран 
            //нужный элемент в 1 таблице, показ пользователю сообщения
        }
        private void ChTheme_Click(object sender, EventArgs e)//метод изменения выбранного объекта
        {
            if (dataGridView1.CurrentCell.Value != null && TextTheme.Text != "")//проверка 
                //на правильность вхождения данных
            {
                string change = dataGridView1.CurrentCell.Value.ToString();//запись в строку выбранной строки
                int index = dataGridView1.CurrentRow.Index;//получение индекса выбранной строки
                Container.FindTheme(change).NameChapter = TextTheme.Text;//изменение данных в самой структуре
                dataGridView1.Rows[index].Cells[0].Value = TextTheme.Text;//изменение данных в выбранной строке
                TextTheme.Clear();//очищение текстбокса
            }
            else { MessageBox.Show("The change failure"); }//вывод сообщени пользователю в случае недостающих данных
        }
        private void DelTheme_Click(object sender, EventArgs e)//удаление новостного раздела
        {
            string text = dataGridView1.CurrentCell.Value.ToString();//запись выбранной строки в таблице
            int index = dataGridView1.CurrentRow.Index;//запись индекса выбранной строки
            Container.delTheme(text);//удаление элемента из самой структуры
            dataGridView1.Rows.RemoveAt(index);//удаление выбранной строки из 1 таблицы
            dataGridView2.Rows.Clear();//для правильности данных очищение всей 2 таблицы
            //далее при нажатии на нужную строку выводится актуальная информация
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AddNews_Click(object sender, EventArgs e)//добавление новости в раздел
        {
            //обрабатываем вхождение нужных элементов
            if (dataGridView1.CurrentCell.Value != null && TextNews1.Text != "" && TextNews2.Text != "")
            {
                //добавление новости в саму структуру
                Container.FindTheme(dataGridView1.CurrentCell.Value.ToString()).AddToList(TextNews1.Text, TextNews2.Text);
                dataGridView2.Rows.Add(TextNews1.Text, TextNews2.Text);//добавление новости в таблицу 2
                //очищение текстбоксов
                TextNews1.Clear();
                TextNews2.Clear();
            }
            else { MessageBox.Show("Adding news is not successful"); }//вывод сообщение пользователю
            //в случае неправильности входных данных
        }
        private void ChNews_Click(object sender, EventArgs e)
        {
            //обрабатываем вхождение нужных элементов
            if (dataGridView1.CurrentCell.Value != null && dataGridView2.CurrentCell.Value != null && TextNews1.Text != "" && TextNews2.Text != "")
            {
                string change = dataGridView1.CurrentCell.Value.ToString();//запись выбранной строки в таблице
                string changeNews = dataGridView2.CurrentCell.Value.ToString();//запись выбранной строки в таблице
                int index = dataGridView2.CurrentRow.Index;//запись индекса выбранной строки в таблице
                Container.FindTheme(change).Search(changeNews).Title = TextNews1.Text;//изменение данных в самой структуре
                Container.FindTheme(change).Search(TextNews1.Text).Date = TextNews2.Text;//изменение данных в самой структуре
                dataGridView2.Rows[index].Cells[0].Value = TextNews1.Text;//изменение данных во 2 таблице
                dataGridView2.Rows[index].Cells[1].Value = TextNews2.Text;//изменение данных во 2 таблице
                //очищение текстбоксов
                TextNews1.Clear();
                TextNews2.Clear();
            }
            else { MessageBox.Show("The change news failure"); }//вывод сообщение пользователю
            //в случае неправильности входных данных
        }
        private void DelNews_Click(object sender, EventArgs e)//удаление новости в разделе
        {
            string search = dataGridView1.CurrentCell.Value.ToString();//запись выбранной строки в таблице
            Container.FindTheme(search).DeleteFromQueue();//удаление новости из выбранного раздела в структуре
            dataGridView2.Rows.RemoveAt(0);//удаление новости во 2 таблице
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)//сохранение файла
        {
            string path;
            string fileText = "Файл\n";
            //Создание экземпляра диалогового окна (Для того чтобы не занимать поток) + фильтр на создание текстовых файлов
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    path = saveFile.FileName;//имя файла
                    fileText += Container.getQueue() + "\n";//получение названий разделов, и общее их количество
                    fileText += Container.getQueueFor();//получение количества новостей и данных о них в каждом разделе
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
        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)//загрузка файла
        {
            string path = "", doIt = "";
            int Count, LCount;
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    path = openFile.FileName;//получение имени выбранного файла
                }
            }
            using (StreamReader stream3 = new StreamReader(path))
            {
                doIt = stream3.ReadLine();
                //Проверка на пригодность файла для работы с программой
                if (doIt == "Файл")
                {
                    Container.delThemeAll();//удаление всех имеющихся данных в запущенной программе
                    dataGridView1.Rows.Clear();//удаление всех строк в 1 и 2 таблицах
                    dataGridView2.Rows.Clear();
                    Count = int.Parse(stream3.ReadLine());//количество разделов
                    for (int i = 1; i <= Count;)//цикл for по количеству разделов для их добавления в структуру и в 1 таблицу
                    {
                        string name = stream3.ReadLine();
                        Container.addTheme(name);
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i - 1].Cells[0].Value = name;
                        if (i != Count)
                            i++;
                        else
                            break;
                    }
                    stream3.ReadLine(); int hall = 0;
                    while (stream3.Peek() != -1)//цикл while для добавление в структуру новостей в каждый раздел
                    {
                        LCount = int.Parse(stream3.ReadLine());
                        if (LCount != 0)
                            for (int i = 1; i <= LCount;)
                            {
                                string _NewsName = stream3.ReadLine();
                                string _DatePub = stream3.ReadLine();
                                string name = Convert.ToString(dataGridView1.Rows[hall].Cells[0].Value);
                                Container.FindTheme(name).AddToList(_NewsName, _DatePub);
                                if (i != LCount)
                                    i++;
                                else
                                    break;
                            }
                        hall++;
                    }
                }
                else { MessageBox.Show("Данный файл не подходит для работы с программой"); }//вывод сообщения
                //в случае, когда первая строка не содержит фразу "Файл"
                stream3.Close();
            }
        }
    }
}