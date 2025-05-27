using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExperimentNo2_3
{
    public partial class Default : System.Web.UI.Page
    {
        Hashtable HolidayList;

        protected void Page_Load(object sender, EventArgs e)
        {
            HolidayList = Getholiday();
            Calendar1.Caption = " ";
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
            Calendar1.TitleFormat = TitleFormat.Month;
            Calendar1.ShowGridLines = true;
            Calendar1.DayStyle.Height = new Unit(50);
            Calendar1.DayStyle.Width = new Unit(150);
            Calendar1.DayStyle.HorizontalAlign = HorizontalAlign.Center;
            Calendar1.DayStyle.VerticalAlign = VerticalAlign.Middle;
            Calendar1.OtherMonthDayStyle.BackColor = System.Drawing.Color.AliceBlue;
        }

        private Hashtable Getholiday()
        {
            Hashtable holiday = new Hashtable();
            holiday[new DateTime(2025, 1, 1)] = "New Year";
            holiday[new DateTime(2025, 1, 14)] = "Pongal";
            holiday[new DateTime(2025, 1, 26)] = "Republic Day";
            holiday[new DateTime(2025, 3, 14)] = "Holi";
            holiday[new DateTime(2025, 4, 10)] = "Good Friday";
            holiday[new DateTime(2025, 4, 14)] = "Dr. Ambedkar Jayanti & Tamil New Year";
            holiday[new DateTime(2025, 5, 1)] = "May Day";
            holiday[new DateTime(2025, 5, 14)] = "Buddha Purnima";
            holiday[new DateTime(2025, 7, 10)] = "Rath Yatra";
            holiday[new DateTime(2025, 8, 15)] = "Independence Day";
            holiday[new DateTime(2025, 8, 16)] = "Parsi New Year";
            holiday[new DateTime(2025, 9, 7)] = "Ganesh Chaturthi";
            holiday[new DateTime(2025, 10, 2)] = "Gandhi Jayanti";
            holiday[new DateTime(2025, 10, 21)] = "Dussehra";
            holiday[new DateTime(2025, 10, 31)] = "Diwali";
            holiday[new DateTime(2025, 11, 1)] = "Govardhan Puja";
            holiday[new DateTime(2025, 11, 3)] = "Bhai Dooj";
            holiday[new DateTime(2025, 11, 7)] = "Chhath Puja";
            holiday[new DateTime(2025, 12, 25)] = "Christmas";
            return holiday;
        }


        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            LabelAction.Text = "Date changed to :" + Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            LabelAction.Text = "Month changed to :" + e.NewDate.ToShortDateString();
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (HolidayList.ContainsKey(e.Day.Date))
            {
                Literal literal1 = new Literal();
                literal1.Text = "<br/>";
                e.Cell.Controls.Add(literal1);

                Label label1 = new Label();
                label1.Text = (string)HolidayList[e.Day.Date];
                label1.Font.Size = new FontUnit(FontSize.Small);
                label1.ForeColor = System.Drawing.Color.Red;
                e.Cell.Controls.Add(label1);

                e.Cell.BackColor = System.Drawing.Color.LightYellow;
            }
        }

    }
}