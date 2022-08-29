using System.IO;

namespace ThumbnailLib
{
    public class MediaInfo
    {
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public Stream FileStream { get; set; }

        public MediaInfo(string fileName, string mimeType, Stream fileStream)
        {
            FileName = fileName;
            MimeType = mimeType;
            FileStream = fileStream;
        }
    }
}
