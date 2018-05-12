namespace BudgetTracking
{
    partial class BudgetForm
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
            this.labelSingleItem = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelBudgetInfo = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSubmitInfo = new System.Windows.Forms.Button();
            this.labelItemName = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.comboBoxItemCategory = new System.Windows.Forms.ComboBox();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.pictureBoxLargestItem = new System.Windows.Forms.PictureBox();
            this.pictureBoxLargestGroup = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLargestItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLargestGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSingleItem
            // 
            this.labelSingleItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelSingleItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSingleItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSingleItem.Location = new System.Drawing.Point(12, 25);
            this.labelSingleItem.Name = "labelSingleItem";
            this.labelSingleItem.Size = new System.Drawing.Size(372, 46);
            this.labelSingleItem.TabIndex = 0;
            this.labelSingleItem.Text = "Largest Item This Month";
            this.labelSingleItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGroup
            // 
            this.labelGroup.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGroup.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(390, 25);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(418, 46);
            this.labelGroup.TabIndex = 1;
            this.labelGroup.Text = "Largest Group This Month";
            this.labelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBudgetInfo
            // 
            this.labelBudgetInfo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelBudgetInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBudgetInfo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBudgetInfo.Location = new System.Drawing.Point(814, 25);
            this.labelBudgetInfo.Name = "labelBudgetInfo";
            this.labelBudgetInfo.Size = new System.Drawing.Size(336, 46);
            this.labelBudgetInfo.TabIndex = 2;
            this.labelBudgetInfo.Text = "Over/Under Budget";
            this.labelBudgetInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(511, 510);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(167, 21);
            this.labelAdd.TabIndex = 3;
            this.labelAdd.Text = "Add New Payment";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(498, 534);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // buttonSubmitInfo
            // 
            this.buttonSubmitInfo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitInfo.Location = new System.Drawing.Point(1035, 661);
            this.buttonSubmitInfo.Name = "buttonSubmitInfo";
            this.buttonSubmitInfo.Size = new System.Drawing.Size(115, 37);
            this.buttonSubmitInfo.TabIndex = 5;
            this.buttonSubmitInfo.Text = "Submit";
            this.buttonSubmitInfo.UseVisualStyleBackColor = true;
            this.buttonSubmitInfo.Click += new System.EventHandler(this.buttonSubmitInfo_Click);
            // 
            // labelItemName
            // 
            this.labelItemName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.Location = new System.Drawing.Point(12, 571);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(335, 130);
            this.labelItemName.TabIndex = 6;
            this.labelItemName.Text = "Item Name";
            this.labelItemName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(30, 621);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(304, 20);
            this.textBoxItemName.TabIndex = 7;
            // 
            // comboBoxItemCategory
            // 
            this.comboBoxItemCategory.FormattingEnabled = true;
            this.comboBoxItemCategory.Location = new System.Drawing.Point(739, 621);
            this.comboBoxItemCategory.Name = "comboBoxItemCategory";
            this.comboBoxItemCategory.Size = new System.Drawing.Size(231, 21);
            this.comboBoxItemCategory.TabIndex = 8;
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Location = new System.Drawing.Point(419, 621);
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(192, 20);
            this.textBoxItemPrice.TabIndex = 14;
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(353, 571);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(335, 130);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "Item Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCategory
            // 
            this.labelCategory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(694, 571);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(335, 130);
            this.labelCategory.TabIndex = 16;
            this.labelCategory.Text = "Item Category";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(374, 622);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(304, 20);
            this.textBoxPrice.TabIndex = 17;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(707, 622);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(309, 21);
            this.comboBoxCategory.TabIndex = 18;
            // 
            // pictureBoxLargestItem
            // 
            this.pictureBoxLargestItem.Location = new System.Drawing.Point(12, 103);
            this.pictureBoxLargestItem.Name = "pictureBoxLargestItem";
            this.pictureBoxLargestItem.Size = new System.Drawing.Size(372, 289);
            this.pictureBoxLargestItem.TabIndex = 19;
            this.pictureBoxLargestItem.TabStop = false;
            // 
            // pictureBoxLargestGroup
            // 
            this.pictureBoxLargestGroup.Location = new System.Drawing.Point(406, 103);
            this.pictureBoxLargestGroup.Name = "pictureBoxLargestGroup";
            this.pictureBoxLargestGroup.Size = new System.Drawing.Size(372, 289);
            this.pictureBoxLargestGroup.TabIndex = 20;
            this.pictureBoxLargestGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(814, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Amount Left This Paycheck Period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(814, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Amount Spent This Paycheck Period:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(814, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Total Profit This Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(814, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Paycheck Period Ends:";
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1162, 714);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLargestGroup);
            this.Controls.Add(this.pictureBoxLargestItem);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxItemPrice);
            this.Controls.Add(this.comboBoxItemCategory);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.buttonSubmitInfo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelBudgetInfo);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelSingleItem);
            this.Name = "BudgetForm";
            this.Text = "BudgetTracking";
            this.Load += new System.EventHandler(this.BudgetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLargestItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLargestGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSingleItem;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelBudgetInfo;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSubmitInfo;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.ComboBox comboBoxItemCategory;
        private System.Windows.Forms.TextBox textBoxItemPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.PictureBox pictureBoxLargestItem;
        private System.Windows.Forms.PictureBox pictureBoxLargestGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

