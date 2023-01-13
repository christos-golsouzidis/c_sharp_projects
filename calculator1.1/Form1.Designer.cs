namespace calculator1._1
{
    partial class calculator
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
            this.toutput = new System.Windows.Forms.TextBox();
            this.tinput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.opera_komma = new System.Windows.Forms.Button();
            this.opera_changesign = new System.Windows.Forms.Button();
            this.opera_add = new System.Windows.Forms.Button();
            this.opera_sub = new System.Windows.Forms.Button();
            this.opera_mul = new System.Windows.Forms.Button();
            this.opera_div = new System.Windows.Forms.Button();
            this.opera_result = new System.Windows.Forms.Button();
            this.key_clear = new System.Windows.Forms.Button();
            this.key_clearentry = new System.Windows.Forms.Button();
            this.key_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toutput
            // 
            this.toutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toutput.Location = new System.Drawing.Point(28, 33);
            this.toutput.Multiline = true;
            this.toutput.Name = "toutput";
            this.toutput.ReadOnly = true;
            this.toutput.Size = new System.Drawing.Size(339, 66);
            this.toutput.TabIndex = 0;
            this.toutput.TabStop = false;
            // 
            // tinput
            // 
            this.tinput.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinput.Location = new System.Drawing.Point(28, 122);
            this.tinput.Name = "tinput";
            this.tinput.Size = new System.Drawing.Size(339, 34);
            this.tinput.TabIndex = 1;
            this.tinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tinput.TextChanged += new System.EventHandler(this.tinput_TextChanged);
            this.tinput.GotFocus += new System.EventHandler(this.tinput_GotFocus);
            this.tinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tinput_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(97, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(97, 406);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(63, 63);
            this.button0.TabIndex = 3;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(166, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(235, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 63);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(97, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 63);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(166, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 63);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(235, 268);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 63);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(97, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 63);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(166, 199);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 63);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(235, 199);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 63);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // opera_komma
            // 
            this.opera_komma.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opera_komma.Location = new System.Drawing.Point(166, 406);
            this.opera_komma.Name = "opera_komma";
            this.opera_komma.Size = new System.Drawing.Size(63, 63);
            this.opera_komma.TabIndex = 12;
            this.opera_komma.Text = ",";
            this.opera_komma.UseVisualStyleBackColor = true;
            this.opera_komma.Click += new System.EventHandler(this.opera_komma_Click);
            // 
            // opera_changesign
            // 
            this.opera_changesign.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opera_changesign.Location = new System.Drawing.Point(235, 406);
            this.opera_changesign.Name = "opera_changesign";
            this.opera_changesign.Size = new System.Drawing.Size(63, 63);
            this.opera_changesign.TabIndex = 13;
            this.opera_changesign.Text = "+|-";
            this.opera_changesign.UseVisualStyleBackColor = true;
            this.opera_changesign.Click += new System.EventHandler(this.opera_changesign_Click);
            // 
            // opera_add
            // 
            this.opera_add.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opera_add.Location = new System.Drawing.Point(304, 406);
            this.opera_add.Name = "opera_add";
            this.opera_add.Size = new System.Drawing.Size(63, 63);
            this.opera_add.TabIndex = 14;
            this.opera_add.Text = "+";
            this.opera_add.UseVisualStyleBackColor = true;
            this.opera_add.Click += new System.EventHandler(this.opera_add_Click);
            // 
            // opera_sub
            // 
            this.opera_sub.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opera_sub.Location = new System.Drawing.Point(304, 337);
            this.opera_sub.Name = "opera_sub";
            this.opera_sub.Size = new System.Drawing.Size(63, 63);
            this.opera_sub.TabIndex = 15;
            this.opera_sub.Text = "-";
            this.opera_sub.UseVisualStyleBackColor = true;
            this.opera_sub.Click += new System.EventHandler(this.opera_sub_Click);
            // 
            // opera_mul
            // 
            this.opera_mul.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opera_mul.Location = new System.Drawing.Point(304, 268);
            this.opera_mul.Name = "opera_mul";
            this.opera_mul.Size = new System.Drawing.Size(63, 63);
            this.opera_mul.TabIndex = 16;
            this.opera_mul.Text = "*";
            this.opera_mul.UseVisualStyleBackColor = true;
            this.opera_mul.Click += new System.EventHandler(this.opera_mul_Click);
            // 
            // opera_div
            // 
            this.opera_div.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opera_div.Location = new System.Drawing.Point(304, 199);
            this.opera_div.Name = "opera_div";
            this.opera_div.Size = new System.Drawing.Size(63, 63);
            this.opera_div.TabIndex = 17;
            this.opera_div.Text = "/";
            this.opera_div.UseVisualStyleBackColor = true;
            this.opera_div.Click += new System.EventHandler(this.opera_div_Click);
            // 
            // opera_result
            // 
            this.opera_result.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.opera_result.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opera_result.Location = new System.Drawing.Point(28, 406);
            this.opera_result.Name = "opera_result";
            this.opera_result.Size = new System.Drawing.Size(63, 63);
            this.opera_result.TabIndex = 18;
            this.opera_result.Text = "=";
            this.opera_result.UseVisualStyleBackColor = false;
            this.opera_result.Click += new System.EventHandler(this.opera_result_Click);
            // 
            // key_clear
            // 
            this.key_clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.key_clear.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_clear.Location = new System.Drawing.Point(28, 337);
            this.key_clear.Name = "key_clear";
            this.key_clear.Size = new System.Drawing.Size(63, 63);
            this.key_clear.TabIndex = 19;
            this.key_clear.Text = "C";
            this.key_clear.UseVisualStyleBackColor = false;
            this.key_clear.Click += new System.EventHandler(this.key_clear_Click);
            // 
            // key_clearentry
            // 
            this.key_clearentry.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.key_clearentry.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_clearentry.Location = new System.Drawing.Point(28, 268);
            this.key_clearentry.Name = "key_clearentry";
            this.key_clearentry.Size = new System.Drawing.Size(63, 63);
            this.key_clearentry.TabIndex = 20;
            this.key_clearentry.Text = "CE";
            this.key_clearentry.UseVisualStyleBackColor = false;
            this.key_clearentry.Click += new System.EventHandler(this.key_clearentry_Click);
            // 
            // key_back
            // 
            this.key_back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.key_back.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_back.Location = new System.Drawing.Point(28, 199);
            this.key_back.Name = "key_back";
            this.key_back.Size = new System.Drawing.Size(63, 63);
            this.key_back.TabIndex = 21;
            this.key_back.Text = "<X]";
            this.key_back.UseVisualStyleBackColor = false;
            this.key_back.Click += new System.EventHandler(this.key_back_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 502);
            this.Controls.Add(this.key_back);
            this.Controls.Add(this.key_clearentry);
            this.Controls.Add(this.key_clear);
            this.Controls.Add(this.opera_result);
            this.Controls.Add(this.opera_div);
            this.Controls.Add(this.opera_mul);
            this.Controls.Add(this.opera_sub);
            this.Controls.Add(this.opera_add);
            this.Controls.Add(this.opera_changesign);
            this.Controls.Add(this.opera_komma);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tinput);
            this.Controls.Add(this.toutput);
            this.Name = "calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox toutput;
        private System.Windows.Forms.TextBox tinput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button opera_komma;
        private System.Windows.Forms.Button opera_changesign;
        private System.Windows.Forms.Button opera_add;
        private System.Windows.Forms.Button opera_sub;
        private System.Windows.Forms.Button opera_mul;
        private System.Windows.Forms.Button opera_div;
        private System.Windows.Forms.Button opera_result;
        private System.Windows.Forms.Button key_clear;
        private System.Windows.Forms.Button key_clearentry;
        private System.Windows.Forms.Button key_back;
    }
}

