namespace ProjectX
{
    partial class TableForm
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
            this.components = new System.ComponentModel.Container();
            this.overallDataGridView = new System.Windows.Forms.DataGridView();
            this.drinksTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drinksDataSet = new ProjectX.DrinksDataSet();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeTableButton = new System.Windows.Forms.Button();
            this.drinksTableTableAdapter = new ProjectX.DrinksDataSetTableAdapters.DrinksTableTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.overallDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // overallDataGridView
            // 
            this.overallDataGridView.AllowUserToResizeColumns = false;
            this.overallDataGridView.AllowUserToResizeRows = false;
            this.overallDataGridView.AutoGenerateColumns = false;
            this.overallDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.overallDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overallDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.overallDataGridView.DataSource = this.drinksTableBindingSource;
            this.overallDataGridView.Location = new System.Drawing.Point(12, 12);
            this.overallDataGridView.Name = "overallDataGridView";
            this.overallDataGridView.ReadOnly = true;
            this.overallDataGridView.RowHeadersVisible = false;
            this.overallDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.overallDataGridView.Size = new System.Drawing.Size(243, 254);
            this.overallDataGridView.TabIndex = 0;
            // 
            // drinksTableBindingSource
            // 
            this.drinksTableBindingSource.DataMember = "DrinksTable";
            this.drinksTableBindingSource.DataSource = this.drinksDataSet;
            // 
            // drinksDataSet
            // 
            this.drinksDataSet.DataSetName = "DrinksDataSet";
            this.drinksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToResizeColumns = false;
            this.tableDataGridView.AllowUserToResizeRows = false;
            this.tableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Location = new System.Drawing.Point(304, 12);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            this.tableDataGridView.RowHeadersVisible = false;
            this.tableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableDataGridView.Size = new System.Drawing.Size(304, 254);
            this.tableDataGridView.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(95, 276);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(137, 32);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.Location = new System.Drawing.Point(16, 279);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(73, 24);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Поиск:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(261, 76);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(37, 38);
            this.addButton.TabIndex = 4;
            this.addButton.Text = ">";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(261, 120);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(37, 38);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "<";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeTableButton
            // 
            this.closeTableButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeTableButton.Location = new System.Drawing.Point(402, 272);
            this.closeTableButton.Name = "closeTableButton";
            this.closeTableButton.Size = new System.Drawing.Size(186, 39);
            this.closeTableButton.TabIndex = 6;
            this.closeTableButton.Text = "Закрыть стол";
            this.closeTableButton.UseVisualStyleBackColor = true;
            this.closeTableButton.Click += new System.EventHandler(this.closeTableButton_Click);
            // 
            // drinksTableTableAdapter
            // 
            this.drinksTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DrinkType";
            this.dataGridViewTextBoxColumn2.HeaderText = "Напиток";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 345);
            this.Controls.Add(this.closeTableButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.overallDataGridView);
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.overallDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView overallDataGridView;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeTableButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinkTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DrinksDataSet drinksDataSet;
        private System.Windows.Forms.BindingSource drinksTableBindingSource;
        private DrinksDataSetTableAdapters.DrinksTableTableAdapter drinksTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}