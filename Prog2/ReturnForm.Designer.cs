namespace LibraryItems
{
    partial class ReturnForm
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
            this.CancelReturnButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelReturnButton
            // 
            this.CancelReturnButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelReturnButton.Location = new System.Drawing.Point(293, 197);
            this.CancelReturnButton.Name = "CancelReturnButton";
            this.CancelReturnButton.Size = new System.Drawing.Size(208, 72);
            this.CancelReturnButton.TabIndex = 11;
            this.CancelReturnButton.Text = "Cancel";
            this.CancelReturnButton.UseVisualStyleBackColor = true;
            this.CancelReturnButton.Click += new System.EventHandler(this.CancelReturnButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(41, 197);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(208, 72);
            this.ReturnButton.TabIndex = 10;
            this.ReturnButton.Text = "Accept";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Item:";
            // 
            // ReturnComboBox
            // 
            this.ReturnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReturnComboBox.FormattingEnabled = true;
            this.ReturnComboBox.Location = new System.Drawing.Point(41, 99);
            this.ReturnComboBox.Name = "ReturnComboBox";
            this.ReturnComboBox.Size = new System.Drawing.Size(460, 28);
            this.ReturnComboBox.TabIndex = 6;
            // 
            // ReturnForm
            // 
            this.AcceptButton = this.ReturnButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelReturnButton;
            this.ClientSize = new System.Drawing.Size(555, 327);
            this.Controls.Add(this.CancelReturnButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnComboBox);
            this.Name = "ReturnForm";
            this.Text = "Return Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelReturnButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ReturnComboBox;
    }
}