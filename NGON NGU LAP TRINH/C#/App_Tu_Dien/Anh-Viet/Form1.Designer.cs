namespace Anh_Viet
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
            this.CBEng = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBVN = new System.Windows.Forms.TextBox();
            this.TBMT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eng = new System.Windows.Forms.TextBox();
            this.vn = new System.Windows.Forms.TextBox();
            this.MT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.them = new System.Windows.Forms.Button();
            this.pnCB = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnNghia = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnthem = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnCB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnNghia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnthem.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBEng
            // 
            this.CBEng.AllowDrop = true;
            this.CBEng.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBEng.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBEng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBEng.Location = new System.Drawing.Point(8, 37);
            this.CBEng.Name = "CBEng";
            this.CBEng.Size = new System.Drawing.Size(215, 384);
            this.CBEng.TabIndex = 0;
            this.CBEng.SelectedIndexChanged += new System.EventHandler(this.CBEng_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TỪ ĐIỂN ANH VIỆT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Mistral", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(349, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đổ Trọng Hảo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(258, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "---------------------------------------------------------------------------------" +
                "--------------";
            // 
            // TBVN
            // 
            this.TBVN.Location = new System.Drawing.Point(6, 16);
            this.TBVN.Name = "TBVN";
            this.TBVN.Size = new System.Drawing.Size(506, 20);
            this.TBVN.TabIndex = 4;
            // 
            // TBMT
            // 
            this.TBMT.Location = new System.Drawing.Point(6, 52);
            this.TBMT.Multiline = true;
            this.TBMT.Name = "TBMT";
            this.TBMT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBMT.Size = new System.Drawing.Size(506, 164);
            this.TBMT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thêm Từ";
            // 
            // eng
            // 
            this.eng.Location = new System.Drawing.Point(11, 57);
            this.eng.Name = "eng";
            this.eng.Size = new System.Drawing.Size(140, 20);
            this.eng.TabIndex = 7;
            // 
            // vn
            // 
            this.vn.Location = new System.Drawing.Point(192, 56);
            this.vn.Name = "vn";
            this.vn.Size = new System.Drawing.Size(167, 20);
            this.vn.TabIndex = 8;
            // 
            // MT
            // 
            this.MT.Location = new System.Drawing.Point(11, 105);
            this.MT.Multiline = true;
            this.MT.Name = "MT";
            this.MT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MT.Size = new System.Drawing.Size(347, 57);
            this.MT.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "English";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vietnamese";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mô tả";
            // 
            // them
            // 
            this.them.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.them.FlatAppearance.BorderSize = 5;
            this.them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(391, 100);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(130, 62);
            this.them.TabIndex = 13;
            this.them.Text = "THÊM";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // pnCB
            // 
            this.pnCB.Controls.Add(this.pictureBox1);
            this.pnCB.Controls.Add(this.CBEng);
            this.pnCB.Location = new System.Drawing.Point(4, 55);
            this.pnCB.Name = "pnCB";
            this.pnCB.Size = new System.Drawing.Size(251, 434);
            this.pnCB.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Anh_Viet.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(224, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnNghia
            // 
            this.pnNghia.Controls.Add(this.pictureBox3);
            this.pnNghia.Controls.Add(this.pictureBox2);
            this.pnNghia.Controls.Add(this.TBMT);
            this.pnNghia.Controls.Add(this.TBVN);
            this.pnNghia.Location = new System.Drawing.Point(255, 76);
            this.pnNghia.Name = "pnNghia";
            this.pnNghia.Size = new System.Drawing.Size(547, 226);
            this.pnNghia.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Anh_Viet.Properties.Resources._1;
            this.pictureBox3.Location = new System.Drawing.Point(515, 187);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Anh_Viet.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(515, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnthem
            // 
            this.pnthem.Controls.Add(this.label8);
            this.pnthem.Controls.Add(this.them);
            this.pnthem.Controls.Add(this.label7);
            this.pnthem.Controls.Add(this.label6);
            this.pnthem.Controls.Add(this.label5);
            this.pnthem.Controls.Add(this.MT);
            this.pnthem.Controls.Add(this.vn);
            this.pnthem.Controls.Add(this.eng);
            this.pnthem.Controls.Add(this.label4);
            this.pnthem.Location = new System.Drawing.Point(264, 308);
            this.pnthem.Name = "pnthem";
            this.pnthem.Size = new System.Drawing.Size(537, 180);
            this.pnthem.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 482);
            this.Controls.Add(this.pnthem);
            this.Controls.Add(this.pnNghia);
            this.Controls.Add(this.pnCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnCB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnNghia.ResumeLayout(false);
            this.pnNghia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnthem.ResumeLayout(false);
            this.pnthem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBEng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBVN;
        private System.Windows.Forms.TextBox TBMT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eng;
        private System.Windows.Forms.TextBox vn;
        private System.Windows.Forms.TextBox MT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Panel pnCB;
        private System.Windows.Forms.Panel pnNghia;
        private System.Windows.Forms.Panel pnthem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
    }
}

