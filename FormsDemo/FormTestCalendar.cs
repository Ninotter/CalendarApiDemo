using CalendrierApi.Core;

namespace FormsDemo
{
    public partial class FormTestCalendar : Form
    {
        private List<Button> CalendarDays { get; set; } = new List<Button>();

        public FormTestCalendar()
        {
            InitializeComponent();
            SetWeekDays();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int month = (int)numericUpDownMonth.Value;
            int year = (int)numericUpDownYear.Value;
            GenerateCalendar(year, month);
        }

        private void GenerateCalendar(int year, int month)
        {
            //Validates user input. 1753 is the minimum date for a MonthCalendar
            if ((numericUpDownMonth.Value <= 12 && numericUpDownMonth.Value > 0)
                && (numericUpDownYear.Value >= 1753 && numericUpDownYear.Value < 10_000))
            {

                IEnumerable<DateTime> dates = Calendar.GetDaysInMonth(year, month);
                SetDates(dates);
            }
        }

        //private void SetDates(IEnumerable<DateTime> dates)
        //{
        //    if (dates.Any())
        //    {
        //        monthCalendar1.SetDate(dates.FirstOrDefault());
        //    }
        //}

        private void SetWeekDays()
        {
            string[] weekdays = { "lu", "ma", "me", "je", "ve", "sa", "di" };
            var labelHeight = panelCalendar.Height / 7;    // a maximum of 6 different weeks can be shown in a month + 1 to accomodate for weekdays labels
            var labelWidth = panelCalendar.Width / 7;
            for (int i = 0; i < 7; i++)
            {
                Label lbl = new Label();
                lbl.Text = weekdays[i];
                lbl.Parent = panelCalendar;
                lbl.Location = new Point(labelWidth * i, 0);
                lbl.Size = new Size(labelWidth, labelHeight);
                lbl.Show();
            }
        }

        private void SetDates(IEnumerable<DateTime> dates)
        {
            ClearCalendar();
            GenerateButtonList(dates);
            ShowCalendar();
        }

        private void ClearCalendar()
        {
            foreach (Button button in CalendarDays)
            {
                button.Dispose();
            }
        }

        private void ShowCalendar()
        {
            foreach (Button button in CalendarDays)
            {
                button.Show();
            }
        }

        private void GenerateButtonList(IEnumerable<DateTime> dates)
        {
            CalendarDays.Clear();
            var dateButtonHeight = panelCalendar.Height / 7;    // a maximum of 6 different weeks can be shown in a month + 1 to accomodate for weekdays labels
            var dateButtonWidth = panelCalendar.Width / 7;      // used to fit 7 days (of the week) in a row
            if (dates.Any())
            {
                int currentWeekOfTheMonth = 0;
                int currentDayOfTheWeek = (int)dates.First().DayOfWeek;
                currentDayOfTheWeek--; //Adjusted to have the first column of the calendar as monday
                if (currentDayOfTheWeek < 0) currentDayOfTheWeek = 6;
                foreach (DateTime date in dates)
                {
                    Button buttonDate = new Button();
                    buttonDate.Location = new Point
                        (
                        dateButtonWidth * currentDayOfTheWeek,
                        dateButtonHeight * (currentWeekOfTheMonth + 1) //+1 for weekdays label
                        ) ;
                    buttonDate.Size = new Size(dateButtonWidth, dateButtonHeight);
                    buttonDate.Text = date.Day.ToString();
                    buttonDate.Parent = panelCalendar;
                    CalendarDays.Add(buttonDate);

                    currentDayOfTheWeek++;
                    if (currentDayOfTheWeek > 6)
                    {
                        currentDayOfTheWeek = 0;
                        currentWeekOfTheMonth++;
                    }
                }
            }
        }
    }
}