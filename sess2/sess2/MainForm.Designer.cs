namespace sess2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanelEmployees = new FlowLayoutPanel();
            treeViewDepartments = new TreeView();
            buttonAddEmployee = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-10, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(41, 128, 185);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(119, 32);
            label1.Name = "label1";
            label1.Size = new Size(433, 41);
            label1.TabIndex = 1;
            label1.Text = "Организационная структура";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelEmployees
            // 
            flowLayoutPanelEmployees.AutoScroll = true;
            flowLayoutPanelEmployees.BackColor = Color.FromArgb(236, 240, 241);
            flowLayoutPanelEmployees.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelEmployees.Location = new Point(280, 91);
            flowLayoutPanelEmployees.Name = "flowLayoutPanelEmployees";
            flowLayoutPanelEmployees.Size = new Size(537, 593);
            flowLayoutPanelEmployees.TabIndex = 1;
            flowLayoutPanelEmployees.WrapContents = false;
            // 
            // treeViewDepartments
            // 
            treeViewDepartments.BackColor = Color.White;
            treeViewDepartments.BorderStyle = BorderStyle.None;
            treeViewDepartments.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            treeViewDepartments.Location = new Point(12, 91);
            treeViewDepartments.Name = "treeViewDepartments";
            treeViewDepartments.Size = new Size(262, 593);
            treeViewDepartments.TabIndex = 2;
            treeViewDepartments.AfterSelect += treeViewDepartments_AfterSelect;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.BackColor = Color.FromArgb(46, 204, 113);
            buttonAddEmployee.FlatAppearance.BorderSize = 0;
            buttonAddEmployee.FlatStyle = FlatStyle.Flat;
            buttonAddEmployee.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddEmployee.ForeColor = Color.White;
            buttonAddEmployee.Location = new Point(768, 690);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(49, 49);
            buttonAddEmployee.TabIndex = 3;
            buttonAddEmployee.Text = "➕";
            buttonAddEmployee.UseVisualStyleBackColor = false;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 748);
            Controls.Add(buttonAddEmployee);
            Controls.Add(treeViewDepartments);
            Controls.Add(flowLayoutPanelEmployees);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Управление персоналом";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelEmployees;
        private TreeView treeViewDepartments;
        private Button buttonAddEmployee;
        private PictureBox pictureBox1;
    }
}