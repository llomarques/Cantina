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
            ((System.ComponentModel.ISupportInitialize)numericQuant).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei", 11.25F);
            label1.Location = new Point(149, 148);
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
            listBox1.Location = new Point(149, 170);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 80);
            listBox1.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Microsoft JhengHei", 11.25F);
            btnAdicionar.Location = new Point(310, 316);
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
            btnRemover.Location = new Point(469, 316);
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
            listBox2.Location = new Point(502, 170);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(211, 80);
            listBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft JhengHei", 11.25F);
            label2.Location = new Point(502, 148);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 5;
            label2.Text = "Carrinho";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(310, 417);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(89, 26);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "TOTAL :";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Microsoft JhengHei", 11.25F);
            button1.Location = new Point(703, 466);
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
            dateTimePicker1.Location = new Point(65, 524);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(278, 527);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.Value = new DateTime(2025, 5, 12, 9, 0, 52, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // numericQuant
            // 
            numericQuant.Location = new Point(191, 335);
            numericQuant.Name = "numericQuant";
            numericQuant.Size = new Size(104, 23);
            numericQuant.TabIndex = 11;
            numericQuant.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(993, 559);
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
    }
}
