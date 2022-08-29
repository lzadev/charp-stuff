using System;
using System.Drawing;

namespace ThumbnailLib
{
    using System;

    namespace ThumbnailLib
    {
        public abstract class ThumbnailerBase
        {
            public Image GetThumbnail(MediaInfo mediaInfo)
            {
                GetMetaData(mediaInfo);
                Console.WriteLine("ThumbnailerBase.GetThumbnail");
                return GetThumbnailCore(mediaInfo);
            }

            protected abstract void GetMetaData(MediaInfo mediaInfo);
            protected abstract Image GetThumbnailCore(MediaInfo mediaInfo);
        }

        class ThumbnailerImage : ThumbnailerBase
        {
            protected override void GetMetaData(MediaInfo mediaInfo)
            {
                Console.WriteLine("ThumbnailerImage.GetMetaData");
            }

            protected override Image GetThumbnailCore(MediaInfo mediaInfo)
            {
                throw new NotImplementedException();
            }
        }

        class ThumbnailerVideo : ThumbnailerBase
        {
            protected override void GetMetaData(MediaInfo mediaInfo)
            {
                Console.WriteLine("ThumbnailerVideo.GetMetaData");
            }

            protected override Image GetThumbnailCore(MediaInfo mediaInfo)
            {
                throw new NotImplementedException();
            }
        }

        class ThumbailerAudio : ThumbnailerBase
        {
            protected override void GetMetaData(MediaInfo mediaInfo)
            {
                Console.WriteLine("ThumbnailerAudio.GetMetaData");
            }

            protected override Image GetThumbnailCore(MediaInfo mediaInfo)
            {
                throw new NotImplementedException();
            }
        }
    }

}
