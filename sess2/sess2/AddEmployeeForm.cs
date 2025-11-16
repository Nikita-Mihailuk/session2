using System.Data;
using System.Text.RegularExpressions;

namespace sess2
{
    public partial class AddEmployeeForm : Form
    {
        int departmentId;
        public AddEmployeeForm(int departmentId, string departmentName)
        {
            InitializeComponent();
            this.departmentId = departmentId;
            textBoxDepartment.Text = departmentName;
            textBoxDepartment.Enabled = false;
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            string query = @"SELECT employee_id, CONCAT(last_name, ' ', first_name, ' ', surname) as full_name 
                            FROM employees WHERE end_work_date IS NULL ORDER BY last_name";
            DataTable dt = DBHelper.ExecuteQuery(query);

            DataRow emptyRow = dt.NewRow();
            emptyRow["employee_id"] = DBNull.Value;
            emptyRow["full_name"] = "-- Не выбрано --";
            dt.Rows.InsertAt(emptyRow, 0);

            comboBoxManager.DataSource = dt.Copy();
            comboBoxManager.ValueMember = "employee_id";
            comboBoxManager.DisplayMember = "full_name";

            comboBoxAssistant.DataSource = dt.Copy();
            comboBoxAssistant.ValueMember = "employee_id";
            comboBoxAssistant.DisplayMember = "full_name";
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

        private bool IsValidDate(string dateString, out DateTime date)
        {
            return DateTime.TryParse(dateString, out date);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Валидация
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxBirthDate.Text) ||
                string.IsNullOrWhiteSpace(textBoxWorkPhone.Text) ||
                string.IsNullOrWhiteSpace(textBoxPersonalPhone.Text) ||
                string.IsNullOrWhiteSpace(textBoxOffice.Text) ||
                string.IsNullOrWhiteSpace(textBoxPost.Text) ||
                string.IsNullOrWhiteSpace(textBoxStartWorkDate.Text) ||
                comboBoxQualification.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Неправильный формат email", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPhone(textBoxWorkPhone.Text) || !IsValidPhone(textBoxPersonalPhone.Text))
            {
                MessageBox.Show("Неправильный формат телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidDate(textBoxBirthDate.Text, out DateTime birthDate))
            {
                MessageBox.Show("Неправильный формат даты рождения (dd.MM.yyyy)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidDate(textBoxStartWorkDate.Text, out DateTime startWorkDate))
            {
                MessageBox.Show("Неправильный формат даты начала работы (dd.MM.yyyy)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем уникальность email
            string checkQuery = "SELECT COUNT(*) FROM employees WHERE work_email = @work_email";
            DataTable checkDt = DBHelper.ExecuteQuery(checkQuery, new Dictionary<string, object> { { "@work_email", textBoxEmail.Text } });
            if (Convert.ToInt64(checkDt.Rows[0][0]) > 0)
            {
                MessageBox.Show("Сотрудник с таким email уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Добавляем сотрудника
                string insertQuery = @"INSERT INTO employees (last_name, first_name, surname, department_id, post, 
                                      qualification_level, work_phone, personal_phone, office, work_email, 
                                      birth_date, start_work_date, password) 
                                      VALUES (@last_name, @first_name, @surname, @department_id, @post, 
                                      @qualification_level, @work_phone, @personal_phone, @office, @work_email, 
                                      @birth_date, @start_work_date, @password) RETURNING employee_id";

                DataTable result = DBHelper.ExecuteQuery(insertQuery, new Dictionary<string, object>
                {
                    { "@last_name", textBoxLastName.Text.Trim() },
                    { "@first_name", textBoxFirstName.Text.Trim() },
                    { "@surname", textBoxSurname.Text.Trim() },
                    { "@department_id", departmentId },
                    { "@post", textBoxPost.Text.Trim() },
                    { "@qualification_level", comboBoxQualification.Text },
                    { "@work_phone", textBoxWorkPhone.Text.Trim() },
                    { "@personal_phone", textBoxPersonalPhone.Text.Trim() },
                    { "@office", textBoxOffice.Text.Trim() },
                    { "@work_email", textBoxEmail.Text.Trim() },
                    { "@birth_date", birthDate },
                    { "@start_work_date", startWorkDate },
                    { "@password", "qwerty" } // Пароль по умолчанию
                });

                int newEmployeeId = Convert.ToInt32(result.Rows[0][0]);

                // Добавляем руководителя
                if (comboBoxManager.SelectedValue != DBNull.Value && comboBoxManager.SelectedIndex > 0)
                {
                    string managerQuery = @"INSERT INTO employees_assistants (manager_id, assistant_id) 
                                          VALUES (@manager_id, @assistant_id)";
                    DBHelper.ExecuteQuery(managerQuery, new Dictionary<string, object>
                    {
                        { "@manager_id", (int)comboBoxManager.SelectedValue },
                        { "@assistant_id", newEmployeeId }
                    });
                }

                // Добавляем помощника
                if (comboBoxAssistant.SelectedValue != DBNull.Value && comboBoxAssistant.SelectedIndex > 0)
                {
                    string assistantQuery = @"INSERT INTO employees_assistants (manager_id, assistant_id) 
                                            VALUES (@manager_id, @assistant_id)";
                    DBHelper.ExecuteQuery(assistantQuery, new Dictionary<string, object>
                    {
                        { "@manager_id", newEmployeeId },
                        { "@assistant_id", (int)comboBoxAssistant.SelectedValue }
                    });
                }

                MessageBox.Show("Сотрудник успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClearManager_Click(object sender, EventArgs e)
        {
            comboBoxManager.SelectedIndex = 0;
        }

        private void buttonClearAssistant_Click(object sender, EventArgs e)
        {
            comboBoxAssistant.SelectedIndex = 0;
        }
    }
}
