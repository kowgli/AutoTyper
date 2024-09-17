using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTyper
{
    public partial class MainForm : Form
    {
        private bool isRunning = false;

        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbInfo.Text = "";
            this.Text = $"{this.Text} {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private async void bType_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            DisableInput(isRunning);

            if (isRunning)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                int waitSec = (int)nudInitialDelay.Value;

                while (true)
                {
                    if (!isRunning || stopwatch.Elapsed.TotalSeconds >= waitSec)
                    {
                        break;
                    }

                    lbInfo.Text = $"Starting in: {waitSec - (int)stopwatch.Elapsed.TotalSeconds}s";
                    await Task.Delay(100);
                }

                lbInfo.Text = "Typing...";

                foreach (char c in tbTypedText.Text)
                {
                    if (!isRunning) { break; }
                    SendKeys.SendWait(c.ToString());
                    await Task.Delay((int)nudTypingDelay.Value);
                }

                isRunning = false;
            }

            lbInfo.Text = "";
            DisableInput(isRunning);
        }

        private void DisableInput(bool disable)
        {
            tbTypedText.Enabled = !disable;
            nudInitialDelay.Enabled = !disable;
            nudTypingDelay.Enabled = !disable;

            bType.Text = disable ? "Cancel" : "Type";
        }

        private void bClearText_Click(object sender, EventArgs e)
        {
            tbTypedText.Text = "";
        }

        private void cbAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cbAlwaysOnTop.Checked;
        }
    }
}
