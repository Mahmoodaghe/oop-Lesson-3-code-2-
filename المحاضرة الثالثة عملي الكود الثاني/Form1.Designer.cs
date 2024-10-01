namespace المحاضرة_الثالثة_عملي_الكود_الثاني
{
    partial class sendr
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
            this.butyelow = new System.Windows.Forms.Button();
            this.butgreen = new System.Windows.Forms.Button();
            this.butred = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.device1 = new System.Windows.Forms.Label();
            this.device2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butyelow
            // 
            this.butyelow.Location = new System.Drawing.Point(197, 63);
            this.butyelow.Name = "butyelow";
            this.butyelow.Size = new System.Drawing.Size(75, 23);
            this.butyelow.TabIndex = 0;
            this.butyelow.Text = "اصفر";
            this.butyelow.UseVisualStyleBackColor = true;
            //this.butyelow.Click += new System.EventHandler(this.butyelow_Click);
            // 
            // butgreen
            // 
            this.butgreen.Location = new System.Drawing.Point(105, 63);
            this.butgreen.Name = "butgreen";
            this.butgreen.Size = new System.Drawing.Size(75, 23);
            this.butgreen.TabIndex = 1;
            this.butgreen.Text = "اخضر";
            this.butgreen.UseVisualStyleBackColor = true;
            // 
            // butred
            // 
            this.butred.Location = new System.Drawing.Point(12, 63);
            this.butred.Name = "butred";
            this.butred.Size = new System.Drawing.Size(75, 23);
            this.butred.TabIndex = 2;
            this.butred.Text = "احمر";
            this.butred.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "color";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // device1
            // 
            this.device1.AutoSize = true;
            this.device1.Location = new System.Drawing.Point(169, 24);
            this.device1.Name = "device1";
            this.device1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.device1.Size = new System.Drawing.Size(58, 13);
            this.device1.TabIndex = 4;
            this.device1.Text = "الجهاز الاول";
            // 
            // device2
            // 
            this.device2.AutoSize = true;
            this.device2.Location = new System.Drawing.Point(70, 24);
            this.device2.Name = "device2";
            this.device2.Size = new System.Drawing.Size(63, 13);
            this.device2.TabIndex = 5;
            this.device2.Text = "الجهاز الثاني";
            // 
            // sendr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.device2);
            this.Controls.Add(this.device1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.butred);
            this.Controls.Add(this.butgreen);
            this.Controls.Add(this.butyelow);
            this.Name = "sendr";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.sendr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butyelow;
        private System.Windows.Forms.Button butgreen;
        private System.Windows.Forms.Button butred;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label device1;
        private System.Windows.Forms.Label device2;
        
    }
}

