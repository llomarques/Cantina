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
            listEstoque = new ListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            lab = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listEstoque
            // 
            listEstoque.FormattingEnabled = true;
            listEstoque.ItemHeight = 15;
            listEstoque.Location = new Point(23, 81);
            listEstoque.Name = "listEstoque";
            listEstoque.Size = new Size(377, 184);
            listEstoque.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(641, 324);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(110, 32);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(641, 362);
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
            lab.Location = new Point(23, 50);
            lab.Name = "lab";
            lab.Size = new Size(72, 22);
            lab.TabIndex = 3;
            lab.Text = "Estoque ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(565, 345);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(46, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(698, 40);
            button1.Name = "button1";
            button1.Size = new Size(71, 32);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}