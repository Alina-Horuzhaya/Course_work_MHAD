namespace CourseWork
{
    partial class tp
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
            this.idtp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(35, 33);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(657, 33);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 30);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(346, 33);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(100, 30);
            this.button_export.TabIndex = 2;
            this.button_export.Text = "Отчёт";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(35, 365);
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
            this.idtp,
            this.number,
            this.date,
            this.time,
            this.duration});
            this.dataGridView1.Location = new System.Drawing.Point(35, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(722, 236);
            this.dataGridView1.TabIndex = 4;
            // 
            // idtp
            // 
            this.idtp.HeaderText = "ID ";
            this.idtp.MinimumWidth = 6;
            this.idtp.Name = "idtp";
            this.idtp.Width = 125;
            // 
            // number
            // 
            this.number.HeaderText = "Номер ";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // time
            // 
            this.time.HeaderText = "Время";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.Width = 125;
            // 
            // duration
            // 
            this.duration.HeaderText = "Продолжительность (мин)";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.Width = 150;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(163, 365);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(100, 30);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "Обновить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // tp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Name = "tp";
            this.Text = "ТП";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.Button button_refresh;
    }
}