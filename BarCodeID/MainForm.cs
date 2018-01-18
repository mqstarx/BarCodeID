﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCodeID
{
    public partial class MainForm : Form
    {

        string DbPath;
        List<PacketDataType> DbList;
        QRCoder.QRCodeGenerator qgen = new QRCoder.QRCodeGenerator();
        Bitmap bitmap;
        Graphics g_polufpage;
        QRCoder.QRCode qrCode;
        string cur_page_packet;
        int scan_flag_counter = 0;
        public MainForm()
        {

            InitializeComponent();
            g_polufpage = print_page_poluf.CreateGraphics();
            print_page_poluf.Paint += Print_page_poluf_Paint;
           
        }

       

        private bool CheckRegistryPath()
        {
            RegistryKey localmachineKey = Registry.CurrentUser;
            RegistryKey m_key = localmachineKey.OpenSubKey("BarCodeId", true);
            if (m_key == null)
                return false;
            else
                return true;

        }
        private string GetRegistryValue()
        {
            RegistryKey localmachineKey = Registry.CurrentUser;
            RegistryKey m_key = localmachineKey.OpenSubKey("BarCodeId", true);
            if (m_key == null)
                return null;
            else
            {

                string str = m_key.GetValue("Path").ToString();

                m_key.Close();
                return str;
            }
        }
        private void SetRegistryValue(string path)
        {
            RegistryKey localmachineKey = Registry.CurrentUser;
            RegistryKey m_key;
            if (!CheckRegistryPath())
                m_key = localmachineKey.CreateSubKey("BarCodeId");
            else
                m_key = localmachineKey.OpenSubKey("BarCodeId", true);

            m_key.SetValue("Path", path);
            m_key.Close();


        }
        private void DrawQrCode(string data, Graphics g, int z)
        {
            QRCoder.QRCodeData qr_data = qgen.CreateQrCode(data, QRCoder.QRCodeGenerator.ECCLevel.L);
            qrCode = new QRCoder.QRCode(qr_data);
            bitmap = qrCode.GetGraphic(25);          
            g.DrawImage(bitmap, 10, 10,z, z);
                               
        }

       

       

       

     

        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
           
            DrawQrCode(GenerateQrPacket(), e.Graphics, (int)qr_size_poluf.Value);
        }



        private void path_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op_fd = new OpenFileDialog();
            op_fd.Filter = "INI File(*.ini)|*.ini";
            op_fd.Title = "Выбор файла конфигурации справочника";
            if (CheckRegistryPath())
                op_fd.FileName = GetRegistryValue();

            if (op_fd.ShowDialog() == DialogResult.OK)
            {
                DbPath = op_fd.FileName;
                SetRegistryValue(DbPath);
            }


        }



        private void MainForm_Shown(object sender, EventArgs e)
        {
           
            if (!CheckRegistryPath())
            {
                path_btn_Click(null, null);
            }
            if (CheckRegistryPath())
            {
                DbPath = GetRegistryValue();
                path_lbl.Text = DbPath;
                DbList = Functions.LoadConfig(DbPath);
                UpdateListControl();

            }
            if (!CheckRegistryPath())
                this.Close();
        }
        private void UpdateListControl()
        {
            list_data.Items.Clear();
            listKeyPairs.Items.Clear();
            for (int i = 0; i < DbList.Count; i++)
            {
                ListViewItem liw = new ListViewItem();
                liw.Text = DbList[i].TypeId;
                liw.Tag = DbList[i].KeyValue;
                liw.SubItems.Add(DbList[i].DataLen.ToString());
                liw.SubItems.Add(DbList[i].DataDescr);
                list_data.Items.Add(liw);
            }
            for (int i = 0; i < DbList.Count; i++)
            {
                param_poluf_cmb.Items.Add(DbList[i]);

                if(DbList[i].KeyValue.Count==0)
                    sn_param_poluf.Items.Add(DbList[i]);
            }
        }

        private void list_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            listKeyPairs.Items.Clear();
            if (list_data.SelectedIndices.Count > 0)
            {
                List<KeyValuePair<string, string>> lkv = (List<KeyValuePair<string, string>>)list_data.Items[list_data.SelectedIndices[0]].Tag;
                if (lkv.Count > 0)
                {

                    for (int i = 0; i < lkv.Count; i++)
                    {
                        ListViewItem liw = new ListViewItem();
                        liw.Text = lkv[i].Key;
                        liw.SubItems.Add(lkv[i].Value);
                        listKeyPairs.Items.Add(liw);
                    }
                }
            }
        }

       
        private List<char> QrPacket = new List<char>();
        private void tab_control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tab_control.SelectedTab.Name == "ident_page")
            {
                QrPacket.Add(e.KeyChar);
                try
                {
                    ParseQrPacket();
                }
                catch(Exception d)
                {
                    MessageBox.Show("Ошибка чтения: " + d.Message);
                }
            }
            if (tab_control.SelectedTab.Name == "print_page_poluf" && !add_from_skanner_btn.Enabled)
            {
               // print_page_poluf.Focus();
               
               
                QrPacket.Add(e.KeyChar);
                try
                {
                    ParseQrPacketAdd();
                }
                catch (Exception d)
                {
                    MessageBox.Show("Ошибка чтения: " + d.Message);
                }

            }
        }

        private void ParseQrPacketAdd()
            {
            string res = "";
            foreach (char c in QrPacket)
            {
                res += c;
            }
            if (res.IndexOf("FFX") != -1 && res.IndexOf("FXX") != -1 && res.Length > 9)


            {



                ListObject result = new ListObject();
               // qr_add_poluf.Items.Clear();
           
                string datapacket = res.Substring(res.IndexOf("FFX") + 6, int.Parse(res.Substring(res.IndexOf("FFX") + 3, 3)));

                string t_packet = datapacket;
                List<string> in_pac = new List<string>();

                // парсинг входящих пакетов в состав основного пакета

                while (t_packet.IndexOf("FFY") != -1 && t_packet.IndexOf("FYY") != -1)
                {
                    in_pac.Add(t_packet.Substring(t_packet.IndexOf("FFY") + 6, int.Parse(res.Substring(res.IndexOf("FFY") + 3, 3))));
                    t_packet = t_packet.Substring(t_packet.IndexOf("FYY") + 3, t_packet.Length - t_packet.IndexOf("FYY") - 3);
                }
                if (in_pac.Count == 0)
                {
                    foreach (PacketDataType p in DbList)
                    {
                        if (datapacket.IndexOf(p.TypeId) != -1)
                        {
                            string d = datapacket.Substring(datapacket.IndexOf(p.TypeId) + 1, p.DataLen);
                            if (p.KeyValue.Count > 0)
                            {
                                foreach (KeyValuePair<string, string> kv in p.KeyValue)
                                {
                                    if (kv.Key == d)
                                        result.Text+=p.DataDescr + ": " + kv.Value+";";
                                }
                            }
                            else
                            {
                                result.Text+=p.DataDescr + ": " + d + ";";
                            }

                        }
                    }
                    result.Text1 = datapacket;
                    QrPacket.Clear();
                }
                else
                {
                    string main_packet = datapacket.Substring(0, datapacket.IndexOf("FFY"));
                    foreach (PacketDataType p in DbList)
                    {
                        if (main_packet.IndexOf(p.TypeId) != -1)
                        {
                            string d = main_packet.Substring(main_packet.IndexOf(p.TypeId) + 1, p.DataLen);
                            if (p.KeyValue.Count > 0)
                            {
                                foreach (KeyValuePair<string, string> kv in p.KeyValue)
                                {
                                    if (kv.Key == d)
                                        result.Text+=p.DataDescr + ": " + kv.Value + ";";
                                }
                            }
                            else
                            {
                                result.Text += p.DataDescr + ": " + d + ";";
                            }

                        }
                    }
                   
                    result.Text1 = main_packet;
                   
                    QrPacket.Clear();
                }
                qr_add_poluf.Items.Add(result);
                print_page_poluf.Invalidate();

            }
        }

        private void tab_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            QrPacket.Clear();
            list_ident_data.Items.Clear();
        }
        private void ParseQrPacket()
        {
            string res = "";
             foreach (char c in QrPacket)
            {
                res += c;
            }
            if (res.IndexOf("FFX") != -1 && res.IndexOf("FXX") != -1 && res.Length > 9)
            {




                list_ident_data.Items.Clear();
                ident_page.CreateGraphics().Clear(Color.White);
                DrawQrCode(res, ident_page.CreateGraphics(), 200);
                string datapacket = res.Substring(res.IndexOf("FFX") + 6, int.Parse(res.Substring(res.IndexOf("FFX")+3 , 3)));

                string t_packet = datapacket;
                List<string> in_pac = new List<string>();

                // парсинг входящих пакетов в состав основного пакета

                while (t_packet.IndexOf("FFY") != -1 && t_packet.IndexOf("FYY") != -1)
                {
                    in_pac.Add(t_packet.Substring(t_packet.IndexOf("FFY") + 6, int.Parse(res.Substring(res.IndexOf("FFY") + 3, 3))));
                    t_packet = t_packet.Substring(t_packet.IndexOf("FYY") + 3, t_packet.Length- t_packet.IndexOf("FYY") - 3);
                }
                if (in_pac.Count == 0)
                {
                    foreach (PacketDataType p in DbList)
                    {
                        if (datapacket.IndexOf(p.TypeId) != -1)
                        {
                            string d = datapacket.Substring(datapacket.IndexOf(p.TypeId)+1, p.DataLen);
                            if (p.KeyValue.Count > 0)
                            {
                                foreach (KeyValuePair<string, string> kv in p.KeyValue)
                                {
                                    if (kv.Key == d)
                                        list_ident_data.Items.Add(p.DataDescr + ": " + kv.Value);
                                }
                            }
                            else
                            {
                                list_ident_data.Items.Add(p.DataDescr + ": " + d);
                            }

                        }
                    }
                    QrPacket.Clear();
                }
                else
                {
                    string main_packet = datapacket.Substring(0, datapacket.IndexOf("FFY"));
                    foreach (PacketDataType p in DbList)
                    {
                        if (main_packet.IndexOf(p.TypeId) != -1)
                        {
                            string d = main_packet.Substring(main_packet.IndexOf(p.TypeId) + 1, p.DataLen);
                            if (p.KeyValue.Count > 0)
                            {
                                foreach (KeyValuePair<string, string> kv in p.KeyValue)
                                {
                                    if (kv.Key == d)
                                        list_ident_data.Items.Add(p.DataDescr + ": " + kv.Value);
                                }
                            }
                            else
                            {
                                list_ident_data.Items.Add(p.DataDescr + ": " + d);
                            }

                        }
                    }
                    foreach(string s in in_pac )
                    {
                        
                        foreach (PacketDataType p in DbList)
                        {
                            if (s.IndexOf(p.TypeId) != -1)
                            {
                                string d = s.Substring(s.IndexOf(p.TypeId) + 1, p.DataLen);
                                if (p.KeyValue.Count > 0)
                                {
                                    foreach (KeyValuePair<string, string> kv in p.KeyValue)
                                    {
                                        if (kv.Key == d)
                                            list_ident_data.Items.Add(p.DataDescr + ": " + kv.Value);
                                    }
                                }
                                else
                                {
                                    list_ident_data.Items.Add(p.DataDescr + ": " + d);
                                }

                            }
                        }
                    }

                    QrPacket.Clear();
                }

            }
        }

        private void param_poluf_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(param_poluf_cmb.SelectedIndex!=-1)
            {
                value_poluf_cmb.Items.Clear();
                value_poluf_cmb.Text = "";
                value_poluf_cmb.MaxLength = 255;
                if(((PacketDataType)param_poluf_cmb.SelectedItem).KeyValue.Count>0)
                {
                    value_poluf_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                    for (int i = 0; i < ((PacketDataType)param_poluf_cmb.SelectedItem).KeyValue.Count; i++)
                    {

                        value_poluf_cmb.Items.Add(((PacketDataType)param_poluf_cmb.SelectedItem).KeyValue[i]);
                    }
                    value_poluf_cmb.SelectedIndex = 0;
                }
                else
                {
                    value_poluf_cmb.DropDownStyle = ComboBoxStyle.Simple;
                    value_poluf_cmb.MaxLength = ((PacketDataType)param_poluf_cmb.SelectedItem).DataLen;
                }
            }
        }

       

        private string GenerateQrPacket()
        {
            string packet_data = "";
            for (int i = 0; i < qr_result_poluf.Items.Count; i++)
            {


                if (((ListObject)qr_result_poluf.Items[i]).Object1 != null)
                    packet_data += ((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).TypeId + ((KeyValuePair<string, string>)((ListObject)qr_result_poluf.Items[i]).Object1).Key;
                else
                    packet_data += ((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).TypeId + ((ListObject)qr_result_poluf.Items[i]).Text1;

                


            }
            for (int j = 0; j < qr_add_poluf.Items.Count; j++)
            {

                packet_data += "FFY" + ((ListObject)qr_add_poluf.Items[j]).Text1.Length.ToString("000") + ((ListObject)qr_add_poluf.Items[j]).Text1 + "FYY";
            }

            return "FFX" + packet_data.Length.ToString("000") + packet_data + "FXX";
        }
        private string[] GenerateQrPacketArray()
        {
            string[] resarray = new string[(int)sn_array_count.Value];
            for (int j = 0; j < sn_array_count.Value; j++)
            {
                string packet_data = "";
                for (int i = 0; i < qr_result_poluf.Items.Count; i++)
                {

                   


                    if (((ListObject)qr_result_poluf.Items[i]).Object1 != null)
                        packet_data += ((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).TypeId + ((KeyValuePair<string, string>)((ListObject)qr_result_poluf.Items[i]).Object1).Key;
                    else
                    {
                        if (((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).TypeId == ((PacketDataType)sn_param_poluf.SelectedItem).TypeId)
                        {
                            int sn_current = int.Parse(((ListObject)qr_result_poluf.Items[i]).Text1);

                            string sn_str = (sn_current + j).ToString();// ((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).DataLen).ToString();
                            if (sn_str.Length > ((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).DataLen)
                                sn_str = sn_str.Substring(1);
                            while (sn_str.Length< ((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).DataLen)
                            {
                                sn_str = "0" + sn_str;
                            }
                            packet_data += ((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).TypeId + sn_str;

                        }
                        else
                        {
                            packet_data += ((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).TypeId + ((ListObject)qr_result_poluf.Items[i]).Text1;
                        }
                    }


                }
                resarray[j] = packet_data;
            }

            return resarray;
        }

        private void qr_size_poluf_ValueChanged(object sender, EventArgs e)
        {
           print_page_poluf.Invalidate();
        }
        private void Print_page_poluf_Paint(object sender, PaintEventArgs e)
        {
            DrawQrCode(GenerateQrPacket(), e.Graphics, (int)qr_size_poluf.Value);
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
           
            if (add_sn_chk.Checked)
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintDocument_PrintPageArray;
                string[] arr  = GenerateQrPacketArray();
                for(int i=0;i<arr.Length;i++)
                {
                    cur_page_packet = arr[i];
                    printDocument.Print();
                    
                }
            }
            else
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PD_PrintPage;
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPageArray(object sender, PrintPageEventArgs e)
        {
            DrawQrCode(cur_page_packet, e.Graphics, (int)qr_size_poluf.Value);
        }

        private void add_sn_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (add_sn_chk.Checked)
            {
                if(qr_add_poluf.Items.Count>0)
                {
                    MessageBox.Show("Нельзя печатать разные этикетки с одинаковыми комплектующими");
                    add_sn_chk.Checked = false;
                }
                if (sn_param_poluf.SelectedItem == null)
                {
                    MessageBox.Show("Не выбран параметр серии");
                    add_sn_chk.Checked = false;
                }
            }
        }

        private void del_btn_menu_Click(object sender, EventArgs e)
        {
            if (qr_add_poluf.SelectedIndex != -1)
            {
                qr_add_poluf.Items.RemoveAt(qr_add_poluf.SelectedIndex);
                print_page_poluf.Invalidate();
            }
        }



        private void del_item_qr_result_Click(object sender, EventArgs e)
        {
            if (qr_result_poluf.SelectedIndex != -1)
            {
                qr_result_poluf.Items.RemoveAt(qr_result_poluf.SelectedIndex);
                print_page_poluf.Invalidate();
            }
        }

        private void add_qr_btn_Click(object sender, EventArgs e)
        {
            if (value_poluf_cmb.Text.Length > 0)
            {
                PacketDataType obj = (PacketDataType)param_poluf_cmb.SelectedItem;
                ListObject lwi = new ListObject();
                lwi.Object = obj;
                if (value_poluf_cmb.DropDownStyle == ComboBoxStyle.DropDownList)
                {
                    lwi.Object1 = value_poluf_cmb.SelectedItem;
                }
                lwi.Text = obj.DataDescr + ": " + value_poluf_cmb.Text;
                lwi.Text1 = value_poluf_cmb.Text;
                qr_result_poluf.Items.Add(lwi);



                print_page_poluf.Invalidate();

            }
        }

        private void incr_sn_btn_Click(object sender, EventArgs e)
        {
            if(sn_param_poluf.SelectedIndex==-1)
            {
                MessageBox.Show("Не выбран параметр серии");
                return;
            }
            for (int i = 0; i < qr_result_poluf.Items.Count; i++)
            {
                if (((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).TypeId == ((PacketDataType)sn_param_poluf.SelectedItem).TypeId)
                {
                    int sn = int.Parse(((ListObject)qr_result_poluf.Items[i]).Text1);
                    string sn_str = (sn + 1).ToString();
                    if (sn_str.Length > ((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).DataLen)
                        sn_str = sn_str.Substring(1);
                    while (sn_str.Length < ((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).DataLen)
                    {
                        sn_str = "0" + sn_str;
                    }
                    ListObject lwi = new ListObject();
                    lwi.Text1 = sn_str;
                    lwi.Text = ((PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object).DataDescr + ": " + sn_str;
                    lwi.Object = (PacketDataType)((ListObject)qr_result_poluf.Items[i]).Object;
                    qr_result_poluf.Items[i] = lwi;

                }
            }
        }

        private void timer_scan_Tick(object sender, EventArgs e)
        {
            if(scan_flag_counter>=5)
            {
                scan_flag_counter = 0;
                add_from_skanner_btn.Enabled = true;
                value_poluf_cmb.Enabled = true;
                qr_size_poluf.Enabled = true;
                sn_array_count.Enabled = true;
                add_from_skanner_btn.Text = "Сканировать входные детали";
                timer_scan.Stop();
                    
            }
            else
            {
                add_from_skanner_btn.Text = "Сканировать входные детали" + "("+ (5- scan_flag_counter).ToString() + ")";
                scan_flag_counter++;
            }
        }

        private void add_from_skanner_btn_Click(object sender, EventArgs e)
        {
            print_page_poluf.Focus();
            timer_scan.Start();
            add_from_skanner_btn.Enabled = false;
            value_poluf_cmb.Enabled = false;
            qr_size_poluf.Enabled = false;
            sn_array_count.Enabled = false;
        }
    }
}