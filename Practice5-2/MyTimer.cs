using Timer = System.Windows.Forms.Timer;

namespace Practice5_2
{
    internal class MyTimer
    {
        private Timer timer;
        private int remain;
        private int elapsed;
        private Action<int, int>? action;

        public MyTimer(Timer timer, Action<int, int>? action)
        {
            this.timer = timer;
            this.action = action;
            timer.Tick += timer_Tick;
            timer.Interval = 1000;
            remain = 0;
            elapsed = 0;
        }

        public void StartCountDown(int seconds)
        {
            this.remain = seconds;
            timer.Enabled = true;
        }

        public void StartCounting()
        {
            elapsed = 0;
            timer.Enabled = true;
        }

        public void Stop()
        {
            timer.Enabled = false;
        }

        public int RemainSeconds()
        {
            return remain;
        }

        public int ElapsedSeconds()
        {
            return elapsed;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            remain--;
            elapsed++;
            if (action != null) action.Invoke(remain, elapsed);
        }
    }
}
