namespace Recept
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendby = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TRMODE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dese = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.trid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Trtype = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.amt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cusname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cusid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Memid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.sendby);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TRMODE);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dese);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.trid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Trtype);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.amt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cusname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cusid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Memid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 634);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sendby
            // 
            this.sendby.Location = new System.Drawing.Point(785, 342);
            this.sendby.Name = "sendby";
            this.sendby.Size = new System.Drawing.Size(189, 26);
            this.sendby.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(659, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 27);
            this.label14.TabIndex = 23;
            this.label14.Text = "Send By:";
            // 
            // TRMODE
            // 
            this.TRMODE.Location = new System.Drawing.Point(226, 354);
            this.TRMODE.Name = "TRMODE";
            this.TRMODE.Size = new System.Drawing.Size(192, 26);
            this.TRMODE.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 27);
            this.label11.TabIndex = 19;
            this.label11.Text = "Transaction Mode:";
            // 
            // dese
            // 
            this.dese.Location = new System.Drawing.Point(785, 399);
            this.dese.Multiline = true;
            this.dese.Name = "dese";
            this.dese.Size = new System.Drawing.Size(229, 116);
            this.dese.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(645, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 27);
            this.label10.TabIndex = 17;
            this.label10.Text = "Description:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 27);
            this.label9.TabIndex = 16;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date:";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(520, 521);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(199, 85);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // trid
            // 
            this.trid.Location = new System.Drawing.Point(229, 431);
            this.trid.Name = "trid";
            this.trid.Size = new System.Drawing.Size(189, 26);
            this.trid.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Transaction ID:";
            // 
            // Trtype
            // 
            this.Trtype.Location = new System.Drawing.Point(960, 273);
            this.Trtype.Name = "Trtype";
            this.Trtype.Size = new System.Drawing.Size(189, 26);
            this.Trtype.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(753, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Transaction Type:";
            // 
            // amt
            // 
            this.amt.Location = new System.Drawing.Point(535, 273);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(189, 26);
            this.amt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount:";
            // 
            // cusname
            // 
            this.cusname.Location = new System.Drawing.Point(215, 273);
            this.cusname.Name = "cusname";
            this.cusname.Size = new System.Drawing.Size(189, 26);
            this.cusname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Name:";
            // 
            // cusid
            // 
            this.cusid.Location = new System.Drawing.Point(785, 188);
            this.cusid.Name = "cusid";
            this.cusid.Size = new System.Drawing.Size(189, 26);
            this.cusid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer ID:";
            // 
            // Memid
            // 
            this.Memid.Location = new System.Drawing.Point(419, 188);
            this.Memid.Name = "Memid";
            this.Memid.Size = new System.Drawing.Size(189, 26);
            this.Memid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(926, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 47);
            this.button3.TabIndex = 22;
            this.button3.Text = "Preview";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Recept.Properties.Resources.bintpex;
            this.pictureBox1.Location = new System.Drawing.Point(467, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cusid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Memid;
        private System.Windows.Forms.TextBox Trtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cusname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox trid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dese;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TRMODE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox sendby;
        private System.Windows.Forms.Label label14;
    }
}

