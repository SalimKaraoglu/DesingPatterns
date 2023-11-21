using TheChainOfResponsibility.Abstract;
using TheChainOfResponsibility.Concrate;

namespace TheChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zincirin Halkalarını Tanımlar
            PlayerHandler aviPlayer = new HandlerAVI();
            PlayerHandler mp3Player = new HandlerMP3();
            PlayerHandler mp4Player = new HandlerMP4();

            //Zinciri Oluşturuyoruz
            mp3Player.NextHandler =  mp4Player;
            mp4Player.NextHandler =  aviPlayer;

            //Request zincirinin ilk halkasına gönderiyorsunuz
            mp3Player.Player("video.mp4");
            mp3Player.Player("video.avi");
            mp3Player.Player("video.mp3");
            mp3Player.Player("video.mpg");
        }
    }
}