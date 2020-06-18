namespace InventoriCerdas.Forms.Kabel
{
    partial class KabelForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.kabelDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kabelDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(620, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 34);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(709, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 34);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Kabel";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(13, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(587, 30);
            this.searchTextBox.TabIndex = 2;
            // 
            // kabelDGV
            // 
            this.kabelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kabelDGV.Location = new System.Drawing.Point(13, 58);
            this.kabelDGV.Name = "kabelDGV";
            this.kabelDGV.RowHeadersWidth = 51;
            this.kabelDGV.RowTemplate.Height = 24;
            this.kabelDGV.Size = new System.Drawing.Size(775, 380);
            this.kabelDGV.TabIndex = 3;
            // 
            // KabelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kabelDGV);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchButton);
            this.Name = "KabelForm";
            this.Text = "Data Kabel";
            ((System.ComponentModel.ISupportInitialize)(this.kabelDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView kabelDGV;
    }
}