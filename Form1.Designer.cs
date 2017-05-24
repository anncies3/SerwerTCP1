namespace SerwerTCP
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
            this.adres = new System.Windows.Forms.TextBox();
            this.port_p = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.port_p)).BeginInit();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(13, 13);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(100, 20);
            this.adres.TabIndex = 0;
            this.adres.Text = "adres";
            // 
            // port_p
            // 
            this.port_p.Location = new System.Drawing.Point(152, 13);
            this.port_p.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port_p.Name = "port_p";
            this.port_p.Size = new System.Drawing.Size(120, 20);
            this.port_p.TabIndex = 1;
            this.port_p.ValueChanged += new System.EventHandler(this.port_p_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 173);
            this.listBox1.TabIndex = 2;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 220);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 3;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(197, 220);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 4;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 266);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.port_p);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.port_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown port_p;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
    }
}

