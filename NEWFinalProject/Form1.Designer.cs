namespace NEWFinalProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F);
            this.label1.Location = new System.Drawing.Point(343, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the RES System!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "You are: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(333, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Waiter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(580, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 80);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cashier";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkKhaki;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(829, 552);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 80);
            this.button3.TabIndex = 4;
            this.button3.Text = "Manager";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::NEWFinalProject.Properties.Resources._71908;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1380, 969);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

