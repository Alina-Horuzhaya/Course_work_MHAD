namespace CourseWork
{
    partial class add_dev
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
            this.dev_Box = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add_dev = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование подразделения";
            // 
            // dev_Box
            // 
            this.dev_Box.Location = new System.Drawing.Point(32, 112);
            this.dev_Box.Name = "dev_Box";
            this.dev_Box.Size = new System.Drawing.Size(252, 22);
            this.dev_Box.TabIndex = 1;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 189);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 30);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_add_dev
            // 
            this.button_add_dev.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_add_dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_dev.Location = new System.Drawing.Point(323, 189);
            this.button_add_dev.Name = "button_add_dev";
            this.button_add_dev.Size = new System.Drawing.Size(100, 30);
            this.button_add_dev.TabIndex = 3;
            this.button_add_dev.Text = "Добавить";
            this.button_add_dev.UseVisualStyleBackColor = false;
            this.button_add_dev.Click += new System.EventHandler(this.button_add_dev_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите для добавления";
            // 
            // add_dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 243);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_add_dev);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.dev_Box);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(460, 290);
            this.MinimumSize = new System.Drawing.Size(460, 290);
            this.Name = "add_dev";
            this.Text = "Добавление подразделение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dev_Box;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add_dev;
        private System.Windows.Forms.Label label2;
    }
}