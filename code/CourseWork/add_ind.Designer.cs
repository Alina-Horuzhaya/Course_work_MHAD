namespace CourseWork
{
    partial class add_ind
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
            this.name_Box = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.checkBox_yes = new System.Windows.Forms.CheckBox();
            this.checkBox_no = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заполните поля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование показателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Показатель в норме?";
            // 
            // name_Box
            // 
            this.name_Box.Location = new System.Drawing.Point(33, 102);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(329, 22);
            this.name_Box.TabIndex = 3;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 271);
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
            this.button_add.Location = new System.Drawing.Point(357, 271);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // checkBox_yes
            // 
            this.checkBox_yes.AutoSize = true;
            this.checkBox_yes.Location = new System.Drawing.Point(33, 201);
            this.checkBox_yes.Name = "checkBox_yes";
            this.checkBox_yes.Size = new System.Drawing.Size(49, 21);
            this.checkBox_yes.TabIndex = 7;
            this.checkBox_yes.Text = "Да";
            this.checkBox_yes.UseVisualStyleBackColor = true;
            this.checkBox_yes.CheckedChanged += new System.EventHandler(this.checkBox_yes_CheckedChanged);
            // 
            // checkBox_no
            // 
            this.checkBox_no.AutoSize = true;
            this.checkBox_no.Location = new System.Drawing.Point(149, 201);
            this.checkBox_no.Name = "checkBox_no";
            this.checkBox_no.Size = new System.Drawing.Size(55, 21);
            this.checkBox_no.TabIndex = 8;
            this.checkBox_no.Text = "Нет";
            this.checkBox_no.UseVisualStyleBackColor = true;
            this.checkBox_no.CheckedChanged += new System.EventHandler(this.checkBox_no_CheckedChanged);
            // 
            // add_ind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 326);
            this.Controls.Add(this.checkBox_no);
            this.Controls.Add(this.checkBox_yes);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(487, 373);
            this.MinimumSize = new System.Drawing.Size(487, 373);
            this.Name = "add_ind";
            this.Text = "Добавление показателей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.CheckBox checkBox_yes;
        private System.Windows.Forms.CheckBox checkBox_no;
    }
}