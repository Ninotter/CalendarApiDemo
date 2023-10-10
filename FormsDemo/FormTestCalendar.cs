using CalendrierApi.Core;

namespace FormsDemo
{
    public partial class FormTestCalendar : Form
    {
        public FormTestCalendar()
        {
            InitializeComponent();
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

        private void SetDates(IEnumerable<DateTime> dates)
        {
            if (dates.Any())
            {
                monthCalendar1.SetDate(dates.FirstOrDefault());
            }
        }
    }
}