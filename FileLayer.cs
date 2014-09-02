using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSFileLayer
{
    class FileLayer
    {
        public static byte[] Read(string szPath)
        {
            FileInfo fi = new FileInfo(szPath);
            if (fi.Length != 4 * 1024)
            {
                return null;
            }

            FileStream fs = new FileStream(szPath, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            byte[] btBuf = br.ReadBytes((int)fi.Length);

            br.Close();
            fs.Close();

            return btBuf;
        }

        public static byte[] ReadWhileFixDump(string szPath)
        {
            FileInfo fi = new FileInfo(szPath);

            if (!(fi.Length == 4 * 1024 || fi.Length == 1024))
            {
                return null;
            }

            FileStream fs = new FileStream(szPath, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            List<byte> blBuf = new List<byte>();
            blBuf.AddRange(br.ReadBytes((int)fi.Length));

            if (fi.Length == 1024)
            {
                byte[] btTmp = new byte[3072];
                blBuf.AddRange(btTmp);
            }

            br.Close();
            fs.Close(); 

            return blBuf.ToArray();
        }

        public static void Write(string szPath, byte[] btData)
        {
            FileStream fs = new FileStream(szPath, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(btData);
            bw.Close();
            fs.Close();
        }

        public static bool Exists(string szPath)
        {
            return File.Exists(szPath);
        }
    }
}
