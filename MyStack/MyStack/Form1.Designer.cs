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
            this.pushItemButton = new System.Windows.Forms.Button();
            this.popItemButton = new System.Windows.Forms.Button();
            this.pushItemTextBox = new System.Windows.Forms.TextBox();
            this.popItemListBox = new System.Windows.Forms.ListBox();
            this.peekItemButton = new System.Windows.Forms.Button();
            this.peekItemListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 29;
            this.outputListBox.Location = new System.Drawing.Point(396, 12);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(261, 410);
            this.outputListBox.TabIndex = 0;
            // 
            // CreateStackButton
            // 
            this.CreateStackButton.Location = new System.Drawing.Point(61, 139);
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
            this.stackSizeTextBox.Location = new System.Drawing.Point(185, 139);
            this.stackSizeTextBox.Name = "stackSizeTextBox";
            this.stackSizeTextBox.Size = new System.Drawing.Size(155, 29);
            this.stackSizeTextBox.TabIndex = 2;
            // 
            // pushItemButton
            // 
            this.pushItemButton.Location = new System.Drawing.Point(61, 174);
            this.pushItemButton.Name = "pushItemButton";
            this.pushItemButton.Size = new System.Drawing.Size(118, 29);
            this.pushItemButton.TabIndex = 3;
            this.pushItemButton.Text = "Добавить элемент";
            this.pushItemButton.UseVisualStyleBackColor = true;
            this.pushItemButton.Click += new System.EventHandler(this.pushItemButton_Click);
            // 
            // popItemButton
            // 
            this.popItemButton.Location = new System.Drawing.Point(61, 209);
            this.popItemButton.Name = "popItemButton";
            this.popItemButton.Size = new System.Drawing.Size(118, 29);
            this.popItemButton.TabIndex = 4;
            this.popItemButton.Text = "Изъять элемент";
            this.popItemButton.UseVisualStyleBackColor = true;
            this.popItemButton.Click += new System.EventHandler(this.popItemButton_Click);
            // 
            // pushItemTextBox
            // 
            this.pushItemTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pushItemTextBox.Location = new System.Drawing.Point(185, 174);
            this.pushItemTextBox.Name = "pushItemTextBox";
            this.pushItemTextBox.Size = new System.Drawing.Size(155, 29);
            this.pushItemTextBox.TabIndex = 5;
            // 
            // popItemListBox
            // 
            this.popItemListBox.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.popItemListBox.FormattingEnabled = true;
            this.popItemListBox.ItemHeight = 25;
            this.popItemListBox.Location = new System.Drawing.Point(185, 209);
            this.popItemListBox.Name = "popItemListBox";
            this.popItemListBox.Size = new System.Drawing.Size(155, 29);
            this.popItemListBox.TabIndex = 6;
            // 
            // peekItemButton
            // 
            this.peekItemButton.Location = new System.Drawing.Point(61, 244);
            this.peekItemButton.Name = "peekItemButton";
            this.peekItemButton.Size = new System.Drawing.Size(118, 41);
            this.peekItemButton.TabIndex = 7;
            this.peekItemButton.Text = "Проверить верхний элемент";
            this.peekItemButton.UseVisualStyleBackColor = true;
            this.peekItemButton.Click += new System.EventHandler(this.peekItemButton_Click);
            // 
            // peekItemListBox
            // 
            this.peekItemListBox.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.peekItemListBox.FormattingEnabled = true;
            this.peekItemListBox.ItemHeight = 37;
            this.peekItemListBox.Location = new System.Drawing.Point(185, 244);
            this.peekItemListBox.Name = "peekItemListBox";
            this.peekItemListBox.Size = new System.Drawing.Size(155, 41);
            this.peekItemListBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.peekItemListBox);
            this.Controls.Add(this.peekItemButton);
            this.Controls.Add(this.popItemListBox);
            this.Controls.Add(this.pushItemTextBox);
            this.Controls.Add(this.popItemButton);
            this.Controls.Add(this.pushItemButton);
            this.Controls.Add(this.stackSizeTextBox);
            this.Controls.Add(this.CreateStackButton);
            this.Controls.Add(this.outputListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAOD_2072_Spirin_Vladislav_Task_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox outputListBox;
        private Button CreateStackButton;
        private TextBox stackSizeTextBox;
        private Button pushItemButton;
        private Button popItemButton;
        private TextBox pushItemTextBox;
        private ListBox popItemListBox;
        private Button peekItemButton;
        private ListBox peekItemListBox;
    }
}