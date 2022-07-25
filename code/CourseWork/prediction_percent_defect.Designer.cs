namespace CourseWork
{
    partial class prediction_percent_defect
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_refresh = new System.Windows.Forms.Button();
            this.idprediction_percent_defect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idraw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assumed_percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batch_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(45, 35);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(643, 35);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 30);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(320, 35);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(100, 30);
            this.button_export.TabIndex = 2;
            this.button_export.Text = "Отчёт";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(45, 403);
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
            this.idprediction_percent_defect,
            this.idraw,
            this.idtp,
            this.assumed_percent,
            this.batch_number});
            this.dataGridView1.Location = new System.Drawing.Point(45, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 273);
            this.dataGridView1.TabIndex = 4;
            // 
            // button_refresh
            // 
            this.button_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_refresh.Location = new System.Drawing.Point(170, 403);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(100, 30);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "Обновить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // idprediction_percent_defect
            // 
            this.idprediction_percent_defect.HeaderText = "ID";
            this.idprediction_percent_defect.MinimumWidth = 6;
            this.idprediction_percent_defect.Name = "idprediction_percent_defect";
            this.idprediction_percent_defect.Width = 50;
            // 
            // idraw
            // 
            this.idraw.HeaderText = "ID сырья";
            this.idraw.MinimumWidth = 6;
            this.idraw.Name = "idraw";
            this.idraw.Width = 125;
            // 
            // idtp
            // 
            this.idtp.HeaderText = "ID ТП";
            this.idtp.MinimumWidth = 6;
            this.idtp.Name = "idtp";
            this.idtp.Width = 125;
            // 
            // assumed_percent
            // 
            this.assumed_percent.HeaderText = "Предполагаемый %";
            this.assumed_percent.MinimumWidth = 6;
            this.assumed_percent.Name = "assumed_percent";
            this.assumed_percent.Width = 125;
            // 
            // batch_number
            // 
            this.batch_number.HeaderText = "Номер партии";
            this.batch_number.MinimumWidth = 6;
            this.batch_number.Name = "batch_number";
            this.batch_number.Width = 125;
            // 
            // prediction_percent_defect
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
            this.Name = "prediction_percent_defect";
            this.Text = "Прогнозирование % брака";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprediction_percent_defect;
        private System.Windows.Forms.DataGridViewTextBoxColumn idraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn assumed_percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn batch_number;
    }
}