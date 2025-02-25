namespace sess2
{
    public partial class AddEmployeeForm : Form
    {
        int departmentId;
        public AddEmployeeForm(int departmentId, string departmentName)
        {
            InitializeComponent();
            this.departmentId = departmentId;
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
