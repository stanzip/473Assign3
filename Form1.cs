using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assign3

{
    public partial class Form1 : Form

    {
        public Form1()


        {

            InitializeComponent();

        }


        private void trackBar2_Scroll(object sender, EventArgs e)

        {



            if (MaxTrackBar.Value < MinTrackBar.Value) MaxTrackBar.Value = MinTrackBar.Value;

            MinPriceLabel.Text = "Min Value: $" + MinTrackBar.Value;

        }


        private void button1_Click(object sender, EventArgs e)

        {


        }


        private void checkBox5_CheckedChanged(object sender, EventArgs e)

        {


        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)

        {


        }


        private void MinPriceLabel_Click(object sender, EventArgs e)

        {


        }


        private void MaxTrackBar_Scroll(object sender, EventArgs e)

        {

            if (MinTrackBar.Value > MaxTrackBar.Value) MinTrackBar.Value = MaxTrackBar.Value;

            MaxPriceLabel.Text = "Max Value: $" + MaxTrackBar.Value;

        }


        private void Form1_Load(object sender, EventArgs e)

        {
            foreach(Business b in Program.DeKalbBusinessList)
            {
                SelectBusiness.Items.Add(b.businessAddress());
            }

        }

        private void QueryResultsLabel_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}