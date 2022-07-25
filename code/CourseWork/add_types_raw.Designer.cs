namespace CourseWork
{
    partial class add_types_raw
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
            this.idraw_Box = new System.Windows.Forms.TextBox();
            this.provider_Box = new System.Windows.Forms.TextBox();
            this.idprovider_box = new System.Windows.Forms.Label();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите для добавления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID сырья";
            // 
            // idraw_Box
            // 
            this.idraw_Box.Location = new System.Drawing.Point(43, 105);
            this.idraw_Box.Name = "idraw_Box";
            this.idraw_Box.Size = new System.Drawing.Size(225, 22);
            this.idraw_Box.TabIndex = 2;
            // 
            // provider_Box
            // 
            this.provider_Box.Location = new System.Drawing.Point(43, 184);
            this.provider_Box.Name = "provider_Box";
            this.provider_Box.Size = new System.Drawing.Size(225, 22);
            this.provider_Box.TabIndex = 4;
            // 
            // idprovider_box
            // 
            this.idprovider_box.AutoSize = true;
            this.idprovider_box.Location = new System.Drawing.Point(40, 153);
            this.idprovider_box.Name = "idprovider_box";
            this.idprovider_box.Size = new System.Drawing.Size(104, 17);
            this.idprovider_box.TabIndex = 3;
            this.idprovider_box.Text = "ID поставщика";
            // 
            // name_Box
            // 
            this.name_Box.Location = new System.Drawing.Point(43, 264);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(225, 22);
            this.name_Box.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Наименование типа сырья";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 373);
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
            this.button_add.Location = new System.Drawing.Point(338, 373);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // add_types_raw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 415);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.provider_Box);
            this.Controls.Add(this.idprovider_box);
            this.Controls.Add(this.idraw_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(468, 462);
            this.MinimumSize = new System.Drawing.Size(468, 462);
            this.Name = "add_types_raw";
            this.Text = "Добавление типа сырья";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idraw_Box;
        private System.Windows.Forms.TextBox provider_Box;
        private System.Windows.Forms.Label idprovider_box;
        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
    }
}