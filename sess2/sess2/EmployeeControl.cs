using System.Data;

namespace sess2
{
    public partial class EmployeeControl : UserControl
    {
        int employeeId;
        public EmployeeControl(int employeeId, string name, string departmentPost, string emailPhone, string office)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            labelName.Text = name;
            labelDepartmentPost.Text = departmentPost;
            labelEmailPhone.Text = emailPhone;
            labelOffice.Text = office;
        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.LightGray)
            {
                MessageBox.Show("Сотрудник уже уволен", "Ошибка");
                return;
            }
            string query = $@"SELECT COUNT(*) FROM days_off WHERE day_off_type_id = 1 AND employee_id = {employeeId}
                            AND (started_at > CURRENT_DATE OR (started_at < CURRENT_DATE AND ended_at > CURRENT_DATE))";
            DataTable dt = DBHelper.ExecuteQuery(query);
            long count = 0;
            if (dt.Rows.Count > 0) count = Convert.ToInt64(dt.Rows[0][0]);
            if (count > 0)
            {
                MessageBox.Show("Сотрудник может быть уволен, т.к. у него есть предстоящие или текущие обучения", "Ошибка");
                return;
            }
            var result = MessageBox.Show("Вы уверены что хотите уволить сотрудника?", "Предупреждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                query = $@"UPDATE employees SET end_work_date = CURRENT_DATE WHERE employee_id = {employeeId}";
                DBHelper.ExecuteQuery(query);
                query = $@"DELETE FROM days_off WHERE employee_id = {employeeId} AND started_at > CURRENT_DATE";
                DBHelper.ExecuteQuery(query);
                this.BackColor = Color.LightGray;
            }
        }

        private void EmployeeControl_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(employeeId);
            employeeForm.ShowDialog();
        }
    }
}
