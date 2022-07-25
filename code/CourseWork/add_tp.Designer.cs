namespace CourseWork
{
    partial class add_tp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_Box = new System.Windows.Forms.TextBox();
            this.time_Box = new System.Windows.Forms.TextBox();
            this.duration_Box = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.number_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите для добавления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Время начала";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Продолжительность (мин)";
            // 
            // date_Box
            // 
            this.date_Box.Location = new System.Drawing.Point(28, 158);
            this.date_Box.Name = "date_Box";
            this.date_Box.Size = new System.Drawing.Size(212, 22);
            this.date_Box.TabIndex = 4;
            // 
            // time_Box
            // 
            this.time_Box.Location = new System.Drawing.Point(28, 234);
            this.time_Box.Name = "time_Box";
            this.time_Box.Size = new System.Drawing.Size(212, 22);
            this.time_Box.TabIndex = 5;
            // 
            // duration_Box
            // 
            this.duration_Box.Location = new System.Drawing.Point(28, 309);
            this.duration_Box.Name = "duration_Box";
            this.duration_Box.Size = new System.Drawing.Size(212, 22);
            this.duration_Box.TabIndex = 6;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(18, 373);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 30);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(421, 373);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Номер ТП";
            // 
            // number_Box
            // 
            this.number_Box.Location = new System.Drawing.Point(28, 93);
            this.number_Box.Name = "number_Box";
            this.number_Box.Size = new System.Drawing.Size(212, 22);
            this.number_Box.TabIndex = 10;
            // 
            // add_tp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 427);
            this.Controls.Add(this.number_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.duration_Box);
            this.Controls.Add(this.time_Box);
            this.Controls.Add(this.date_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(551, 474);
            this.MinimumSize = new System.Drawing.Size(551, 474);
            this.Name = "add_tp";
            this.Text = "Добавление ТП";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox date_Box;
        private System.Windows.Forms.TextBox time_Box;
        private System.Windows.Forms.TextBox duration_Box;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox number_Box;
    }
}