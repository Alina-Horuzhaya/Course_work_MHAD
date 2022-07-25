namespace CourseWork
{
    partial class add_raw
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idind_Box = new System.Windows.Forms.TextBox();
            this.date_Box = new System.Windows.Forms.TextBox();
            this.time_Box = new System.Windows.Forms.TextBox();
            this.volume_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите для добавления";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 385);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 30);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(379, 385);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID показателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата проведения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Время проведения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Объем\\масса";
            // 
            // idind_Box
            // 
            this.idind_Box.Location = new System.Drawing.Point(35, 106);
            this.idind_Box.Name = "idind_Box";
            this.idind_Box.Size = new System.Drawing.Size(287, 22);
            this.idind_Box.TabIndex = 7;
            // 
            // date_Box
            // 
            this.date_Box.Location = new System.Drawing.Point(36, 178);
            this.date_Box.Name = "date_Box";
            this.date_Box.Size = new System.Drawing.Size(287, 22);
            this.date_Box.TabIndex = 8;
            // 
            // time_Box
            // 
            this.time_Box.Location = new System.Drawing.Point(37, 243);
            this.time_Box.Name = "time_Box";
            this.time_Box.Size = new System.Drawing.Size(287, 22);
            this.time_Box.TabIndex = 9;
            // 
            // volume_Box
            // 
            this.volume_Box.Location = new System.Drawing.Point(35, 318);
            this.volume_Box.Name = "volume_Box";
            this.volume_Box.Size = new System.Drawing.Size(287, 22);
            this.volume_Box.TabIndex = 10;
            // 
            // add_raw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 440);
            this.Controls.Add(this.volume_Box);
            this.Controls.Add(this.time_Box);
            this.Controls.Add(this.date_Box);
            this.Controls.Add(this.idind_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(509, 487);
            this.MinimumSize = new System.Drawing.Size(509, 487);
            this.Name = "add_raw";
            this.Text = "Добавление сырья";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idind_Box;
        private System.Windows.Forms.TextBox date_Box;
        private System.Windows.Forms.TextBox time_Box;
        private System.Windows.Forms.TextBox volume_Box;
    }
}