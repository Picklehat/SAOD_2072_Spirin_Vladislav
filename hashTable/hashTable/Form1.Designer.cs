namespace MyHashTable
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
            addButton = new Button();
            findButton = new Button();
            deleteButton = new Button();
            outputListBox = new ListBox();
            addKeyTextBox = new TextBox();
            addValueTextBox = new TextBox();
            findKeyTextBox = new TextBox();
            deleteKeyTextBox = new TextBox();
            lablel1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(26, 20);
            addButton.Name = "addButton";
            addButton.Size = new Size(121, 47);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // findButton
            // 
            findButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            findButton.Location = new Point(26, 86);
            findButton.Name = "findButton";
            findButton.Size = new Size(121, 47);
            findButton.TabIndex = 1;
            findButton.Text = "Найти";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(26, 147);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(121, 47);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // outputListBox
            // 
            outputListBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 22;
            outputListBox.Location = new Point(365, 26);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(564, 334);
            outputListBox.TabIndex = 3;
            // 
            // addKeyTextBox
            // 
            addKeyTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addKeyTextBox.Location = new Point(153, 41);
            addKeyTextBox.Name = "addKeyTextBox";
            addKeyTextBox.Size = new Size(100, 26);
            addKeyTextBox.TabIndex = 4;
            // 
            // addValueTextBox
            // 
            addValueTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addValueTextBox.Location = new Point(259, 41);
            addValueTextBox.Name = "addValueTextBox";
            addValueTextBox.Size = new Size(100, 26);
            addValueTextBox.TabIndex = 5;
            // 
            // findKeyTextBox
            // 
            findKeyTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            findKeyTextBox.Location = new Point(153, 107);
            findKeyTextBox.Name = "findKeyTextBox";
            findKeyTextBox.Size = new Size(100, 26);
            findKeyTextBox.TabIndex = 6;
            // 
            // deleteKeyTextBox
            // 
            deleteKeyTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteKeyTextBox.Location = new Point(153, 168);
            deleteKeyTextBox.Name = "deleteKeyTextBox";
            deleteKeyTextBox.Size = new Size(100, 26);
            deleteKeyTextBox.TabIndex = 7;
            // 
            // lablel1
            // 
            lablel1.AutoSize = true;
            lablel1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lablel1.Location = new Point(179, 20);
            lablel1.Name = "lablel1";
            lablel1.Size = new Size(45, 18);
            lablel1.TabIndex = 8;
            lablel1.Text = "Ключ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(179, 86);
            label1.Name = "label1";
            label1.Size = new Size(45, 18);
            label1.TabIndex = 9;
            label1.Text = "Ключ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 147);
            label2.Name = "label2";
            label2.Size = new Size(45, 18);
            label2.TabIndex = 10;
            label2.Text = "Ключ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(271, 20);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 11;
            label3.Text = "Значение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(254, 111);
            label4.Name = "label4";
            label4.Size = new Size(26, 18);
            label4.TabIndex = 12;
            label4.Text = "=>";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(286, 111);
            label5.Name = "label5";
            label5.Size = new Size(0, 18);
            label5.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 390);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lablel1);
            Controls.Add(deleteKeyTextBox);
            Controls.Add(findKeyTextBox);
            Controls.Add(addValueTextBox);
            Controls.Add(addKeyTextBox);
            Controls.Add(outputListBox);
            Controls.Add(deleteButton);
            Controls.Add(findButton);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button findButton;
        private Button deleteButton;
        private ListBox outputListBox;
        private TextBox addKeyTextBox;
        private TextBox addValueTextBox;
        private TextBox findKeyTextBox;
        private TextBox deleteKeyTextBox;
        private Label lablel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}