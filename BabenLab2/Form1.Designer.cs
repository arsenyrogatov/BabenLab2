namespace BabenLab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileStatus_label = new System.Windows.Forms.Label();
            this.openFile_button = new System.Windows.Forms.Button();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.output_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.fileStatus_label);
            this.panel1.Controls.Add(this.openFile_button);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 50);
            this.panel1.TabIndex = 2;
            // 
            // fileStatus_label
            // 
            this.fileStatus_label.AutoSize = true;
            this.fileStatus_label.Location = new System.Drawing.Point(126, 15);
            this.fileStatus_label.Name = "fileStatus_label";
            this.fileStatus_label.Size = new System.Drawing.Size(106, 17);
            this.fileStatus_label.TabIndex = 1;
            this.fileStatus_label.Text = "Файл не выбран";
            // 
            // openFile_button
            // 
            this.openFile_button.AutoSize = true;
            this.openFile_button.Location = new System.Drawing.Point(10, 10);
            this.openFile_button.Name = "openFile_button";
            this.openFile_button.Size = new System.Drawing.Size(110, 27);
            this.openFile_button.TabIndex = 0;
            this.openFile_button.Text = "Выберите файл";
            this.openFile_button.UseVisualStyleBackColor = true;
            this.openFile_button.Click += new System.EventHandler(this.openFile_button_Click);
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(12, 94);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(279, 253);
            this.input_textBox.TabIndex = 3;
            // 
            // output_textBox
            // 
            this.output_textBox.Location = new System.Drawing.Point(297, 94);
            this.output_textBox.Multiline = true;
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_textBox.Size = new System.Drawing.Size(279, 253);
            this.output_textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходная матрица";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Обход решетками";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_textBox);
            this.Controls.Add(this.input_textBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Лаба 2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label fileStatus_label;
        private Button openFile_button;
        private TextBox input_textBox;
        private TextBox output_textBox;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog;
    }
}