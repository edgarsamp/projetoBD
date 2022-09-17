using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace GuildInterface.GuildeClasses {
    class TrataImagem {
        public static MemoryStream byteToImage(byte[] img) => new MemoryStream((byte[])img);
        public static byte[] imageToByte(Image img) {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);

            return ms.ToArray();
        }
    }
}
