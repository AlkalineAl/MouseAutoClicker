using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MouseAutoClicker
{
    class Coordinate : INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Координата Х.
        /// </summary>
        private double xCoord;
        /// <summary>
        /// Координата У.
        /// </summary>
        private double yCoord;
        /*
        /// <summary>
        /// Интервал нажатий.
        /// </summary>
        private int interval;
        /// <summary>
        /// Количество нажатий до остановки.
        /// </summary>
        private int clickAmount;
        /// <summary>
        /// Счетчик нажатий.
        /// </summary>
        private int clickStatus;
        /// <summary>
        /// Таймер остановки в минутах.
        /// </summary>
        private int timer;
        /// <summary>
        /// Статус таймера.
        /// </summary>
        private int timerStatus;
        /// <summary>
        /// Выбор кнопки мыши
        /// </summary>
        private bool mouseStatus;*/

        public double XCoord { get => xCoord; set { xCoord = value; OnPropertyChanged("XCoord"); } }
        public double YCoord { get => yCoord; set { yCoord = value; OnPropertyChanged("YCoord"); } }
        /*
        public int Interval { get => interval; set { interval = value; OnPropertyChanged("Interval"); } }
        public int ClickAmount { get => clickAmount; set { clickAmount = value; OnPropertyChanged("ClickAmount"); } }
        public int ClickStatus { get => clickStatus; set { clickStatus = value; OnPropertyChanged("ClickStatus"); } }
        public int Timer { get => timer; set { timer = value; OnPropertyChanged("Timer"); } }
        public int TimerStatus { get => timerStatus; set { timerStatus = value; OnPropertyChanged("TimerStatus"); } }
        public bool MouseStatus { get => mouseStatus; set { mouseStatus = value; OnPropertyChanged("TimerStatus"); } }
        */

        /// <summary>
        /// OnPropertyChanged
        /// </summary>
        /// <param name="prop"></param>
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
