using System.Data;

namespace sess2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            TreeNode parrent = new TreeNode("Организационная структура") { Tag = 0 };
            treeViewDepartments.Nodes.Add(parrent);
            string query = @"SELECT department_id, department_name FROM departments WHERE department_id NOT IN (SELECT sub_department_id FROM sub_departments)";
            DataTable dt = DBHelper.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                int departmentId = (int)dr["department_id"];
                string departmentName = dr["department_name"].ToString();
                TreeNode department = new TreeNode(departmentName) { Tag = departmentId };
                parrent.Nodes.Add(department);
                LoadSubDepartments(department, departmentId);
            }
        }

        private void LoadSubDepartments(TreeNode parrent, int parrentId)
        {
            string query = $@"SELECT sd.sub_department_id, d.department_name FROM sub_departments sd 
                             JOIN departments d ON d.department_id = sd.sub_department_id WHERE sd.department_id = {parrentId}";
            DataTable dt = DBHelper.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                int departmentId = (int)dr["sub_department_id"];
                string departmentName = dr["department_name"].ToString();
                TreeNode department = new TreeNode(departmentName) { Tag = departmentId };
                parrent.Nodes.Add(department);
                LoadSubDepartments(department, departmentId);
            }
        }

        private void LoadEmployees(int departmentId)
        {
            flowLayoutPanelEmployees.Controls.Clear();

            string query = $@"SELECT e.employee_id, e.last_name, e.first_name, e.surname, e.post, e.work_phone, e.office, e.work_email, e.end_work_date, d.department_name FROM employees e
                                JOIN departments d ON d.department_id = e.department_id WHERE e.department_id = {departmentId} OR e.department_id IN 
                                (SELECT sub_department_id FROM sub_departments WHERE department_id = {departmentId}) ORDER BY e.last_name";
            DataTable dt = DBHelper.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                DateTime? endWorkDate = dr["end_work_date"] == DBNull.Value ? null : Convert.ToDateTime(dr["end_work_date"]);
                if (endWorkDate != null && (DateTime.Now - endWorkDate.Value).TotalDays > 30) continue;

                int employeeId = (int)dr["employee_id"];
                string name = $"{dr["last_name"]} {dr["first_name"]} {dr["surname"]}",
                        departmentPost = $"{dr["department_name"]}-{dr["post"]}",
                        emailPhone = $"{dr["work_email"]} {dr["work_phone"]}",
                        office = $"{dr["office"]}";

                EmployeeControl employeeControl = new EmployeeControl(employeeId, name, departmentPost, emailPhone, office);
                if (endWorkDate != null) employeeControl.BackColor = Color.LightGray;
                flowLayoutPanelEmployees.Controls.Add(employeeControl);
            }
        }

        private void treeViewDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadEmployees((int)e.Node.Tag);
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (treeViewDepartments.SelectedNode == null)
            {
                MessageBox.Show("Выберите подразделение", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int departmentId = (int)treeViewDepartments.SelectedNode.Tag;
            if (departmentId == 0)
            {
                MessageBox.Show("Выберите конкретный отдел, а не корневой элемент", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(departmentId, treeViewDepartments.SelectedNode.Text);
            if (addEmployeeForm.ShowDialog() == DialogResult.OK)
            {
                // Обновляем список сотрудников
                LoadEmployees(departmentId);
            }
        }
    }
}