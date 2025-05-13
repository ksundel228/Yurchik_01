namespace zadanie_4
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grpBirthDate = new System.Windows.Forms.GroupBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmbConnectionType = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.grpExperience = new System.Windows.Forms.GroupBox();
            this.radioMoreThan10Years = new System.Windows.Forms.RadioButton();
            this.radio5to9Years = new System.Windows.Forms.RadioButton();
            this.radio3to5Years = new System.Windows.Forms.RadioButton();
            this.radio1to3Years = new System.Windows.Forms.RadioButton();
            this.radioLessThanYear = new System.Windows.Forms.RadioButton();
            this.radioNoExperience = new System.Windows.Forms.RadioButton();
            this.grpAdditionalInfo = new System.Windows.Forms.GroupBox();
            this.chkCategoryD = new System.Windows.Forms.CheckBox();
            this.chkCategoryC = new System.Windows.Forms.CheckBox();
            this.chkCategoryB = new System.Windows.Forms.CheckBox();
            this.chkCategoryA = new System.Windows.Forms.CheckBox();
            this.lbl = new System.Windows.Forms.Label();
            this.chkLicense = new System.Windows.Forms.CheckBox();
            this.chkCar = new System.Windows.Forms.CheckBox();
            this.grpSalary = new System.Windows.Forms.GroupBox();
            this.txtSalaryFrom = new System.Windows.Forms.TextBox();
            this.lblSalaryFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalaryTo = new System.Windows.Forms.TextBox();
            this.lblResume = new System.Windows.Forms.Label();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.grpSchedule = new System.Windows.Forms.GroupBox();
            this.radioFullTime = new System.Windows.Forms.RadioButton();
            this.radioRemote = new System.Windows.Forms.RadioButton();
            this.radioPartTime = new System.Windows.Forms.RadioButton();
            this.radioShiftWork = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpPersonalInfo.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.grpBirthDate.SuspendLayout();
            this.grpExperience.SuspendLayout();
            this.grpAdditionalInfo.SuspendLayout();
            this.grpSalary.SuspendLayout();
            this.grpSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.grpGender);
            this.grpPersonalInfo.Controls.Add(this.txtPatronymic);
            this.grpPersonalInfo.Controls.Add(this.txtFirstName);
            this.grpPersonalInfo.Controls.Add(this.txtSurname);
            this.grpPersonalInfo.Controls.Add(this.lblPatronymic);
            this.grpPersonalInfo.Controls.Add(this.lblFirstName);
            this.grpPersonalInfo.Controls.Add(this.lblSurname);
            this.grpPersonalInfo.Location = new System.Drawing.Point(12, 12);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(739, 156);
            this.grpPersonalInfo.TabIndex = 0;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Персональные данные";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.radioFemale);
            this.grpGender.Controls.Add(this.radioMale);
            this.grpGender.Location = new System.Drawing.Point(404, 21);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(318, 109);
            this.grpGender.TabIndex = 6;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Пол";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(24, 64);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(87, 20);
            this.radioFemale.TabIndex = 2;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Женский";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(24, 38);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(86, 20);
            this.radioMale.TabIndex = 1;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Мужской";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(91, 108);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(258, 22);
            this.txtPatronymic.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(91, 72);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(258, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(91, 34);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(258, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(15, 114);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(70, 16);
            this.lblPatronymic.TabIndex = 2;
            this.lblPatronymic.Text = "Отчество";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(52, 78);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(33, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Имя";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(19, 40);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(66, 16);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Фамилия";
            // 
            // grpBirthDate
            // 
            this.grpBirthDate.Controls.Add(this.lblYear);
            this.grpBirthDate.Controls.Add(this.lblMonth);
            this.grpBirthDate.Controls.Add(this.cmbYear);
            this.grpBirthDate.Controls.Add(this.cmbMonth);
            this.grpBirthDate.Controls.Add(this.lblDay);
            this.grpBirthDate.Controls.Add(this.cmbDay);
            this.grpBirthDate.Location = new System.Drawing.Point(12, 174);
            this.grpBirthDate.Name = "grpBirthDate";
            this.grpBirthDate.Size = new System.Drawing.Size(739, 87);
            this.grpBirthDate.TabIndex = 1;
            this.grpBirthDate.TabStop = false;
            this.grpBirthDate.Text = "Дата рождения";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(580, 22);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(30, 16);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Год";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(351, 22);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(48, 16);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Месяц";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbYear.Location = new System.Drawing.Point(536, 41);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 5;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.cmbMonth.Location = new System.Drawing.Point(323, 41);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbMonth.TabIndex = 4;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(138, 22);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(39, 16);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "День";
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDay.Location = new System.Drawing.Point(101, 41);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(121, 24);
            this.cmbDay.TabIndex = 0;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(31, 281);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(132, 16);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Город проживания:";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Минск",
            "Гомель",
            "Гродно",
            "Витебск",
            "Могилёв",
            "Брест",
            "Бобруйск",
            "Барановичи",
            "Борисов",
            "Пинск",
            "Мозырь",
            "Лида",
            "Орша",
            "Солигорск",
            "Новополоцк",
            "Слуцк",
            "Речица",
            "Жлобин",
            "Светлогорск",
            "Кобрин",
            "Горки"});
            this.cmbCity.Location = new System.Drawing.Point(224, 278);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(501, 24);
            this.cmbCity.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 309);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(182, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Адрес электронной почты:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(224, 309);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(501, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(31, 340);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(146, 16);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Мобильный телефон:";
            // 
            // cmbConnectionType
            // 
            this.cmbConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConnectionType.FormattingEnabled = true;
            this.cmbConnectionType.Items.AddRange(new object[] {
            "MTC",
            "Life",
            "A1",
            "Белтелеком"});
            this.cmbConnectionType.Location = new System.Drawing.Point(224, 337);
            this.cmbConnectionType.Name = "cmbConnectionType";
            this.cmbConnectionType.Size = new System.Drawing.Size(121, 24);
            this.cmbConnectionType.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(380, 337);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(345, 22);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // grpExperience
            // 
            this.grpExperience.Controls.Add(this.radioMoreThan10Years);
            this.grpExperience.Controls.Add(this.radio5to9Years);
            this.grpExperience.Controls.Add(this.radio3to5Years);
            this.grpExperience.Controls.Add(this.radio1to3Years);
            this.grpExperience.Controls.Add(this.radioLessThanYear);
            this.grpExperience.Controls.Add(this.radioNoExperience);
            this.grpExperience.Location = new System.Drawing.Point(12, 367);
            this.grpExperience.Name = "grpExperience";
            this.grpExperience.Size = new System.Drawing.Size(739, 100);
            this.grpExperience.TabIndex = 9;
            this.grpExperience.TabStop = false;
            this.grpExperience.Text = "Опыт работы";
            // 
            // radioMoreThan10Years
            // 
            this.radioMoreThan10Years.AutoSize = true;
            this.radioMoreThan10Years.Location = new System.Drawing.Point(484, 57);
            this.radioMoreThan10Years.Name = "radioMoreThan10Years";
            this.radioMoreThan10Years.Size = new System.Drawing.Size(112, 20);
            this.radioMoreThan10Years.TabIndex = 14;
            this.radioMoreThan10Years.TabStop = true;
            this.radioMoreThan10Years.Text = "Более 10 лет";
            this.radioMoreThan10Years.UseVisualStyleBackColor = true;
            // 
            // radio5to9Years
            // 
            this.radio5to9Years.AutoSize = true;
            this.radio5to9Years.Location = new System.Drawing.Point(484, 31);
            this.radio5to9Years.Name = "radio5to9Years";
            this.radio5to9Years.Size = new System.Drawing.Size(110, 20);
            this.radio5to9Years.TabIndex = 13;
            this.radio5to9Years.TabStop = true;
            this.radio5to9Years.Text = "От 5 до 9 лет";
            this.radio5to9Years.UseVisualStyleBackColor = true;
            // 
            // radio3to5Years
            // 
            this.radio3to5Years.AutoSize = true;
            this.radio3to5Years.Location = new System.Drawing.Point(263, 57);
            this.radio3to5Years.Name = "radio3to5Years";
            this.radio3to5Years.Size = new System.Drawing.Size(110, 20);
            this.radio3to5Years.TabIndex = 12;
            this.radio3to5Years.TabStop = true;
            this.radio3to5Years.Text = "От 3 до 5 лет";
            this.radio3to5Years.UseVisualStyleBackColor = true;
            // 
            // radio1to3Years
            // 
            this.radio1to3Years.AutoSize = true;
            this.radio1to3Years.Location = new System.Drawing.Point(263, 31);
            this.radio1to3Years.Name = "radio1to3Years";
            this.radio1to3Years.Size = new System.Drawing.Size(110, 20);
            this.radio1to3Years.TabIndex = 11;
            this.radio1to3Years.TabStop = true;
            this.radio1to3Years.Text = "От 1 до 3 лет";
            this.radio1to3Years.UseVisualStyleBackColor = true;
            // 
            // radioLessThanYear
            // 
            this.radioLessThanYear.AutoSize = true;
            this.radioLessThanYear.Location = new System.Drawing.Point(33, 57);
            this.radioLessThanYear.Name = "radioLessThanYear";
            this.radioLessThanYear.Size = new System.Drawing.Size(112, 20);
            this.radioLessThanYear.TabIndex = 11;
            this.radioLessThanYear.TabStop = true;
            this.radioLessThanYear.Text = "Меньше года";
            this.radioLessThanYear.UseVisualStyleBackColor = true;
            // 
            // radioNoExperience
            // 
            this.radioNoExperience.AutoSize = true;
            this.radioNoExperience.Location = new System.Drawing.Point(33, 31);
            this.radioNoExperience.Name = "radioNoExperience";
            this.radioNoExperience.Size = new System.Drawing.Size(156, 20);
            this.radioNoExperience.TabIndex = 10;
            this.radioNoExperience.TabStop = true;
            this.radioNoExperience.Text = "Прежде не работал";
            this.radioNoExperience.UseVisualStyleBackColor = true;
            // 
            // grpAdditionalInfo
            // 
            this.grpAdditionalInfo.Controls.Add(this.chkCategoryD);
            this.grpAdditionalInfo.Controls.Add(this.chkCategoryC);
            this.grpAdditionalInfo.Controls.Add(this.chkCategoryB);
            this.grpAdditionalInfo.Controls.Add(this.chkCategoryA);
            this.grpAdditionalInfo.Controls.Add(this.lbl);
            this.grpAdditionalInfo.Controls.Add(this.chkLicense);
            this.grpAdditionalInfo.Controls.Add(this.chkCar);
            this.grpAdditionalInfo.Location = new System.Drawing.Point(12, 473);
            this.grpAdditionalInfo.Name = "grpAdditionalInfo";
            this.grpAdditionalInfo.Size = new System.Drawing.Size(245, 143);
            this.grpAdditionalInfo.TabIndex = 10;
            this.grpAdditionalInfo.TabStop = false;
            this.grpAdditionalInfo.Text = "Другие сведения";
            // 
            // chkCategoryD
            // 
            this.chkCategoryD.AutoSize = true;
            this.chkCategoryD.Location = new System.Drawing.Point(142, 117);
            this.chkCategoryD.Name = "chkCategoryD";
            this.chkCategoryD.Size = new System.Drawing.Size(39, 20);
            this.chkCategoryD.TabIndex = 6;
            this.chkCategoryD.Text = "D";
            this.chkCategoryD.UseVisualStyleBackColor = true;
            // 
            // chkCategoryC
            // 
            this.chkCategoryC.AutoSize = true;
            this.chkCategoryC.Location = new System.Drawing.Point(99, 117);
            this.chkCategoryC.Name = "chkCategoryC";
            this.chkCategoryC.Size = new System.Drawing.Size(38, 20);
            this.chkCategoryC.TabIndex = 5;
            this.chkCategoryC.Text = "C";
            this.chkCategoryC.UseVisualStyleBackColor = true;
            // 
            // chkCategoryB
            // 
            this.chkCategoryB.AutoSize = true;
            this.chkCategoryB.Location = new System.Drawing.Point(55, 117);
            this.chkCategoryB.Name = "chkCategoryB";
            this.chkCategoryB.Size = new System.Drawing.Size(38, 20);
            this.chkCategoryB.TabIndex = 4;
            this.chkCategoryB.Text = "B";
            this.chkCategoryB.UseVisualStyleBackColor = true;
            // 
            // chkCategoryA
            // 
            this.chkCategoryA.AutoSize = true;
            this.chkCategoryA.Location = new System.Drawing.Point(11, 117);
            this.chkCategoryA.Name = "chkCategoryA";
            this.chkCategoryA.Size = new System.Drawing.Size(38, 20);
            this.chkCategoryA.TabIndex = 3;
            this.chkCategoryA.Text = "A";
            this.chkCategoryA.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(8, 91);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(111, 16);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Категории прав";
            // 
            // chkLicense
            // 
            this.chkLicense.AutoSize = true;
            this.chkLicense.Location = new System.Drawing.Point(11, 56);
            this.chkLicense.Name = "chkLicense";
            this.chkLicense.Size = new System.Drawing.Size(227, 20);
            this.chkLicense.TabIndex = 1;
            this.chkLicense.Text = "Водительское удостоверение";
            this.chkLicense.UseVisualStyleBackColor = true;
            // 
            // chkCar
            // 
            this.chkCar.AutoSize = true;
            this.chkCar.Location = new System.Drawing.Point(11, 30);
            this.chkCar.Name = "chkCar";
            this.chkCar.Size = new System.Drawing.Size(226, 20);
            this.chkCar.TabIndex = 0;
            this.chkCar.Text = "Наличие личного автомобиля";
            this.chkCar.UseVisualStyleBackColor = true;
            // 
            // grpSalary
            // 
            this.grpSalary.Controls.Add(this.txtSalaryTo);
            this.grpSalary.Controls.Add(this.label1);
            this.grpSalary.Controls.Add(this.txtSalaryFrom);
            this.grpSalary.Controls.Add(this.lblSalaryFrom);
            this.grpSalary.Location = new System.Drawing.Point(263, 473);
            this.grpSalary.Name = "grpSalary";
            this.grpSalary.Size = new System.Drawing.Size(488, 55);
            this.grpSalary.TabIndex = 11;
            this.grpSalary.TabStop = false;
            this.grpSalary.Text = "Объем заработной платы";
            // 
            // txtSalaryFrom
            // 
            this.txtSalaryFrom.Location = new System.Drawing.Point(80, 24);
            this.txtSalaryFrom.Name = "txtSalaryFrom";
            this.txtSalaryFrom.Size = new System.Drawing.Size(90, 22);
            this.txtSalaryFrom.TabIndex = 4;
            // 
            // lblSalaryFrom
            // 
            this.lblSalaryFrom.AutoSize = true;
            this.lblSalaryFrom.Location = new System.Drawing.Point(35, 27);
            this.lblSalaryFrom.Name = "lblSalaryFrom";
            this.lblSalaryFrom.Size = new System.Drawing.Size(27, 16);
            this.lblSalaryFrom.TabIndex = 0;
            this.lblSalaryFrom.Text = "От:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "До:";
            // 
            // txtSalaryTo
            // 
            this.txtSalaryTo.Location = new System.Drawing.Point(281, 24);
            this.txtSalaryTo.Name = "txtSalaryTo";
            this.txtSalaryTo.Size = new System.Drawing.Size(90, 22);
            this.txtSalaryTo.TabIndex = 6;
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Location = new System.Drawing.Point(12, 619);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(115, 16);
            this.lblResume.TabIndex = 12;
            this.lblResume.Text = "Краткое резюме";
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(12, 638);
            this.txtResume.Multiline = true;
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(739, 200);
            this.txtResume.TabIndex = 13;
            // 
            // grpSchedule
            // 
            this.grpSchedule.Controls.Add(this.radioShiftWork);
            this.grpSchedule.Controls.Add(this.radioPartTime);
            this.grpSchedule.Controls.Add(this.radioRemote);
            this.grpSchedule.Controls.Add(this.radioFullTime);
            this.grpSchedule.Location = new System.Drawing.Point(263, 535);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Size = new System.Drawing.Size(488, 81);
            this.grpSchedule.TabIndex = 14;
            this.grpSchedule.TabStop = false;
            this.grpSchedule.Text = "Предпочитаемый график работы";
            // 
            // radioFullTime
            // 
            this.radioFullTime.AutoSize = true;
            this.radioFullTime.Location = new System.Drawing.Point(19, 27);
            this.radioFullTime.Name = "radioFullTime";
            this.radioFullTime.Size = new System.Drawing.Size(147, 20);
            this.radioFullTime.TabIndex = 0;
            this.radioFullTime.TabStop = true;
            this.radioFullTime.Text = "Полная занятость";
            this.radioFullTime.UseVisualStyleBackColor = true;
            // 
            // radioRemote
            // 
            this.radioRemote.AutoSize = true;
            this.radioRemote.Location = new System.Drawing.Point(19, 53);
            this.radioRemote.Name = "radioRemote";
            this.radioRemote.Size = new System.Drawing.Size(131, 20);
            this.radioRemote.TabIndex = 1;
            this.radioRemote.TabStop = true;
            this.radioRemote.Text = "Работа на дому";
            this.radioRemote.UseVisualStyleBackColor = true;
            // 
            // radioPartTime
            // 
            this.radioPartTime.AutoSize = true;
            this.radioPartTime.Location = new System.Drawing.Point(240, 27);
            this.radioPartTime.Name = "radioPartTime";
            this.radioPartTime.Size = new System.Drawing.Size(168, 20);
            this.radioPartTime.TabIndex = 2;
            this.radioPartTime.TabStop = true;
            this.radioPartTime.Text = "Частичная занятость";
            this.radioPartTime.UseVisualStyleBackColor = true;
            // 
            // radioShiftWork
            // 
            this.radioShiftWork.AutoSize = true;
            this.radioShiftWork.Location = new System.Drawing.Point(240, 53);
            this.radioShiftWork.Name = "radioShiftWork";
            this.radioShiftWork.Size = new System.Drawing.Size(151, 20);
            this.radioShiftWork.TabIndex = 3;
            this.radioShiftWork.TabStop = true;
            this.radioShiftWork.Text = "Посменная работа";
            this.radioShiftWork.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(321, 844);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить данные";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(485, 844);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Очистить форму";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(640, 844);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 867);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpSchedule);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.grpSalary);
            this.Controls.Add(this.grpAdditionalInfo);
            this.Controls.Add(this.grpExperience);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.cmbConnectionType);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.grpBirthDate);
            this.Controls.Add(this.grpPersonalInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpBirthDate.ResumeLayout(false);
            this.grpBirthDate.PerformLayout();
            this.grpExperience.ResumeLayout(false);
            this.grpExperience.PerformLayout();
            this.grpAdditionalInfo.ResumeLayout(false);
            this.grpAdditionalInfo.PerformLayout();
            this.grpSalary.ResumeLayout(false);
            this.grpSalary.PerformLayout();
            this.grpSchedule.ResumeLayout(false);
            this.grpSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.GroupBox grpBirthDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cmbConnectionType;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.GroupBox grpExperience;
        private System.Windows.Forms.RadioButton radioMoreThan10Years;
        private System.Windows.Forms.RadioButton radio5to9Years;
        private System.Windows.Forms.RadioButton radio3to5Years;
        private System.Windows.Forms.RadioButton radio1to3Years;
        private System.Windows.Forms.RadioButton radioLessThanYear;
        private System.Windows.Forms.RadioButton radioNoExperience;
        private System.Windows.Forms.GroupBox grpAdditionalInfo;
        private System.Windows.Forms.CheckBox chkLicense;
        private System.Windows.Forms.CheckBox chkCar;
        private System.Windows.Forms.CheckBox chkCategoryD;
        private System.Windows.Forms.CheckBox chkCategoryC;
        private System.Windows.Forms.CheckBox chkCategoryB;
        private System.Windows.Forms.CheckBox chkCategoryA;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox grpSalary;
        private System.Windows.Forms.TextBox txtSalaryFrom;
        private System.Windows.Forms.Label lblSalaryFrom;
        private System.Windows.Forms.TextBox txtSalaryTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.TextBox txtResume;
        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.RadioButton radioShiftWork;
        private System.Windows.Forms.RadioButton radioPartTime;
        private System.Windows.Forms.RadioButton radioRemote;
        private System.Windows.Forms.RadioButton radioFullTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
    }
}

