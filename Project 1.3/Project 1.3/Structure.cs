using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1._1
{

    class Structure
    {

        public static string ReadDB(int DBNumber, int Size, Byte[] Buffer)
        {

            int y, c;
            string s, Text;
            Text = "";

            y = 0;
            for (c = 0; c <= Size - 1; c++)
            {
                s = Convert.ToString(Buffer[c], 16);
                if (s.Length == 1)
                {
                    s = "0" + s;
                }
                Text = Text + s + " ";
                //y = y + 1;
                //if (y == 8)
                //{
                //    y = 0;
                //    Text = Text + "\n";
                //}
            }


            return Text;
        }


    }
}
