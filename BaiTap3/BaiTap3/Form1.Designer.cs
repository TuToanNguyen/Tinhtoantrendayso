namespace BaiTap3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntongle = new System.Windows.Forms.Button();
            this.txttongle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btntongchan = new System.Windows.Forms.Button();
            this.txttongchan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btntich = new System.Windows.Forms.Button();
            this.txttich = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btntong = new System.Windows.Forms.Button();
            this.txttong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtkt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(409, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập giới hạn của dãy số";
            // 
            // txtkt
            // 
            this.txtkt.Location = new System.Drawing.Point(280, 42);
            this.txtkt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtkt.Name = "txtkt";
            this.txtkt.Size = new System.Drawing.Size(73, 24);
            this.txtkt.TabIndex = 3;
            this.txtkt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkt_KeyPress);
            this.txtkt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtkt_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số kết thúc";
            // 
            // txtbd
            // 
            this.txtbd.Location = new System.Drawing.Point(111, 45);
            this.txtbd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbd.Name = "txtbd";
            this.txtbd.Size = new System.Drawing.Size(75, 24);
            this.txtbd.TabIndex = 1;
            this.txtbd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbd_KeyPress);
            this.txtbd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtbd_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số bắt đầu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btntongle);
            this.groupBox2.Controls.Add(this.txttongle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btntongchan);
            this.groupBox2.Controls.Add(this.txttongchan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btntich);
            this.groupBox2.Controls.Add(this.txttich);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btntong);
            this.groupBox2.Controls.Add(this.txttong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(409, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // btntongle
            // 
            this.btntongle.Location = new System.Drawing.Point(265, 162);
            this.btntongle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntongle.Name = "btntongle";
            this.btntongle.Size = new System.Drawing.Size(122, 25);
            this.btntongle.TabIndex = 13;
            this.btntongle.Text = "Tổng lẽ";
            this.btntongle.UseVisualStyleBackColor = true;
            this.btntongle.Click += new System.EventHandler(this.btntongle_Click);
            // 
            // txttongle
            // 
            this.txttongle.Location = new System.Drawing.Point(124, 162);
            this.txttongle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttongle.Name = "txttongle";
            this.txttongle.ReadOnly = true;
            this.txttongle.Size = new System.Drawing.Size(120, 24);
            this.txttongle.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng các số lẻ";
            // 
            // btntongchan
            // 
            this.btntongchan.Location = new System.Drawing.Point(265, 118);
            this.btntongchan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntongchan.Name = "btntongchan";
            this.btntongchan.Size = new System.Drawing.Size(122, 25);
            this.btntongchan.TabIndex = 10;
            this.btntongchan.Text = "Tổng chẵn";
            this.btntongchan.UseVisualStyleBackColor = true;
            this.btntongchan.Click += new System.EventHandler(this.btntongchan_Click);
            // 
            // txttongchan
            // 
            this.txttongchan.Location = new System.Drawing.Point(124, 121);
            this.txttongchan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttongchan.Name = "txttongchan";
            this.txttongchan.ReadOnly = true;
            this.txttongchan.Size = new System.Drawing.Size(120, 24);
            this.txttongchan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng các số chẵn";
            // 
            // btntich
            // 
            this.btntich.Location = new System.Drawing.Point(265, 80);
            this.btntich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntich.Name = "btntich";
            this.btntich.Size = new System.Drawing.Size(122, 25);
            this.btntich.TabIndex = 7;
            this.btntich.Text = "Tính tích";
            this.btntich.UseVisualStyleBackColor = true;
            this.btntich.Click += new System.EventHandler(this.btntich_Click);
            // 
            // txttich
            // 
            this.txttich.Location = new System.Drawing.Point(124, 82);
            this.txttich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttich.Name = "txttich";
            this.txttich.ReadOnly = true;
            this.txttich.Size = new System.Drawing.Size(120, 24);
            this.txttich.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tích các số";
            // 
            // btntong
            // 
            this.btntong.Location = new System.Drawing.Point(265, 41);
            this.btntong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(122, 25);
            this.btntong.TabIndex = 4;
            this.btntong.Text = "Tính tổng";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(124, 44);
            this.txttong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttong.Name = "txttong";
            this.txttong.ReadOnly = true;
            this.txttong.Size = new System.Drawing.Size(120, 24);
            this.txttong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng các số";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(77, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tính toán trên dãy số";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 388);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Tính toán trên dãy số";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntongle;
        private System.Windows.Forms.TextBox txttongle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btntongchan;
        private System.Windows.Forms.TextBox txttongchan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btntich;
        private System.Windows.Forms.TextBox txttich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}

