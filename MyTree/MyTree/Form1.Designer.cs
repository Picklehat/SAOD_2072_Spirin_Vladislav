namespace MyTree
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
            insertButton = new Button();
            insertTextBox = new TextBox();
            containsTextBox = new TextBox();
            containsButton = new Button();
            containsLabel = new Label();
            deleteTextBox = new TextBox();
            deleteButton = new Button();
            outputLabel = new Label();
            outputTextBox = new TextBox();
            CLRButton = new Button();
            LCRButton = new Button();
            RCLButton = new Button();
            acrossButton = new Button();
            SuspendLayout();
            // 
            // insertButton
            // 
            insertButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            insertButton.Location = new Point(12, 17);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(108, 29);
            insertButton.TabIndex = 0;
            insertButton.Text = "Добавить";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click;
            // 
            // insertTextBox
            // 
            insertTextBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            insertTextBox.Location = new Point(126, 17);
            insertTextBox.Name = "insertTextBox";
            insertTextBox.Size = new Size(100, 29);
            insertTextBox.TabIndex = 1;
            // 
            // containsTextBox
            // 
            containsTextBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            containsTextBox.Location = new Point(126, 52);
            containsTextBox.Name = "containsTextBox";
            containsTextBox.Size = new Size(100, 29);
            containsTextBox.TabIndex = 3;
            // 
            // containsButton
            // 
            containsButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            containsButton.Location = new Point(12, 52);
            containsButton.Name = "containsButton";
            containsButton.Size = new Size(108, 29);
            containsButton.TabIndex = 2;
            containsButton.Text = "Поиск";
            containsButton.UseVisualStyleBackColor = true;
            containsButton.Click += containsButton_Click;
            // 
            // containsLabel
            // 
            containsLabel.AutoSize = true;
            containsLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            containsLabel.Location = new Point(232, 55);
            containsLabel.Name = "containsLabel";
            containsLabel.Size = new Size(0, 22);
            containsLabel.TabIndex = 4;
            // 
            // deleteTextBox
            // 
            deleteTextBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteTextBox.Location = new Point(126, 87);
            deleteTextBox.Name = "deleteTextBox";
            deleteTextBox.Size = new Size(100, 29);
            deleteTextBox.TabIndex = 6;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(12, 87);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(108, 29);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            outputLabel.Location = new Point(12, 299);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(74, 22);
            outputLabel.TabIndex = 7;
            outputLabel.Text = "Вывод:";
            // 
            // outputTextBox
            // 
            outputTextBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            outputTextBox.Location = new Point(92, 296);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(562, 29);
            outputTextBox.TabIndex = 8;
            // 
            // CLRButton
            // 
            CLRButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CLRButton.Location = new Point(12, 262);
            CLRButton.Name = "CLRButton";
            CLRButton.Size = new Size(159, 29);
            CLRButton.TabIndex = 9;
            CLRButton.Text = "Прямой обход";
            CLRButton.UseVisualStyleBackColor = true;
            CLRButton.Click += CLRButton_Click;
            // 
            // LCRButton
            // 
            LCRButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LCRButton.Location = new Point(177, 261);
            LCRButton.Name = "LCRButton";
            LCRButton.Size = new Size(159, 29);
            LCRButton.TabIndex = 10;
            LCRButton.Text = "Обратный обход";
            LCRButton.UseVisualStyleBackColor = true;
            LCRButton.Click += LCRButton_Click;
            // 
            // RCLButton
            // 
            RCLButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RCLButton.Location = new Point(507, 261);
            RCLButton.Name = "RCLButton";
            RCLButton.Size = new Size(147, 29);
            RCLButton.TabIndex = 11;
            RCLButton.Text = "Концевой обход";
            RCLButton.UseVisualStyleBackColor = true;
            RCLButton.Click += RCLButton_Click;
            // 
            // acrossButton
            // 
            acrossButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            acrossButton.Location = new Point(342, 261);
            acrossButton.Name = "acrossButton";
            acrossButton.Size = new Size(159, 29);
            acrossButton.TabIndex = 12;
            acrossButton.Text = "Обход в ширину";
            acrossButton.UseVisualStyleBackColor = true;
            acrossButton.Click += acrossButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 334);
            Controls.Add(acrossButton);
            Controls.Add(RCLButton);
            Controls.Add(LCRButton);
            Controls.Add(CLRButton);
            Controls.Add(outputTextBox);
            Controls.Add(outputLabel);
            Controls.Add(deleteTextBox);
            Controls.Add(deleteButton);
            Controls.Add(containsLabel);
            Controls.Add(containsTextBox);
            Controls.Add(containsButton);
            Controls.Add(insertTextBox);
            Controls.Add(insertButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button insertButton;
        private TextBox insertTextBox;
        private TextBox containsTextBox;
        private Button containsButton;
        private Label containsLabel;
        private TextBox deleteTextBox;
        private Button deleteButton;
        private Label outputLabel;
        private TextBox outputTextBox;
        private Button CLRButton;
        private Button LCRButton;
        private Button RCLButton;
        private Button acrossButton;
    }
}