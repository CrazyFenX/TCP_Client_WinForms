using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Client_WinForms
{
    //internal class Controller
    //{
    //    // coords of click
    //    float X = 0;
    //    float Y = 0;

    //    // keycode
    //    short c = 0;

    //}

    struct MouseData
    {
        public ushort _x;
        public ushort _y;
        public byte _button;
        public byte _ID;

        public MouseData(byte ID, ushort x, ushort y, byte button)
        {
            _ID = ID;
            _x = x;
            _y = y;
            _button = button;
        }
        
        public MouseData(int ID, int x, int y, int button)
        {
            _ID = (byte)ID;
            _x = (ushort)x;
            _y = (ushort)y;
            _button = (byte)button;
        }

        public static byte[] toByteArr(MouseData input)
        {
            byte[] mas = new byte[10];
            mas[0] = input._ID;
            for (int i = 0; i < 4; i++)
            {
                mas[i + 1] = Convert.ToByte(input._x / (ushort)Math.Pow(10, 3 - i) % 10);
                mas[i + 5] = Convert.ToByte(input._y / (ushort)Math.Pow(10, 3 - i) % 10);
            }
            mas[9] = input._button;
            return mas;
        }

        public static MouseData toData(byte[] arr)
        {
            ushort x = 0;
            ushort y = 0;
            byte ID = arr[0];
            byte button = arr[9];
            for (int i = 0; i < 4; i++)
            {
                x += Convert.ToUInt16(arr[i + 1] * (ushort)Math.Pow(10, 3 - i));
                y += Convert.ToUInt16(arr[i + 5] * (ushort)Math.Pow(10, 3 - i));
            }
            return new MouseData(ID, x, y, button);
        }
    }

    public struct KeyBoardData
    {
        public byte _button;
        public byte _ID;

        public KeyBoardData(byte ID, byte button)
        {
            _button = button;
            _ID = ID;
        }

        public static byte[] toByteArr(KeyBoardData kb)
        {
            byte[] mas = new byte[10];
            mas[0] = kb._ID;
            mas[1] = kb._button;
            return mas;
        }

        public static KeyBoardData toData(byte[] arr)
        {
            byte ID = arr[0];
            byte button = arr[9];
            return new KeyBoardData(ID, button);
        }
    }
}
