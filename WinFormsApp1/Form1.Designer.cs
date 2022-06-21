
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerInvoke = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timerLoc = new System.Windows.Forms.Timer(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.timerCheckFast = new System.Windows.Forms.Timer(this.components);
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timerInvoke
            // 
            this.timerInvoke.Interval = 2000;
            this.timerInvoke.Tick += new System.EventHandler(this.timerInvoke_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(687, 396);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "&Run Macro";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 392);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "3000";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 392);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "1000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timerLoc
            // 
            this.timerLoc.Enabled = true;
            this.timerLoc.Interval = 300;
            this.timerLoc.Tick += new System.EventHandler(this.timerLoc_Tick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 12);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(775, 213);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(287, 295);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(277, 23);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(287, 237);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(277, 23);
            this.textBox6.TabIndex = 6;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(7, 237);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(260, 23);
            this.textBox7.TabIndex = 7;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(7, 266);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(260, 23);
            this.textBox8.TabIndex = 8;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // timerCheckFast
            // 
            this.timerCheckFast.Interval = 100000;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(287, 266);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(277, 23);
            this.textBox9.TabIndex = 9;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 295);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 91);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(287, 325);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(388, 21);
            this.textBox10.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(287, 352);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(388, 63);
            this.textBox11.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(697, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(575, 236);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 83);
            this.textBox12.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerInvoke;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerLoc;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Timer timerCheckFast;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox12;
    }
}

