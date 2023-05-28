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
        byte _UpOrDown;

        public MouseData()
        {
            _ID = 0;
            _x = 0;
            _y = 0;
            _button = 0;
            _UpOrDown = 0;
        }

        public MouseData(byte ID, ushort x, ushort y, byte button, byte UpOrDown)
        {
            _ID = ID;
            _x = x;
            _y = y;
            _button = button;
            _UpOrDown = UpOrDown;
        }

        public MouseData(int ID, int x, int y, int button, int UpOrDown)
        {
            _ID = (byte)ID;
            _x = (ushort)x;
            _y = (ushort)y;
            _button = (byte)button;
            _UpOrDown = (byte)UpOrDown;
        }

        public static byte[] toByteArr(MouseData input)
        {
            byte[] mas = new byte[11];
            mas[0] = input._ID;
            for (int i = 0; i < 4; i++)
            {
                mas[i + 1] = Convert.ToByte(input._x / (ushort)Math.Pow(10, 3 - i) % 10);
                mas[i + 5] = Convert.ToByte(input._y / (ushort)Math.Pow(10, 3 - i) % 10);
            }
            mas[9] = input._button;
            mas[10] = input._UpOrDown;
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
            byte UpOrDown = arr[10];
            return new MouseData(ID, x, y, button, UpOrDown);
        }

        public override string ToString()
        {
            var ret = "";
            if (_x != 0 || _y != 0 || _ID != 0 || _button != 0)
                ret = _x + " " + _y + " " + _ID + " " + _button;
            return ret;
        }
    }

    public struct KeyBoardData
    {
        public byte _button;
        public byte _ID;
        public byte _UpOrDown;

        public KeyBoardData()
        {
            _button = 0;
            _ID = 0;
            _UpOrDown = 0;
        }

        public KeyBoardData(byte ID, byte button, byte UpOrDown)
        {
            _button = button;
            _ID = ID;
            _UpOrDown = UpOrDown;
        }

        public static byte[] toByteArr(KeyBoardData kb)
        {
            byte[] mas = new byte[2];
            mas[0] = kb._ID;
            mas[1] = kb._button;
            mas[2] = kb._UpOrDown;
            return mas;
        }

        public static KeyBoardData toData(byte[] arr)
        {
            //byte ID = arr[0];
            //byte button = arr[1];
            //byte UpOrDown = arr[2];
            //return new KeyBoardData(ID, button);
            return new KeyBoardData(arr[0], arr[1], arr[2]);
        }

        public override string ToString()
        {
            var ret = "";
            if (_ID != 0 || _button != 0)
                ret = _ID + " " + _button + " " + _UpOrDown;
            return ret;
        }
    }
}
