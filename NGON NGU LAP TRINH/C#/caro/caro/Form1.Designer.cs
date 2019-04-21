namespace caro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnbanco = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.IP = new System.Windows.Forms.TextBox();
            this.btnIP = new System.Windows.Forms.Button();
            this.pbxo = new System.Windows.Forms.PictureBox();
            this.pclogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnbanco);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 541);
            this.panel1.TabIndex = 0;
            // 
            // pnbanco
            // 
            this.pnbanco.Location = new System.Drawing.Point(3, 27);
            this.pnbanco.Name = "pnbanco";
            this.pnbanco.Size = new System.Drawing.Size(571, 483);
            this.pnbanco.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pclogo);
            this.panel3.Location = new System.Drawing.Point(576, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 314);
            this.panel3.TabIndex = 1;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Red;
            this.name.Location = new System.Drawing.Point(10, 5);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(176, 29);
            this.name.TabIndex = 2;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 33);
            this.progressBar1.TabIndex = 4;
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(10, 79);
            this.IP.Multiline = true;
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(176, 29);
            this.IP.TabIndex = 5;
            // 
            // btnIP
            // 
            this.btnIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIP.Location = new System.Drawing.Point(10, 116);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(176, 34);
            this.btnIP.TabIndex = 6;
            this.btnIP.Text = "LAN";
            this.btnIP.UseVisualStyleBackColor = true;
            // 
            // pbxo
            // 
            this.pbxo.Location = new System.Drawing.Point(195, 7);
            this.pbxo.Name = "pbxo";
            this.pbxo.Size = new System.Drawing.Size(134, 110);
            this.pbxo.TabIndex = 7;
            this.pbxo.TabStop = false;
            // 
            // pclogo
            // 
            this.pclogo.Image = global::caro.Properties.Resources._03;
            this.pclogo.Location = new System.Drawing.Point(4, 2);
            this.pclogo.Name = "pclogo";
            this.pclogo.Size = new System.Drawing.Size(333, 307);
            this.pclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pclogo.TabIndex = 0;
            this.pclogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.pbxo);
            this.panel2.Controls.Add(this.btnIP);
            this.panel2.Controls.Add(this.IP);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.name);
            this.panel2.Location = new System.Drawing.Point(576, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 167);
            this.panel2.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 520);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxo;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnbanco;
        private System.Windows.Forms.PictureBox pclogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    }
}

