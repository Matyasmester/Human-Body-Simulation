using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Body_Simulation_GUI
{
    public partial class MainForm : Form
    {
        Brain brain = new Brain(true, true, true);

        public delegate void TimerCallbackFunction(int param);

        public MainForm()
        {
            InitializeComponent();
            TimerCallbackFunction updateTimerFunction = (count) =>
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    timerBox.Text = count.ToString();
                });
            };
            brain.StartTimer(updateTimerFunction);
            
        }

        private void WriteToBoxes()
        {
            HasEatenBox.Text = brain.isHungry().ToString();
            HasDrunkBox.Text = brain.isThirsty().ToString();
            isFunctionalBox.Text = brain.isOrganFunctional().ToString();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TimerBox_TextChanged(object sender, EventArgs e)
        {
            WriteToBoxes();
        }

        private void EatButton_Click(object sender, EventArgs e)
        {
            brain.Eat();
        }

        private void DrinkButton_Click(object sender, EventArgs e)
        {
            brain.Drink();
        }

        private void HasDrunkBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HasEatenBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SetHungryButton_Click(object sender, EventArgs e)
        {
            brain.setHungry();
        }

        private void SetThirstyButton_Click(object sender, EventArgs e)
        {
            brain.setThirsty();
        }

        private void OrganFailureButton_Click(object sender, EventArgs e)
        {
            brain.setOrganFailure();
            GeneralStatusBox.Text = brain.setOrganFailure();
        }

        private void IsFunctionalBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
