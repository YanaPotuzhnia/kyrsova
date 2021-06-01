namespace zakharevich
{
    partial class ChangePassForm
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
            this.savePass = new System.Windows.Forms.Button();
            this.passNewConfirm = new System.Windows.Forms.MaskedTextBox();
            this.passNew = new System.Windows.Forms.MaskedTextBox();
            this.passLast = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passLNew = new System.Windows.Forms.Label();
            this.passLLast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // savePass
            // 
            this.savePass.Location = new System.Drawing.Point(12, 138);
            this.savePass.Name = "savePass";
            this.savePass.Size = new System.Drawing.Size(260, 23);
            this.savePass.TabIndex = 15;
            this.savePass.Text = "Зберегти";
            this.savePass.UseVisualStyleBackColor = true;
            this.savePass.Click += new System.EventHandler(this.savePass_Click);
            // 
            // passNewConfirm
            // 
            this.passNewConfirm.Location = new System.Drawing.Point(12, 112);
            this.passNewConfirm.Name = "passNewConfirm";
            this.passNewConfirm.Size = new System.Drawing.Size(260, 20);
            this.passNewConfirm.TabIndex = 14;
            this.passNewConfirm.UseSystemPasswordChar = true;
            // 
            // passNew
            // 
            this.passNew.Location = new System.Drawing.Point(12, 73);
            this.passNew.Name = "passNew";
            this.passNew.Size = new System.Drawing.Size(260, 20);
            this.passNew.TabIndex = 13;
            this.passNew.UseSystemPasswordChar = true;
            // 
            // passLast
            // 
            this.passLast.Location = new System.Drawing.Point(12, 25);
            this.passLast.Name = "passLast";
            this.passLast.Size = new System.Drawing.Size(260, 20);
            this.passLast.TabIndex = 12;
            this.passLast.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введіть новий пароль ще раз:";
            // 
            // passLNew
            // 
            this.passLNew.AutoSize = true;
            this.passLNew.Location = new System.Drawing.Point(12, 57);
            this.passLNew.Name = "passLNew";
            this.passLNew.Size = new System.Drawing.Size(120, 13);
            this.passLNew.TabIndex = 10;
            this.passLNew.Text = "Введіть новий пароль:";
            // 
            // passLLast
            // 
            this.passLLast.AutoSize = true;
            this.passLLast.Location = new System.Drawing.Point(12, 9);
            this.passLLast.Name = "passLLast";
            this.passLLast.Size = new System.Drawing.Size(136, 13);
            this.passLLast.TabIndex = 9;
            this.passLLast.Text = "Введіть колишній пароль:";
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.savePass);
            this.Controls.Add(this.passNewConfirm);
            this.Controls.Add(this.passNew);
            this.Controls.Add(this.passLast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passLNew);
            this.Controls.Add(this.passLLast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Змінити пароль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePass_FormClosing);
            this.Load += new System.EventHandler(this.ChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savePass;
        private System.Windows.Forms.MaskedTextBox passNewConfirm;
        private System.Windows.Forms.MaskedTextBox passNew;
        private System.Windows.Forms.MaskedTextBox passLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passLNew;
        private System.Windows.Forms.Label passLLast;
    }
}