using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using NAudio.CoreAudioApi;

namespace balance
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer();
        MMDeviceEnumerator a = new MMDeviceEnumerator();
        bool isThereALesson;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Processsss();
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 1000;
            timer.Enabled = true;
        }

        private void OnElapsedTime(object source,ElapsedEventArgs e)
        {
            Processsss();
        }

        protected override void OnStop()
        {
            Processsss();
        }

        public void Processsss()
        {
            var device = a.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            int theTime = Int32.Parse((DateTime.Now.TimeOfDay.Hours.ToString() + DateTime.Now.TimeOfDay.Minutes.ToString()));

            if (820<= theTime && theTime < 940)
            {
                isThereALesson = true;
            }
            else if (1000 <= theTime && theTime < 1120)
            {
                isThereALesson = true;
            }
            else if (1130 <= theTime && theTime < 1210)
            {
                isThereALesson = true;
            }
            else if (1310 <= theTime && theTime < 1350)
            {
                isThereALesson = true;
            }
            else if (1400 <= theTime && theTime < 1440)
            {
                isThereALesson = true;
            }
            else if (1450 <= theTime && theTime < 1800)
            {
                isThereALesson = true;
            }
            else
            {
                isThereALesson = false;
            }

            if (device.AudioEndpointVolume.MasterVolumeLevelScalar != 0 && !isThereALesson)
            {
                device.AudioEndpointVolume.MasterVolumeLevelScalar = 0f;
            }
        }
    }
}
