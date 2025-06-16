namespace cantina
{
    partial class TelaEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstoque));
            listEstoque = new ListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            lab = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listEstoque
            // 
            listEstoque.FormattingEnabled = true;
            listEstoque.ItemHeight = 15;
            listEstoque.Location = new Point(12, 146);
            listEstoque.Name = "listEstoque";
            listEstoque.Size = new Size(702, 184);
            listEstoque.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(84, 350);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(110, 32);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(84, 403);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(109, 35);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab.Location = new Point(12, 103);
            lab.Name = "lab";
            lab.Size = new Size(72, 22);
            lab.TabIndex = 3;
            lab.Text = "Estoque ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 350);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(46, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(601, 403);
            button1.Name = "button1";
            button1.Size = new Size(113, 32);
            button1.TabIndex = 6;
            button1.Text = "Fazer pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // TelaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(lab);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listEstoque);
            Name = "TelaEstoque";
            Text = "TelaEstoque";
            Load += TelaEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listEstoque;
        private Button btnAdicionar;
        private Button btnRemover;
        private Label lab;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}