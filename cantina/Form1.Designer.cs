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

        private Button GetButtonFinalizar()
        {
            return buttonFinalizar;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            listBox1 = new ListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            listBox2 = new ListBox();
            label2 = new Label();
            lblTotal = new Label();
            buttonFinalizar = new Button();
            dateTimePicker2 = new DateTimePicker();
            numericQuant = new NumericUpDown();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericQuant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(29, 115);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Produtos Cantina";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(202, 196, 183);
            listBox1.Font = new Font("Microsoft JhengHei", 11.25F);
            listBox1.ForeColor = Color.Black;
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
            btnAdicionar.BackColor = Color.FromArgb(17, 25, 12);
            btnAdicionar.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.FromArgb(230, 255, 0);
            btnAdicionar.Location = new Point(29, 291);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(104, 36);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar >";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(17, 25, 12);
            btnRemover.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.FromArgb(230, 255, 0);
            btnRemover.Location = new Point(402, 291);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(107, 36);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "< Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(202, 196, 183);
            listBox2.Font = new Font("Microsoft JhengHei", 11.25F);
            listBox2.ForeColor = Color.Black;
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
            label2.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(298, 115);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "Carrinho";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Agrandir Semi Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(29, 374);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 28);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "TOTAL :";
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.BackColor = Color.FromArgb(17, 25, 12);
            buttonFinalizar.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFinalizar.ForeColor = Color.FromArgb(230, 255, 0);
            buttonFinalizar.Location = new Point(344, 462);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(165, 36);
            buttonFinalizar.TabIndex = 6;
            buttonFinalizar.Text = "Finalizar pedido";
            buttonFinalizar.UseVisualStyleBackColor = false;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(430, 504);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(79, 23);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.Value = new DateTime(2025, 5, 12, 9, 0, 52, 0);
            // 
            // numericQuant
            // 
            numericQuant.BackColor = Color.DarkGray;
            numericQuant.Location = new Point(29, 243);
            numericQuant.Name = "numericQuant";
            numericQuant.Size = new Size(104, 23);
            numericQuant.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(29, 220);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 13;
            label3.Text = "Quantidade";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(202, 193, 183);
            textBox1.Location = new Point(740, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(670, 140);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 15;
            label4.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
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
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(670, 225);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 19;
            label6.Text = "Valor";
            label6.Visible = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gray;
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(740, 260);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(107, 23);
            textBox3.TabIndex = 21;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(670, 263);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 22;
            label7.Text = "Troco";
            label7.Visible = false;
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(17, 25, 12);
            button2.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(230, 255, 0);
            button2.Location = new Point(740, 336);
            button2.Name = "button2";
            button2.Size = new Size(201, 35);
            button2.TabIndex = 23;
            button2.Text = "Mandar para o balcão ";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(202, 196, 183);
            textBox2.Location = new Point(740, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(107, 23);
            textBox2.TabIndex = 25;
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(202, 196, 183);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(740, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 23);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 559);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(numericQuant);
            Controls.Add(dateTimePicker2);
            Controls.Add(lblTotal);
            Controls.Add(buttonFinalizar);
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
        private Button buttonFinalizar;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericQuant;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private Button button2;
        private TextBox textBox2;
        private ComboBox comboBox1;
    }
}
