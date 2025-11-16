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
            labelDepartmentPost.ForeColor = Color.FromArgb(127, 140, 141);
            labelDepartmentPost.Location = new Point(10, 8);
            labelDepartmentPost.Name = "labelDepartmentPost";
            labelDepartmentPost.Size = new Size(149, 20);
            labelDepartmentPost.TabIndex = 0;
            labelDepartmentPost.Text = "labelDepartmentPost";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.FromArgb(44, 62, 80);
            labelName.Location = new Point(10, 35);
            labelName.Name = "labelName";
            labelName.Size = new Size(129, 31);
            labelName.TabIndex = 1;
            labelName.Text = "labelName";
            // 
            // labelEmailPhone
            // 
            labelEmailPhone.AutoSize = true;
            labelEmailPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmailPhone.ForeColor = Color.FromArgb(52, 73, 94);
            labelEmailPhone.Location = new Point(10, 73);
            labelEmailPhone.Name = "labelEmailPhone";
            labelEmailPhone.Size = new Size(136, 23);
            labelEmailPhone.TabIndex = 2;
            labelEmailPhone.Text = "labelEmailPhone";
            // 
            // labelOffice
            // 
            labelOffice.AutoSize = true;
            labelOffice.ForeColor = Color.FromArgb(127, 140, 141);
            labelOffice.Location = new Point(10, 104);
            labelOffice.Name = "labelOffice";
            labelOffice.Size = new Size(82, 20);
            labelOffice.TabIndex = 3;
            labelOffice.Text = "labelOffice";
            // 
            // buttonFire
            // 
            buttonFire.BackColor = Color.FromArgb(231, 76, 60);
            buttonFire.FlatAppearance.BorderSize = 0;
            buttonFire.FlatStyle = FlatStyle.Flat;
            buttonFire.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFire.ForeColor = Color.White;
            buttonFire.Location = new Point(380, 54);
            buttonFire.Name = "buttonFire";
            buttonFire.Size = new Size(110, 37);
            buttonFire.TabIndex = 4;
            buttonFire.Text = "Уволить";
            buttonFire.UseVisualStyleBackColor = false;
            buttonFire.Click += buttonFire_Click;
            // 
            // EmployeeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonFire);
            Controls.Add(labelOffice);
            Controls.Add(labelEmailPhone);
            Controls.Add(labelName);
            Controls.Add(labelDepartmentPost);
            Margin = new Padding(3, 3, 3, 8);
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
