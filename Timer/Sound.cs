using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Sound
    {
        static SoundPlayer sound_TimerOver = new SoundPlayer(Properties.Resources.TimerOver);

        public static void Play_TimerOver()
        {
            sound_TimerOver.Play();
        }

        public static void Stop_TimerOver()
        {
            sound_TimerOver.Stop();
        }
    }
}
