namespace cantina
{
    partial class Balcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balcao));
            listbalcao = new ListBox();
            label1 = new Label();
            listentrega = new ListBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnEntregar = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listbalcao
            // 
            listbalcao.BackColor = Color.FromArgb(202, 196, 183);
            listbalcao.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbalcao.FormattingEnabled = true;
            listbalcao.ItemHeight = 17;
            listbalcao.Location = new Point(12, 118);
            listbalcao.Name = "listbalcao";
            listbalcao.Size = new Size(380, 208);
            listbalcao.TabIndex = 0;
            listbalcao.SelectedIndexChanged += listbalcao_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(21, 95);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Pedidos Balcão";
            // 
            // listentrega
            // 
            listentrega.BackColor = Color.FromArgb(202, 196, 183);
            listentrega.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listentrega.FormattingEnabled = true;
            listentrega.ItemHeight = 17;
            listentrega.Location = new Point(398, 118);
            listentrega.Name = "listentrega";
            listentrega.Size = new Size(380, 208);
            listentrega.TabIndex = 2;
            listentrega.SelectedIndexChanged += listentrega_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(398, 95);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Entregues ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnEntregar
            // 
            btnEntregar.BackColor = Color.FromArgb(17, 25, 12);
            btnEntregar.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntregar.ForeColor = Color.FromArgb(230, 255, 0);
            btnEntregar.Location = new Point(674, 372);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(104, 36);
            btnEntregar.TabIndex = 14;
            btnEntregar.Text = "Entregar ";
            btnEntregar.UseVisualStyleBackColor = false;
            btnEntregar.Click += btnEntregar_Click_1;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(17, 25, 12);
            btnVoltar.Font = new Font("Inter ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.FromArgb(230, 255, 0);
            btnVoltar.Location = new Point(21, 372);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(54, 39);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "←";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnEntregar);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(listentrega);
            Controls.Add(label1);
            Controls.Add(listbalcao);
            Name = "Balcao";
            Text = "Form2";
            Load += Balcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbalcao;
        private Label label1;
        private ListBox listentrega;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnEntregar;
        private Button btnVoltar;
    }
}