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
            this.SuspendLayout();
            // 
            // labelSingleItem
            // 
            this.labelSingleItem.AutoSize = true;
            this.labelSingleItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSingleItem.Location = new System.Drawing.Point(13, 25);
            this.labelSingleItem.Name = "labelSingleItem";
            this.labelSingleItem.Size = new System.Drawing.Size(233, 24);
            this.labelSingleItem.TabIndex = 0;
            this.labelSingleItem.Text = "Largest Item This Month";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(436, 25);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(252, 24);
            this.labelGroup.TabIndex = 1;
            this.labelGroup.Text = "Largest Group This Month";
            // 
            // labelBudgetInfo
            // 
            this.labelBudgetInfo.AutoSize = true;
            this.labelBudgetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBudgetInfo.Location = new System.Drawing.Point(917, 25);
            this.labelBudgetInfo.Name = "labelBudgetInfo";
            this.labelBudgetInfo.Size = new System.Drawing.Size(190, 24);
            this.labelBudgetInfo.TabIndex = 2;
            this.labelBudgetInfo.Text = "Over/Under Budget";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(465, 474);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(167, 21);
            this.labelAdd.TabIndex = 3;
            this.labelAdd.Text = "Add New Payment";
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 710);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelBudgetInfo);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelSingleItem);
            this.Name = "BudgetForm";
            this.Text = "BudgetTracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSingleItem;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelBudgetInfo;
        private System.Windows.Forms.Label labelAdd;
    }
}

