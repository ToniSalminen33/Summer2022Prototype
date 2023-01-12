using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProactivityPrototype
{
    public partial class Form1 : Form
    {
        public string[] maList = new string[3];
        public string[] tiList = new string[3];
        public string[] keList = new string[3];
        public string[] toList = new string[3];
        public string[] peList = new string[3];
        public string[] laList = new string[3];
        public string[] suList = new string[3];
        public string todayIs;
        public Form1()
        {

            InitializeComponent();
            DayOfWeek Day = DateTime.Now.DayOfWeek;
            string dayName = Day.ToString();
            string shortDay = dayName.Remove(3);
            int Days = Day - DayOfWeek.Monday;
            DateTime WeekStartDate = DateTime.Now.AddDays(-Days);
            MondayButton.Text = "Ma\n" + WeekStartDate;
            TuesdayButton.Text = "Ti\n" + WeekStartDate.AddDays(1);
            WednesdayButton.Text = "Ke\n" + WeekStartDate.AddDays(2);
            ThursdayButton.Text = "To\n" + WeekStartDate.AddDays(3);
            FridayButton.Text = "Pe\n" + WeekStartDate.AddDays(4);
            SaturdayButton.Text = "La\n" + WeekStartDate.AddDays(5);
            SundayButton.Text = "Su\n" + WeekStartDate.AddDays(6);
            string fileDaily = @"C:\Users\Tommen\source\repos\ProactivityPrototype_App\ProactivityPrototype\Lists\DailyList.txt";
            string fileWeekly = @"C:\Users\Tommen\source\repos\ProactivityPrototype_App\ProactivityPrototype\Lists\WeeklyList.txt";
            string path = @"C:\Users\Tommen\source\repos\ProactivityPrototype_App\ProactivityPrototype\Lists\";
            string resultDaily;
            string resultWeekly;
            resultDaily = File.ReadAllText(Path.GetFileName(fileDaily));
            resultWeekly = File.ReadAllText(Path.GetFileName(fileWeekly));
            string[] dataDaily = resultDaily.Split(';');
            string[] dataWeekly = resultWeekly.Split(';');
            Random randomInt = new Random();
            int num = randomInt.Next(dataDaily.Length);
            bool correct = false;
            while (!correct)
            {
                ListSorter(maList, dataDaily, num, randomInt);
                    if (maList[0] != maList[1] && maList[1] != maList[2] && maList[2] != maList[0])
                    {
                        correct = true;
                    }
            }
            correct = false;
            while (!correct)
            {
                ListSorter(tiList, dataDaily, num, randomInt);
                if (tiList[0] != tiList[1] && tiList[1] != tiList[2] && tiList[2] != tiList[0])
                {
                    correct = true;
                }
            }
            correct = false;
            while (!correct)
            {
                ListSorter(keList, dataDaily, num, randomInt);
                if (keList[0] != keList[1] && keList[1] != keList[2] && keList[2] != keList[0])
                {
                    correct = true;
                }
            }
            correct = false;
            while (!correct)
            {
                ListSorter(toList, dataDaily, num, randomInt);
                if (toList[0] != toList[1] && toList[1] != toList[2] && toList[2] != toList[0])
                {
                    correct = true;
                }
            }
            correct = false;
            while (!correct)
            {
                ListSorter(peList, dataDaily, num, randomInt);
                if (peList[0] != peList[1] && peList[1] != peList[2] && peList[2] != peList[0])
                {
                    correct = true;
                }
            }
            correct = false;
            while (!correct)
            {
                ListSorter(laList, dataDaily, num, randomInt);
                if (laList[0] != laList[1] && laList[1] != laList[2] && laList[2] != laList[0])
                {
                    correct = true;
                }
            }
            correct = false;
            while (!correct)
            {
                ListSorter(suList, dataDaily, num, randomInt);
                if (suList[0] != suList[1] && suList[1] != suList[2] && suList[2] != suList[0])
                {
                    correct = true;
                }
            }
            num = randomInt.Next(dataWeekly.Length);
            WeeklyActivity1.Text = dataWeekly[num];
            ListWriter();
            CheckDay(Day, todayIs);
            //num = randomInt.Next(data.Length);
            //if (DailyActivity1.Text == "" && DailyActivity2.Text == "" && DailyActivity3.Text == "")
            //{
            //    randomInt = new Random();
            //    num = randomInt.Next(data.Length);
            //    DailyActivity1.Text = data[num];
            //    num = randomInt.Next(data.Length);
            //    DailyActivity2.Text = data[num];
            //    num = randomInt.Next(data.Length);
            //    DailyActivity3.Text = data[num];
            //}
            //if (DailyActivity1.Text == DailyActivity2.Text || DailyActivity2.Text == DailyActivity3.Text || DailyActivity3.Text == DailyActivity1.Text)
            //{

            //    randomInt = new Random();
            //    num = randomInt.Next(data.Length);
            //    DailyActivity1.Text = data[num];
            //    num = randomInt.Next(data.Length);
            //    DailyActivity2.Text = data[num];
            //    num = randomInt.Next(data.Length);
            //    DailyActivity3.Text = data[num];

            //}
        }

        public void ListSorter(string[] list, string[] content, int rndNum, Random rndGen){
            int k = 0;
            foreach (string s in list)
            {
                rndNum = rndGen.Next(content.Length);
                list[k] = content[rndNum];
                k++;
            }
        }

        public void ListWriter()
        {
            MonActivity1.Text = maList[0];
            MonActivity2.Text = maList[1];
            MonActivity3.Text = maList[2];
            TueActivity1.Text = tiList[0];
            TueActivity2.Text = tiList[1];
            TueActivity3.Text = tiList[2];
            WedActivity1.Text = keList[0];
            WedActivity2.Text = keList[1];
            WedActivity3.Text = keList[2]; 
            ThuActivity1.Text = toList[0];
            ThuActivity2.Text = toList[1];
            ThuActivity3.Text = toList[2];
            FriActivity1.Text = peList[0];
            FriActivity2.Text = peList[1];
            FriActivity3.Text = peList[2];
            SatActivity1.Text = laList[0];
            SatActivity2.Text = laList[1];
            SatActivity3.Text = laList[2];
            SunActivity1.Text = suList[0];
            SunActivity2.Text = suList[1];
            SunActivity3.Text = suList[2];
        }

        public void CheckDay(DayOfWeek today, string day)
        {
            if (today.ToString().StartsWith("Mon"))
            { 
                MonActivity1.Visible = true;
                MonActivity2.Visible = true;
                MonActivity3.Visible = true;
                MonCheck1.Visible = true;
                MonCheck2.Visible = true;
                MonCheck3.Visible = true;
                ButtonColorReset();
                MondayButton.BackColor = Color.DarkGray;
            }
            if (today.ToString().StartsWith("Tue"))
            {
                TueActivity1.Visible = true;
                TueActivity2.Visible = true;
                TueActivity3.Visible = true;
                TueCheck1.Visible = true;
                TueCheck2.Visible = true;
                TueCheck3.Visible = true;
                ButtonColorReset();
                TuesdayButton.BackColor = Color.DarkGray;
            }
            if (today.ToString().StartsWith("Wed"))
            {
                WedActivity1.Visible = true;
                WedActivity2.Visible = true;
                WedActivity3.Visible = true;
                WedCheck1.Visible = true;
                WedCheck2.Visible = true;
                WedCheck3.Visible = true;
                ButtonColorReset();
                WednesdayButton.BackColor = Color.DarkGray;
            }
            if (today.ToString().StartsWith("Thu"))
            {
                ThuActivity1.Visible = true;
                ThuActivity2.Visible = true;
                ThuCheck1.Visible = true;
                ThuCheck2.Visible = true;
                ThuCheck3.Visible = true;
                ThuActivity3.Visible = true;
                ButtonColorReset();
                ThursdayButton.BackColor = Color.DarkGray;
            }
            if (today.ToString().StartsWith("Fri"))
            {
                FriActivity1.Visible = true;
                FriActivity2.Visible = true;
                FriActivity3.Visible = true;
                FriCheck1.Visible = true;
                FriCheck2.Visible = true;
                FriCheck3.Visible = true;
                ButtonColorReset();
                FridayButton.BackColor = Color.DarkGray;
            }
            if (today.ToString().StartsWith("Sat"))
            {
                SatActivity1.Visible = true;
                SatActivity2.Visible = true;
                SatActivity3.Visible = true;
                SatCheck1.Visible = true;
                SatCheck2.Visible = true;
                SatCheck3.Visible = true;
                ButtonColorReset();
                SaturdayButton.BackColor = Color.DarkGray;
            }
            if (today.ToString().StartsWith("Sun"))
            {
                SunActivity1.Visible = true;
                SunActivity2.Visible = true;
                SunActivity3.Visible = true;
                SunCheck1.Visible = true;
                SunCheck2.Visible = true;
                SunCheck3.Visible = true;
                ButtonColorReset();
                SundayButton.BackColor = Color.DarkGray;
            }
        }

        public void ButtonColorReset()
        {
            MondayButton.BackColor = Color.LightGray;
            TuesdayButton.BackColor = Color.LightGray;
            WednesdayButton.BackColor = Color.LightGray;
            ThursdayButton.BackColor = Color.LightGray;
            FridayButton.BackColor = Color.LightGray;
            SaturdayButton.BackColor = Color.LightGray;
            SundayButton.BackColor = Color.LightGray;
        }

        public void CheckHider ()
        {
            MonCheck1.Visible = false;
            MonCheck2.Visible = false;
            MonCheck3.Visible = false;
            TueCheck1.Visible = false;
            TueCheck2.Visible = false;
            TueCheck3.Visible = false;
            WedCheck1.Visible = false;
            WedCheck2.Visible = false;
            WedCheck3.Visible = false;
            ThuCheck1.Visible = false;
            ThuCheck2.Visible = false;
            ThuCheck3.Visible = false;
            FriCheck1.Visible = false;
            FriCheck2.Visible = false;
            FriCheck3.Visible = false;
            SatCheck1.Visible = false;
            SatCheck2.Visible = false;
            SatCheck3.Visible = false;
            SunCheck1.Visible = false;
            SunCheck2.Visible = false;
            SunCheck3.Visible = false;
        }

        public void ActivityHider()
        {
            MonActivity1.Visible = false;
            MonActivity2.Visible = false;
            MonActivity3.Visible = false;
            TueActivity1.Visible = false;
            TueActivity2.Visible = false;
            TueActivity3.Visible = false;
            WedActivity1.Visible = false;
            WedActivity2.Visible = false;
            WedActivity3.Visible = false;
            ThuActivity1.Visible = false;
            ThuActivity2.Visible = false;
            ThuActivity3.Visible = false;
            FriActivity1.Visible = false;
            FriActivity2.Visible = false;
            FriActivity3.Visible = false;
            SatActivity1.Visible = false;
            SatActivity2.Visible = false;
            SatActivity3.Visible = false;
            SunActivity1.Visible = false;
            SunActivity2.Visible = false;
            SunActivity3.Visible = false;
        }

        public void MondayButton_Click(object sender, EventArgs e)
        {
            ActivityHider();
            MonActivity1.Visible = true;
            MonActivity2.Visible=true;
            MonActivity3.Visible=true;
            ButtonColorReset();
            MondayButton.BackColor = Color.DarkGray;
            CheckHider();
            MonCheck1.Visible = true;
            MonCheck2.Visible = true;
            MonCheck3.Visible = true;
        }



        private void TuesdayButton_Click(object sender, EventArgs e)
        {
            ActivityHider();
            TueActivity1.Visible = true;
            TueActivity2.Visible = true;
            TueActivity3.Visible = true;
            ButtonColorReset();
            TuesdayButton.BackColor = Color.DarkGray;
            CheckHider();
            TueCheck1.Visible = true;
            TueCheck2.Visible = true;
            TueCheck3.Visible = true;
        }

        private void WednesdayButton_Click(object sender, EventArgs e)
        {
            ActivityHider();
            WedActivity1.Visible = true;
            WedActivity2.Visible = true;
            WedActivity3.Visible = true;
            ButtonColorReset();
            WednesdayButton.BackColor = Color.DarkGray;
            CheckHider();
            WedCheck1.Visible = true;
            WedCheck2.Visible = true;
            WedCheck3.Visible = true;
        }

        private void ThursdayButton_Click(object sender, EventArgs e)
        {
            ActivityHider();
            ThuActivity1.Visible = true;
            ThuActivity2.Visible = true;
            ThuActivity3.Visible = true;
            ButtonColorReset();
            ThursdayButton.BackColor = Color.DarkGray;
            CheckHider();
            ThuCheck1.Visible = true;
            ThuCheck2.Visible = true;
            ThuCheck3.Visible = true;
        }

        private void FridayButton_Click(object sender, EventArgs e)
        {
            ActivityHider();
            FriActivity1.Visible = true;
            FriActivity2.Visible = true;
            FriActivity3.Visible = true;
            ButtonColorReset();
            FridayButton.BackColor = Color.DarkGray;
            CheckHider();
            FriCheck1.Visible = true;
            FriCheck2.Visible = true;
            FriCheck3.Visible = true;
        }

        private void SaturdayButton_Click(object sender, EventArgs e)
        {
            ActivityHider();
            SatActivity1.Visible = true;
            SatActivity2.Visible = true;
            SatActivity3.Visible = true;
            ButtonColorReset();
            SaturdayButton.BackColor = Color.DarkGray;
            CheckHider();
            SatCheck1.Visible = true;
            SatCheck2.Visible = true;
            SatCheck3.Visible = true;
        }

        private void SundayButton_Click(object sender, EventArgs e)
        {
            ActivityHider();
            SunActivity1.Visible = true;
            SunActivity2.Visible = true;
            SunActivity3.Visible = true;
            ButtonColorReset();
            SundayButton.BackColor = Color.DarkGray;
            CheckHider();
            SunCheck1.Visible = true;
            SunCheck2.Visible = true;
            SunCheck3.Visible = true;
        }

        private void MonCheck1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + MonActivity1.Text+" ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                MonCheck1.BackColor = Color.Green;
            }
        }

        private void MonCheck2_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + MonActivity2.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                MonCheck2.BackColor = Color.Green;
            }
        }

        private void MonCheck3_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + MonActivity3.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                MonCheck3.BackColor = Color.Green;
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (MenuBackground.Enabled == false)
            {
                MenuBackground.Enabled = true;
                MenuBackground.Visible = true;
                UserAccount.Visible = true;
                Settings.Visible = true;
            }
            else
            {
                MenuBackground.Enabled = false;
                MenuBackground.Visible = false;
                UserAccount.Visible=false;
                Settings.Visible = false;
            }
        }

        private void TueCheck1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + TueActivity1.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                TueCheck1.BackColor = Color.Green;
            }
        }

        private void TueCheck2_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + TueActivity2.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                TueCheck2.BackColor = Color.Green;
            }
        }

        private void TueCheck3_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + TueActivity3.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                TueCheck3.BackColor = Color.Green;
            }
        }

        private void WedCheck1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + WedActivity1.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                WedCheck1.BackColor = Color.Green;
            }
        }

        private void WedCheck2_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + WedActivity2.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                WedCheck2.BackColor = Color.Green;
            }
        }

        private void WedCheck3_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + WedActivity3.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                WedCheck3.BackColor = Color.Green;
            }
        }

        private void ThuCheck1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + ThuActivity1.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                ThuCheck1.BackColor = Color.Green;
            }
        }

        private void ThuCheck2_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + ThuActivity2.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                ThuCheck2.BackColor = Color.Green;
            }
        }

        private void ThuCheck3_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + ThuActivity3.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                ThuCheck3.BackColor = Color.Green;
            }
        }

        private void FriCheck1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + FriActivity1.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                FriCheck1.BackColor = Color.Green;
            }
        }

        private void FriCheck2_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + FriActivity2.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                FriCheck2.BackColor = Color.Green;
            }
        }

        private void FriCheck3_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + FriActivity3.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                FriCheck3.BackColor = Color.Green;
            }
        }

        private void SatCheck1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + SatActivity1.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                SatCheck1.BackColor = Color.Green;
            }
        }

        private void SatCheck2_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + SatActivity2.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                SatCheck2.BackColor = Color.Green;
            }
        }

        private void SatCheck3_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + SatActivity3.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                SatCheck3.BackColor = Color.Green;
            }
        }

        private void SunCheck1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + SunActivity1.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                SunCheck1.BackColor = Color.Green;
            }
        }

        private void SunCheck2_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + SunActivity2.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                SunCheck2.BackColor = Color.Green;
            }
        }

        private void SunCheck3_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + SunActivity3.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                SunCheck3.BackColor = Color.Green;
            }
        }

        public class OwnActivityModel : System.Windows.Forms.Button
        {
            public string Activity { get; set; }
            public Button ActivityButton { get; set; }
            public Button CheckButton { get; set; }
        }

        private void AddOwnActivity_Click(object sender, EventArgs e)
        {
            AddActivityPanel.Visible = true;
            AddActivityLabel.Visible = true;
            AddActivityConfirmButton.Visible = true;
            AddActivityCancelButton.Visible = true;
            AddActivityTextbox.Visible = true;
            AddActivityTextbox.Clear();
        }

        private void AddActivityConfirmButton_Click(object sender, EventArgs e)
        {
            OwnActivity1.Text = AddActivityTextbox.Text;
            AddActivityPanel.Visible = false;
            AddActivityLabel.Visible = false;
            AddActivityConfirmButton.Visible = false;
            AddActivityCancelButton.Visible = false;
            AddActivityTextbox.Visible = false;
            OwnActivity1.Visible = true;
            OwnActivityCheck.Visible = true;
            PresetActivityPanel.Location = new Point(PresetActivityPanel.Location.X, PresetActivityPanel.Location.Y+40);
            AddOwnActivity.Location = new Point(AddOwnActivity.Location.X, AddOwnActivity.Location.Y+40);
        }

        private void AddActivityCancelButton_Click(object sender, EventArgs e)
        {
            AddActivityPanel.Visible = false;
            AddActivityLabel.Visible = false;
            AddActivityConfirmButton.Visible = false;
            AddActivityCancelButton.Visible = false;
            AddActivityTextbox.Visible = false;
            AddActivityTextbox.Clear();
        }

        private void OwnActivityCheck_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + OwnActivity1.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                OwnActivityCheck.BackColor = Color.Green;
            }
        }

        private void WeeklyCheck1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Oletko suorittanut aktiviteetin " + WeeklyActivity1.Text + " ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                WeeklyCheck1.BackColor = Color.Green;
            }
        }
    }
}
