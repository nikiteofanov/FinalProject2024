namespace NEWFinalProject
{
    partial class ViewOrdersForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 17F);
            this.button2.Location = new System.Drawing.Point(1069, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 61);
            this.button2.TabIndex = 9;
            this.button2.Text = "Tables";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(47, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "WaiterID: 10334";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nikolay Teofanov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 19F);
            this.label3.Location = new System.Drawing.Point(501, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order #";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(635, 268);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 19F);
            this.label4.Location = new System.Drawing.Point(607, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 46);
            this.label4.TabIndex = 12;
            this.label4.Text = "Order Info";
            // 
            // ViewOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1380, 969);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewOrdersForm";
            this.Text = "ViewOrdersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}