namespace SecurIT_Memory
{
    partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblChronos = new System.Windows.Forms.Label();
            this.lblEssais = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChronos
            // 
            this.lblChronos.AutoSize = true;
            this.lblChronos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChronos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.lblChronos.Location = new System.Drawing.Point(30, 30);
            this.lblChronos.Name = "lblChronos";
            this.lblChronos.Size = new System.Drawing.Size(222, 41);
            this.lblChronos.TabIndex = 0;
            this.lblChronos.Text = "Temps : 00:00";
            // 
            // lblEssais
            // 
            this.lblEssais.AutoSize = true;
            this.lblEssais.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEssais.ForeColor = System.Drawing.Color.White;
            this.lblEssais.Location = new System.Drawing.Point(30, 80);
            this.lblEssais.Name = "lblEssais";
            this.lblEssais.Size = new System.Drawing.Size(147, 41);
            this.lblEssais.TabIndex = 1;
            this.lblEssais.Text = "Essais : 0";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMenu.FlatAppearance.BorderSize = 0;
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(30, 140);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(150, 40);
            this.btnBackToMenu.TabIndex = 2;
            this.btnBackToMenu.Text = "↩ MENU";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblEssais);
            this.Controls.Add(this.lblChronos);
            this.Name = "GameForm";
            this.Text = "SecurIT Memory - Jeu";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChronos;
        private System.Windows.Forms.Label lblEssais;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}