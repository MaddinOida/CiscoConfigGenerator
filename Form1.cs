using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Microsoft.Win32;

namespace CiscoConfigGeneratorTest01
{

    


    public partial class Form1 : Form
    {

        dot1xTemplate ProduktiveTemplate = new dot1xTemplate();
        List<string> PortRange = new List<string>();

        char type = 'n';

        public Form1()
        {
            InitializeComponent();

            

        }



        private void btn_generate_Click(object sender, EventArgs e)
        {
            //ProduktiveTemplate.loadTemplate();


            List<string> temp = new List<string>();

            foreach(string elem in lbx_portranges.Items)
            {
                temp.Add(elem);
            }


            //txt_output.Text = ProduktiveTemplate.insertMultiplePortRange(temp);

            DateTime dt = DateTime.Now;

            string DateAndTime = dt.Ticks.ToString();



            FileStream saveConfig = new FileStream(@".\.\newConfig" + DateAndTime + ".txt", FileMode.Create, FileAccess.Write);

            StreamWriter sw = new StreamWriter(saveConfig);

            string teppat = ProduktiveTemplate.insertMultiplePortRange(temp);

            sw.WriteLine(teppat);

            ProduktiveTemplate.closeStream();
            sw.Close();

            System.Windows.Forms.MessageBox.Show("Done!", "Nachricht", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_lbxsave_Click(object sender, EventArgs e)
        {
            string prefix = txt_prefix.Text;
            string pos1 = txt_pos1.Text;
            string pos2 = txt_pos2.Text;
            string pos3 = txt_pos3.Text;
            string pos4 = txt_pos4.Text;
            string ItemString = string.Empty;



            //if(pos2 == String.Empty || pos2 == "")
            //{
            //    ItemString = prefix + pos1 + "/" + pos3 + "-" + pos4;
            //}
            //else
            //{
            //    ItemString = prefix + pos1 + "/" + pos2 + "/" + pos3 + "-" + pos4;
            //}


            ItemString = prefix + pos1 + "/" + pos2 + "/" + pos3 + "-" + pos4;

            
            if(ItemString.EndsWith("-") == true)
            {
                ItemString = ItemString.Substring(0,ItemString.Length - 1);
            }

            if(ItemString.Contains("//") == true)
            {
                ItemString = ItemString.Replace("//", "/");
            }

            if(ItemString.EndsWith("/") == true)
            {
                ItemString = ItemString.Replace("/", "");
            }

            if(ItemString.Contains("/-") == true)
            {
                ItemString = ItemString.Replace("/-", "-");
            }


            ItemString = "%" + type + "%" + ItemString;




            //last is -
            //last is - and double //
            // double // = bad
            // folge //- is bad


            lbx_portranges.Items.Add(ItemString);

            


        }

        private void btn_lbxrem_Click(object sender, EventArgs e)
        {
            if(lbx_portranges.SelectedItems != null)
                lbx_portranges.Items.RemoveAt(lbx_portranges.SelectedIndex);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clearlbx_Click(object sender, EventArgs e)
        {
            lbx_portranges.Items.Clear();
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_lbxsave_Click(sender, e);
            }
        }

        private void rbx_normal_CheckedChanged(object sender, EventArgs e)
        {
            if(rbx_ap.Checked == false && rbx_normal.Checked == true)
            {
                type = 'n';
            }
        }

        private void rbx_ap_CheckedChanged(object sender, EventArgs e)
        {
            if (rbx_ap.Checked == true && rbx_normal.Checked == false)
            {
                type = 'a';
            }
        }
    }
}
