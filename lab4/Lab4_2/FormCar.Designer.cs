﻿namespace Lab4_2
{
    partial class FormCar
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
            this.MarkTextBox = new System.Windows.Forms.TextBox();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceRentlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PriceRentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MarkTextBox
            // 
            this.MarkTextBox.Location = new System.Drawing.Point(116, 12);
            this.MarkTextBox.Name = "MarkTextBox";
            this.MarkTextBox.Size = new System.Drawing.Size(120, 20);
            this.MarkTextBox.TabIndex = 0;
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Location = new System.Drawing.Point(9, 15);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(40, 13);
            this.MarkLabel.TabIndex = 1;
            this.MarkLabel.Text = "Марка";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(9, 50);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(62, 13);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Стоимость";
            // 
            // PriceRentlabel
            // 
            this.PriceRentlabel.AutoSize = true;
            this.PriceRentlabel.Location = new System.Drawing.Point(9, 82);
            this.PriceRentlabel.Name = "PriceRentlabel";
            this.PriceRentlabel.Size = new System.Drawing.Size(103, 13);
            this.PriceRentlabel.TabIndex = 3;
            this.PriceRentlabel.Text = "Стоимость аренды";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тип";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(116, 112);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(120, 21);
            this.TypeComboBox.TabIndex = 5;
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.Location = new System.Drawing.Point(116, 48);
            this.PriceNumericUpDown.Name = "PriceNumericUpDown";
            this.PriceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PriceNumericUpDown.TabIndex = 6;
            // 
            // PriceRentNumericUpDown
            // 
            this.PriceRentNumericUpDown.Location = new System.Drawing.Point(118, 80);
            this.PriceRentNumericUpDown.Name = "PriceRentNumericUpDown";
            this.PriceRentNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PriceRentNumericUpDown.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(161, 139);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 169);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PriceRentNumericUpDown);
            this.Controls.Add(this.PriceNumericUpDown);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceRentlabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.MarkTextBox);
            this.Name = "FormCar";
            this.Text = "Автомобиль";
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRentNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MarkTextBox;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label PriceRentlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown PriceRentNumericUpDown;
        private System.Windows.Forms.Button SaveButton;
    }
}