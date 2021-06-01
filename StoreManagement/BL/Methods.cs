using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StoreManagement.BL
{
    class Methods
    {
       public MemoryStream ma = new MemoryStream();
       public byte[] by;

        // Convert to byte
        public byte [] ConvertToByte()
        {
            return ma.ToArray();
        }

        // Convert to MemoryStream
        public MemoryStream ConvertToImage()
        {
            ma = new MemoryStream(by);
            return ma;
        }
    }
}
