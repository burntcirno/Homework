using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock {

    /// <summary>
    /// event publisher:Clock class
    /// </summary> 
    class MyClock {
        
        private MyTime currentTime;

        // Keys are Id of the time when clock begins alarming
        // Values are the alarm time continuing
        private List<MyTime> alarmTimes=new List<MyTime>();

        /// <summary>
        /// delegate for time operation
        /// </summary>
        /// <param name="time"></param>
        /// <param name="seconds"></param>
        public delegate void AlarmEventHandler(MyTime time, int seconds);

        /// <summary>
        /// alarm event
        /// </summary>
        public event AlarmEventHandler AlarmEvent;

        /// <summary>
        /// constuctor
        /// </summary>
        public MyClock() {
            currentTime = new MyTime();
        }

        /// <summary>
        /// current time
        /// </summary>
        public MyTime CurrentTime {
            get { return currentTime; }
        }

        /// <summary>
        /// add alarm time into clock
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <param name="second"></param>
        /// <param name="secContinue"></param> 
        public void AddAlarmTime(MyTime time) {
            if (!alarmTimes.Contains(time)) 
                alarmTimes.Add(time);
        }

        /// /// <summary>
        /// remove alarm time from clock 
        /// </summary>
        public void RemoveAlarmTime(MyTime time) {
            if (alarmTimes.Contains(time))
                alarmTimes.Remove(time);
        }

        /// <summary>
        /// clock is running after call this function
        /// </summary>
        public void Run() {
            while (true) {
                DateTime now = DateTime.Now;
                currentTime = new MyTime(now.Hour, now.Minute, now.Second);
                if (alarmTimes.Contains(currentTime))
                    AlarmEvent(currentTime, 10);
                Thread.Sleep(1000);
            }
        }
    }
}
