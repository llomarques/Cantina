namespace cantina
{
    partial class Cozinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cozinha));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            listCozinha = new ListBox();
            btnPronto = new Button();
            btnHome = new Button();
            btnBalcao = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(24, 95);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Pedidos Cozinha";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // listCozinha
            // 
            listCozinha.BackColor = Color.FromArgb(202, 196, 183);
            listCozinha.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listCozinha.FormattingEnabled = true;
            listCozinha.ItemHeight = 17;
            listCozinha.Location = new Point(24, 118);
            listCozinha.Name = "listCozinha";
            listCozinha.Size = new Size(446, 174);
            listCozinha.TabIndex = 15;
            // 
            // btnPronto
            // 
            btnPronto.BackColor = Color.FromArgb(17, 25, 12);
            btnPronto.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPronto.ForeColor = Color.FromArgb(230, 255, 0);
            btnPronto.Location = new Point(673, 394);
            btnPronto.Name = "btnPronto";
            btnPronto.Size = new Size(94, 35);
            btnPronto.TabIndex = 16;
            btnPronto.Text = "Pronto";
            btnPronto.UseVisualStyleBackColor = false;
            btnPronto.Click += btnPronto_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(230, 255, 0);
            btnHome.Font = new Font("Inter Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(723, 40);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(44, 36);
            btnHome.TabIndex = 17;
            btnHome.Text = "🏠︎";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnBalcao
            // 
            btnBalcao.BackColor = Color.FromArgb(17, 25, 12);
            btnBalcao.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBalcao.ForeColor = Color.FromArgb(230, 255, 0);
            btnBalcao.Location = new Point(673, 353);
            btnBalcao.Name = "btnBalcao";
            btnBalcao.Size = new Size(94, 35);
            btnBalcao.TabIndex = 24;
            btnBalcao.Text = "Balcão ";
            btnBalcao.UseVisualStyleBackColor = false;
            btnBalcao.Click += button2_Click;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(800, 450);
            Controls.Add(btnBalcao);
            Controls.Add(btnHome);
            Controls.Add(btnPronto);
            Controls.Add(listCozinha);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Cozinha";
            Text = "Cozinha";
            Load += Cozinha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ListBox listCozinha;
        private Button btnPronto;
        private Button btnHome;
        private Button btnBalcao;
    }
}