using System;
using System.IO;
using System.Media;
using System.Linq;
using System.Text;

namespace CyberSecurityBot
{
    internal class Utils
    {
        public  void PlayGreeting()
        {
            try
            {
                string filepath  = @"C:\\Users\\lab_services_student\\Desktop\\CyberSecurityBot\\Audio\\Greetings.wav";
                Console.WriteLine("\n🎵 Playing greeting...");

                /*if (!File.Exists(path))
                {
                    Console.WriteLine($"❌ Audio file not found at: {path}");
                    return;
                }*/

                using (SoundPlayer player = new SoundPlayer(filepath))
                {
                    
                    player.PlaySync(); // Play and wait for it to finish
                }

                Console.WriteLine("✅ Audio playback finished.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error playing audio: {ex.Message}");
            }
        }
    }
}