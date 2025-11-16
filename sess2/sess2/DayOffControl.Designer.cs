namespace sess2
{
    partial class DayOffControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelInfo = new Label();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfo.ForeColor = Color.FromArgb(52, 73, 94);
            labelInfo.Location = new Point(8, 8);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(68, 20);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "labelInfo";
            // 
            // DayOffControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelInfo);
            Margin = new Padding(3, 3, 3, 6);
            Name = "DayOffControl";
            Size = new Size(350, 60);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
    }
}
