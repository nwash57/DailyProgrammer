using System.ComponentModel;

namespace CH4
{
    partial class Challenge4Form
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
            this.txtPassLength = new System.Windows.Forms.TextBox();
            this.lblPassLength = new System.Windows.Forms.Label();
            this.lblNumOfPass = new System.Windows.Forms.Label();
            this.txtNumOfPass = new System.Windows.Forms.TextBox();
            this.btnPassCreate = new System.Windows.Forms.Button();
            this.lbxPasswords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPassLength
            // 
            this.txtPassLength.Location = new System.Drawing.Point(139, 10);
            this.txtPassLength.Name = "txtPassLength";
            this.txtPassLength.Size = new System.Drawing.Size(100, 20);
            this.txtPassLength.TabIndex = 0;
            this.txtPassLength.TextChanged += new System.EventHandler(this.txtPassLength_TextChanged);
            // 
            // lblPassLength
            // 
            this.lblPassLength.AutoSize = true;
            this.lblPassLength.Location = new System.Drawing.Point(13, 13);
            this.lblPassLength.Name = "lblPassLength";
            this.lblPassLength.Size = new System.Drawing.Size(95, 13);
            this.lblPassLength.TabIndex = 1;
            this.lblPassLength.Text = "Password Length: ";
            // 
            // lblNumOfPass
            // 
            this.lblNumOfPass.AutoSize = true;
            this.lblNumOfPass.Location = new System.Drawing.Point(12, 47);
            this.lblNumOfPass.Name = "lblNumOfPass";
            this.lblNumOfPass.Size = new System.Drawing.Size(116, 13);
            this.lblNumOfPass.TabIndex = 2;
            this.lblNumOfPass.Text = "Number of Passwords: ";
            // 
            // txtNumOfPass
            // 
            this.txtNumOfPass.Location = new System.Drawing.Point(139, 44);
            this.txtNumOfPass.Name = "txtNumOfPass";
            this.txtNumOfPass.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfPass.TabIndex = 3;
            this.txtNumOfPass.TextChanged += new System.EventHandler(this.txtNumOfPass_TextChanged);
            // 
            // btnPassCreate
            // 
            this.btnPassCreate.Location = new System.Drawing.Point(16, 87);
            this.btnPassCreate.Name = "btnPassCreate";
            this.btnPassCreate.Size = new System.Drawing.Size(75, 37);
            this.btnPassCreate.TabIndex = 4;
            this.btnPassCreate.Text = "Create Passwords";
            this.btnPassCreate.UseVisualStyleBackColor = true;
            this.btnPassCreate.Click += new System.EventHandler(this.btnPassCreate_Click);
            // 
            // lbxPasswords
            // 
            this.lbxPasswords.FormattingEnabled = true;
            this.lbxPasswords.Location = new System.Drawing.Point(278, 13);
            this.lbxPasswords.Name = "lbxPasswords";
            this.lbxPasswords.Size = new System.Drawing.Size(190, 238);
            this.lbxPasswords.TabIndex = 5;
            this.lbxPasswords.SelectedIndexChanged += new System.EventHandler(this.lbxPasswords_SelectedIndexChanged);
            // 
            // Challenge4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 261);
            this.Controls.Add(this.lbxPasswords);
            this.Controls.Add(this.btnPassCreate);
            this.Controls.Add(this.txtNumOfPass);
            this.Controls.Add(this.lblNumOfPass);
            this.Controls.Add(this.lblPassLength);
            this.Controls.Add(this.txtPassLength);
            this.Name = "Challenge4Form";
            this.Text = "Challenge4Form";
            this.Load += new System.EventHandler(this.Challenge4Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassLength;
        private System.Windows.Forms.Label lblPassLength;
        private System.Windows.Forms.Label lblNumOfPass;
        private System.Windows.Forms.TextBox txtNumOfPass;
        private System.Windows.Forms.Button btnPassCreate;
        private System.Windows.Forms.ListBox lbxPasswords;
    }
}