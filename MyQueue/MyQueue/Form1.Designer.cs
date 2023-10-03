namespace MyQueue
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
            this.peekItemListBox = new System.Windows.Forms.ListBox();
            this.peekItemButton = new System.Windows.Forms.Button();
            this.popItemListBox = new System.Windows.Forms.ListBox();
            this.pushItemTextBox = new System.Windows.Forms.TextBox();
            this.popItemButton = new System.Windows.Forms.Button();
            this.pushItemButton = new System.Windows.Forms.Button();
            this.queueSizeTextBox = new System.Windows.Forms.TextBox();
            this.CreateQueueButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // peekItemListBox
            // 
            this.peekItemListBox.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.peekItemListBox.FormattingEnabled = true;
            this.peekItemListBox.ItemHeight = 37;
            this.peekItemListBox.Location = new System.Drawing.Point(226, 252);
            this.peekItemListBox.Name = "peekItemListBox";
            this.peekItemListBox.Size = new System.Drawing.Size(155, 41);
            this.peekItemListBox.TabIndex = 17;
            // 
            // peekItemButton
            // 
            this.peekItemButton.Location = new System.Drawing.Point(102, 252);
            this.peekItemButton.Name = "peekItemButton";
            this.peekItemButton.Size = new System.Drawing.Size(118, 41);
            this.peekItemButton.TabIndex = 16;
            this.peekItemButton.Text = "Проверить верхний элемент";
            this.peekItemButton.UseVisualStyleBackColor = true;
            this.peekItemButton.Click += new System.EventHandler(this.peekItemButton_Click);
            // 
            // popItemListBox
            // 
            this.popItemListBox.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.popItemListBox.FormattingEnabled = true;
            this.popItemListBox.ItemHeight = 25;
            this.popItemListBox.Location = new System.Drawing.Point(226, 217);
            this.popItemListBox.Name = "popItemListBox";
            this.popItemListBox.Size = new System.Drawing.Size(155, 29);
            this.popItemListBox.TabIndex = 15;
            // 
            // pushItemTextBox
            // 
            this.pushItemTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pushItemTextBox.Location = new System.Drawing.Point(226, 182);
            this.pushItemTextBox.Name = "pushItemTextBox";
            this.pushItemTextBox.Size = new System.Drawing.Size(155, 29);
            this.pushItemTextBox.TabIndex = 14;
            // 
            // popItemButton
            // 
            this.popItemButton.Location = new System.Drawing.Point(102, 217);
            this.popItemButton.Name = "popItemButton";
            this.popItemButton.Size = new System.Drawing.Size(118, 29);
            this.popItemButton.TabIndex = 13;
            this.popItemButton.Text = "Изъять элемент";
            this.popItemButton.UseVisualStyleBackColor = true;
            this.popItemButton.Click += new System.EventHandler(this.popItemButton_Click);
            // 
            // pushItemButton
            // 
            this.pushItemButton.Location = new System.Drawing.Point(102, 182);
            this.pushItemButton.Name = "pushItemButton";
            this.pushItemButton.Size = new System.Drawing.Size(118, 29);
            this.pushItemButton.TabIndex = 12;
            this.pushItemButton.Text = "Добавить элемент";
            this.pushItemButton.UseVisualStyleBackColor = true;
            this.pushItemButton.Click += new System.EventHandler(this.pushItemButton_Click);
            // 
            // queueSizeTextBox
            // 
            this.queueSizeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queueSizeTextBox.Location = new System.Drawing.Point(226, 147);
            this.queueSizeTextBox.Name = "queueSizeTextBox";
            this.queueSizeTextBox.Size = new System.Drawing.Size(155, 29);
            this.queueSizeTextBox.TabIndex = 11;
            // 
            // CreateQueueButton
            // 
            this.CreateQueueButton.Location = new System.Drawing.Point(102, 147);
            this.CreateQueueButton.Name = "CreateQueueButton";
            this.CreateQueueButton.Size = new System.Drawing.Size(118, 29);
            this.CreateQueueButton.TabIndex = 10;
            this.CreateQueueButton.Text = "Создать стек";
            this.CreateQueueButton.UseVisualStyleBackColor = true;
            this.CreateQueueButton.Click += new System.EventHandler(this.CreateQueueButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 29;
            this.outputListBox.Location = new System.Drawing.Point(437, 20);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(261, 410);
            this.outputListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.peekItemListBox);
            this.Controls.Add(this.peekItemButton);
            this.Controls.Add(this.popItemListBox);
            this.Controls.Add(this.pushItemTextBox);
            this.Controls.Add(this.popItemButton);
            this.Controls.Add(this.pushItemButton);
            this.Controls.Add(this.queueSizeTextBox);
            this.Controls.Add(this.CreateQueueButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox peekItemListBox;
        private Button peekItemButton;
        private ListBox popItemListBox;
        private TextBox pushItemTextBox;
        private Button popItemButton;
        private Button pushItemButton;
        private TextBox queueSizeTextBox;
        private Button CreateQueueButton;
        private ListBox outputListBox;
    }
}