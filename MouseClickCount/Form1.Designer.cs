namespace MouseClickCount
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
            this.addbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(136, 97);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(180, 61);
            this.addbutton.TabIndex = 0;
            this.addbutton.Text = "點我+1";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(136, 185);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(180, 62);
            this.resetbutton.TabIndex = 1;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(114, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mouse Click 0 Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.addbutton);
            this.Name = "Form1";
            this.Text = "滑鼠點擊計數器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label label1;
    }
}

