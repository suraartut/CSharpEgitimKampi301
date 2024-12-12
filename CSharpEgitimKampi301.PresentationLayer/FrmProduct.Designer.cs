namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmProduct
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
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProdDescrip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnList2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(72, 392);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(170, 32);
            this.btnGetById.TabIndex = 25;
            this.btnGetById.Text = "ID\'ye Göre Getir";
            this.btnGetById.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(72, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 32);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(72, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 32);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(72, 278);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(170, 32);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Ekle";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(72, 38);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(170, 20);
            this.txtProdName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ürün Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 412);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(72, 240);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(81, 32);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(72, 12);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(170, 20);
            this.txtProdId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ürün ID:";
            // 
            // txtProdStok
            // 
            this.txtProdStok.Location = new System.Drawing.Point(72, 64);
            this.txtProdStok.Name = "txtProdStok";
            this.txtProdStok.Size = new System.Drawing.Size(170, 20);
            this.txtProdStok.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ürün Stok:";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Location = new System.Drawing.Point(72, 90);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(170, 20);
            this.txtProdPrice.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ürün Fiyatı:";
            // 
            // txtProdDescrip
            // 
            this.txtProdDescrip.Location = new System.Drawing.Point(72, 143);
            this.txtProdDescrip.Multiline = true;
            this.txtProdDescrip.Name = "txtProdDescrip";
            this.txtProdDescrip.Size = new System.Drawing.Size(170, 91);
            this.txtProdDescrip.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Kategori:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(72, 116);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(170, 21);
            this.cmbCategory.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Açıklama:";
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(161, 240);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(81, 32);
            this.btnList2.TabIndex = 34;
            this.btnList2.Text = "Listele2";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(869, 435);
            this.Controls.Add(this.btnList2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtProdDescrip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProdStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtProdId);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProdDescrip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnList2;
    }
}