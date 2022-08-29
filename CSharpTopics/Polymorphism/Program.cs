using System;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            var choice = Console.ReadLine();
            ThumbnailerBase thumbnailer = CreateThumnailer(choice);

            //thumbnailer.GetMetaData();
            thumbnailer.GetThumbnail();

            Console.ReadLine();
        }

        private static ThumbnailerBase CreateThumnailer(string choice)
        {
            switch (choice.ToLower())
            {
                case "i":
                    return new ThumbnailerImage();
                case "v":
                    return new ThumbnailerVideo();
                case "a":
                    return new ThumbailerAudio();
                default:
                    throw new Exception("Your choice is invalid");
            }
        }
    }

    abstract class ThumbnailerBase
    {
        protected abstract void GetMetaData();

        public virtual void GetThumbnail()
        {
            GetMetaData();
            Console.WriteLine("ThumbnailerBase.GetThumbnail");
        }
    }

    class ThumbnailerImage : ThumbnailerBase
    {
        protected override void GetMetaData()
        {
            Console.WriteLine("ThumbnailerImage.GetMetaData");
        }
    }

    class ThumbnailerVideo : ThumbnailerBase
    {
        protected override void GetMetaData()
        {
            Console.WriteLine("ThumbnailerVideo.GetMetaData");
        }
    }

    class ThumbailerAudio : ThumbnailerBase
    {
        protected override void GetMetaData()
        {
            Console.WriteLine("ThumbnailerAudio.GetMetaData");
        }
    }
}
