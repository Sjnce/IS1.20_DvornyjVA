namespace IS1._20_DvornyjVA
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.button3 = new System.Windows.Forms.Button();
            this.PRINT = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BillID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ProdDGV1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.ORDERDGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Amtlbl = new System.Windows.Forms.Label();
            this.SellerNamelbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(782, 542);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 56);
            this.button3.TabIndex = 26;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // PRINT
            // 
            this.PRINT.BackColor = System.Drawing.Color.MediumPurple;
            this.PRINT.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PRINT.Location = new System.Drawing.Point(651, 542);
            this.PRINT.Name = "PRINT";
            this.PRINT.Size = new System.Drawing.Size(125, 56);
            this.PRINT.TabIndex = 25;
            this.PRINT.Text = "Печать";
            this.PRINT.UseVisualStyleBackColor = false;
            this.PRINT.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumPurple;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.ProdPrice);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.ProdQty);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.ProdName);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.BillID);
            this.panel5.Location = new System.Drawing.Point(8, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 209);
            this.panel5.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 15.75F);
            this.label5.Location = new System.Drawing.Point(9, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Цена";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(167, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 5);
            this.panel4.TabIndex = 14;
            // 
            // ProdPrice
            // 
            this.ProdPrice.Location = new System.Drawing.Point(167, 170);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(225, 20);
            this.ProdPrice.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 15.75F);
            this.label4.Location = new System.Drawing.Point(9, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(167, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 5);
            this.panel3.TabIndex = 11;
            // 
            // ProdQty
            // 
            this.ProdQty.Location = new System.Drawing.Point(167, 121);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(225, 20);
            this.ProdQty.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F);
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Наименование";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(167, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 5);
            this.panel1.TabIndex = 8;
            // 
            // ProdName
            // 
            this.ProdName.Location = new System.Drawing.Point(167, 70);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(225, 20);
            this.ProdName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F);
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(167, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 5);
            this.panel2.TabIndex = 5;
            // 
            // BillID
            // 
            this.BillID.Location = new System.Drawing.Point(167, 21);
            this.BillID.Name = "BillID";
            this.BillID.Size = new System.Drawing.Size(225, 20);
            this.BillID.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(535, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 56);
            this.button1.TabIndex = 24;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProdDGV1
            // 
            this.ProdDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV1.Location = new System.Drawing.Point(8, 288);
            this.ProdDGV1.Name = "ProdDGV1";
            this.ProdDGV1.Size = new System.Drawing.Size(304, 310);
            this.ProdDGV1.TabIndex = 27;
            this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Управление продажами";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(318, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 310);
            this.button4.TabIndex = 29;
            this.button4.Text = "Добавить продукт";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BillsDGV
            // 
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDGV.Location = new System.Drawing.Point(416, 356);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.Size = new System.Drawing.Size(574, 180);
            this.BillsDGV.TabIndex = 30;
            this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
            // 
            // ORDERDGV
            // 
            this.ORDERDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ORDERDGV.Location = new System.Drawing.Point(416, 73);
            this.ORDERDGV.Name = "ORDERDGV";
            this.ORDERDGV.Size = new System.Drawing.Size(574, 209);
            this.ORDERDGV.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(602, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 36);
            this.label7.TabIndex = 32;
            this.label7.Text = "Список продаж:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(620, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 36);
            this.label8.TabIndex = 33;
            this.label8.Text = "Сумма:";
            // 
            // Amtlbl
            // 
            this.Amtlbl.AutoSize = true;
            this.Amtlbl.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amtlbl.Location = new System.Drawing.Point(731, 282);
            this.Amtlbl.Name = "Amtlbl";
            this.Amtlbl.Size = new System.Drawing.Size(63, 36);
            this.Amtlbl.TabIndex = 34;
            this.Amtlbl.Text = "руб.";
            this.Amtlbl.Click += new System.EventHandler(this.label9_Click);
            // 
            // SellerNamelbl
            // 
            this.SellerNamelbl.AutoSize = true;
            this.SellerNamelbl.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerNamelbl.Location = new System.Drawing.Point(12, 9);
            this.SellerNamelbl.Name = "SellerNamelbl";
            this.SellerNamelbl.Size = new System.Drawing.Size(140, 36);
            this.SellerNamelbl.TabIndex = 35;
            this.SellerNamelbl.Text = "Продавец";
            // 
            // Datelbl
            // 
            this.Datelbl.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Datelbl.Location = new System.Drawing.Point(812, 11);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(178, 45);
            this.Datelbl.TabIndex = 36;
            this.Datelbl.Text = "Дата";
            this.Datelbl.Click += new System.EventHandler(this.Datelbl_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 606);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.SellerNamelbl);
            this.Controls.Add(this.Amtlbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ORDERDGV);
            this.Controls.Add(this.BillsDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PRINT);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProdDGV1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button PRINT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ProdQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox BillID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ProdDGV1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView BillsDGV;
        private System.Windows.Forms.DataGridView ORDERDGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Amtlbl;
        private System.Windows.Forms.Label SellerNamelbl;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}