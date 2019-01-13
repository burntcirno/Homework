﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock {

    /// <summary>
    /// the time obj
    /// </summary>
    class MyTime {

        private int hour; 
        
        private int minute; 
       
        private int second; 
        
        /// <summary>
        /// constuctor
        /// </summary>
        public MyTime(int hour = 0, int minute = 0, int second = 0) {
            Hour = hour;
            Minute = minute;
            Second = second;
        }



        /// <summary>
        /// hour : 0-23
        /// </summary>
        public int Hour {
            get { return hour; }
            set {
                if(value >= 0 && value < 24) {
                    hour = value;
                } else {
                    throw new ArgumentOutOfRangeException("hour invalid!");
                }
            }
        }

        /// <summary>
        /// minute 0-59
        /// </summary>
        public int Minute {
            get { return minute; }
            set {
                if (value >= 0 && value < 60) {
                    minute = value;
                } else {
                    throw new ArgumentOutOfRangeException("minute invalid!");
                }
            }
        }

        /// <summary>
        /// second 0-59
        /// </summary>
        public int Second {
            get { return second; }
            set {
                if (value >= 0 && value < 60) {
                    second = value;
                } else {
                    throw new ArgumentOutOfRangeException("second invalid!");
                }
            }
        }
        /// <summary>
        /// mytime identifier : calculate by hour,minute and second
        /// </summary>
        public int Id {
            get { return hour * 10000 + minute * 100 + second; }
        }

        public override bool Equals(object obj)
        {
            var time = obj as MyTime;
            return time != null &&
                   Hour == time.Hour &&
                   Minute == time.Minute &&
                   Second == time.Second;
        }

        public override int GetHashCode()
        {
            var hashCode = 1505761165;
            hashCode = hashCode * -1521134295 + Hour.GetHashCode();
            hashCode = hashCode * -1521134295 + Minute.GetHashCode();
            hashCode = hashCode * -1521134295 + Second.GetHashCode();
            return hashCode;
        }
    }
}
