﻿namespace cantina
{
    partial class TelaVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVendas));
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
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            btnCozinha = new Button();
            btnEstoque = new Button();
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
            listBox1.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(29, 137);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(375, 112);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdicionar.BackColor = Color.FromArgb(17, 25, 12);
            btnAdicionar.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.FromArgb(230, 255, 0);
            btnAdicionar.Location = new Point(410, 172);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(79, 34);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar ";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(17, 25, 12);
            btnRemover.Font = new Font("Inter Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.FromArgb(230, 255, 0);
            btnRemover.Location = new Point(410, 209);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(79, 36);
            btnRemover.TabIndex = 3;
            btnRemover.Text = " Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(202, 196, 183);
            listBox2.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.ForeColor = Color.Black;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(29, 291);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(375, 106);
            listBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(29, 268);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "Carrinho";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Agrandir Semi Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(411, 375);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(66, 22);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "TOTAL :";
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.BackColor = Color.FromArgb(17, 25, 12);
            buttonFinalizar.Font = new Font("Inter SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFinalizar.ForeColor = Color.FromArgb(230, 255, 0);
            buttonFinalizar.Location = new Point(29, 403);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(152, 40);
            buttonFinalizar.TabIndex = 6;
            buttonFinalizar.Text = "Finalizar pedido";
            buttonFinalizar.UseVisualStyleBackColor = false;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(187, 411);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(79, 23);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.Value = new DateTime(2025, 5, 12, 9, 0, 52, 0);
            // 
            // numericQuant
            // 
            numericQuant.BackColor = Color.DarkGray;
            numericQuant.Location = new Point(495, 179);
            numericQuant.Name = "numericQuant";
            numericQuant.Size = new Size(57, 23);
            numericQuant.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(202, 193, 183);
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox1.Location = new Point(740, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(670, 175);
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
            label5.Location = new Point(670, 209);
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
            label6.Location = new Point(675, 247);
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
            textBox3.Location = new Point(740, 282);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(107, 23);
            textBox3.TabIndex = 21;
            textBox3.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(675, 285);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 22;
            label7.Text = "Troco";
            label7.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(17, 25, 12);
            button2.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(230, 255, 0);
            button2.Location = new Point(703, 481);
            button2.Name = "button2";
            button2.Size = new Size(86, 35);
            button2.TabIndex = 23;
            button2.Text = "Balcão ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonBalcao_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(202, 196, 183);
            textBox2.Location = new Point(740, 244);
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
            comboBox1.Location = new Point(740, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Agrandir Semi Narrow", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(410, 143);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 20);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Viagem";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnCozinha
            // 
            btnCozinha.BackColor = Color.FromArgb(17, 25, 12);
            btnCozinha.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCozinha.ForeColor = Color.FromArgb(230, 255, 0);
            btnCozinha.Location = new Point(795, 480);
            btnCozinha.Name = "btnCozinha";
            btnCozinha.Size = new Size(88, 35);
            btnCozinha.TabIndex = 28;
            btnCozinha.Text = "Cozinha ";
            btnCozinha.UseVisualStyleBackColor = false;
            btnCozinha.Click += btnCozinha_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.FromArgb(17, 25, 12);
            btnEstoque.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstoque.ForeColor = Color.FromArgb(230, 255, 0);
            btnEstoque.Location = new Point(611, 482);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(86, 35);
            btnEstoque.TabIndex = 29;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += button1_Click;
            // 
            // TelaVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 559);
            Controls.Add(btnEstoque);
            Controls.Add(btnCozinha);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
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
            Name = "TelaVendas";
            Text = "Form1";
            Activated += TelaVendas_Activated;
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
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private Button button2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private Button btnCozinha;
        private Button btnEstoque;
    }
}
