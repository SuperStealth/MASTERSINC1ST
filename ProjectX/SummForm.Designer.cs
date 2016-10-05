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
            this.печать_button1 = new System.Windows.Forms.Button();
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
            // печать_button1
            // 
            this.печать_button1.Location = new System.Drawing.Point(291, 305);
            this.печать_button1.Name = "печать_button1";
            this.печать_button1.Size = new System.Drawing.Size(128, 23);
            this.печать_button1.TabIndex = 1;
            this.печать_button1.Text = "Распечатать отчет";
            this.печать_button1.UseVisualStyleBackColor = true;
            this.печать_button1.Click += new System.EventHandler(this.печать_button1_Click);
            // 
            // SummForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 334);
            this.Controls.Add(this.печать_button1);
            this.Controls.Add(this.summDataGridView);
            this.Name = "SummForm";
            this.Text = "SummForm";
            ((System.ComponentModel.ISupportInitialize)(this.summDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView summDataGridView;
        private System.Windows.Forms.Button печать_button1;
    }
}