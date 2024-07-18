using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachinConsoleApp1
{
    interface IPlayable
    {
        void Play(string a);
    }
        public class VideoPlayer : IPlayable
        {
            public void Play(string a)
            {
                Console.WriteLine($"Video Player:{a}");
            }
        }

        public class MusicPlayer : IPlayable
        {
            public void Play(string a)
            {
                Console.WriteLine($"Music Player:{a}");
            }
        }

       class InterfaceAssignment
    { 
            public static void Main()
            {
                VideoPlayer obj = new VideoPlayer();
                obj.Play("Playing Video....");

                MusicPlayer obj2 = new MusicPlayer();
                obj2.Play("Playing Music....");
            }

        
    }
}
