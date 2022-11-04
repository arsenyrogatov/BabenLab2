namespace BabenLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_button_Click(object sender, EventArgs e)
        {
            //выбирай файл input.txt в папке с проектом
            if (openFileDialog.ShowDialog() == DialogResult.OK) //Если выбран правильный файл
            {
                fileStatus_label.Text = System.IO.Path.GetFileName(openFileDialog.FileName); //Выводим имя файла
                var lines = File.ReadAllLines(openFileDialog.FileName); //считываем из него все строки
                var matrix = new string[lines.Length, lines.Length]; //создаем матрицу

                for (int i = 0; i < lines.Length; i++)
                {
                    var line = lines[i].Split(new char[] { ' ' }); //разбиваем строку на элементы через пробел (была строка "1 2 3" стало 3 элемента '1' '2' '3')
                    for (int j = 0; j < lines.Length; j++)
                    {
                        matrix[i, j] = line[j]; //записываем каждый из разбитых элементов в матрицу
                        input_textBox.Text += line[j] + " "; //выводим на экран
                    }
                    input_textBox.Text += Environment.NewLine; //перенос строки когда очередная строка выведена на экран
                }

                var width = matrix.GetLength(1); //ширина матрицы
                var height = matrix.GetLength(0); //высота матрицы

                /* Сначала берем элементы из каждого 2-гo столбца каждой 2-ой строки.
                 * Затем сдвигаем на один столбец. 
                 * Так же и для следующих, а затем со сдвигом на одну, две строки.*/

                //Подробнее https://studfile.net/preview/9410594/page:3/

                for (int i = 0; i < height; i++)
                    for (int j = 0; j < width; j++)
                        if ((i % 2 == 0) && (j % 2 == 0)) //тут сдвигаем
                            output_textBox.Text += matrix[i, j] + Environment.NewLine; //тут выводим
                        
                for (int i = 0; i < height; i++)
                    for (int j = 0; j < width; j++)
                        if ((i % 2 == 0) && (j % 2 != 0))
                            output_textBox.Text += matrix[i, j] + Environment.NewLine;

                for (int i = 1; i < height; i++)
                    for (int j = 0; j < width; j++)
                        if ((i % 2 != 0) && (j % 2 == 0))
                            output_textBox.Text += matrix[i, j] + Environment.NewLine;

                for (int i = 1; i < height; i++)
                    for (int j = 0; j < width; j++)
                        if ((i % 2 != 0) && (j % 2 != 0))
                            output_textBox.Text += matrix[i, j] + Environment.NewLine;

            }
            else //если файл не выбран
            {
                fileStatus_label.Text = "Файл не выбран";
            }
        }
    }
}