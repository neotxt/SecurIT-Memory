namespace SecurIT_Memory
{
    partial class OptionForm
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
            this.rb4x4 = new System.Windows.Forms.RadioButton();
            this.rb6x6 = new System.Windows.Forms.RadioButton();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.White;
            this.lblInstruction.Location = new System.Drawing.Point(50, 40);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(434, 38);
            this.lblInstruction.TabIndex = 3;
            this.lblInstruction.Text = "Choisissez la taille de la grille :";
            // 
            // rb4x4
            // 
            this.rb4x4.AutoSize = true;
            this.rb4x4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb4x4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4x4.ForeColor = System.Drawing.Color.White;
            this.rb4x4.Location = new System.Drawing.Point(130, 110);
            this.rb4x4.Name = "rb4x4";
            this.rb4x4.Size = new System.Drawing.Size(221, 35);
            this.rb4x4.TabIndex = 0;
            this.rb4x4.TabStop = true;
            this.rb4x4.Text = "Grille 4x4 (Normal)";
            this.rb4x4.UseVisualStyleBackColor = true;
            // 
            // rb6x6
            // 
            this.rb6x6.AutoSize = true;
            this.rb6x6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb6x6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb6x6.ForeColor = System.Drawing.Color.White;
            this.rb6x6.Location = new System.Drawing.Point(130, 160);
            this.rb6x6.Name = "rb6x6";
            this.rb6x6.Size = new System.Drawing.Size(232, 35);
            this.rb6x6.TabIndex = 1;
            this.rb6x6.TabStop = true;
            this.rb6x6.Text = "Grille 6x6 (Difficile)";
            this.rb6x6.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(180, 240);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(200, 50);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(180, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "ANNULER";
            this.btnCancel.UseVisualStyleBackColor = false;
            // Magie ici : On ajoute l'action de fermeture (Cancel) directement dans le Designer
            this.btnCancel.Click += (s, e) => this.Close();
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(560, 380);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.rb6x6);
            this.Controls.Add(this.rb4x4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres de la partie";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb4x4;
        private System.Windows.Forms.RadioButton rb6x6;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInstruction;
    }
}