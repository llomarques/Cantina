namespace cantina
{
    partial class TelaChamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaChamada));
            pictureBox1 = new PictureBox();
            labelNome = new Label();
            lblNome = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(332, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(363, 241);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(57, 23);
            labelNome.TabIndex = 16;
            labelNome.Text = "Nome";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Agrandir Semi Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(218, 148);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(370, 28);
            lblNome.TabIndex = 17;
            lblNome.Text = "PRODUTO PRONTO PARA RETIRADA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 318);
            label1.Name = "label1";
            label1.Size = new Size(273, 20);
            label1.TabIndex = 18;
            label1.Text = "AGRADECEMOS PELA PREFERÊNCIA !!";
            // 
            // TelaChamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblNome);
            Controls.Add(labelNome);
            Controls.Add(pictureBox1);
            Name = "TelaChamada";
            Text = "TelaChamada";
            Load += TelaChamada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelNome;
        private Label lblNome;
        private Label label1;
    }
}