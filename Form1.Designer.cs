namespace CSharp_Hinhtron1
{
    partial class Form1
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
            this.btndientich = new System.Windows.Forms.Button();
            this.cbdientich = new System.Windows.Forms.CheckBox();
            this.lblbankinh = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbchuvi = new System.Windows.Forms.CheckBox();
            this.btnloai1 = new System.Windows.Forms.Button();
            this.btnloai2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndientich
            // 
            this.btndientich.Location = new System.Drawing.Point(142, 276);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(91, 23);
            this.btndientich.TabIndex = 0;
            this.btndientich.Text = "Tính Diện Tích";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbdientich
            // 
            this.cbdientich.AutoSize = true;
            this.cbdientich.Location = new System.Drawing.Point(6, 31);
            this.cbdientich.Name = "cbdientich";
            this.cbdientich.Size = new System.Drawing.Size(100, 17);
            this.cbdientich.TabIndex = 1;
            this.cbdientich.Text = "Tính Diện Tích";
            this.cbdientich.UseVisualStyleBackColor = true;
            // 
            // lblbankinh
            // 
            this.lblbankinh.AutoSize = true;
            this.lblbankinh.Location = new System.Drawing.Point(114, 140);
            this.lblbankinh.Name = "lblbankinh";
            this.lblbankinh.Size = new System.Drawing.Size(52, 13);
            this.lblbankinh.TabIndex = 2;
            this.lblbankinh.Text = "Bán Kính";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(194, 176);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 3;
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Location = new System.Drawing.Point(9, 30);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(99, 17);
            this.rdbdientich.TabIndex = 4;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "Tính Diện Tích";
            this.rdbdientich.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbchuvi);
            this.groupBox1.Controls.Add(this.rdbdientich);
            this.groupBox1.Location = new System.Drawing.Point(435, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 104);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Chức Năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kết quả";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(114, 231);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(44, 13);
            this.lblkq.TabIndex = 7;
            this.lblkq.Text = "Kết quả";
            // 
            // txtbankinh
            // 
            this.txtbankinh.Location = new System.Drawing.Point(194, 140);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(100, 20);
            this.txtbankinh.TabIndex = 9;
            // 
            // btnchuvi
            // 
            this.btnchuvi.Location = new System.Drawing.Point(278, 276);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(75, 23);
            this.btnchuvi.TabIndex = 10;
            this.btnchuvi.Text = "Tính Chu Vi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(257, 342);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Location = new System.Drawing.Point(6, 62);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(82, 17);
            this.rdbchuvi.TabIndex = 5;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "Tính Chu Vi";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbchuvi);
            this.groupBox2.Controls.Add(this.cbdientich);
            this.groupBox2.Location = new System.Drawing.Point(600, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 104);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Chức Năng";
            // 
            // cbchuvi
            // 
            this.cbchuvi.AutoSize = true;
            this.cbchuvi.Location = new System.Drawing.Point(6, 62);
            this.cbchuvi.Name = "cbchuvi";
            this.cbchuvi.Size = new System.Drawing.Size(83, 17);
            this.cbchuvi.TabIndex = 2;
            this.cbchuvi.Text = "Tính Chu Vi";
            this.cbchuvi.UseVisualStyleBackColor = true;
            // 
            // btnloai1
            // 
            this.btnloai1.Location = new System.Drawing.Point(448, 254);
            this.btnloai1.Name = "btnloai1";
            this.btnloai1.Size = new System.Drawing.Size(75, 23);
            this.btnloai1.TabIndex = 12;
            this.btnloai1.Text = "Tính loại 1";
            this.btnloai1.UseVisualStyleBackColor = true;
            this.btnloai1.Click += new System.EventHandler(this.btnloai1_Click);
            // 
            // btnloai2
            // 
            this.btnloai2.Location = new System.Drawing.Point(631, 254);
            this.btnloai2.Name = "btnloai2";
            this.btnloai2.Size = new System.Drawing.Size(75, 23);
            this.btnloai2.TabIndex = 13;
            this.btnloai2.Text = "Tính loại 2";
            this.btnloai2.UseVisualStyleBackColor = true;
            this.btnloai2.Click += new System.EventHandler(this.btnloai2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnloai2);
            this.Controls.Add(this.btnloai1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.txtbankinh);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.lblbankinh);
            this.Controls.Add(this.btndientich);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.CheckBox cbdientich;
        private System.Windows.Forms.Label lblbankinh;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbchuvi;
        private System.Windows.Forms.Button btnloai1;
        private System.Windows.Forms.Button btnloai2;
    }
}

