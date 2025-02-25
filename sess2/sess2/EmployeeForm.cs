using System.Data;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace sess2
{
    public partial class EmployeeForm : Form
    {
        int employeeId;
        string filter = "current";
        DateTime today = DateTime.Now;
        public EmployeeForm(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            LoadDepartments();
            LoadEmployeeInfo();
            LoadDayOff();
        }
        private void LoadDepartments()
        {
            string query = "SELECT department_id, department_name FROM departments";
            DataTable dt = DBHelper.ExecuteQuery(query);
            comboBoxDepartment.DataSource = dt;
            comboBoxDepartment.ValueMember = "department_id";
            comboBoxDepartment.DisplayMember = "department_name";
        }
        private void LoadEmployeeInfo()
        {
            string query = $@"SELECT last_name, first_name, surname, department_id, post, qualification_level,
                            work_phone, personal_phone, office, work_email, birth_date, start_work_date FROM employees WHERE employee_id = {employeeId}";
            DataTable dt = DBHelper.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];

            textBoxBirthDate.Text = Convert.ToDateTime(dr["birth_date"]).ToString("d");
            textBoxEmail.Text = dr["work_email"].ToString();
            textBoxFirstName.Text = dr["first_name"].ToString();
            textBoxLastName.Text = dr["last_name"].ToString();
            textBoxOffice.Text = dr["office"].ToString();
            textBoxPersonalPhone.Text = dr["personal_phone"].ToString();
            textBoxPost.Text = dr["post"].ToString();
            textBoxStartWorkDate.Text = Convert.ToDateTime(dr["start_work_date"]).ToString("d");
            textBoxSurname.Text = dr["surname"].ToString();
            textBoxWorkPhone.Text = dr["work_phone"].ToString();
            comboBoxQualification.Text = dr["qualification_level"].ToString();
            comboBoxDepartment.SelectedValue = (int)dr["department_id"];
        }

        private void LoadDayOff()
        {
            flowLayoutPanelDayOff.Controls.Clear();
            flowLayoutPanelTreaning.Controls.Clear();
            flowLayoutPanelVacation.Controls.Clear();

            string query = $@"SELECT d.started_at, d.ended_at, d.description, dt.type_name FROM days_off d
                            JOIN day_off_types dt ON d.day_off_type_id = dt.type_id WHERE d.employee_id = {employeeId}
                            ORDER BY d.started_at ASC";
            DataTable dt = DBHelper.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                DateTime start = Convert.ToDateTime(dr["started_at"]);
                DateTime end = Convert.ToDateTime(dr["ended_at"]);
                if (FilterDayOff(start, end)) AddDayOffCard(dr);
            }


        }

        private void AddDayOffCard(DataRow dr)
        {
            string start = Convert.ToDateTime(dr["started_at"]).ToString("d");
            string end = Convert.ToDateTime(dr["ended_at"]).ToString("d");
            string typeName = dr["type_name"].ToString();
            string description = dr["description"].ToString();

            DayOffControl dayOffControl = new DayOffControl($"{start}-{end}\n{description}");
            if (typeName == "Обучение") flowLayoutPanelTreaning.Controls.Add(dayOffControl);
            if (typeName == "Отгул") flowLayoutPanelDayOff.Controls.Add(dayOffControl);
            if (typeName == "Отпуск") flowLayoutPanelVacation.Controls.Add(dayOffControl);
        }

        private bool FilterDayOff(DateTime start, DateTime end)
        {
            if (filter == "past") return end < today;
            if (filter == "current") return start < today && end > today;
            if (filter == "future") return start > today;
            return true;
        }

        private void buttonPast_Click(object sender, EventArgs e)
        {
            filter = "past";
            LoadDayOff();
        }

        private void buttonCurrent_Click(object sender, EventArgs e)
        {
            filter = "current";
            LoadDayOff();
        }

        private void buttonFuture_Click(object sender, EventArgs e)
        {
            filter = "future";
            LoadDayOff();
        }
        private void buttonAddDayOff_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePickerStart.Value;
            DateTime end = dateTimePickerEnd.Value;
            string description = textBoxDescription.Text;
            string typeName = comboBoxTypeDayOff.Text;

            if (typeName == "" || description == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }
            if (start >= end)
            {
                MessageBox.Show("Дата окончания не может быть раньше даты начала", "Ошибка");
                return;
            }
            int typeId = typeName switch
            {
                "Обучение" => 1,
                "Отгул" => 2,
                "Отпуск" => 3
            };
            string query = @"INSERT INTO public.days_off(day_off_type_id, started_at, ended_at, description, employee_id)
	                            VALUES ( @day_off_type_id, @started_at, @ended_at, @description, @employee_id)";
            DBHelper.ExecuteQuery(query, new Dictionary<string, object>
            {
                {"@day_off_type_id", typeId },
                {"@started_at", start },
                {"@ended_at", end },
                {"@description", description },
                {"@employee_id", employeeId },
            });
            LoadDayOff();
        }

        private void EnabledInputs(bool enabled)
        {
            textBoxEmail.Enabled = enabled;
            textBoxFirstName.Enabled = enabled;
            textBoxLastName.Enabled = enabled;
            textBoxOffice.Enabled = enabled;
            textBoxPersonalPhone.Enabled = enabled;
            textBoxPost.Enabled = enabled;
            textBoxSurname.Enabled = enabled;
            textBoxWorkPhone.Enabled = enabled;
            comboBoxAssistant.Enabled = enabled;
            comboBoxDepartment.Enabled = enabled;
            comboBoxManager.Enabled = enabled;
            comboBoxQualification.Enabled = enabled;
            buttonBack.Enabled = enabled;
            buttonClearAssistant.Enabled = enabled;
            buttonClearManager.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonEdit.Enabled = !enabled;
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EnabledInputs(true);
        }

        private bool IsValidEmail(string email)
        {
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private bool IsValidPhone(string phone)
        {
            var pattern = @"^[\d+\-()\s]+$";
            return Regex.IsMatch(phone, pattern);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (!IsValidEmail(textBoxEmail.Text) ||
                !IsValidPhone(textBoxPersonalPhone.Text) ||
                !IsValidPhone(textBoxWorkPhone.Text) ||
                textBoxFirstName.Text == "" ||
                textBoxLastName.Text == "" ||
                textBoxOffice.Text == "" ||
                textBoxPost.Text == "" ||
                textBoxSurname.Text == "")
            {
                MessageBox.Show("Неправильно заполненные поля", "Ошибка");
                return;
            }

            string query = $@"UPDATE employees SET last_name=@last_name, first_name=@first_name, surname=@surname, department_id=@department_id, post=@post,
                            qualification_level=@qualification_level, work_phone=@work_phone, personal_phone=@personal_phone, office=@office, work_email=@work_email
	                        WHERE employee_id=@employee_id";
            DBHelper.ExecuteQuery(query, new Dictionary<string, object>
            {
                {"@last_name", textBoxLastName.Text },
                {"@first_name", textBoxFirstName.Text },
                {"@surname", textBoxSurname.Text },
                {"@department_id", (int)comboBoxDepartment.SelectedValue },
                {"@post", textBoxPost.Text },
                {"@qualification_level", comboBoxQualification.Text },
                {"@work_phone", textBoxWorkPhone.Text },
                {"@personal_phone", textBoxPersonalPhone.Text },
                {"@office", textBoxOffice.Text },
                {"@work_email", textBoxEmail.Text },
                {"@employee_id", employeeId },
            });

            EnabledInputs(false);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            EnabledInputs(false);
            LoadEmployeeInfo();
        }
    }
}
