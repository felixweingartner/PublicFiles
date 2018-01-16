namespace WindowsFormsApplication2
{
    partial class editstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editstudent));
            this.error = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.t9 = new System.Windows.Forms.TextBox();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.back = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.t8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.t7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.t6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.hideBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.finderror = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideBox)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(155, 208);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(119, 22);
            this.error.TabIndex = 50;
            this.error.Text = "error message";
            this.error.Visible = false;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.SteelBlue;
            this.submit.Enabled = false;
            this.submit.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.Silver;
            this.submit.Location = new System.Drawing.Point(371, 606);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(98, 37);
            this.submit.TabIndex = 48;
            this.submit.Text = "Save";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(85, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Money Owed - $";
            // 
            // t9
            // 
            this.t9.Location = new System.Drawing.Point(201, 555);
            this.t9.Name = "t9";
            this.t9.Size = new System.Drawing.Size(73, 20);
            this.t9.TabIndex = 46;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Checked = true;
            this.r1.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1.ForeColor = System.Drawing.Color.Silver;
            this.r1.Location = new System.Drawing.Point(6, 3);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(44, 21);
            this.r1.TabIndex = 44;
            this.r1.TabStop = true;
            this.r1.Text = "yes";
            this.r1.UseVisualStyleBackColor = true;
            this.r1.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.BackColor = System.Drawing.Color.Transparent;
            this.r2.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2.ForeColor = System.Drawing.Color.Silver;
            this.r2.Location = new System.Drawing.Point(65, 3);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(41, 21);
            this.r2.TabIndex = 45;
            this.r2.Text = "no";
            this.r2.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.SteelBlue;
            this.back.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Silver;
            this.back.Location = new System.Drawing.Point(88, 606);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(98, 37);
            this.back.TabIndex = 49;
            this.back.Text = "Cancel";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(89, 523);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Active Member?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(109, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Year Joined -";
            // 
            // t8
            // 
            this.t8.Location = new System.Drawing.Point(201, 486);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(109, 20);
            this.t8.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(143, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Email -";
            // 
            // t7
            // 
            this.t7.Location = new System.Drawing.Point(201, 446);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(225, 20);
            this.t7.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(146, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "State -";
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(201, 407);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(225, 20);
            this.t6.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(141, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Grade -";
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(201, 368);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(225, 20);
            this.t5.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(135, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "School -";
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(201, 329);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(225, 20);
            this.t4.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(116, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Last Name -";
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(201, 290);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(225, 20);
            this.t3.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(109, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "First Name -";
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(201, 253);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(225, 20);
            this.t2.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 55);
            this.label1.TabIndex = 28;
            this.label1.Text = "Edit Student";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r1);
            this.groupBox1.Controls.Add(this.r2);
            this.groupBox1.Location = new System.Drawing.Point(204, 523);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 26);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(92, 95);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(144, 20);
            this.n1.TabIndex = 52;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(306, 95);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(144, 20);
            this.n2.TabIndex = 53;
            // 
            // hideBox
            // 
            this.hideBox.Location = new System.Drawing.Point(88, 202);
            this.hideBox.Name = "hideBox";
            this.hideBox.Size = new System.Drawing.Size(381, 398);
            this.hideBox.TabIndex = 54;
            this.hideBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(116, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "First Name";
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.ForeColor = System.Drawing.Color.Silver;
            this.find.Location = new System.Drawing.Point(235, 138);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 29);
            this.find.TabIndex = 56;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // finderror
            // 
            this.finderror.AutoSize = true;
            this.finderror.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finderror.ForeColor = System.Drawing.Color.Red;
            this.finderror.Location = new System.Drawing.Point(214, 170);
            this.finderror.Name = "finderror";
            this.finderror.Size = new System.Drawing.Size(114, 16);
            this.finderror.TabIndex = 57;
            this.finderror.Text = "*Student not found";
            this.finderror.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(335, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 18);
            this.label12.TabIndex = 58;
            this.label12.Text = "Last Name";
            // 
            // editstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(543, 655);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.finderror);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hideBox);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t9);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.t8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editstudent";
            this.Text = "editstudent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t9;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox t8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox t7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.PictureBox hideBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label finderror;
        private System.Windows.Forms.Label label12;
    }
}