using Clock.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace Clock
{
    public partial class Clock : Form
    {
        int mode = 1;
        bool isfold = false;
        bool isbig = false;
        int smallwaittime = -1;
        bool isMouseDown = false;
        Point pointMouse = new Point();
        int downclass = 0;
        bool IsMinrun = false;
        bool Is40 = false;
        bool Is00use = false;

        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            this.Size = Time.Size;
            this.Opacity = 0;
            //this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width - 50, 50);
            this.Location = new Point(50, 50);
            if (Settings.Default.NewNum != 1)
            {
                notifyIcon.Visible = false;
                NewForm.Enabled = false;
                NewForm.Text = "Clones" + (Settings.Default.NewNum - 1);
                ExitApp.Text = "Close";
            }
            Time.Visible = false;
            fold.Visible = false;
            AboutButton.Visible = false;
            progressBar1.Visible = false;
            this.BackgroundImage = new Bitmap(Resources.clockload);
            Launch.Start();
        }

        private void run_Tick(object sender, EventArgs e)
        {
            //label1.Text = "欢迎使用时钟校园版";
            Rectangle rec = Screen.GetWorkingArea(this);
            int SH = rec.Height;
            int SW = rec.Width;
            string H;
            string M;
            string S;
            int tempT;
            if (DateTime.Now.Hour < 10) H = "0" + DateTime.Now.Hour.ToString();
            else H = DateTime.Now.Hour.ToString();
            if (DateTime.Now.Minute < 10) M = "0" + DateTime.Now.Minute.ToString();
            else M = DateTime.Now.Minute.ToString();
            if (DateTime.Now.Second < 10) S = "0" + DateTime.Now.Second.ToString();
            else S = DateTime.Now.Second.ToString();
            if (DateTime.Now.Hour == 7)
                if (DateTime.Now.Minute <= 35 & DateTime.Now.Minute >= 28)
                {
                    tempT = DateTime.Now.Minute - 1;
                    M = tempT.ToString();
                }
            if (mode == 1)
            {
                Time.Text = H + ":" + M + ":" + S;
            }
            if (mode == 2)
            {
                Time.Text = H + ":" + M;
            }
            if (isbig == false)
            {
                label1.Visible = true;
                AboutButton.Visible = true;
                if (isfold == false)
                {
                    this.Size = new Size(Time.Size.Width, Time.Size.Height + label1.Height);
                    fold.Image = Resources.时钟展开;
                    Time.Location = new Point(this.Width / 2 - Time.Width / 2, (this.Height - label1.Height) / 2 - Time.Height / 2);
                    if (smallwaittime != -1) smallwaittime += 1;
                    if (smallwaittime == 1)
                    {
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width - 50, 50);
                        smallwaittime = -1;
                    }
                    fold.Top = this.Height - fold.Height - label1.Height;
                }
                if (isfold == true)
                {
                    this.Size = new Size(this.Width, Time.Height + ExitApp.Height + button3.Height + label1.Height + fold.Height * 2 + 15);
                    fold.Image = Resources.时钟收起;
                    fold.Top = this.Height - fold.Height - 1;
                }
                if (Settings.Default.skin == 0)
                {
                    this.BackgroundImage = null;
                    Bitmap bitmap = Resources.草莓粉;
                    bitmap.Dispose();
                }
                if (Settings.Default.skin == 1)
                {
                    this.BackgroundImage = Resources.草莓粉;
                    Bitmap bitmap = Resources.炫酷坤;
                    bitmap.Dispose();
                }
                if (Settings.Default.skin == 2)
                {
                    this.BackgroundImage = Resources.炫酷坤;
                    Bitmap bitmap = Resources.草莓粉;
                    bitmap.Dispose();
                }
                fold.Visible = true;
            }
            else
            {
                label1.Visible = false;
                AboutButton.Visible = false;
                this.Size = new Size(SW, SH);
                Time.Location = new Point(this.Width / 2 - Time.Width / 2, this.Height / 2 - Time.Height / 2);
                fold.Visible = false;
                if (Settings.Default.skin == 0)
                {
                    this.BackgroundImage = null;
                    Bitmap bitmap = Resources.草莓粉;
                    bitmap.Dispose();
                }
                if (Settings.Default.skin == 1)
                {
                    this.BackgroundImage = Resources.草莓粉;
                    Bitmap bitmap = Resources.炫酷坤;
                    bitmap.Dispose();
                }
                if (Settings.Default.skin == 2)
                {
                    this.BackgroundImage = Resources.炫酷坤;
                    Bitmap bitmap = Resources.草莓粉;
                    bitmap.Dispose();
                }
                if (Settings.Default.skin == 0)
                {
                    this.BackColor = Color.Black;
                    Time.ForeColor = Color.White;
                }
                else
                {
                    Time.ForeColor = Color.Black;
                }
            }
            if (isMouseDown == false)
            {
                if (this.Right > SW) this.Left = SW - this.Width;
                if (this.Bottom > SH) this.Top = SH - this.Height;
                if (this.Location.Y < 0) this.Top = 0;
                if (this.Location.X < 0) this.Left = 0;
            }
            if (DateTime.Now.DayOfWeek != DayOfWeek.Sunday & DateTime.Now.DayOfWeek != DayOfWeek.Saturday)
            {
                if (H == "07" & M == "30") downclass = 25;//H:hour M:minute downclass:Duration in this class
                if (H == "08" & M == "00") downclass = 40;
                if (H == "08" & M == "50") downclass = 40;
                if (H == "09" & M == "40") downclass = 40;
                if (H == "10" & M == "40") downclass = 30;
                if (H == "11" & M == "20") downclass = 55;
                if (H == "14" & M == "00") downclass = 40;
                if (H == "14" & M == "50") downclass = 40;
                if (H == "15" & M == "00") downclass = 40;
                if (H == "15" & M == "40") downclass = 40;
                if (H == "16" & M == "30") downclass = 40;
                if (H == "18" & M == "00") downclass = 60;
                if (H == "19" & M == "10") downclass = 60;
                label1.Text = "Weekday schedule";
                progressBar1.Maximum = 740;//The minutes in your school per day.
                if (DateTime.Now.Hour * 60 + DateTime.Now.Minute - 470 >= 0 & DateTime.Now.Hour * 60 + DateTime.Now.Minute - 470 <= 740)//470 means:The minutes before you go to shcool from 0:00.
                {
                    progressBar1.Value = DateTime.Now.Hour * 60 + DateTime.Now.Minute - 470;
                }
                else progressBar1.Value = 0;
            }
            else
            {
                if (H == "07" & M == "30") downclass = 40;
                if (H == "08" & M == "20") downclass = 40;
                if (H == "09" & M == "10") downclass = 40;
                if (H == "10" & M == "10") downclass = 40;
                if (H == "11" & M == "00") downclass = 40;
                if (H == "14" & M == "00") downclass = 30;
                if (H == "14" & M == "50") downclass = 40;
                if (H == "15" & M == "40") downclass = 40;
                if (H == "16" & M == "30") downclass = 40;
                if (H == "17" & M == "40") downclass = 40;
                if (H == "18" & M == "30") downclass = 40;
                progressBar1.Maximum = 680;
                label1.Text = "Weekend schedule";
                if (DateTime.Now.Hour * 60 + DateTime.Now.Minute - 470 >= 0 & DateTime.Now.Hour * 60 + DateTime.Now.Minute - 470 <= 680)
                {
                    progressBar1.Value = DateTime.Now.Hour * 60 + DateTime.Now.Minute - 470;
                }
                else progressBar1.Value = 0;
            }
            if (downclass > 0)
            {
                label1.Text = "There's" + downclass + "minute(s) left until class ends.";
                if (!isMouseDown) this.Opacity = 0.7;
                Is40 = true;
            }
            else
            {
                if (!isMouseDown & !isbig) this.Opacity = 1;
            }
            if (IsMinrun == true)
            {
                if (downclass == 0)
                {
                    label1.Text = "Class is over.";
                }
            }
            if (DateTime.Now.Second == 0) if (Is40 == true)
                {
                    if (Is00use == false)
                    {
                        downclass -= 1;
                        IsMinrun = true;
                        this.TopMost = false;
                        this.TopMost = true;
                        if (isbig) this.TopMost = false;
                        Is00use = true;
                    }
                    //Min1.Start();
                }
            if (downclass < 0)
            {
                label1.Text = "Class just ended" + (-downclass) + "minute(s) ago.";
            }
            if (DateTime.Now.Second == 2)
            {
                Is00use = false;
            }
            int R = 10;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(this.Width - R, this.Height - R, R, R, 0, 90);
            path.AddArc(0, this.Height - R, R, R, 90, 90);
            path.AddArc(0, 0, R, R, 180, 90);
            path.AddArc(this.Width - R, 0, R, R, 270, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
            fold.Left = this.Width / 2 - fold.Width / 2;
            button3.Width = (this.Width - 36) / 2;
            NewForm.Width = this.Width - 24;
            ExitApp.Width = button3.Width;
            button3.Left = 12;
            NewForm.Left = 12;
            ExitApp.Left = button3.Right + 12;
            label1.Left = this.Width / 2 - label1.Width / 2;
            AboutButton.Left = this.Width / 2 - AboutButton.Width / 2;
            AboutButton.Top = Time.Bottom - AboutButton.Height;
            progressBar1.Width = this.Width;
            if (Settings.Default.NewNum >= 6) Settings.Default.skin = 0;
        }

        private void Time_MouseDown(object sender, MouseEventArgs e)
        {
            if (isbig == false)
            {
                pointMouse = e.Location;
                isMouseDown = true;
                this.Opacity = 0.5;
            }
        }

        private void Time_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point location = this.PointToScreen(e.Location);
                location.Offset(-pointMouse.X, -pointMouse.Y);
                this.Location = location;
                isfold = false;
            }
        }

        private void Time_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Clock_MouseDown(object sender, MouseEventArgs e)
        {
            if (isbig == false)
            {
                pointMouse = e.Location;
                isMouseDown = true;
                this.Opacity = 0.5;
            }
        }

        private void Clock_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point location = this.PointToScreen(e.Location);
                location.Offset(-pointMouse.X, -pointMouse.Y);
                this.Location = location;
                isfold = false;
            }
        }

        private void Clock_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Time_DoubleClick(object sender, EventArgs e)
        {
            mode += 1;
            if (mode == 3) mode = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Time.Font = new Font(Time.Font.FontFamily, 36, FontStyle.Bold);
            this.TopMost = true;
            this.BackColor = Color.White;
            Time.ForeColor = Color.Black;
            button1.Visible = false;
            NewForm.Visible = true;
            isbig = false;
            button3.Visible = true;
            ExitApp.Visible = true;
            smallwaittime = 0;
            this.Opacity = 1;
        }

        private void fold_Click(object sender, EventArgs e)
        {
            if (isfold == false)
            {
                isfold = true;
            }
            else
            {
                isfold = false;
            }
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isfold = false;
            this.Size = Time.Size;
            if (isbig == false)
            {
                this.Opacity = 0.8;
                Time.Font = new Font(Time.Font.FontFamily, 200, FontStyle.Bold);
                Rectangle rec = Screen.GetWorkingArea(this);
                int SH = rec.Height;
                int SW = rec.Width;
                this.Size = new Size(SW, SH);
                this.TopMost = false;
                button1.Visible = true;
                button3.Visible = false;
                ExitApp.Visible = false;
                NewForm.Visible = false;
                button1.Left = this.Width / 2 - button1.Width / 2;
                isbig = true;
            }
        }

        private void NewForm_Click(object sender, EventArgs e)
        {
            Settings.Default.NewNum += 1;
            new Clock().Show();
        }

        private void AboutButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isfold = false;
            MessageBox.Show("JJClock-Schedule_Version V4.1.9" +
                "\r\n\r\nBy JJCC   Official Website：jjcc.wz.hwdlszywz.net  \r\nThanks for using this software.You can get the code on Github.", "JJClock-Schedule_Version  About");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 展开菜单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isfold = true;
        }

        private void 搪瓷白ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.skin = 0;
        }

        private void 草莓粉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.NewNum < 6) Settings.Default.skin = 1;
        }

        private void 炫酷坤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.NewNum < 6) Settings.Default.skin = 2;
        }

        private void Clock_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F4) && (e.Alt == true))
            {
                e.Handled = true;
            }
        }

        private void Min1_Tick(object sender, EventArgs e)
        {
            //downclass -= 1;
        }

        private void Launch_Tick(object sender, EventArgs e)
        {
            if (this.Left < Screen.PrimaryScreen.Bounds.Width - this.Width - 50)
            {
                this.Left += 20;
                this.Opacity += 0.01;
                if (Settings.Default.NewNum > 1)
                {
                    this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width - 50 * Settings.Default.NewNum, 50 * Settings.Default.NewNum);
                    run.Start();
                    Launch.Stop();
                    Time.Visible = true;
                    fold.Visible = true;
                    AboutButton.Visible = true;
                    progressBar1.Visible = true;
                    this.BackgroundImage = null;
                }
            }
            else
            {
                Thread.Sleep(1000);
                run.Start();
                Launch.Stop();
                Time.Visible = true;
                fold.Visible = true;
                AboutButton.Visible = true;
                progressBar1.Visible = true;
                this.BackgroundImage = null;
            }
        }
    }
}
