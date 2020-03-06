namespace LibraryItems
{
    partial class patronForm
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
            this.components = new System.ComponentModel.Container();
            this.patronIDBox = new System.Windows.Forms.TextBox();
            this.patronNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patCancelButton = new System.Windows.Forms.Button();
            this.patAcceptButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // patronIDBox
            // 
            this.patronIDBox.Location = new System.Drawing.Point(28, 181);
            this.patronIDBox.Name = "patronIDBox";
            this.patronIDBox.Size = new System.Drawing.Size(419, 26);
            this.patronIDBox.TabIndex = 13;
            this.patronIDBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronIDBox_Validating);
            this.patronIDBox.Validated += new System.EventHandler(this.patronIDBox_Validated);
            // 
            // patronNameBox
            // 
            this.patronNameBox.Location = new System.Drawing.Point(28, 79);
            this.patronNameBox.Name = "patronNameBox";
            this.patronNameBox.Size = new System.Drawing.Size(419, 26);
            this.patronNameBox.TabIndex = 1;
            this.patronNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.patronNameBox_Validating);
            this.patronNameBox.Validated += new System.EventHandler(this.patronNameBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter Patron Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter Patron ID:";
            // 
            // patCancelButton
            // 
            this.patCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.patCancelButton.Location = new System.Drawing.Point(261, 236);
            this.patCancelButton.Name = "patCancelButton";
            this.patCancelButton.Size = new System.Drawing.Size(208, 72);
            this.patCancelButton.TabIndex = 18;
            this.patCancelButton.Text = "Cancel";
            this.patCancelButton.UseVisualStyleBackColor = true;
            this.patCancelButton.Click += new System.EventHandler(this.patCancelButton_Click);
            // 
            // patAcceptButton
            // 
            this.patAcceptButton.Location = new System.Drawing.Point(9, 236);
            this.patAcceptButton.Name = "patAcceptButton";
            this.patAcceptButton.Size = new System.Drawing.Size(208, 72);
            this.patAcceptButton.TabIndex = 17;
            this.patAcceptButton.TabStop = false;
            this.patAcceptButton.Text = "Accept";
            this.patAcceptButton.UseVisualStyleBackColor = true;
            this.patAcceptButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // patronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 360);
            this.Controls.Add(this.patCancelButton);
            this.Controls.Add(this.patAcceptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patronNameBox);
            this.Controls.Add(this.patronIDBox);
            this.Name = "patronForm";
            this.Text = "Patron Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patronIDBox;
        private System.Windows.Forms.TextBox patronNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button patCancelButton;
        private System.Windows.Forms.Button patAcceptButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}