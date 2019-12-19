namespace Praktika_2
{
    partial class Registruotis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.patvirtinti = new System.Windows.Forms.Button();
            this.slaptazodis = new System.Windows.Forms.TextBox();
            this.prisijungVardas = new System.Windows.Forms.TextBox();
            this.pavarde = new System.Windows.Forms.TextBox();
            this.vardas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patvirtinti);
            this.groupBox1.Controls.Add(this.slaptazodis);
            this.groupBox1.Controls.Add(this.prisijungVardas);
            this.groupBox1.Controls.Add(this.pavarde);
            this.groupBox1.Controls.Add(this.vardas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Naudotojo duomenys";
            // 
            // patvirtinti
            // 
            this.patvirtinti.Location = new System.Drawing.Point(359, 250);
            this.patvirtinti.Name = "patvirtinti";
            this.patvirtinti.Size = new System.Drawing.Size(148, 30);
            this.patvirtinti.TabIndex = 9;
            this.patvirtinti.Text = "Patvirtinti";
            this.patvirtinti.UseVisualStyleBackColor = true;
            this.patvirtinti.Click += new System.EventHandler(this.patvirtinti_Click);
            // 
            // slaptazodis
            // 
            this.slaptazodis.Location = new System.Drawing.Point(167, 183);
            this.slaptazodis.Name = "slaptazodis";
            this.slaptazodis.PasswordChar = '•';
            this.slaptazodis.Size = new System.Drawing.Size(148, 22);
            this.slaptazodis.TabIndex = 7;
            // 
            // prisijungVardas
            // 
            this.prisijungVardas.Location = new System.Drawing.Point(167, 139);
            this.prisijungVardas.Name = "prisijungVardas";
            this.prisijungVardas.Size = new System.Drawing.Size(148, 22);
            this.prisijungVardas.TabIndex = 6;
            // 
            // pavarde
            // 
            this.pavarde.Location = new System.Drawing.Point(167, 99);
            this.pavarde.Name = "pavarde";
            this.pavarde.Size = new System.Drawing.Size(148, 22);
            this.pavarde.TabIndex = 5;
            // 
            // vardas
            // 
            this.vardas.Location = new System.Drawing.Point(167, 53);
            this.vardas.Name = "vardas";
            this.vardas.Size = new System.Drawing.Size(148, 22);
            this.vardas.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prisijungimo vardas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Slaptažodis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pavardė:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vardas:";
            // 
            // Registruotis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 310);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registruotis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox slaptazodis;
        private System.Windows.Forms.TextBox prisijungVardas;
        private System.Windows.Forms.TextBox pavarde;
        private System.Windows.Forms.TextBox vardas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button patvirtinti;
    }
}