namespace CourseWork
{
    partial class indicators
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idindicators = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idindicators,
            this.name,
            this.normal});
            this.dataGridView1.Location = new System.Drawing.Point(68, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // idindicators
            // 
            this.idindicators.HeaderText = "ID";
            this.idindicators.MinimumWidth = 6;
            this.idindicators.Name = "idindicators";
            this.idindicators.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Наименование";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 300;
            // 
            // normal
            // 
            this.normal.HeaderText = "Норма (1 или 0)";
            this.normal.MinimumWidth = 6;
            this.normal.Name = "normal";
            this.normal.Width = 150;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(32, 30);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(335, 30);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(100, 30);
            this.button_export.TabIndex = 2;
            this.button_export.Text = "Отчёт";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(649, 30);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 30);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(29, 393);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 30);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Назад";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(165, 393);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(100, 30);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "Обновить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // indicators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "indicators";
            this.Text = "Показатели";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idindicators;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn normal;
        private System.Windows.Forms.Button button_refresh;
    }
}