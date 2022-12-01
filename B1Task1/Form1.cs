using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace B1Task1
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        // Обработка нажатия на кнопку "Выбор папки"
        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {
            //Выводим диалоговое окно выбора папки
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxFolder.Text = fbd.SelectedPath;
            }
        }

        // Обработка нажатия на кнопку "Сгенерировать"
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string folderPath = textBoxFolder.Text;

            //Создаю название файла таким, чтобы оно было уникальным (при использовании функции генерации повторно)
            DateTime dtPath = DateTime.Now;
            string dateFileName = dtPath.ToString("ddMMyyyyHHmmss");
            string fullPath = folderPath + "\\" + dateFileName + "_";

            // Нахожу разницу в днях между сегодняшним днём и 5 годами ранее (для нахождения случайной даты в этом промежутке)
            DateTime startTime = DateTime.Today.AddYears(-5);
            int range = (DateTime.Today - startTime).Days;
            Random rndDateText = new Random();

            // Строка английский символов (для генерации случайной строки)
            string englishLetters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rndEnglish = new Random();

            // Строка русских символов (для генерации случайной строки)
            string russianLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            Random rndRussian = new Random();

            Random rndNumber = new Random();

            // Генерация 100 файлов
            for (int i = 0; i < 100; i++)
            {
                // Проверка на существование файла (чтобы мы не перезаписывали ранее созданные файлы)
                // Если не возвращаться в прошлое то при генерации файлов, их названия никогда не повторятся
                if (!File.Exists(fullPath + i + ".txt"))
                {
                    // Поток для записи
                    using (StreamWriter sw = File.CreateText(fullPath + i + ".txt"))
                    {
                        for (int j = 0; j < 100000; j++)
                        {
                            // Получаем наши "рандомные значения"
                            string tmpDateText = startTime.AddDays(rndDateText.Next(range)).ToString("dd.MM.yyyy");

                            string randomEnglishString = "";
                            string randomRussianString = "";
                            for (int k = 0; k < 10; k++)
                            {
                                randomEnglishString += englishLetters[rndEnglish.Next(englishLetters.Length)];
                                randomRussianString += russianLetters[rndRussian.Next(russianLetters.Length)];
                            }

                            int randomEvenNumber = 2 * rndNumber.Next(1, 50000000);

                            double randomLessNumber = rndNumber.Next(100000000, 2000000000) / (double)100000000;

                            // Записываем их в файл (построчно)
                            sw.WriteLine(tmpDateText + "||" + randomEnglishString + "||" + randomRussianString + "||" + randomEvenNumber + "||" + randomLessNumber + "||");
                        }
                    }
                }
            }
            MessageBox.Show("Файлы сгенерированы!");
        }

        // Обработка нажатия на кнопку "Объединить"
        private void buttonJoin_Click(object sender, EventArgs e)
        {
            // Открываем окно выбора файла/ов (для их объединения)
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Файлы txt|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Объединяем файлы через новые потоки (так как главный поток может не успеть всё сделать, что в итоге вызовет ошибку)
                // Однако скорость работы функции в итоге сильно замедлится
                new Thread(() => JoinFiles(ofd.FileNames)).Start();
            }
        }

        // Метод объединения файлов
        private void JoinFiles(string[] fileNames)
        {
            int countDeletedLine = 0;
            //Получаем название файла в виде даты его создания, и также называем наш новый файл
            string destFileName = fileNames[0].Split('_')[0] + "_All.txt";
            // Создаём поток для записи строк в новый файл
            using (FileStream destStream = File.OpenWrite(destFileName))
            {
                // Возвращаем позицию для того, чтобы мы могли записывать в него данные
                destStream.Position = 0;
                // Проходим через все выбранные файлы
                foreach (string file in fileNames)
                {
                    string[] tmpStringFile = File.ReadAllLines(file);
                    foreach (string s in tmpStringFile)
                    {
                        // Проверяем содержит ли строка файла строку, которая не должна быть в итоге записана (учитывая регистр строки)
                        if (!s.Contains(textBoxFile.Text) || textBoxFile.Text.Length < 1)
                        {
                            // Вызываем метода записи строки в файл
                            WriteText(destStream, s);
                        }
                        else
                        {
                            countDeletedLine++;
                        }
                    }
                }
            }
            MessageBox.Show("Объединение завершено!\nУдалённых строк: " + countDeletedLine);
        }

        // Методо записи строки в файл
        private void WriteText(FileStream fs, string text)
        {
            text += "\n";
            byte[] byteText = Encoding.Default.GetBytes(text);
            fs.Write(byteText, 0, byteText.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1Task1DataSet.B1t1". При необходимости она может быть перемещена или удалена.
            this.b1t1TableAdapter.Fill(this.b1Task1DataSet.B1t1);

        }

        // Обработка нажатия на кнопку "Загрузить файлы в БД"
        private void buttonAddDB_Click(object sender, EventArgs e)
        {
            // Открываем диалоговое окно выбора файлов (которые будем загружать в БД)
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Файлы txt|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Загружаем данные через новые потоки (очень медленно)
                new Thread(() => WriteIntoBD(ofd.FileNames)).Start();
            }
        }

        // Метод записи строк в БД
        private void WriteIntoBD(string[] files)
        {
            int tmpNum = 0;
            int numAllString = 0;
            // Находим количество всех строк, которые должны импортировать в БД
            foreach (string file in files)
            {
                numAllString += File.ReadAllLines(file).Length;
            }
            foreach (string file in files)
            {
                // Читаем файл построчно
                string[] tmpStringFile = File.ReadAllLines(file);
                foreach (string s in tmpStringFile)
                {
                    // Делим файл по разделителю - ||
                    // И заносим в БД
                    string[] tmpOneString = s.Split(new string[] { "||" }, StringSplitOptions.None);
                    DataRow tmpRow = this.b1Task1DataSet.Tables[0].NewRow();
                    tmpRow[0] = tmpOneString[0];
                    tmpRow[1] = tmpOneString[1];
                    tmpRow[2] = tmpOneString[2];
                    tmpRow[3] = tmpOneString[3];
                    tmpRow[4] = tmpOneString[4];
                    this.b1Task1DataSet.Tables[0].Rows.Add(tmpRow);
                    this.b1t1TableAdapter.Update(this.b1Task1DataSet.B1t1);
                    this.b1Task1DataSet.Tables[0].AcceptChanges();
                    Action actionWriteIntoBD = () => this.dataGridView1.Refresh();
                    Action actionChangeNum = () => label1.Text = "Импортировано строк:\n" + (++tmpNum).ToString() + " \nСтрок осталось:\n" + --numAllString;

                    // Через Invoke так как к label1 и dataGridView1 нужно обращаться из потока, в котором они были созданы (главный)
                    Invoke(actionWriteIntoBD);
                    Invoke(actionChangeNum);
                }
            }
        }
    }
}
