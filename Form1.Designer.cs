namespace HomeWorkThreads
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
            buttonExecute = new Button();
            textBoxMax = new TextBox();
            textBoxMin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelRandom = new Label();
            buttonFib = new Button();
            labelFib = new Label();
            textBoxFib = new TextBox();
            label4 = new Label();
            label5 = new Label();
            buttonPause = new Button();
            buttonFibStop = new Button();
            buttonStop = new Button();
            buttonPauseFib = new Button();
            SuspendLayout();
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(206, 54);
            buttonExecute.Margin = new Padding(3, 2, 3, 2);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(202, 22);
            buttonExecute.TabIndex = 0;
            buttonExecute.Text = "Выполнить";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(272, 23);
            textBoxMax.Margin = new Padding(3, 2, 3, 2);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(162, 23);
            textBoxMax.TabIndex = 1;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(34, 23);
            textBoxMin.Margin = new Padding(3, 2, 3, 2);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(162, 23);
            textBoxMin.TabIndex = 1;
            textBoxMin.TextChanged += textBoxMin_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 6);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Нижний диапазон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 6);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Верхний диапазон";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 84);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 2;
            label3.Text = "Сгенерированное число:";
            // 
            // labelRandom
            // 
            labelRandom.AutoSize = true;
            labelRandom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelRandom.ForeColor = Color.Blue;
            labelRandom.Location = new Point(257, 84);
            labelRandom.Name = "labelRandom";
            labelRandom.Size = new Size(62, 21);
            labelRandom.TabIndex = 2;
            labelRandom.Text = "Вывод";
            // 
            // buttonFib
            // 
            buttonFib.Location = new Point(206, 178);
            buttonFib.Margin = new Padding(3, 2, 3, 2);
            buttonFib.Name = "buttonFib";
            buttonFib.Size = new Size(202, 25);
            buttonFib.TabIndex = 0;
            buttonFib.Text = "ВКЛ генератора Фибоначи";
            buttonFib.UseVisualStyleBackColor = true;
            buttonFib.Click += buttonFib_Click;
            // 
            // labelFib
            // 
            labelFib.AutoSize = true;
            labelFib.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFib.ForeColor = Color.Blue;
            labelFib.Location = new Point(10, 268);
            labelFib.MaximumSize = new Size(490, 375);
            labelFib.Name = "labelFib";
            labelFib.Size = new Size(92, 21);
            labelFib.TabIndex = 2;
            labelFib.Text = "Фибоначи";
            // 
            // textBoxFib
            // 
            textBoxFib.Location = new Point(24, 189);
            textBoxFib.Margin = new Padding(3, 2, 3, 2);
            textBoxFib.Name = "textBoxFib";
            textBoxFib.Size = new Size(132, 23);
            textBoxFib.TabIndex = 1;
            textBoxFib.TextChanged += textBoxMin_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 167);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 2;
            label4.Text = "Предел Фибоначи";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 148);
            label5.Name = "label5";
            label5.Size = new Size(447, 15);
            label5.TabIndex = 2;
            label5.Text = "________________________________________________________________________________________";
            // 
            // buttonPause
            // 
            buttonPause.ForeColor = Color.Blue;
            buttonPause.Location = new Point(257, 117);
            buttonPause.Margin = new Padding(3, 2, 3, 2);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(150, 22);
            buttonPause.TabIndex = 0;
            buttonPause.Text = "Приостановить поток";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonFibStop
            // 
            buttonFibStop.ForeColor = Color.FromArgb(255, 128, 128);
            buttonFibStop.Location = new Point(97, 220);
            buttonFibStop.Margin = new Padding(3, 2, 3, 2);
            buttonFibStop.Name = "buttonFibStop";
            buttonFibStop.Size = new Size(131, 38);
            buttonFibStop.TabIndex = 0;
            buttonFibStop.Text = "Полная остановка Фибоначи";
            buttonFibStop.UseVisualStyleBackColor = true;
            buttonFibStop.Click += buttonFibStop_Click;
            // 
            // buttonStop
            // 
            buttonStop.ForeColor = Color.FromArgb(255, 128, 128);
            buttonStop.Location = new Point(97, 117);
            buttonStop.Margin = new Padding(3, 2, 3, 2);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(131, 22);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "Полная остановка генерации";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonPauseFib
            // 
            buttonPauseFib.ForeColor = Color.Blue;
            buttonPauseFib.Location = new Point(257, 220);
            buttonPauseFib.Margin = new Padding(3, 2, 3, 2);
            buttonPauseFib.Name = "buttonPauseFib";
            buttonPauseFib.Size = new Size(150, 38);
            buttonPauseFib.TabIndex = 4;
            buttonPauseFib.Text = "Приостановить поток Фибоначи";
            buttonPauseFib.UseVisualStyleBackColor = true;
            buttonPauseFib.Click += buttonPauseFib_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 401);
            Controls.Add(buttonPauseFib);
            Controls.Add(buttonStop);
            Controls.Add(label2);
            Controls.Add(labelFib);
            Controls.Add(labelRandom);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxFib);
            Controls.Add(textBoxMin);
            Controls.Add(textBoxMax);
            Controls.Add(buttonFibStop);
            Controls.Add(buttonFib);
            Controls.Add(buttonPause);
            Controls.Add(buttonExecute);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExecute;
        private TextBox textBoxMax;
        private TextBox textBoxMin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelRandom;
        private Button buttonFib;
        private Label labelFib;
        private TextBox textBoxFib;
        private Label label4;
        private Label label5;
        private Button buttonPause;
        private Button buttonFibStop;
        private Button buttonStop;
        private Button buttonPauseFib;
    }
}