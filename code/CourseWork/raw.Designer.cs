namespace CourseWork
{
    partial class raw
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
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idraw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idindicators = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_receipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_of_receipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volume_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(42, 37);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(633, 37);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 30);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(324, 37);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(100, 30);
            this.button_export.TabIndex = 2;
            this.button_export.Text = "Отчёт";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(42, 385);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 30);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Назад";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idraw,
            this.idindicators,
            this.date_of_receipt,
            this.time_of_receipt,
            this.volume_weight});
            this.dataGridView1.Location = new System.Drawing.Point(42, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 221);
            this.dataGridView1.TabIndex = 4;
            // 
            // idraw
            // 
            this.idraw.HeaderText = "ID";
            this.idraw.MinimumWidth = 6;
            this.idraw.Name = "idraw";
            this.idraw.Width = 125;
            // 
            // idindicators
            // 
            this.idindicators.HeaderText = "ID показателя";
            this.idindicators.MinimumWidth = 6;
            this.idindicators.Name = "idindicators";
            this.idindicators.Width = 125;
            // 
            // date_of_receipt
            // 
            this.date_of_receipt.HeaderText = "Дата получения";
            this.date_of_receipt.MinimumWidth = 6;
            this.date_of_receipt.Name = "date_of_receipt";
            this.date_of_receipt.Width = 125;
            // 
            // time_of_receipt
            // 
            this.time_of_receipt.HeaderText = "Время получения";
            this.time_of_receipt.MinimumWidth = 6;
            this.time_of_receipt.Name = "time_of_receipt";
            this.time_of_receipt.Width = 125;
            // 
            // volume_weight
            // 
            this.volume_weight.HeaderText = "Объем\\вес";
            this.volume_weight.MinimumWidth = 6;
            this.volume_weight.Name = "volume_weight";
            this.volume_weight.Width = 125;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(171, 385);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(100, 30);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "Обновить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // raw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Name = "raw";
            this.Text = "Сырьё";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn idindicators;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_receipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_of_receipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn volume_weight;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_refresh;
    }
}