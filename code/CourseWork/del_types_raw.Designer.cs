namespace CourseWork
{
    partial class del_types_raw
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
            this.id_Box = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите для удаления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID типа сырья";
            // 
            // id_Box
            // 
            this.id_Box.Location = new System.Drawing.Point(34, 98);
            this.id_Box.Name = "id_Box";
            this.id_Box.Size = new System.Drawing.Size(202, 22);
            this.id_Box.TabIndex = 2;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 201);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 30);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_del.Location = new System.Drawing.Point(330, 201);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(100, 30);
            this.button_del.TabIndex = 4;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // del_types_raw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 243);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.id_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "del_types_raw";
            this.Text = "Удаление типа сырья";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_Box;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_del;
    }
}