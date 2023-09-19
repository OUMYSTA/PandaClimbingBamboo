namespace Panda
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnBack = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerclick = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayerattack = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayereat = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayergameover = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayermove = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerclick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerattack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayereat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayergameover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayermove)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(6)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Option";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sound Game";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "50%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "50%";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(285, 229);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(349, 56);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = 50;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sound Effect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sound Music";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(285, 104);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(349, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::Panda.Properties.Resources.return_50px;
            this.btnBack.Location = new System.Drawing.Point(42, 521);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 67);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // axWindowsMediaPlayerclick
            // 
            this.axWindowsMediaPlayerclick.Enabled = true;
            this.axWindowsMediaPlayerclick.Location = new System.Drawing.Point(131, 94);
            this.axWindowsMediaPlayerclick.Name = "axWindowsMediaPlayerclick";
            this.axWindowsMediaPlayerclick.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerclick.OcxState")));
            this.axWindowsMediaPlayerclick.Size = new System.Drawing.Size(70, 19);
            this.axWindowsMediaPlayerclick.TabIndex = 5;
            // 
            // axWindowsMediaPlayerattack
            // 
            this.axWindowsMediaPlayerattack.Enabled = true;
            this.axWindowsMediaPlayerattack.Location = new System.Drawing.Point(230, 94);
            this.axWindowsMediaPlayerattack.Name = "axWindowsMediaPlayerattack";
            this.axWindowsMediaPlayerattack.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerattack.OcxState")));
            this.axWindowsMediaPlayerattack.Size = new System.Drawing.Size(70, 19);
            this.axWindowsMediaPlayerattack.TabIndex = 6;
            // 
            // axWindowsMediaPlayereat
            // 
            this.axWindowsMediaPlayereat.Enabled = true;
            this.axWindowsMediaPlayereat.Location = new System.Drawing.Point(338, 94);
            this.axWindowsMediaPlayereat.Name = "axWindowsMediaPlayereat";
            this.axWindowsMediaPlayereat.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayereat.OcxState")));
            this.axWindowsMediaPlayereat.Size = new System.Drawing.Size(70, 19);
            this.axWindowsMediaPlayereat.TabIndex = 7;
            // 
            // axWindowsMediaPlayergameover
            // 
            this.axWindowsMediaPlayergameover.Enabled = true;
            this.axWindowsMediaPlayergameover.Location = new System.Drawing.Point(428, 94);
            this.axWindowsMediaPlayergameover.Name = "axWindowsMediaPlayergameover";
            this.axWindowsMediaPlayergameover.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayergameover.OcxState")));
            this.axWindowsMediaPlayergameover.Size = new System.Drawing.Size(70, 19);
            this.axWindowsMediaPlayergameover.TabIndex = 8;
            // 
            // axWindowsMediaPlayermove
            // 
            this.axWindowsMediaPlayermove.Enabled = true;
            this.axWindowsMediaPlayermove.Location = new System.Drawing.Point(518, 94);
            this.axWindowsMediaPlayermove.Name = "axWindowsMediaPlayermove";
            this.axWindowsMediaPlayermove.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayermove.OcxState")));
            this.axWindowsMediaPlayermove.Size = new System.Drawing.Size(70, 19);
            this.axWindowsMediaPlayermove.TabIndex = 9;
            // 
            // Options
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Panda.Properties.Resources.game;
            this.ClientSize = new System.Drawing.Size(846, 600);
            this.Controls.Add(this.axWindowsMediaPlayermove);
            this.Controls.Add(this.axWindowsMediaPlayergameover);
            this.Controls.Add(this.axWindowsMediaPlayereat);
            this.Controls.Add(this.axWindowsMediaPlayerattack);
            this.Controls.Add(this.axWindowsMediaPlayerclick);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerclick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerattack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayereat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayergameover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayermove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerclick;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerattack;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayereat;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayergameover;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayermove;
    }
}