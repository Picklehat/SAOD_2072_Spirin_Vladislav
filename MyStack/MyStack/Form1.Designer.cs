namespace MyStack
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.CreateStackButton = new System.Windows.Forms.Button();
            this.stackSizeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 15;
            this.outputListBox.Location = new System.Drawing.Point(480, 12);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(261, 424);
            this.outputListBox.TabIndex = 0;
            // 
            // CreateStackButton
            // 
            this.CreateStackButton.Location = new System.Drawing.Point(76, 110);
            this.CreateStackButton.Name = "CreateStackButton";
            this.CreateStackButton.Size = new System.Drawing.Size(118, 29);
            this.CreateStackButton.TabIndex = 1;
            this.CreateStackButton.Text = "Создать стек";
            this.CreateStackButton.UseVisualStyleBackColor = true;
            this.CreateStackButton.Click += new System.EventHandler(this.CreateStackButton_Click);
            // 
            // stackSizeTextBox
            // 
            this.stackSizeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stackSizeTextBox.Location = new System.Drawing.Point(200, 110);
            this.stackSizeTextBox.Name = "stackSizeTextBox";
            this.stackSizeTextBox.Size = new System.Drawing.Size(120, 29);
            this.stackSizeTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stackSizeTextBox);
            this.Controls.Add(this.CreateStackButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox outputListBox;
        private Button CreateStackButton;
        private TextBox stackSizeTextBox;
    }
}