namespace TotpApp
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
            this.label_totp = new System.Windows.Forms.Label();
            this.validate_totp_label = new System.Windows.Forms.Label();
            this.textbox_totp = new System.Windows.Forms.RichTextBox();
            this.button_generate_totp = new System.Windows.Forms.Button();
            this.textbox_validate = new System.Windows.Forms.RichTextBox();
            this.button_validate_totp = new System.Windows.Forms.Button();
            this.label_isVerified = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_totp
            // 
            this.label_totp.AutoSize = true;
            this.label_totp.Location = new System.Drawing.Point(51, 148);
            this.label_totp.Name = "label_totp";
            this.label_totp.Size = new System.Drawing.Size(42, 20);
            this.label_totp.TabIndex = 0;
            this.label_totp.Text = "TOTP";
            this.label_totp.Click += new System.EventHandler(this.email_label_Click);
            // 
            // validate_totp_label
            // 
            this.validate_totp_label.AutoSize = true;
            this.validate_totp_label.Location = new System.Drawing.Point(51, 264);
            this.validate_totp_label.Name = "validate_totp_label";
            this.validate_totp_label.Size = new System.Drawing.Size(100, 20);
            this.validate_totp_label.TabIndex = 1;
            this.validate_totp_label.Text = "Validate TOTP";
            // 
            // textbox_totp
            // 
            this.textbox_totp.Location = new System.Drawing.Point(176, 145);
            this.textbox_totp.Name = "textbox_totp";
            this.textbox_totp.ReadOnly = true;
            this.textbox_totp.Size = new System.Drawing.Size(416, 31);
            this.textbox_totp.TabIndex = 2;
            this.textbox_totp.Text = "";
            // 
            // button_generate_totp
            // 
            this.button_generate_totp.Location = new System.Drawing.Point(244, 59);
            this.button_generate_totp.Name = "button_generate_totp";
            this.button_generate_totp.Size = new System.Drawing.Size(251, 61);
            this.button_generate_totp.TabIndex = 3;
            this.button_generate_totp.Text = "GENERATE TOTP";
            this.button_generate_totp.UseVisualStyleBackColor = true;
            this.button_generate_totp.Click += new System.EventHandler(this.button_generate_totp_Click);
            // 
            // textbox_validate
            // 
            this.textbox_validate.Location = new System.Drawing.Point(176, 255);
            this.textbox_validate.Name = "textbox_validate";
            this.textbox_validate.Size = new System.Drawing.Size(416, 28);
            this.textbox_validate.TabIndex = 4;
            this.textbox_validate.Text = "";
            // 
            // button_validate_totp
            // 
            this.button_validate_totp.Location = new System.Drawing.Point(254, 289);
            this.button_validate_totp.Name = "button_validate_totp";
            this.button_validate_totp.Size = new System.Drawing.Size(251, 61);
            this.button_validate_totp.TabIndex = 5;
            this.button_validate_totp.Text = "VALIDATE TOTP";
            this.button_validate_totp.UseVisualStyleBackColor = true;
            this.button_validate_totp.Click += new System.EventHandler(this.button_validate_totp_Click);
            // 
            // label_isVerified
            // 
            this.label_isVerified.AutoSize = true;
            this.label_isVerified.Location = new System.Drawing.Point(284, 383);
            this.label_isVerified.Name = "label_isVerified";
            this.label_isVerified.Size = new System.Drawing.Size(0, 20);
            this.label_isVerified.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_isVerified);
            this.Controls.Add(this.button_validate_totp);
            this.Controls.Add(this.textbox_validate);
            this.Controls.Add(this.button_generate_totp);
            this.Controls.Add(this.textbox_totp);
            this.Controls.Add(this.validate_totp_label);
            this.Controls.Add(this.label_totp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_totp;
        private System.Windows.Forms.Label validate_totp_label;
        private System.Windows.Forms.RichTextBox textbox_totp;
        private System.Windows.Forms.Button button_generate_totp;
        private System.Windows.Forms.RichTextBox textbox_validate;
        private System.Windows.Forms.Button button_validate_totp;
        private System.Windows.Forms.Label label_isVerified;
    }
}
