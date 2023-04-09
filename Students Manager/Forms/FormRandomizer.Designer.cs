namespace Students_Manager.Forms
{
    partial class FormRandomizer
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
            this.btnRandomizer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.LapTextBox = new System.Windows.Forms.TextBox();
            this.PcsTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRandomizer
            // 
            this.btnRandomizer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRandomizer.FlatAppearance.BorderSize = 0;
            this.btnRandomizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomizer.Location = new System.Drawing.Point(0, 389);
            this.btnRandomizer.Name = "btnRandomizer";
            this.btnRandomizer.Size = new System.Drawing.Size(200, 61);
            this.btnRandomizer.TabIndex = 0;
            this.btnRandomizer.Text = "Randomize";
            this.btnRandomizer.UseVisualStyleBackColor = true;
            this.btnRandomizer.Click += new System.EventHandler(this.btnRandomizer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(800, 450);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PcsTextBox);
            this.panel1.Controls.Add(this.LapTextBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnRandomizer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LapTextBox
            // 
            this.LapTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LapTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LapTextBox.Location = new System.Drawing.Point(0, 0);
            this.LapTextBox.Name = "LapTextBox";
            this.LapTextBox.Size = new System.Drawing.Size(200, 45);
            this.LapTextBox.TabIndex = 2;
            this.LapTextBox.Text = "11";
            this.LapTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PcsTextBox
            // 
            this.PcsTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PcsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PcsTextBox.Location = new System.Drawing.Point(0, 45);
            this.PcsTextBox.Name = "PcsTextBox";
            this.PcsTextBox.Size = new System.Drawing.Size(200, 45);
            this.PcsTextBox.TabIndex = 3;
            this.PcsTextBox.Text = "17";
            this.PcsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormRandomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormRandomizer";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomizer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PcsTextBox;
        private System.Windows.Forms.TextBox LapTextBox;
    }
}