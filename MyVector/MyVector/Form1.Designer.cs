namespace MyVector
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
            addItemTextBox = new TextBox();
            addItemButton = new Button();
            vectorSizeTextBox = new TextBox();
            CreateVectorButton = new Button();
            outputListBox = new ListBox();
            setValueButton = new Button();
            indexTextBox = new TextBox();
            itemTextBox = new TextBox();
            capacityListBox = new ListBox();
            sizeListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            reserveButton = new Button();
            reserveTextBox = new TextBox();
            resizeTextBox = new TextBox();
            resizeButton = new Button();
            shrinkToFitButton = new Button();
            SuspendLayout();
            // 
            // addItemTextBox
            // 
            addItemTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addItemTextBox.Location = new Point(205, 89);
            addItemTextBox.Name = "addItemTextBox";
            addItemTextBox.Size = new Size(155, 29);
            addItemTextBox.TabIndex = 23;
            // 
            // addItemButton
            // 
            addItemButton.Location = new Point(81, 84);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(118, 41);
            addItemButton.TabIndex = 21;
            addItemButton.Text = "Добавить элемент в конец";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // vectorSizeTextBox
            // 
            vectorSizeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vectorSizeTextBox.Location = new Point(205, 49);
            vectorSizeTextBox.Name = "vectorSizeTextBox";
            vectorSizeTextBox.Size = new Size(155, 29);
            vectorSizeTextBox.TabIndex = 20;
            // 
            // CreateVectorButton
            // 
            CreateVectorButton.Location = new Point(81, 49);
            CreateVectorButton.Name = "CreateVectorButton";
            CreateVectorButton.Size = new Size(118, 29);
            CreateVectorButton.TabIndex = 19;
            CreateVectorButton.Text = "Создать вектор";
            CreateVectorButton.UseVisualStyleBackColor = true;
            CreateVectorButton.Click += CreateVectorButton_Click;
            // 
            // outputListBox
            // 
            outputListBox.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 29;
            outputListBox.Location = new Point(448, 20);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(261, 381);
            outputListBox.TabIndex = 18;
            // 
            // setValueButton
            // 
            setValueButton.Location = new Point(81, 131);
            setValueButton.Name = "setValueButton";
            setValueButton.Size = new Size(118, 64);
            setValueButton.TabIndex = 27;
            setValueButton.Text = "Добавить элемент по индексу\r\n";
            setValueButton.UseVisualStyleBackColor = true;
            setValueButton.Click += setValueButton_Click;
            // 
            // indexTextBox
            // 
            indexTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            indexTextBox.Location = new Point(205, 166);
            indexTextBox.Name = "indexTextBox";
            indexTextBox.Size = new Size(75, 29);
            indexTextBox.TabIndex = 28;
            // 
            // itemTextBox
            // 
            itemTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemTextBox.Location = new Point(286, 166);
            itemTextBox.Name = "itemTextBox";
            itemTextBox.Size = new Size(74, 29);
            itemTextBox.TabIndex = 29;
            // 
            // capacityListBox
            // 
            capacityListBox.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point);
            capacityListBox.FormattingEnabled = true;
            capacityListBox.ItemHeight = 16;
            capacityListBox.Location = new Point(448, 418);
            capacityListBox.Name = "capacityListBox";
            capacityListBox.Size = new Size(129, 20);
            capacityListBox.TabIndex = 30;
            // 
            // sizeListBox
            // 
            sizeListBox.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point);
            sizeListBox.FormattingEnabled = true;
            sizeListBox.ItemHeight = 16;
            sizeListBox.Location = new Point(583, 418);
            sizeListBox.Name = "sizeListBox";
            sizeListBox.Size = new Size(129, 20);
            sizeListBox.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(211, 142);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 32;
            label1.Text = "Индекс";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(295, 142);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 33;
            label2.Text = "Число";
            // 
            // reserveButton
            // 
            reserveButton.Location = new Point(81, 248);
            reserveButton.Name = "reserveButton";
            reserveButton.Size = new Size(118, 41);
            reserveButton.TabIndex = 34;
            reserveButton.Text = "Зарезервировать место";
            reserveButton.UseVisualStyleBackColor = true;
            reserveButton.Click += reserveButton_Click;
            // 
            // reserveTextBox
            // 
            reserveTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reserveTextBox.Location = new Point(205, 253);
            reserveTextBox.Name = "reserveTextBox";
            reserveTextBox.Size = new Size(155, 29);
            reserveTextBox.TabIndex = 35;
            // 
            // resizeTextBox
            // 
            resizeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resizeTextBox.Location = new Point(205, 206);
            resizeTextBox.Name = "resizeTextBox";
            resizeTextBox.Size = new Size(155, 29);
            resizeTextBox.TabIndex = 37;
            // 
            // resizeButton
            // 
            resizeButton.Location = new Point(81, 201);
            resizeButton.Name = "resizeButton";
            resizeButton.Size = new Size(118, 41);
            resizeButton.TabIndex = 36;
            resizeButton.Text = "Переназначить размер";
            resizeButton.UseVisualStyleBackColor = true;
            resizeButton.Click += resizeButton_Click;
            // 
            // shrinkToFitButton
            // 
            shrinkToFitButton.Location = new Point(81, 295);
            shrinkToFitButton.Name = "shrinkToFitButton";
            shrinkToFitButton.Size = new Size(279, 33);
            shrinkToFitButton.TabIndex = 38;
            shrinkToFitButton.Text = "Выровнить Capacity и Size";
            shrinkToFitButton.UseVisualStyleBackColor = true;
            shrinkToFitButton.Click += shrinkToFitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
            Controls.Add(shrinkToFitButton);
            Controls.Add(resizeTextBox);
            Controls.Add(resizeButton);
            Controls.Add(reserveTextBox);
            Controls.Add(reserveButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sizeListBox);
            Controls.Add(capacityListBox);
            Controls.Add(itemTextBox);
            Controls.Add(indexTextBox);
            Controls.Add(setValueButton);
            Controls.Add(addItemTextBox);
            Controls.Add(addItemButton);
            Controls.Add(vectorSizeTextBox);
            Controls.Add(CreateVectorButton);
            Controls.Add(outputListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox addItemTextBox;
        private Button addItemButton;
        private TextBox vectorSizeTextBox;
        private Button CreateVectorButton;
        private ListBox outputListBox;
        private Button setValueButton;
        private TextBox indexTextBox;
        private TextBox itemTextBox;
        private ListBox capacityListBox;
        private ListBox sizeListBox;
        private Label label1;
        private Label label2;
        private Button reserveButton;
        private TextBox reserveTextBox;
        private TextBox resizeTextBox;
        private Button resizeButton;
        private Button shrinkToFitButton;
    }
}