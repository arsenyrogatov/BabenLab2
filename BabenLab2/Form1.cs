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
            //������� ���� input.txt � ����� � ��������
            if (openFileDialog.ShowDialog() == DialogResult.OK) //���� ������ ���������� ����
            {
                fileStatus_label.Text = System.IO.Path.GetFileName(openFileDialog.FileName); //������� ��� �����
                var lines = File.ReadAllLines(openFileDialog.FileName); //��������� �� ���� ��� ������
                var matrix = new string[lines.Length, lines.Length]; //������� �������

                for (int i = 0; i < lines.Length; i++)
                {
                    var line = lines[i].Split(new char[] { ' ' }); //��������� ������ �� �������� ����� ������ (���� ������ "1 2 3" ����� 3 �������� '1' '2' '3')
                    for (int j = 0; j < lines.Length; j++)
                    {
                        matrix[i, j] = line[j]; //���������� ������ �� �������� ��������� � �������
                        input_textBox.Text += line[j] + " "; //������� �� �����
                    }
                    input_textBox.Text += Environment.NewLine; //������� ������ ����� ��������� ������ �������� �� �����
                }

                var width = matrix.GetLength(1); //������ �������
                var height = matrix.GetLength(0); //������ �������

                /* ������� ����� �������� �� ������� 2-�o ������� ������ 2-�� ������.
                 * ����� �������� �� ���� �������. 
                 * ��� �� � ��� ���������, � ����� �� ������� �� ����, ��� ������.*/

                //��������� https://studfile.net/preview/9410594/page:3/

                for (int i = 0; i < height; i++)
                    for (int j = 0; j < width; j++)
                        if ((i % 2 == 0) && (j % 2 == 0)) //��� ��������
                            output_textBox.Text += matrix[i, j] + Environment.NewLine; //��� �������
                        
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
            else //���� ���� �� ������
            {
                fileStatus_label.Text = "���� �� ������";
            }
        }
    }
}