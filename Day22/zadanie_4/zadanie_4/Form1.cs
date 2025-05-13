using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        // Кнопка "Сохранить данные"
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Определяем пол
                string gender = radioMale.Checked ? "Мужской" : "Женский";

                // Получаем дату рождения
                string birthDate = $"{cmbDay.SelectedItem} {cmbMonth.SelectedItem} {cmbYear.SelectedItem}";

                // Определяем опыт работы
                string experience = "";
                if (radioNoExperience.Checked) experience = "Прежде не работал";
                else if (radioLessThanYear.Checked) experience = "Меньше года";
                else if (radio1to3Years.Checked) experience = "От 1 до 3 лет";
                else if (radio3to5Years.Checked) experience = "От 3 до 5 лет";
                else if (radio5to9Years.Checked) experience = "От 5 до 9 лет";
                else if (radioMoreThan10Years.Checked) experience = "Более 10 лет";

                // Определяем график работы
                string schedule = "";
                if (radioFullTime.Checked) schedule = "Полная занятость";
                else if (radioRemote.Checked) schedule = "Работа на дому";
                else if (radioPartTime.Checked) schedule = "Частичная занятость";
                else if (radioShiftWork.Checked) schedule = "Посменная работа";

                // Определяем наличие авто и категорий прав
                string car = chkCar.Checked ? "Да" : "Нет";
                string license = chkLicense.Checked ? "Да" : "Нет";
                string categories = "";
                if (chkCategoryA.Checked) categories += "A ";
                if (chkCategoryB.Checked) categories += "B ";
                if (chkCategoryC.Checked) categories += "C ";
                if (chkCategoryD.Checked) categories += "D ";

                // Составляем анкету
                string data = $"Фамилия: {txtSurname.Text}\n" +
                              $"Имя: {txtFirstName.Text}\n" +
                              $"Отчество: {txtPatronymic.Text}\n" +
                              $"Пол: {gender}\n" +
                              $"Дата рождения: {birthDate}\n" +
                              $"Место проживания: {cmbCity.SelectedItem}\n" +
                              $"Email: {txtEmail.Text}\n" +
                              $"Телефон: {cmbConnectionType.SelectedItem} {txtPhoneNumber.Text}\n" +
                              $"Опыт работы: {experience}\n" +
                              $"Желаемая зарплата: от {txtSalaryFrom.Text} до {txtSalaryTo.Text} руб.\n" +
                              $"График работы: {schedule}\n" +
                              $"Личное авто: {car}\n" +
                              $"Водительское удостоверение: {license}\n" +
                              $"Категория прав: {categories}\n" +
                              $"Краткое резюме:\n{txtResume.Text}";

                // 🔹 Показываем данные перед сохранением
                MessageBox.Show(data, "Проверка данных", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Сохранение в файл
                File.WriteAllText("EmployeeData.txt", data);
                MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка "Очистить форму" (исправленная)
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Очистка текстовых полей
            txtSurname.Clear();
            txtFirstName.Clear();
            txtPatronymic.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtSalaryFrom.Clear();
            txtSalaryTo.Clear();
            txtResume.Clear();

            // Сброс выбора в `ComboBox`
            cmbCity.SelectedIndex = -1;
            cmbConnectionType.SelectedIndex = -1;

            // Сброс `RadioButton`
            radioMale.Checked = false;
            radioFemale.Checked = false;
            radioNoExperience.Checked = false;
            radioLessThanYear.Checked = false;
            radio1to3Years.Checked = false;
            radio3to5Years.Checked = false;
            radio5to9Years.Checked = false;
            radioMoreThan10Years.Checked = false;
            radioFullTime.Checked = false;
            radioRemote.Checked = false;
            radioPartTime.Checked = false;
            radioShiftWork.Checked = false;

            // Сброс `CheckBox`
            chkCar.Checked = false;
            chkLicense.Checked = false;
            chkCategoryA.Checked = false;
            chkCategoryB.Checked = false;
            chkCategoryC.Checked = false;
            chkCategoryD.Checked = false;
        }

        // Кнопка "Отмена"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
