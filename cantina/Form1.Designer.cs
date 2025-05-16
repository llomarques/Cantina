namespace cantina
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
            label1 = new Label();
            listBox1 = new ListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            listBox2 = new ListBox();
            label2 = new Label();
            lblTotal = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            numericQuant = new NumericUpDown();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox3 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericQuant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei", 11.25F);
            label1.Location = new Point(29, 115);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 0;
            label1.Text = "Produtos Cantina";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft JhengHei", 11.25F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(29, 137);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 80);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Microsoft JhengHei", 11.25F);
            btnAdicionar.Location = new Point(29, 291);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(103, 55);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar >";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Microsoft JhengHei", 11.25F);
            btnRemover.Location = new Point(406, 291);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(103, 55);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "< Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Microsoft JhengHei", 11.25F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 19;
            listBox2.Location = new Point(298, 137);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(211, 80);
            listBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei", 11.25F);
            label2.Location = new Point(298, 115);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 5;
            label2.Text = "Carrinho";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Agrandir Semi Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(29, 374);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 28);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "TOTAL :";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Microsoft JhengHei", 11.25F);
            button1.Location = new Point(307, 450);
            button1.Name = "button1";
            button1.Size = new Size(202, 48);
            button1.TabIndex = 6;
            button1.Text = "Finalizar pedido";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(12, 450);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(79, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(12, 479);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(79, 23);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.Value = new DateTime(2025, 5, 12, 9, 0, 52, 0);
            // 
            // numericQuant
            // 
            numericQuant.Location = new Point(29, 243);
            numericQuant.Name = "numericQuant";
            numericQuant.Size = new Size(104, 23);
            numericQuant.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(29, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(29, 220);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 13;
            label3.Text = "Quantidade";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(740, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(670, 140);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 15;
            label4.Text = "Nome";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(741, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(670, 182);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 17;
            label5.Text = "Método";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(670, 225);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 19;
            label6.Text = "Valor";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(740, 222);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(106, 23);
            numericUpDown1.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(740, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(107, 23);
            textBox3.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(670, 263);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 22;
            label7.Text = "Troco";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.Location = new Point(770, 334);
            button2.Name = "button2";
            button2.Size = new Size(142, 41);
            button2.TabIndex = 23;
            button2.Text = "Mandar para o balcão ";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 559);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(numericQuant);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblTotal);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listBox1);
            Controls.Add(label1);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericQuant).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button btnAdicionar;
        private Button btnRemover;
        private ListBox listBox2;
        private Label label2;
        private Label lblTotal;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericQuant;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private Label label7;
        private Button button2;
    }
}
