namespace MyList
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
            label2 = new Label();
            label1 = new Label();
            searchResultListBox = new ListBox();
            itemTextBox = new TextBox();
            indexTextBox = new TextBox();
            setValueButton = new Button();
            appendItemTextBox = new TextBox();
            appendItemButton = new Button();
            CreateListButton = new Button();
            outputListBox = new ListBox();
            prependItemTextBox = new TextBox();
            prependItemButton = new Button();
            label3 = new Label();
            label4 = new Label();
            findTextBox = new TextBox();
            findButton = new Button();
            label5 = new Label();
            label6 = new Label();
            containsTextBox = new TextBox();
            containsButton = new Button();
            containsListBox = new ListBox();
            label8 = new Label();
            atTextBox = new TextBox();
            atButton = new Button();
            label7 = new Label();
            atListBox = new ListBox();
            removeAtTextBox = new TextBox();
            removeAtButton = new Button();
            removeButton = new Button();
            removeTextBox = new TextBox();
            insertButton = new Button();
            label9 = new Label();
            label10 = new Label();
            insertValueTextBox = new TextBox();
            insertIndexTextBox = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(467, 212);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 50;
            label2.Text = "Число";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(543, 212);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 49;
            label1.Text = "Индекс";
            // 
            // searchResultListBox
            // 
            searchResultListBox.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            searchResultListBox.FormattingEnabled = true;
            searchResultListBox.ItemHeight = 23;
            searchResultListBox.Location = new Point(538, 96);
            searchResultListBox.Name = "searchResultListBox";
            searchResultListBox.Size = new Size(75, 27);
            searchResultListBox.TabIndex = 47;
            // 
            // itemTextBox
            // 
            itemTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemTextBox.Location = new Point(458, 236);
            itemTextBox.Name = "itemTextBox";
            itemTextBox.Size = new Size(74, 29);
            itemTextBox.TabIndex = 46;
            // 
            // indexTextBox
            // 
            indexTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            indexTextBox.Location = new Point(538, 236);
            indexTextBox.Name = "indexTextBox";
            indexTextBox.Size = new Size(75, 29);
            indexTextBox.TabIndex = 45;
            // 
            // setValueButton
            // 
            setValueButton.Location = new Point(334, 201);
            setValueButton.Name = "setValueButton";
            setValueButton.Size = new Size(118, 64);
            setValueButton.TabIndex = 44;
            setValueButton.Text = "Установить значение для элемента";
            setValueButton.UseVisualStyleBackColor = true;
            setValueButton.Click += setValueButton_Click;
            // 
            // appendItemTextBox
            // 
            appendItemTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            appendItemTextBox.Location = new Point(136, 62);
            appendItemTextBox.Name = "appendItemTextBox";
            appendItemTextBox.Size = new Size(155, 29);
            appendItemTextBox.TabIndex = 43;
            // 
            // appendItemButton
            // 
            appendItemButton.Location = new Point(12, 57);
            appendItemButton.Name = "appendItemButton";
            appendItemButton.Size = new Size(118, 41);
            appendItemButton.TabIndex = 42;
            appendItemButton.Text = "Добавить элемент в конец";
            appendItemButton.UseVisualStyleBackColor = true;
            appendItemButton.Click += appendItemButton_Click;
            // 
            // CreateListButton
            // 
            CreateListButton.Location = new Point(12, 22);
            CreateListButton.Name = "CreateListButton";
            CreateListButton.Size = new Size(279, 29);
            CreateListButton.TabIndex = 40;
            CreateListButton.Text = "Создать лист";
            CreateListButton.UseVisualStyleBackColor = true;
            CreateListButton.Click += CreateListButton_Click;
            // 
            // outputListBox
            // 
            outputListBox.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 29;
            outputListBox.Location = new Point(656, 12);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(261, 381);
            outputListBox.TabIndex = 39;
            // 
            // prependItemTextBox
            // 
            prependItemTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prependItemTextBox.Location = new Point(136, 109);
            prependItemTextBox.Name = "prependItemTextBox";
            prependItemTextBox.Size = new Size(155, 29);
            prependItemTextBox.TabIndex = 57;
            // 
            // prependItemButton
            // 
            prependItemButton.Location = new Point(12, 104);
            prependItemButton.Name = "prependItemButton";
            prependItemButton.Size = new Size(118, 41);
            prependItemButton.TabIndex = 56;
            prependItemButton.Text = "Добавить элемент в начало";
            prependItemButton.UseVisualStyleBackColor = true;
            prependItemButton.Click += prependItemButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(467, 72);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 62;
            label3.Text = "Число";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(543, 72);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 61;
            label4.Text = "Индекс";
            // 
            // findTextBox
            // 
            findTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            findTextBox.Location = new Point(458, 96);
            findTextBox.Name = "findTextBox";
            findTextBox.Size = new Size(74, 29);
            findTextBox.TabIndex = 60;
            // 
            // findButton
            // 
            findButton.Location = new Point(334, 61);
            findButton.Name = "findButton";
            findButton.Size = new Size(118, 64);
            findButton.TabIndex = 58;
            findButton.Text = "Найти индеск числа";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(467, 142);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 67;
            label5.Text = "Число";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(549, 144);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 66;
            label6.Text = "Ответ";
            // 
            // containsTextBox
            // 
            containsTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            containsTextBox.Location = new Point(458, 166);
            containsTextBox.Name = "containsTextBox";
            containsTextBox.Size = new Size(74, 29);
            containsTextBox.TabIndex = 65;
            // 
            // containsButton
            // 
            containsButton.Location = new Point(334, 131);
            containsButton.Name = "containsButton";
            containsButton.Size = new Size(118, 64);
            containsButton.TabIndex = 64;
            containsButton.Text = "Содержит ли лист число";
            containsButton.UseVisualStyleBackColor = true;
            containsButton.Click += containsButton_Click;
            // 
            // containsListBox
            // 
            containsListBox.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            containsListBox.FormattingEnabled = true;
            containsListBox.ItemHeight = 23;
            containsListBox.Location = new Point(538, 168);
            containsListBox.Name = "containsListBox";
            containsListBox.Size = new Size(75, 27);
            containsListBox.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(458, 285);
            label8.Name = "label8";
            label8.Size = new Size(63, 21);
            label8.TabIndex = 71;
            label8.Text = "Индекс";
            // 
            // atTextBox
            // 
            atTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            atTextBox.Location = new Point(459, 309);
            atTextBox.Name = "atTextBox";
            atTextBox.Size = new Size(62, 29);
            atTextBox.TabIndex = 69;
            // 
            // atButton
            // 
            atButton.Location = new Point(334, 271);
            atButton.Name = "atButton";
            atButton.Size = new Size(118, 69);
            atButton.TabIndex = 68;
            atButton.Text = "Получить элемент по индексу";
            atButton.UseVisualStyleBackColor = true;
            atButton.Click += atButton_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(532, 271);
            label7.Name = "label7";
            label7.Size = new Size(81, 42);
            label7.TabIndex = 73;
            label7.Text = "Значение элемента";
            // 
            // atListBox
            // 
            atListBox.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            atListBox.FormattingEnabled = true;
            atListBox.ItemHeight = 23;
            atListBox.Location = new Point(532, 313);
            atListBox.Name = "atListBox";
            atListBox.Size = new Size(81, 27);
            atListBox.TabIndex = 72;
            // 
            // removeAtTextBox
            // 
            removeAtTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            removeAtTextBox.Location = new Point(205, 162);
            removeAtTextBox.Name = "removeAtTextBox";
            removeAtTextBox.Size = new Size(86, 29);
            removeAtTextBox.TabIndex = 75;
            // 
            // removeAtButton
            // 
            removeAtButton.Location = new Point(12, 157);
            removeAtButton.Name = "removeAtButton";
            removeAtButton.Size = new Size(187, 41);
            removeAtButton.TabIndex = 74;
            removeAtButton.Text = "Удалить элемент по индексу";
            removeAtButton.UseVisualStyleBackColor = true;
            removeAtButton.Click += removeAtButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(12, 204);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(187, 41);
            removeButton.TabIndex = 76;
            removeButton.Text = "Удалить элемент по значению";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // removeTextBox
            // 
            removeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            removeTextBox.Location = new Point(205, 209);
            removeTextBox.Name = "removeTextBox";
            removeTextBox.Size = new Size(86, 29);
            removeTextBox.TabIndex = 77;
            // 
            // insertButton
            // 
            insertButton.Location = new Point(12, 260);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(118, 51);
            insertButton.TabIndex = 78;
            insertButton.Text = "Добавить элемент по индексу";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(226, 256);
            label9.Name = "label9";
            label9.Size = new Size(54, 21);
            label9.TabIndex = 82;
            label9.Text = "Число";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(141, 258);
            label10.Name = "label10";
            label10.Size = new Size(63, 21);
            label10.TabIndex = 81;
            label10.Text = "Индекс";
            // 
            // insertValueTextBox
            // 
            insertValueTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            insertValueTextBox.Location = new Point(217, 282);
            insertValueTextBox.Name = "insertValueTextBox";
            insertValueTextBox.Size = new Size(74, 29);
            insertValueTextBox.TabIndex = 80;
            // 
            // insertIndexTextBox
            // 
            insertIndexTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            insertIndexTextBox.Location = new Point(136, 282);
            insertIndexTextBox.Name = "insertIndexTextBox";
            insertIndexTextBox.Size = new Size(75, 29);
            insertIndexTextBox.TabIndex = 79;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 408);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(insertValueTextBox);
            Controls.Add(insertIndexTextBox);
            Controls.Add(insertButton);
            Controls.Add(removeTextBox);
            Controls.Add(removeButton);
            Controls.Add(removeAtTextBox);
            Controls.Add(removeAtButton);
            Controls.Add(label7);
            Controls.Add(atListBox);
            Controls.Add(label8);
            Controls.Add(atTextBox);
            Controls.Add(atButton);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(containsTextBox);
            Controls.Add(containsButton);
            Controls.Add(containsListBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(findTextBox);
            Controls.Add(findButton);
            Controls.Add(prependItemTextBox);
            Controls.Add(prependItemButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchResultListBox);
            Controls.Add(itemTextBox);
            Controls.Add(indexTextBox);
            Controls.Add(setValueButton);
            Controls.Add(appendItemTextBox);
            Controls.Add(appendItemButton);
            Controls.Add(CreateListButton);
            Controls.Add(outputListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private ListBox searchResultListBox;
        private TextBox itemTextBox;
        private TextBox indexTextBox;
        private Button setValueButton;
        private TextBox appendItemTextBox;
        private Button appendItemButton;
        private Button CreateListButton;
        private ListBox outputListBox;
        private TextBox prependItemTextBox;
        private Button prependItemButton;
        private Label label3;
        private Label label4;
        private TextBox findTextBox;
        private Button findButton;
        private Label label5;
        private Label label6;
        private TextBox containsTextBox;
        private Button containsButton;
        private ListBox containsListBox;
        private Label label8;
        private TextBox atTextBox;
        private Button atButton;
        private Label label7;
        private ListBox atListBox;
        private TextBox removeAtTextBox;
        private Button removeAtButton;
        private Button removeButton;
        private TextBox removeTextBox;
        private Button insertButton;
        private Label label9;
        private Label label10;
        private TextBox insertValueTextBox;
        private TextBox insertIndexTextBox;
    }
}