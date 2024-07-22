using System.IO;
using System.IO.Compression;
using System.Media;

namespace UCB
{
    static class Sound
    {
        public static void Play(byte[] buffer)
        {
            using (MemoryStream fileOut = new MemoryStream(buffer))
            using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                new SoundPlayer(gz).Play();
        }
    }
}
