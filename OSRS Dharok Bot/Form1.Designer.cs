namespace OSRS_Dharok_Bot
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
            this.btn_alch = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_nmz = new System.Windows.Forms.Button();
            this.btn_guth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lb_clicked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_alch
            // 
            this.btn_alch.Location = new System.Drawing.Point(12, 12);
            this.btn_alch.Name = "btn_alch";
            this.btn_alch.Size = new System.Drawing.Size(69, 25);
            this.btn_alch.TabIndex = 0;
            this.btn_alch.Text = "High alch";
            this.btn_alch.UseVisualStyleBackColor = true;
            this.btn_alch.Click += new System.EventHandler(this.btn_alch_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(12, 178);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(137, 71);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_nmz
            // 
            this.btn_nmz.Location = new System.Drawing.Point(13, 44);
            this.btn_nmz.Name = "btn_nmz";
            this.btn_nmz.Size = new System.Drawing.Size(68, 23);
            this.btn_nmz.TabIndex = 2;
            this.btn_nmz.Text = "NMZ Flick";
            this.btn_nmz.UseVisualStyleBackColor = true;
            this.btn_nmz.Click += new System.EventHandler(this.btn_nmz_Click);
            // 
            // btn_guth
            // 
            this.btn_guth.Location = new System.Drawing.Point(13, 73);
            this.btn_guth.Name = "btn_guth";
            this.btn_guth.Size = new System.Drawing.Size(107, 23);
            this.btn_guth.TabIndex = 3;
            this.btn_guth.Text = "NMZ guthans";
            this.btn_guth.UseVisualStyleBackColor = true;
            this.btn_guth.Click += new System.EventHandler(this.btn_guth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Timer:";
            // 
            // lb_timer
            // 
            this.lb_timer.AutoSize = true;
            this.lb_timer.Location = new System.Drawing.Point(185, 12);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(10, 13);
            this.lb_timer.TabIndex = 5;
            this.lb_timer.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Times clicked:";
            // 
            // lb_clicked
            // 
            this.lb_clicked.AutoSize = true;
            this.lb_clicked.Location = new System.Drawing.Point(185, 35);
            this.lb_clicked.Name = "lb_clicked";
            this.lb_clicked.Size = new System.Drawing.Size(10, 13);
            this.lb_clicked.TabIndex = 7;
            this.lb_clicked.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lb_clicked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_timer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_guth);
            this.Controls.Add(this.btn_nmz);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_alch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_alch;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_nmz;
        private System.Windows.Forms.Button btn_guth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_clicked;
    }
}

