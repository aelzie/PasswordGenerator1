namespace PasswordGenerator1
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
            this.label1 = new System.Windows.Forms.Label();
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.passwordLengthSlider = new System.Windows.Forms.TrackBar();
            this.copyPasswordBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLengthLabel.Location = new System.Drawing.Point(100, 229);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(582, 65);
            this.passwordLengthLabel.TabIndex = 1;
            this.passwordLengthLabel.Text = "Password Length: 3";
            this.passwordLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLengthSlider
            // 
            this.passwordLengthSlider.Location = new System.Drawing.Point(100, 322);
            this.passwordLengthSlider.Name = "passwordLengthSlider";
            this.passwordLengthSlider.Size = new System.Drawing.Size(582, 45);
            this.passwordLengthSlider.TabIndex = 2;
            this.passwordLengthSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.passwordLengthSlider.Scroll += new System.EventHandler(this.passwordLengthSlider_Scroll);
            // 
            // copyPasswordBtn
            // 
            this.copyPasswordBtn.BackColor = System.Drawing.Color.Silver;
            this.copyPasswordBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copyPasswordBtn.Location = new System.Drawing.Point(100, 383);
            this.copyPasswordBtn.Name = "copyPasswordBtn";
            this.copyPasswordBtn.Size = new System.Drawing.Size(582, 82);
            this.copyPasswordBtn.TabIndex = 3;
            this.copyPasswordBtn.Text = "Copy Password";
            this.copyPasswordBtn.UseVisualStyleBackColor = false;
            this.copyPasswordBtn.Click += new System.EventHandler(this.copyPasswordBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.copyPasswordBtn);
            this.Controls.Add(this.passwordLengthSlider);
            this.Controls.Add(this.passwordLengthLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.TrackBar passwordLengthSlider;
        private System.Windows.Forms.Button copyPasswordBtn;
    }
}
