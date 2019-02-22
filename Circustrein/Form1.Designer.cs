namespace Circustrein
{
    partial class Form1
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
            this.meatEaterRadioButton = new System.Windows.Forms.RadioButton();
            this.plantEaterRadioButton = new System.Windows.Forms.RadioButton();
            this.typeBox = new System.Windows.Forms.GroupBox();
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.bigRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.addAnimalButton = new System.Windows.Forms.Button();
            this.wagonTreeView = new System.Windows.Forms.TreeView();
            this.animalGroupBox = new System.Windows.Forms.ListBox();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.toGroupBoxButton = new System.Windows.Forms.Button();
            this.typeBox.SuspendLayout();
            this.sizeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // meatEaterRadioButton
            // 
            this.meatEaterRadioButton.AutoSize = true;
            this.meatEaterRadioButton.Checked = true;
            this.meatEaterRadioButton.Location = new System.Drawing.Point(47, 18);
            this.meatEaterRadioButton.Name = "meatEaterRadioButton";
            this.meatEaterRadioButton.Size = new System.Drawing.Size(98, 21);
            this.meatEaterRadioButton.TabIndex = 0;
            this.meatEaterRadioButton.TabStop = true;
            this.meatEaterRadioButton.Text = "Meat Eater";
            this.meatEaterRadioButton.UseVisualStyleBackColor = true;
            // 
            // plantEaterRadioButton
            // 
            this.plantEaterRadioButton.AutoSize = true;
            this.plantEaterRadioButton.Location = new System.Drawing.Point(47, 45);
            this.plantEaterRadioButton.Name = "plantEaterRadioButton";
            this.plantEaterRadioButton.Size = new System.Drawing.Size(99, 21);
            this.plantEaterRadioButton.TabIndex = 1;
            this.plantEaterRadioButton.Text = "Plant Eater";
            this.plantEaterRadioButton.UseVisualStyleBackColor = true;
            // 
            // typeBox
            // 
            this.typeBox.Controls.Add(this.plantEaterRadioButton);
            this.typeBox.Controls.Add(this.meatEaterRadioButton);
            this.typeBox.Location = new System.Drawing.Point(12, 14);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(263, 92);
            this.typeBox.TabIndex = 2;
            this.typeBox.TabStop = false;
            this.typeBox.Text = "Type";
            // 
            // sizeBox
            // 
            this.sizeBox.Controls.Add(this.bigRadioButton);
            this.sizeBox.Controls.Add(this.mediumRadioButton);
            this.sizeBox.Controls.Add(this.smallRadioButton);
            this.sizeBox.Location = new System.Drawing.Point(12, 112);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(263, 115);
            this.sizeBox.TabIndex = 3;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Size";
            // 
            // bigRadioButton
            // 
            this.bigRadioButton.AutoSize = true;
            this.bigRadioButton.Location = new System.Drawing.Point(47, 74);
            this.bigRadioButton.Name = "bigRadioButton";
            this.bigRadioButton.Size = new System.Drawing.Size(49, 21);
            this.bigRadioButton.TabIndex = 2;
            this.bigRadioButton.Text = "Big";
            this.bigRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(47, 47);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(78, 21);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Checked = true;
            this.smallRadioButton.Location = new System.Drawing.Point(47, 20);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(63, 21);
            this.smallRadioButton.TabIndex = 0;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // addAnimalButton
            // 
            this.addAnimalButton.Location = new System.Drawing.Point(305, 80);
            this.addAnimalButton.Name = "addAnimalButton";
            this.addAnimalButton.Size = new System.Drawing.Size(155, 64);
            this.addAnimalButton.TabIndex = 4;
            this.addAnimalButton.Text = ">";
            this.addAnimalButton.UseVisualStyleBackColor = true;
            this.addAnimalButton.Click += new System.EventHandler(this.addAnimalButton_Click);
            // 
            // wagonTreeView
            // 
            this.wagonTreeView.Location = new System.Drawing.Point(500, 14);
            this.wagonTreeView.Name = "wagonTreeView";
            this.wagonTreeView.Size = new System.Drawing.Size(275, 415);
            this.wagonTreeView.TabIndex = 5;
            // 
            // animalGroupBox
            // 
            this.animalGroupBox.FormattingEnabled = true;
            this.animalGroupBox.ItemHeight = 16;
            this.animalGroupBox.Location = new System.Drawing.Point(12, 297);
            this.animalGroupBox.Name = "animalGroupBox";
            this.animalGroupBox.Size = new System.Drawing.Size(263, 132);
            this.animalGroupBox.TabIndex = 6;
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(305, 297);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(155, 64);
            this.addGroupButton.TabIndex = 7;
            this.addGroupButton.Text = ">";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // toGroupBoxButton
            // 
            this.toGroupBoxButton.Location = new System.Drawing.Point(74, 244);
            this.toGroupBoxButton.Name = "toGroupBoxButton";
            this.toGroupBoxButton.Size = new System.Drawing.Size(108, 38);
            this.toGroupBoxButton.TabIndex = 8;
            this.toGroupBoxButton.Text = "V";
            this.toGroupBoxButton.UseVisualStyleBackColor = true;
            this.toGroupBoxButton.Click += new System.EventHandler(this.toGroupBoxButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 617);
            this.Controls.Add(this.toGroupBoxButton);
            this.Controls.Add(this.addGroupButton);
            this.Controls.Add(this.animalGroupBox);
            this.Controls.Add(this.addAnimalButton);
            this.Controls.Add(this.wagonTreeView);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.typeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
            this.sizeBox.ResumeLayout(false);
            this.sizeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton meatEaterRadioButton;
        private System.Windows.Forms.RadioButton plantEaterRadioButton;
        private System.Windows.Forms.GroupBox typeBox;
        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.RadioButton bigRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.Button addAnimalButton;
        private System.Windows.Forms.TreeView wagonTreeView;
        private System.Windows.Forms.ListBox animalGroupBox;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.Button toGroupBoxButton;
    }
}

