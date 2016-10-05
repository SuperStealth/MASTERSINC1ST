namespace ProjectX
{
    partial class SummForm
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
            this.summDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.summDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // summDataGridView
            // 
            this.summDataGridView.AllowUserToAddRows = false;
            this.summDataGridView.AllowUserToDeleteRows = false;
            this.summDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.summDataGridView.Location = new System.Drawing.Point(13, 13);
            this.summDataGridView.Name = "summDataGridView";
            this.summDataGridView.ReadOnly = true;
            this.summDataGridView.Size = new System.Drawing.Size(423, 286);
            this.summDataGridView.TabIndex = 0;
            // 
            // SummForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 334);
            this.Controls.Add(this.summDataGridView);
            this.Name = "SummForm";
            this.Text = "SummForm";
            ((System.ComponentModel.ISupportInitialize)(this.summDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView summDataGridView;
    }
}