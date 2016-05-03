using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortGUI
{
    class Message
    {
        private byte[] data;
        public Message()
        {
            data = new byte[] { 0, 0, 0 };
        }
        public Message(byte cmd, byte fwbw, byte play){
            data = new byte[] { 0, 0, 0 };
            data[0] = 0x26;
            data[1] = cmd;
            switch (fwbw)
            {
                case 0: data[1] += 0; break;
                case 1: data[1] += 8; break;
                case 2: data[1] += 16; break;
                case 3: data[1] += 24; break;
                default: break;
            }
            if (play == 1) {
                data[1] += 32;
            }
            setChecksum();
        }
        public Message(byte freq, byte lvl)
        {
            data = new byte[] { 0, 0, 0 };
            data[0] = 0x66;
            data[1] = freq;
            if (lvl == 0) {
                /*Aumentar*/
                data[1] += 4;
            }
            setChecksum();
        }
        public Message(byte set) {
            data = new byte[] { 0, 0, 0 };
            data[0] = 0x44;
            data[1] = set;
            setChecksum();
        }
        private void setChecksum() {
            data[2] = (byte)(data[0] ^ data[1]);
        }
        public byte[] getData() {
            return data;
        }
    }
}