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
            listbalcao = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listbalcao
            // 
            listbalcao.BackColor = Color.FromArgb(202, 196, 183);
            listbalcao.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbalcao.FormattingEnabled = true;
            listbalcao.ItemHeight = 17;
            listbalcao.Location = new Point(12, 72);
            listbalcao.Name = "listbalcao";
            listbalcao.Size = new Size(428, 174);
            listbalcao.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agrandir Semi Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Pedidos Balcão";
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listbalcao);
            Name = "Balcao";
            Text = "Form2";
            Load += Balcao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbalcao;
        private Label label1;
    }
}