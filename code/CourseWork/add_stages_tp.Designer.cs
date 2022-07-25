namespace CourseWork
{
    partial class add_stages_tp
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idtp_Box = new System.Windows.Forms.TextBox();
            this.iddev_Box = new System.Windows.Forms.TextBox();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.dur_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 375);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 30);
            this.button_cancel.TabIndex = 0;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(334, 375);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите для добавления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID ТП";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Подразделения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Продолжительность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Наименование";
            // 
            // idtp_Box
            // 
            this.idtp_Box.Location = new System.Drawing.Point(36, 86);
            this.idtp_Box.Name = "idtp_Box";
            this.idtp_Box.Size = new System.Drawing.Size(273, 22);
            this.idtp_Box.TabIndex = 7;
            // 
            // iddev_Box
            // 
            this.iddev_Box.Location = new System.Drawing.Point(36, 156);
            this.iddev_Box.Name = "iddev_Box";
            this.iddev_Box.Size = new System.Drawing.Size(273, 22);
            this.iddev_Box.TabIndex = 8;
            // 
            // name_Box
            // 
            this.name_Box.Location = new System.Drawing.Point(36, 235);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(273, 22);
            this.name_Box.TabIndex = 9;
            // 
            // dur_Box
            // 
            this.dur_Box.Location = new System.Drawing.Point(37, 309);
            this.dur_Box.Name = "dur_Box";
            this.dur_Box.Size = new System.Drawing.Size(273, 22);
            this.dur_Box.TabIndex = 10;
            // 
            // add_stages_tp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 425);
            this.Controls.Add(this.dur_Box);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.iddev_Box);
            this.Controls.Add(this.idtp_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_cancel);
            this.MaximumSize = new System.Drawing.Size(477, 472);
            this.MinimumSize = new System.Drawing.Size(477, 472);
            this.Name = "add_stages_tp";
            this.Text = "Добавление стадии ТП";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idtp_Box;
        private System.Windows.Forms.TextBox iddev_Box;
        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.TextBox dur_Box;
    }
}