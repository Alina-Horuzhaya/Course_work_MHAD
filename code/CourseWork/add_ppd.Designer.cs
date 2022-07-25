namespace CourseWork
{
    partial class add_ppd
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
            this.label5 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.idraw_Box = new System.Windows.Forms.TextBox();
            this.idtp_Box = new System.Windows.Forms.TextBox();
            this.percent_Box = new System.Windows.Forms.TextBox();
            this.number_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите для добавления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID сырья";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID ТП";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Предполагаемый %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер партии";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 393);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 30);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(379, 393);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // idraw_Box
            // 
            this.idraw_Box.Location = new System.Drawing.Point(34, 88);
            this.idraw_Box.Name = "idraw_Box";
            this.idraw_Box.Size = new System.Drawing.Size(253, 22);
            this.idraw_Box.TabIndex = 7;
            // 
            // idtp_Box
            // 
            this.idtp_Box.Location = new System.Drawing.Point(34, 169);
            this.idtp_Box.Name = "idtp_Box";
            this.idtp_Box.Size = new System.Drawing.Size(253, 22);
            this.idtp_Box.TabIndex = 8;
            // 
            // percent_Box
            // 
            this.percent_Box.Location = new System.Drawing.Point(34, 244);
            this.percent_Box.Name = "percent_Box";
            this.percent_Box.Size = new System.Drawing.Size(253, 22);
            this.percent_Box.TabIndex = 9;
            // 
            // number_Box
            // 
            this.number_Box.Location = new System.Drawing.Point(34, 322);
            this.number_Box.Name = "number_Box";
            this.number_Box.Size = new System.Drawing.Size(253, 22);
            this.number_Box.TabIndex = 10;
            // 
            // add_ppd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 440);
            this.Controls.Add(this.number_Box);
            this.Controls.Add(this.percent_Box);
            this.Controls.Add(this.idtp_Box);
            this.Controls.Add(this.idraw_Box);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(509, 487);
            this.MinimumSize = new System.Drawing.Size(509, 487);
            this.Name = "add_ppd";
            this.Text = "Добавление прогнозируемого % брака";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox idraw_Box;
        private System.Windows.Forms.TextBox idtp_Box;
        private System.Windows.Forms.TextBox percent_Box;
        private System.Windows.Forms.TextBox number_Box;
    }
}