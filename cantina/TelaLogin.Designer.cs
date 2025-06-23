namespace cantina
{
    partial class TelaLogin
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
            txtlogin = new TextBox();
            txtsenha = new TextBox();
            btnEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtlogin
            // 
            txtlogin.Location = new Point(251, 170);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(277, 23);
            txtlogin.TabIndex = 0;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(251, 217);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(277, 23);
            txtsenha.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(230, 255, 0);
            btnEntrar.Location = new Point(329, 299);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(134, 29);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Semi Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(230, 255, 0);
            label1.Location = new Point(362, 125);
            label1.Name = "label1";
            label1.Size = new Size(49, 22);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(230, 255, 0);
            label2.Location = new Point(197, 175);
            label2.Name = "label2";
            label2.Size = new Size(42, 18);
            label2.TabIndex = 4;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(230, 255, 0);
            label3.Location = new Point(197, 222);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            label3.Click += label3_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(txtsenha);
            Controls.Add(txtlogin);
            Name = "TelaLogin";
            Text = "TelaLogin";
            Load += TelaLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtlogin;
        private TextBox txtsenha;
        private Button btnEntrar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}