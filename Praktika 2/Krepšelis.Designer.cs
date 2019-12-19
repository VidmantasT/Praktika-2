namespace Praktika_2
{
    partial class Krepšelis
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
            this.pasirinkite = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backToProducts = new System.Windows.Forms.Button();
            this.krepselisListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.moketi = new System.Windows.Forms.Label();
            this.pirkti = new System.Windows.Forms.Button();
            this.istrintiProdukta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pasirinkite
            // 
            this.pasirinkite.AutoSize = true;
            this.pasirinkite.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasirinkite.Location = new System.Drawing.Point(7, 9);
            this.pasirinkite.Name = "pasirinkite";
            this.pasirinkite.Size = new System.Drawing.Size(245, 28);
            this.pasirinkite.TabIndex = 6;
            this.pasirinkite.Text = "Produktai krepšelyje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mokėti:";
            // 
            // backToProducts
            // 
            this.backToProducts.Location = new System.Drawing.Point(12, 359);
            this.backToProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backToProducts.Name = "backToProducts";
            this.backToProducts.Size = new System.Drawing.Size(149, 36);
            this.backToProducts.TabIndex = 17;
            this.backToProducts.Text = "Grįžti į produktus";
            this.backToProducts.UseVisualStyleBackColor = true;
            this.backToProducts.Click += new System.EventHandler(this.backToProducts_Click);
            // 
            // krepselisListview
            // 
            this.krepselisListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.krepselisListview.FullRowSelect = true;
            this.krepselisListview.HideSelection = false;
            this.krepselisListview.Location = new System.Drawing.Point(12, 39);
            this.krepselisListview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.krepselisListview.Name = "krepselisListview";
            this.krepselisListview.Size = new System.Drawing.Size(468, 180);
            this.krepselisListview.TabIndex = 18;
            this.krepselisListview.UseCompatibleStateImageBehavior = false;
            this.krepselisListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pavadinimas";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Atmintis";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Spalva";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kaina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 19;
            // 
            // moketi
            // 
            this.moketi.AutoSize = true;
            this.moketi.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moketi.Location = new System.Drawing.Point(115, 223);
            this.moketi.Name = "moketi";
            this.moketi.Size = new System.Drawing.Size(25, 28);
            this.moketi.TabIndex = 20;
            this.moketi.Text = "0";
            // 
            // pirkti
            // 
            this.pirkti.Location = new System.Drawing.Point(331, 360);
            this.pirkti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pirkti.Name = "pirkti";
            this.pirkti.Size = new System.Drawing.Size(149, 36);
            this.pirkti.TabIndex = 21;
            this.pirkti.Text = "Pateikti užsakymą";
            this.pirkti.UseVisualStyleBackColor = true;
            this.pirkti.Click += new System.EventHandler(this.pirkti_Click);
            // 
            // istrintiProdukta
            // 
            this.istrintiProdukta.Location = new System.Drawing.Point(331, 223);
            this.istrintiProdukta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.istrintiProdukta.Name = "istrintiProdukta";
            this.istrintiProdukta.Size = new System.Drawing.Size(149, 36);
            this.istrintiProdukta.TabIndex = 22;
            this.istrintiProdukta.Text = "Pašalinti";
            this.istrintiProdukta.UseVisualStyleBackColor = true;
            this.istrintiProdukta.Click += new System.EventHandler(this.istrintiProdukta_Click);
            // 
            // Krepšelis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 407);
            this.Controls.Add(this.istrintiProdukta);
            this.Controls.Add(this.pirkti);
            this.Controls.Add(this.moketi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.krepselisListview);
            this.Controls.Add(this.backToProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pasirinkite);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Krepšelis";
            this.Text = "Krepšelis";
            this.Load += new System.EventHandler(this.Krepšelis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pasirinkite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backToProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ListView krepselisListview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moketi;
        private System.Windows.Forms.Button pirkti;
        private System.Windows.Forms.Button istrintiProdukta;
    }
}