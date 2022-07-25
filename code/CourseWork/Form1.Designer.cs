namespace CourseWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_percent = new System.Windows.Forms.Button();
            this.button_devisions = new System.Windows.Forms.Button();
            this.button_raw = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_tp = new System.Windows.Forms.Button();
            this.button_providers = new System.Windows.Forms.Button();
            this.button_stages_tp = new System.Windows.Forms.Button();
            this.button_indicators = new System.Windows.Forms.Button();
            this.button_types_raw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_percent
            // 
            this.button_percent.Location = new System.Drawing.Point(189, 257);
            this.button_percent.Name = "button_percent";
            this.button_percent.Size = new System.Drawing.Size(197, 58);
            this.button_percent.TabIndex = 0;
            this.button_percent.Text = "Прогноз % брака";
            this.button_percent.UseVisualStyleBackColor = true;
            this.button_percent.Click += new System.EventHandler(this.button_percent_Click);
            // 
            // button_devisions
            // 
            this.button_devisions.Location = new System.Drawing.Point(53, 67);
            this.button_devisions.Name = "button_devisions";
            this.button_devisions.Size = new System.Drawing.Size(197, 58);
            this.button_devisions.TabIndex = 1;
            this.button_devisions.Text = "Подразделения";
            this.button_devisions.UseVisualStyleBackColor = true;
            this.button_devisions.Click += new System.EventHandler(this.button_devisions_Click);
            // 
            // button_raw
            // 
            this.button_raw.Location = new System.Drawing.Point(53, 349);
            this.button_raw.Name = "button_raw";
            this.button_raw.Size = new System.Drawing.Size(197, 58);
            this.button_raw.TabIndex = 2;
            this.button_raw.Text = "Сырьё";
            this.button_raw.UseVisualStyleBackColor = true;
            this.button_raw.Click += new System.EventHandler(this.button_raw_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(223, 540);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 30);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_tp
            // 
            this.button_tp.Location = new System.Drawing.Point(319, 67);
            this.button_tp.Name = "button_tp";
            this.button_tp.Size = new System.Drawing.Size(197, 58);
            this.button_tp.TabIndex = 4;
            this.button_tp.Text = "ТП (технологический процесс)";
            this.button_tp.UseVisualStyleBackColor = true;
            this.button_tp.Click += new System.EventHandler(this.button_tp_Click);
            // 
            // button_providers
            // 
            this.button_providers.Location = new System.Drawing.Point(53, 149);
            this.button_providers.Name = "button_providers";
            this.button_providers.Size = new System.Drawing.Size(197, 58);
            this.button_providers.TabIndex = 5;
            this.button_providers.Text = "Поставщики";
            this.button_providers.UseVisualStyleBackColor = true;
            this.button_providers.Click += new System.EventHandler(this.button_providers_Click);
            // 
            // button_stages_tp
            // 
            this.button_stages_tp.Location = new System.Drawing.Point(319, 149);
            this.button_stages_tp.Name = "button_stages_tp";
            this.button_stages_tp.Size = new System.Drawing.Size(197, 58);
            this.button_stages_tp.TabIndex = 6;
            this.button_stages_tp.Text = "Этапы ТП";
            this.button_stages_tp.UseVisualStyleBackColor = true;
            this.button_stages_tp.Click += new System.EventHandler(this.button_stages_tp_Click);
            // 
            // button_indicators
            // 
            this.button_indicators.Location = new System.Drawing.Point(319, 349);
            this.button_indicators.Name = "button_indicators";
            this.button_indicators.Size = new System.Drawing.Size(197, 58);
            this.button_indicators.TabIndex = 7;
            this.button_indicators.Text = "Показатели";
            this.button_indicators.UseVisualStyleBackColor = true;
            this.button_indicators.Click += new System.EventHandler(this.button_indicators_Click);
            // 
            // button_types_raw
            // 
            this.button_types_raw.Location = new System.Drawing.Point(53, 435);
            this.button_types_raw.Name = "button_types_raw";
            this.button_types_raw.Size = new System.Drawing.Size(197, 58);
            this.button_types_raw.TabIndex = 8;
            this.button_types_raw.Text = "Виды сырья";
            this.button_types_raw.UseVisualStyleBackColor = true;
            this.button_types_raw.Click += new System.EventHandler(this.button_types_raw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 624);
            this.Controls.Add(this.button_types_raw);
            this.Controls.Add(this.button_indicators);
            this.Controls.Add(this.button_percent);
            this.Controls.Add(this.button_stages_tp);
            this.Controls.Add(this.button_tp);
            this.Controls.Add(this.button_providers);
            this.Controls.Add(this.button_devisions);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_raw);
            this.Name = "Form1";
            this.Text = "Главная страница";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_percent;
        private System.Windows.Forms.Button button_devisions;
        private System.Windows.Forms.Button button_raw;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_tp;
        private System.Windows.Forms.Button button_providers;
        private System.Windows.Forms.Button button_stages_tp;
        private System.Windows.Forms.Button button_indicators;
        private System.Windows.Forms.Button button_types_raw;
    }
}

