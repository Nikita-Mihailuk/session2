namespace sess2
{
    partial class EmployeeControl
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
            labelDepartmentPost = new Label();
            labelName = new Label();
            labelEmailPhone = new Label();
            labelOffice = new Label();
            buttonFire = new Button();
            SuspendLayout();
            // 
            // labelDepartmentPost
            // 
            labelDepartmentPost.AutoSize = true;
            labelDepartmentPost.Location = new Point(4, 2);
            labelDepartmentPost.Name = "labelDepartmentPost";
            labelDepartmentPost.Size = new Size(149, 20);
            labelDepartmentPost.TabIndex = 0;
            labelDepartmentPost.Text = "labelDepartmentPost";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(4, 32);
            labelName.Name = "labelName";
            labelName.Size = new Size(129, 31);
            labelName.TabIndex = 1;
            labelName.Text = "labelName";
            // 
            // labelEmailPhone
            // 
            labelEmailPhone.AutoSize = true;
            labelEmailPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmailPhone.Location = new Point(4, 70);
            labelEmailPhone.Name = "labelEmailPhone";
            labelEmailPhone.Size = new Size(136, 23);
            labelEmailPhone.TabIndex = 2;
            labelEmailPhone.Text = "labelEmailPhone";
            // 
            // labelOffice
            // 
            labelOffice.AutoSize = true;
            labelOffice.Location = new Point(4, 104);
            labelOffice.Name = "labelOffice";
            labelOffice.Size = new Size(82, 20);
            labelOffice.TabIndex = 3;
            labelOffice.Text = "labelOffice";
            // 
            // buttonFire
            // 
            buttonFire.BackColor = Color.FromArgb(128, 255, 128);
            buttonFire.Location = new Point(365, 54);
            buttonFire.Name = "buttonFire";
            buttonFire.Size = new Size(102, 37);
            buttonFire.TabIndex = 4;
            buttonFire.Text = "Уволить";
            buttonFire.UseVisualStyleBackColor = false;
            buttonFire.Click += buttonFire_Click;
            // 
            // EmployeeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(buttonFire);
            Controls.Add(labelOffice);
            Controls.Add(labelEmailPhone);
            Controls.Add(labelName);
            Controls.Add(labelDepartmentPost);
            Name = "EmployeeControl";
            Size = new Size(510, 135);
            Click += EmployeeControl_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDepartmentPost;
        private Label labelName;
        private Label labelEmailPhone;
        private Label labelOffice;
        private Button buttonFire;
    }
}
