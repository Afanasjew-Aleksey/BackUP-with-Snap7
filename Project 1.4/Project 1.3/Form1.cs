using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        String Adress = "";
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] {
            "OB", "FB", "FC", "DB", "SFB", "SFC", "SDB"});
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
                label4.Text = "Start";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
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

        private void Read_Click(object sender, EventArgs e)
        {
            int Result, c;
            string s;

            int BlockNumber, BlockType, BlockSize;

            BlockType = Block_Of[comboBox1.SelectedIndex];
            BlockNumber = System.Convert.ToInt32(TxtDB.Text);
            BlockSize = 65536;
            // Unsafe context: can use pointers here.
            label4.Text = BlockType.ToString();

            Result = Client.FullUpload(BlockType, BlockNumber, Buffer, ref BlockSize);
            ShowResult(Result);
            if (Result == 0)
            {
                //label4.Text = "";
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
            string path, folderName = @"\Test";

            int BlockType = Block_Of[comboBox1.SelectedIndex];
            int BlockSize = 655360, Count = 1000, i;
            int result = Client.ListBlocksOfType(BlockType, List, ref Count);
            ShowResult(result);
            if (result == 0)
            {
                TxtList.Clear();
                for (i = 0; i < Count; i++)
                {
                    string s = Convert.ToString(List[i], 10);
                    TxtList.Text = TxtList.Text + s + " ";
                }
            }
        }

        private void DisconnectBtn_Click_1(object sender, EventArgs e)
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
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string firstName = @"\Saves";
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                System.IO.DirectoryInfo drInfoFirst = new DirectoryInfo(fbd.SelectedPath + firstName);
                if (!drInfoFirst.Exists)
                {
                    drInfoFirst.Create();
                }
                MessageBox.Show("OK");

            }
            Adress = fbd.SelectedPath + firstName;

            SaveBlock(@"\OB", Adress, Client.Block_ob());
            SaveBlock(@"\DB", Adress, Client.Block_db());
            SaveBlock(@"\SDB", Adress, Client.Block_sdb());
            SaveBlock(@"\FC", Adress, Client.Block_fc());
            SaveBlock(@"\FB", Adress, Client.Block_fb());
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int Result, c;
            string s;

            int BlockNumber, BlockType, BlockSize;

            BlockType = Block_Of[comboBox1.SelectedIndex];
            BlockNumber = System.Convert.ToInt32(TxtDB.Text);
            BlockSize = 65536;
            // Unsafe context: can use pointers here.
            label4.Text = BlockType.ToString();

            Result = Client.Delete(BlockType, BlockNumber);
            ShowResult(Result);
            if (Result == 0)
            {
                //label4.Text = "";
                TxtDump.Clear();
                for (c = 0; c <= BlockSize - 1; c++)
                {
                    s = Convert.ToString(Buffer[c], 16);
                    if (s.Length == 1)
                    {
                        s = "0" + s;
                    }
                    TxtDump.Text = "Блок удален";
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

        private void button3_Click(object sender, EventArgs e)
        {
            string firstName = @"\Saves";
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                System.IO.DirectoryInfo drInfoFirst = new DirectoryInfo(fbd.SelectedPath + firstName);
                if (!drInfoFirst.Exists)
                {
                    drInfoFirst.Create();
                }
                MessageBox.Show("OK");

            }
            Adress = fbd.SelectedPath + firstName;

            LoadBlock(@"\OB", Adress, Client.Block_ob());
            LoadBlock(@"\DB", Adress, Client.Block_db());
            LoadBlock(@"\SDB", Adress, Client.Block_sdb());
            LoadBlock(@"\FC", Adress, Client.Block_fc());
            LoadBlock(@"\FB", Adress, Client.Block_fb());

        }

        private void SaveBlock(string Type_name, string firstname, int type_num)
        {
            string path; //firstName = @"\Saves";
            string number_path;

            StreamWriter output;
            byte[] Save_Buffer = new byte[65536];
            ushort[] new_List = new ushort[1000];
            int Count = 1000, i, number, result2, BlockSize = 65536, result1, inforesult;
            Snap7.S7Client.S7BlockInfo Info = new Snap7.S7Client.S7BlockInfo();

            System.IO.DirectoryInfo drInfo = new DirectoryInfo(firstname + Type_name);
            if (!drInfo.Exists)
            {
                drInfo.Create();
            }
            number_path = firstname + Type_name + @"\Number.txt";
            output = new StreamWriter(number_path);
            if (!File.Exists(number_path))
            {
                File.Create(number_path);
            }
            result1 = Client.ListBlocksOfType(type_num, new_List, ref Count);
            if (result1 == 0)
            {
                TxtDump.Clear();
                for (i = 0; i < Count; i++)
                {
                    number = Convert.ToInt32(new_List[i]);
                    Save_Buffer = new byte[65536];
                    inforesult = Client.GetAgBlockInfo(type_num, number, ref Info);
                    if (inforesult == 0)
                    {
                        BlockSize = Info.LoadSize;
                    }
                    output.Write(number + ":" + BlockSize + "\n");
                    Save_Buffer = new byte[BlockSize];
                    result2 = Client.FullUpload(type_num, number, Save_Buffer, ref BlockSize);
                    if (result2 == 0)
                    {
                        path = firstname + Type_name + @"\states" + number.ToString() + ".dat";
                        BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
                        writer.Write(Save_Buffer);
                        writer.Close();
                    }
                }
                output.Close();
            }

        }

        private void LoadBlock(string Type_name, string firstname, int type_num)
        {
            TxtDump.Clear();
            string path;
            string number_path, number, line, size;

            StreamReader output;
            BinaryReader reader_bin;
            byte[] Save_Buffer;
            int result2, index;

            number_path = firstname + Type_name + @"\Number.txt";
            output = new StreamReader(number_path);
            while ((line = output.ReadLine()) != null)
            {
                index = line.LastIndexOf(':');
                number = line.Substring(0, index);

                size = line.Substring(index+1, line.Length - index-1);
                path = firstname + Type_name + @"\states" + number + ".dat";
                //label4.Text = path;
                reader_bin = new BinaryReader(File.OpenRead(path));
                Save_Buffer = new byte[Convert.ToInt32(size)];
                Save_Buffer = reader_bin.ReadBytes(Convert.ToInt32(size));
                reader_bin.Close();
                //label4.Text = Int32.Parse(size).ToString();
                result2 = Client.Download(Convert.ToInt32(number), Save_Buffer, Convert.ToInt32(size));
                ShowResult(result2);
                if (result2 == 0)
                {
                    //label4.Text += "Gut";
                }
                else
                {
                    label4.Text +=Type_name +" ";
                }
            }
            output.Close();
        }
    }
}
