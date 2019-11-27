using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static Human_Body_Simulation_GUI.MainForm;

namespace Human_Body_Simulation_GUI
{
    class Brain : Organ     //The 'main' class
    {
        public static Timer counter;

        protected static int minuteCount;

        private bool hasEaten, hasDrunk;

        public Brain(bool hasEaten, bool hasDrunk, bool isFunctional)
        {
            this.hasEaten = hasEaten;
            this.hasDrunk = hasDrunk;
            this.isFunctional = isFunctional;
        }

        public void Eat()
        {
            this.hasEaten = true;
        }

        public void Drink()
        {
            this.hasDrunk = true;
        }

        public void DrinkAlcohol()
        {
            this.hasDrunk = true;
            this.quality -= 1;
        }

        public bool isHungry()
        {
            return this.hasEaten;
        }

        public void setHungry()
        {
            this.hasEaten = false;
        }

        public bool isThirsty()
        {
            return this.hasDrunk;
        }

        public void setThirsty()
        {
            this.hasDrunk = false;
        }

        public override string setOrganFailure()
        {
            return base.setOrganFailure();
        }

        public void StartTimer(TimerCallbackFunction timerCallback)
        {
            counter = new Timer(1000)
            {
                AutoReset = true,
                Enabled = true,
            };
            counter.Elapsed += OnTimedEvent;
            counter.Elapsed += (o,e) =>
            {
               timerCallback(minuteCount);
            };
        }

        public int getMinuteCount()
        {
            return minuteCount;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            minuteCount++;
        }
    }
}
