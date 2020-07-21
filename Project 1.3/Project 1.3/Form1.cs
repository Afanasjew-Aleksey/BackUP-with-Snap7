using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1._3
{
    public partial class Form1 : Form
    {
        static Snap7.S7Client Client = new Snap7.S7Client();
        byte[] Buffer = new byte[65536];
        ushort[] List = new ushort[1000];
        int[] Block_Of = new int[7] { Client.Block_ob(), Client.Block_fb(), Client.Block_fc(), Client.Block_db(),
            Client.Block_sfb(), Client.Block_sfc(), Client.Block_sdb() };
        public Form1()
        {
            InitializeComponent(); 
            comboBox1.Items.AddRange(new object[] {
            "OB",
            "FB",
            "FC",
            "DB",
            "SFB",
            "SFC",
            "SDB"});
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            String IPAdress = TxtIP.Text;
            int Rack = System.Convert.ToInt32(TxtRack.Text);
            int Slot = System.Convert.ToInt32(TxtSlot.Text);
            int Result = Client.ConnectTo(IPAdress, Rack, Slot);
            ShowResult(Result);
            if (Result == 0)
            {
                TxtIP.Enabled = false;
                TxtRack.Enabled = false;
                TxtSlot.Enabled = false;
                comboBox1.Enabled = true;
                ConnectBtn.Enabled = false;
                DisconnectBtn.Enabled = true;
                Read.Enabled = true;
                TxtDB.Enabled = true;
                TxtSize.Enabled = true;
                label4.Text = "Sieg Heil";
            }
            else
            {
                label4.Text = "Fail";
            }
        }

        private void ShowResult(int Result)
        {
            TextError.Text = Client.ErrorText(Result);
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            Client.Disconnect();
            TxtIP.Enabled = true;
            TxtRack.Enabled = true;
            TxtSlot.Enabled = true;
            ConnectBtn.Enabled = true;
            comboBox1.Enabled = false;
            DisconnectBtn.Enabled = false;
            Read.Enabled = false;
            TxtDB.Enabled = false;
            TxtSize.Enabled = false;
        }

        private void Read_Click(object sender, EventArgs e)
        {
            int Number, Result, Size, c, Count=0;
            string s;

            int BlockNumber, BlockType, BlockSize, result1;

            BlockType = Block_Of[comboBox1.SelectedIndex];
            BlockNumber = System.Convert.ToInt32(TxtDB.Text);
            BlockSize = 65536;
            // Unsafe context: can use pointers here.
            label4.Text = BlockType.ToString();

            Result = Client.FullUpload(BlockType, BlockNumber, Buffer, ref BlockSize);
            ShowResult(Result);
            if (Result == 0)
            {
                label4.Text = "Leib";
                TxtDump.Clear();
                for (c = 0; c <= BlockSize - 1; c++)
                {
                    s = Convert.ToString(Buffer[c], 16);
                    if (s.Length == 1)
                    {
                        s = "0" + s;
                    }
                    TxtDump.Text = TxtDump.Text + s + " ";
                    //y = y + 1;
                    //if (y == 8)
                    //{
                    //    y = 0;
                    //    Text = Text + "\n";
                    //}
                }
            }
            else
            {
                label4.Text = Result.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int BlockType = Block_Of[comboBox1.SelectedIndex];
            int Count = 100,i;
            int result = Client.ListBlocksOfType(BlockType, List, ref Count);
            ShowResult(result);
            if (result == 0)
            {
                TxtList.Clear();
                for (i=0;i<Count;i++)
                {
                    string s = Convert.ToString(List[i], 10);
                    TxtList.Text = TxtList.Text + s + " ";
                }
            }
        }
    }
}
