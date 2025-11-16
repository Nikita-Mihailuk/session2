namespace sess2
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            buttonClearAssistant = new Button();
            buttonClearManager = new Button();
            comboBoxAssistant = new ComboBox();
            comboBoxManager = new ComboBox();
            comboBoxQualification = new ComboBox();
            buttonBack = new Button();
            buttonSave = new Button();
            label12 = new Label();
            textBoxStartWorkDate = new TextBox();
            label13 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxPost = new TextBox();
            label10 = new Label();
            textBoxOffice = new TextBox();
            label11 = new Label();
            textBoxPersonalPhone = new TextBox();
            label6 = new Label();
            textBoxWorkPhone = new TextBox();
            label7 = new Label();
            textBoxBirthDate = new TextBox();
            label5 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            textBoxSurname = new TextBox();
            label3 = new Label();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            textBoxLastName = new TextBox();
            label1 = new Label();
            label14 = new Label();
            textBoxDepartment = new TextBox();
            SuspendLayout();
            // 
            // buttonClearAssistant
            // 
            buttonClearAssistant.Location = new Point(371, 403);
            buttonClearAssistant.Name = "buttonClearAssistant";
            buttonClearAssistant.Size = new Size(28, 28);
            buttonClearAssistant.TabIndex = 69;
            buttonClearAssistant.Text = "\U0001f9f9";
            buttonClearAssistant.UseVisualStyleBackColor = true;
            buttonClearAssistant.Click += buttonClearAssistant_Click;
            // 
            // buttonClearManager
            // 
            buttonClearManager.Location = new Point(371, 350);
            buttonClearManager.Name = "buttonClearManager";
            buttonClearManager.Size = new Size(28, 28);
            buttonClearManager.TabIndex = 68;
            buttonClearManager.Text = "\U0001f9f9";
            buttonClearManager.UseVisualStyleBackColor = true;
            buttonClearManager.Click += buttonClearManager_Click;
            // 
            // comboBoxAssistant
            // 
            comboBoxAssistant.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAssistant.FormattingEnabled = true;
            comboBoxAssistant.Location = new Point(209, 403);
            comboBoxAssistant.Name = "comboBoxAssistant";
            comboBoxAssistant.Size = new Size(156, 28);
            comboBoxAssistant.TabIndex = 67;
            // 
            // comboBoxManager
            // 
            comboBoxManager.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxManager.FormattingEnabled = true;
            comboBoxManager.Location = new Point(209, 350);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(156, 28);
            comboBoxManager.TabIndex = 66;
            // 
            // comboBoxQualification
            // 
            comboBoxQualification.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxQualification.FormattingEnabled = true;
            comboBoxQualification.Items.AddRange(new object[] { "Начальный", "Средний", "Высокий" });
            comboBoxQualification.Location = new Point(12, 350);
            comboBoxQualification.Name = "comboBoxQualification";
            comboBoxQualification.Size = new Size(190, 28);
            comboBoxQualification.TabIndex = 64;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(149, 165, 166);
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(144, 521);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(122, 48);
            buttonBack.TabIndex = 63;
            buttonBack.Text = "Отменить";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(46, 204, 113);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(12, 521);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(122, 48);
            buttonSave.TabIndex = 62;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(209, 380);
            label12.Name = "label12";
            label12.Size = new Size(86, 20);
            label12.TabIndex = 59;
            label12.Text = "Помощник";
            // 
            // textBoxStartWorkDate
            // 
            textBoxStartWorkDate.Location = new Point(12, 403);
            textBoxStartWorkDate.Name = "textBoxStartWorkDate";
            textBoxStartWorkDate.ScrollBars = ScrollBars.Horizontal;
            textBoxStartWorkDate.Size = new Size(190, 27);
            textBoxStartWorkDate.TabIndex = 58;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 380);
            label13.Name = "label13";
            label13.Size = new Size(150, 20);
            label13.TabIndex = 57;
            label13.Text = "Дата начала работы";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 327);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 56;
            label8.Text = "Руководитель";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 327);
            label9.Name = "label9";
            label9.Size = new Size(174, 20);
            label9.TabIndex = 55;
            label9.Text = "Уровень квалификации";
            // 
            // textBoxPost
            // 
            textBoxPost.Location = new Point(209, 297);
            textBoxPost.Name = "textBoxPost";
            textBoxPost.ScrollBars = ScrollBars.Horizontal;
            textBoxPost.Size = new Size(190, 27);
            textBoxPost.TabIndex = 54;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(209, 274);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 53;
            label10.Text = "Должноссть";
            // 
            // textBoxOffice
            // 
            textBoxOffice.Location = new Point(12, 297);
            textBoxOffice.MaxLength = 10;
            textBoxOffice.Name = "textBoxOffice";
            textBoxOffice.ScrollBars = ScrollBars.Horizontal;
            textBoxOffice.Size = new Size(190, 27);
            textBoxOffice.TabIndex = 52;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 274);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 51;
            label11.Text = "Кабинет";
            // 
            // textBoxPersonalPhone
            // 
            textBoxPersonalPhone.Location = new Point(209, 244);
            textBoxPersonalPhone.MaxLength = 20;
            textBoxPersonalPhone.Name = "textBoxPersonalPhone";
            textBoxPersonalPhone.ScrollBars = ScrollBars.Horizontal;
            textBoxPersonalPhone.Size = new Size(190, 27);
            textBoxPersonalPhone.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(209, 221);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 49;
            label6.Text = "Личный телефон";
            // 
            // textBoxWorkPhone
            // 
            textBoxWorkPhone.Location = new Point(12, 244);
            textBoxWorkPhone.MaxLength = 20;
            textBoxWorkPhone.Name = "textBoxWorkPhone";
            textBoxWorkPhone.ScrollBars = ScrollBars.Horizontal;
            textBoxWorkPhone.Size = new Size(190, 27);
            textBoxWorkPhone.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 221);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 47;
            label7.Text = "Рабочий телефон";
            // 
            // textBoxBirthDate
            // 
            textBoxBirthDate.Location = new Point(209, 191);
            textBoxBirthDate.Name = "textBoxBirthDate";
            textBoxBirthDate.ScrollBars = ScrollBars.Horizontal;
            textBoxBirthDate.Size = new Size(190, 27);
            textBoxBirthDate.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 168);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 45;
            label5.Text = "Дата рождения";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 191);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ScrollBars = ScrollBars.Horizontal;
            textBoxEmail.Size = new Size(190, 27);
            textBoxEmail.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 43;
            label4.Text = "Рабочая эл. почта";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(12, 138);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.ScrollBars = ScrollBars.Horizontal;
            textBoxSurname.Size = new Size(247, 27);
            textBoxSurname.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 41;
            label3.Text = "Отчество";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(12, 86);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.ScrollBars = ScrollBars.Horizontal;
            textBoxFirstName.Size = new Size(270, 27);
            textBoxFirstName.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 39;
            label2.Text = "Имя";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(12, 28);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.ScrollBars = ScrollBars.Horizontal;
            textBoxLastName.Size = new Size(270, 27);
            textBoxLastName.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 37;
            label1.Text = "Фамилия";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 452);
            label14.Name = "label14";
            label14.Size = new Size(207, 20);
            label14.TabIndex = 60;
            label14.Text = "Структурное подразделение";
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Enabled = false;
            textBoxDepartment.Location = new Point(12, 475);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.ScrollBars = ScrollBars.Horizontal;
            textBoxDepartment.Size = new Size(270, 27);
            textBoxDepartment.TabIndex = 70;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(432, 578);
            Controls.Add(textBoxDepartment);
            Controls.Add(buttonClearAssistant);
            Controls.Add(buttonClearManager);
            Controls.Add(comboBoxAssistant);
            Controls.Add(comboBoxManager);
            Controls.Add(comboBoxQualification);
            Controls.Add(buttonBack);
            Controls.Add(buttonSave);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(textBoxStartWorkDate);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBoxPost);
            Controls.Add(label10);
            Controls.Add(textBoxOffice);
            Controls.Add(label11);
            Controls.Add(textBoxPersonalPhone);
            Controls.Add(label6);
            Controls.Add(textBoxWorkPhone);
            Controls.Add(label7);
            Controls.Add(textBoxBirthDate);
            Controls.Add(label5);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(textBoxSurname);
            Controls.Add(label3);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(textBoxLastName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEmployeeForm";
            Padding = new Padding(15);
            Text = "Управление персоналом";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClearAssistant;
        private Button buttonClearManager;
        private ComboBox comboBoxAssistant;
        private ComboBox comboBoxManager;
        private ComboBox comboBoxQualification;
        private Button buttonBack;
        private Button buttonSave;
        private Label label12;
        private TextBox textBoxStartWorkDate;
        private Label label13;
        private Label label8;
        private Label label9;
        private TextBox textBoxPost;
        private Label label10;
        private TextBox textBoxOffice;
        private Label label11;
        private TextBox textBoxPersonalPhone;
        private Label label6;
        private TextBox textBoxWorkPhone;
        private Label label7;
        private TextBox textBoxBirthDate;
        private Label label5;
        private TextBox textBoxEmail;
        private Label label4;
        private TextBox textBoxSurname;
        private Label label3;
        private TextBox textBoxFirstName;
        private Label label2;
        private TextBox textBoxLastName;
        private Label label1;
        private Label label14;
        private TextBox textBoxDepartment;
    }
}