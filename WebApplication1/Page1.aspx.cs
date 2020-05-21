using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList3.Enabled = true;
            DropDownList4.Enabled = true;
            TextBox4.Enabled = true;
            TextBox5.Enabled = true;
            TextBox6.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;

            //only items selected

            if(DropDownList1.SelectedIndex == 1)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 50;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox3.Text = (d1 * d2).ToString();
            }

            if (DropDownList1.SelectedIndex == 2)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 60;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox3.Text = (d1 * d2).ToString();
            }

            if (DropDownList1.SelectedIndex == 3)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 70;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox3.Text = (d1 * d2).ToString();
            }

            if (DropDownList1.SelectedIndex == 4)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 80;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox3.Text = (d1 * d2).ToString();
            }

            // items + offer 1

            if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 1)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 50;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 2)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 50;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 3)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 50;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 4)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 50;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }

            //items + offer 2

            if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 1)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 60;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 2)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 60;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 3)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 60;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 4)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 60;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }

            // items + offer 3


            if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 1)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 70;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 2)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 70;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 3)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 70;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 4)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 70;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }

            //items + offer 4


            if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 1)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 80;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 2)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 80;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 3)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 80;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 4)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 80;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox16.Enabled = true;
            TextBox17.Enabled = true;
            TextBox18.Enabled = true;
            Button11.Enabled = true;
            Button12.Enabled = true;

            if (DropDownList1.SelectedIndex == 1)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 50;
                double d2 = Double.Parse(s1);
                TextBox2.Text = d1.ToString();
                TextBox3.Text = (d1 * d2).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList1.SelectedIndex == 2)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 60;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox3.Text = (d1 * d2).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList1.SelectedIndex == 3)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 70;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox3.Text = (d1 * d2).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList1.SelectedIndex == 4)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 80;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox3.Text = (d1 * d2).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 1


            if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 1)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 50;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 2)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 50;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 3)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 50;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 4)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 50;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            //items + offer 2

            if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 1)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 60;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 2)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 60;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 3)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 60;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 4)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 60;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 3


            if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 1)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 70;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 2)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 70;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 3)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 70;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList1.SelectedIndex == 3 && DropDownList2.SelectedIndex == 4)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 70;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            //items + offer 4


            if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 1)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 80;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 2)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 80;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 3)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 80;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList1.SelectedIndex == 4 && DropDownList2.SelectedIndex == 4)
            {
                string s1 = TextBox1.Text.ToString();
                double d1 = 80;
                TextBox2.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox3.Text = ((d1 * d2) - value).ToString();
                TextBox16.Text = TextBox3.Text.ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DropDownList5.Enabled = true;
            DropDownList6.Enabled = true;
            TextBox7.Enabled = true;
            TextBox8.Enabled = true;
            TextBox9.Enabled = true;
            Button5.Enabled = true;
            Button6.Enabled = true;

            //only items selected

            if (DropDownList3.SelectedIndex == 1)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 50;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox6.Text = (d1 * d2).ToString();
            }

            if (DropDownList3.SelectedIndex == 2)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 60;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox6.Text = (d1 * d2).ToString();
            }

            if (DropDownList3.SelectedIndex == 3)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 70;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox6.Text = (d1 * d2).ToString();
            }

            if (DropDownList3.SelectedIndex == 4)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 80;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox6.Text = (d1 * d2).ToString();
            }

            // items + offer 1

            if (DropDownList3.SelectedIndex == 1 && DropDownList4.SelectedIndex == 1)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 50;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList3.SelectedIndex == 1 && DropDownList4.SelectedIndex == 2)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 50;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList3.SelectedIndex == 1 && DropDownList4.SelectedIndex == 3)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 50;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList3.SelectedIndex == 1 && DropDownList4.SelectedIndex == 4)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 50;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }

            //items + offer 2

            if (DropDownList3.SelectedIndex == 2 && DropDownList4.SelectedIndex == 1)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 60;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList3.SelectedIndex == 2 && DropDownList4.SelectedIndex == 2)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 60;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList3.SelectedIndex == 2 && DropDownList4.SelectedIndex == 3)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 60;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList3.SelectedIndex == 2 && DropDownList4.SelectedIndex == 4)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 60;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }

            // items + offer 3


            if (DropDownList3.SelectedIndex == 3 && DropDownList4.SelectedIndex == 1)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 70;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList3.SelectedIndex == 3 && DropDownList4.SelectedIndex == 2)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 70;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList3.SelectedIndex == 3 && DropDownList4.SelectedIndex == 3)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 70;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList3.SelectedIndex == 3 && DropDownList4.SelectedIndex == 4)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 70;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }

            //items + offer 4


            if (DropDownList3.SelectedIndex == 4 && DropDownList4.SelectedIndex == 1)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 80;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList3.SelectedIndex == 4 && DropDownList4.SelectedIndex == 2)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 80;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList3.SelectedIndex == 4 && DropDownList4.SelectedIndex == 3)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 80;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }
            if (DropDownList3.SelectedIndex == 4 && DropDownList4.SelectedIndex == 4)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 80;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox16.Enabled = true;
            TextBox17.Enabled = true;
            TextBox18.Enabled = true;
            Button11.Enabled = true;
            Button12.Enabled = true;

            // only items

            if (DropDownList3.SelectedIndex == 1)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 50;
                double d2 = Double.Parse(s1);
                TextBox5.Text = d1.ToString();
                TextBox6.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList3.SelectedIndex == 2)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 60;
                double d2 = Double.Parse(s1);
                TextBox5.Text = d1.ToString();
                TextBox6.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList3.SelectedIndex == 3)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 70;
                double d2 = Double.Parse(s1);
                TextBox5.Text = d1.ToString();
                TextBox6.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList3.SelectedIndex == 4)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 80;
                double d2 = Double.Parse(s1);
                TextBox5.Text = d1.ToString();
                TextBox6.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 1

            if (DropDownList3.SelectedIndex == 1 && DropDownList4.SelectedIndex == 1)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 50;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList3.SelectedIndex == 1 && DropDownList4.SelectedIndex == 2)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 50;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList3.SelectedIndex == 1 && DropDownList4.SelectedIndex == 3)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 50;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList3.SelectedIndex == 1 && DropDownList4.SelectedIndex == 4)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 50;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            //items + offer 2

            if (DropDownList3.SelectedIndex == 2 && DropDownList4.SelectedIndex == 1)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 60;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList3.SelectedIndex == 2 && DropDownList4.SelectedIndex == 2)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 60;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList3.SelectedIndex == 2 && DropDownList4.SelectedIndex == 3)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 60;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList3.SelectedIndex == 2 && DropDownList4.SelectedIndex == 4)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 60;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 3


            if (DropDownList3.SelectedIndex == 3 && DropDownList4.SelectedIndex == 1)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 70;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList3.SelectedIndex == 3 && DropDownList4.SelectedIndex == 2)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 70;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList3.SelectedIndex == 3 && DropDownList4.SelectedIndex == 3)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 70;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList3.SelectedIndex == 3 && DropDownList4.SelectedIndex == 4)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 70;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            //items + offer 4


            if (DropDownList3.SelectedIndex == 4 && DropDownList4.SelectedIndex == 1)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 80;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList3.SelectedIndex == 4 && DropDownList4.SelectedIndex == 2)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 80;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList3.SelectedIndex == 4 && DropDownList4.SelectedIndex == 3)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 80;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
            if (DropDownList3.SelectedIndex == 4 && DropDownList4.SelectedIndex == 4)
            {
                string s1 = TextBox4.Text.ToString();
                double d1 = 80;
                TextBox5.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox6.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);

                TextBox16.Text = (am1 + am2).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            DropDownList7.Enabled = true;
            DropDownList8.Enabled = true;
            TextBox10.Enabled = true;
            TextBox11.Enabled = true;
            TextBox12.Enabled = true;
            Button7.Enabled = true;
            Button8.Enabled = true;

            //only items selected

            if (DropDownList5.SelectedIndex == 1)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 50;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox9.Text = (d1 * d2).ToString();
            }

            if (DropDownList5.SelectedIndex == 2)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 60;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox9.Text = (d1 * d2).ToString();
            }

            if (DropDownList5.SelectedIndex == 3)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 70;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox9.Text = (d1 * d2).ToString();
            }

            if (DropDownList5.SelectedIndex == 4)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 80;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox9.Text = (d1 * d2).ToString();
            }

            // items + offer 1

            if (DropDownList5.SelectedIndex == 1 && DropDownList6.SelectedIndex == 1)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 50;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 1 && DropDownList6.SelectedIndex == 2)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 50;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 1 && DropDownList6.SelectedIndex == 3)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 50;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 1 && DropDownList6.SelectedIndex == 4)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 50;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            // items + offer 2

            if (DropDownList5.SelectedIndex == 2 && DropDownList6.SelectedIndex == 1)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 60;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 2 && DropDownList6.SelectedIndex == 2)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 60;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 2 && DropDownList6.SelectedIndex == 3)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 60;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 2 && DropDownList6.SelectedIndex == 4)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 60;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            // items + offer 3

            if (DropDownList5.SelectedIndex == 3 && DropDownList6.SelectedIndex == 1)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 70;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 3 && DropDownList6.SelectedIndex == 2)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 70;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 3 && DropDownList6.SelectedIndex == 3)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 70;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 3 && DropDownList6.SelectedIndex == 4)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 70;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            // items + offer 4

            if (DropDownList5.SelectedIndex == 4 && DropDownList6.SelectedIndex == 1)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 80;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 4 && DropDownList6.SelectedIndex == 2)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 80;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 4 && DropDownList6.SelectedIndex == 3)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 80;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList5.SelectedIndex == 4 && DropDownList6.SelectedIndex == 4)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 80;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
            }

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox16.Enabled = true;
            TextBox17.Enabled = true;
            TextBox18.Enabled = true;
            Button11.Enabled = true;
            Button12.Enabled = true;

            // only items

            if (DropDownList5.SelectedIndex == 1)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 50;
                double d2 = Double.Parse(s1);
                TextBox8.Text = d1.ToString();
                TextBox9.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 2)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 60;
                double d2 = Double.Parse(s1);
                TextBox8.Text = d1.ToString();
                TextBox9.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 3)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 70;
                double d2 = Double.Parse(s1);
                TextBox8.Text = d1.ToString();
                TextBox9.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 4)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 80;
                double d2 = Double.Parse(s1);
                TextBox8.Text = d1.ToString();
                TextBox9.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 1

            if (DropDownList5.SelectedIndex == 1 && DropDownList6.SelectedIndex == 1)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 50;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 1 && DropDownList6.SelectedIndex == 2)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 50;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();
                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 1 && DropDownList6.SelectedIndex == 3)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 50;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 1 && DropDownList6.SelectedIndex == 4)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 50;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 2

            if (DropDownList5.SelectedIndex == 2 && DropDownList6.SelectedIndex == 1)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 60;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 2 && DropDownList6.SelectedIndex == 2)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 60;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

                if (DropDownList5.SelectedIndex == 2 && DropDownList6.SelectedIndex == 3)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 60;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                    string sm1 = TextBox3.Text.ToString();
                    string sm2 = TextBox6.Text.ToString();
                    string sm3 = TextBox9.Text.ToString();

                    Double am1 = Double.Parse(sm1);
                    Double am2 = Double.Parse(sm2);
                    Double am3 = Double.Parse(sm3);

                    TextBox16.Text = (am1 + am2 + am3).ToString();
                    double stax = 30;
                    TextBox17.Text = stax.ToString();

                }

            if (DropDownList5.SelectedIndex == 2 && DropDownList6.SelectedIndex == 4)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 60;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 3

            if (DropDownList5.SelectedIndex == 3 && DropDownList6.SelectedIndex == 1)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 70;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 3 && DropDownList6.SelectedIndex == 2)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 70;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 3 && DropDownList6.SelectedIndex == 3)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 70;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 3 && DropDownList6.SelectedIndex == 4)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 70;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 4

            if (DropDownList5.SelectedIndex == 4 && DropDownList6.SelectedIndex == 1)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 80;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 4 && DropDownList6.SelectedIndex == 2)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 80;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 4 && DropDownList6.SelectedIndex == 3)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 80;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList5.SelectedIndex == 4 && DropDownList6.SelectedIndex == 4)
            {
                string s1 = TextBox7.Text.ToString();
                double d1 = 80;
                TextBox8.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox9.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);

                TextBox16.Text = (am1 + am2 + am3).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            DropDownList9.Enabled = true;
            DropDownList10.Enabled = true;
            TextBox13.Enabled = true;
            TextBox14.Enabled = true;
            TextBox15.Enabled = true;
            Button10.Enabled = true;

            //only items selected

            if (DropDownList7.SelectedIndex == 1)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 50;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox12.Text = (d1 * d2).ToString();
            }

            if (DropDownList7.SelectedIndex == 2)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 60;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox12.Text = (d1 * d2).ToString();
            }

            if (DropDownList7.SelectedIndex == 3)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 70;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox12.Text = (d1 * d2).ToString();
            }

            if (DropDownList7.SelectedIndex == 4)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 80;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                TextBox12.Text = (d1 * d2).ToString();
            }

            // items + offer 1

            if (DropDownList7.SelectedIndex == 1 && DropDownList8.SelectedIndex == 1)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 50;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 1 && DropDownList8.SelectedIndex == 2)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 50;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 1 && DropDownList8.SelectedIndex == 3)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 50;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 1 && DropDownList8.SelectedIndex == 4)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 50;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            // items + offer 2


            if (DropDownList7.SelectedIndex == 2 && DropDownList8.SelectedIndex == 1)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 60;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 2 && DropDownList8.SelectedIndex == 2)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 60;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 2 && DropDownList8.SelectedIndex == 3)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 60;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 2 && DropDownList8.SelectedIndex == 4)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 60;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            // items + offer 3


            if (DropDownList7.SelectedIndex == 3 && DropDownList8.SelectedIndex == 1)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 70;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 3 && DropDownList8.SelectedIndex == 2)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 70;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 3 && DropDownList8.SelectedIndex == 3)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 70;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 3 && DropDownList8.SelectedIndex == 4)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 70;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            // items + offer 4


            if (DropDownList7.SelectedIndex == 4 && DropDownList8.SelectedIndex == 1)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 80;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 4 && DropDownList8.SelectedIndex == 2)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 80;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 4 && DropDownList8.SelectedIndex == 3)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 80;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }

            if (DropDownList7.SelectedIndex == 4 && DropDownList8.SelectedIndex == 4)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 80;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {

            TextBox16.Enabled = true;
            TextBox17.Enabled = true;
            TextBox18.Enabled = true;
            Button11.Enabled = true;
            Button12.Enabled = true;

            // only items

            if (DropDownList7.SelectedIndex == 1)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 50;
                double d2 = Double.Parse(s1);
                TextBox11.Text = d1.ToString();
                TextBox12.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 2)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 60;
                double d2 = Double.Parse(s1);
                TextBox11.Text = d1.ToString();
                TextBox12.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 3)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 70;
                double d2 = Double.Parse(s1);
                TextBox11.Text = d1.ToString();
                TextBox12.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 4)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 80;
                double d2 = Double.Parse(s1);
                TextBox11.Text = d1.ToString();
                TextBox12.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 1

            if (DropDownList7.SelectedIndex == 1 && DropDownList8.SelectedIndex == 1)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 50;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 1 && DropDownList8.SelectedIndex == 2)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 50;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 1 && DropDownList8.SelectedIndex == 3)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 50;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 1 && DropDownList8.SelectedIndex == 4)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 50;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 2

            if (DropDownList7.SelectedIndex == 2 && DropDownList8.SelectedIndex == 1)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 60;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 2 && DropDownList8.SelectedIndex == 2)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 60;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 2 && DropDownList8.SelectedIndex == 3)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 60;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 2 && DropDownList8.SelectedIndex == 4)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 60;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 3

            if (DropDownList7.SelectedIndex == 3 && DropDownList8.SelectedIndex == 1)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 70;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 3 && DropDownList8.SelectedIndex == 2)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 70;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 3 && DropDownList8.SelectedIndex == 3)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 70;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 3 && DropDownList8.SelectedIndex == 4)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 70;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 4

            if (DropDownList7.SelectedIndex == 4 && DropDownList8.SelectedIndex == 1)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 80;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 4 && DropDownList8.SelectedIndex == 2)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 80;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 4 && DropDownList8.SelectedIndex == 3)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 80;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList7.SelectedIndex == 4 && DropDownList8.SelectedIndex == 4)
            {
                string s1 = TextBox10.Text.ToString();
                double d1 = 80;
                TextBox11.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox12.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);

                TextBox16.Text = (am1 + am2 + am3 + am4).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            TextBox16.Enabled = true;
            TextBox17.Enabled = true;
            TextBox18.Enabled = true;
            Button11.Enabled = true;
            Button12.Enabled = true;

            // only items

            if (DropDownList9.SelectedIndex == 1)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 50;
                double d2 = Double.Parse(s1);
                TextBox14.Text = d1.ToString();
                TextBox15.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 2)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 60;
                double d2 = Double.Parse(s1);
                TextBox14.Text = d1.ToString();
                TextBox15.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 3)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 70;
                double d2 = Double.Parse(s1);
                TextBox14.Text = d1.ToString();
                TextBox15.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 4)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 80;
                double d2 = Double.Parse(s1);
                TextBox14.Text = d1.ToString();
                TextBox15.Text = (d1 * d2).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 1

            if (DropDownList9.SelectedIndex == 1 && DropDownList10.SelectedIndex == 1)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 50;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 1 && DropDownList10.SelectedIndex == 2)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 50;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 1 && DropDownList10.SelectedIndex == 3)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 50;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 1 && DropDownList10.SelectedIndex == 4)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 50;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 2

            if (DropDownList9.SelectedIndex == 2 && DropDownList10.SelectedIndex == 1)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 60;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 2 && DropDownList10.SelectedIndex == 2)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 60;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 2 && DropDownList10.SelectedIndex == 3)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 60;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 2 && DropDownList10.SelectedIndex == 4)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 60;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 3

            if (DropDownList9.SelectedIndex == 3 && DropDownList10.SelectedIndex == 1)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 70;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 3 && DropDownList10.SelectedIndex == 2)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 70;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 3 && DropDownList10.SelectedIndex == 3)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 70;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 3 && DropDownList10.SelectedIndex == 4)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 70;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            // items + offer 4

            if (DropDownList9.SelectedIndex == 4 && DropDownList10.SelectedIndex == 1)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 80;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 5;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 4 && DropDownList10.SelectedIndex == 2)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 80;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 10;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 4 && DropDownList10.SelectedIndex == 3)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 80;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 15;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }

            if (DropDownList9.SelectedIndex == 4 && DropDownList10.SelectedIndex == 4)
            {
                string s1 = TextBox13.Text.ToString();
                double d1 = 80;
                TextBox14.Text = d1.ToString();
                double d2 = Double.Parse(s1);
                double dis = 20;
                double value = (d1 * d2 * dis) / 100;
                TextBox15.Text = ((d1 * d2) - value).ToString();

                string sm1 = TextBox3.Text.ToString();
                string sm2 = TextBox6.Text.ToString();
                string sm3 = TextBox9.Text.ToString();
                string sm4 = TextBox12.Text.ToString();
                string sm5 = TextBox15.Text.ToString();

                Double am1 = Double.Parse(sm1);
                Double am2 = Double.Parse(sm2);
                Double am3 = Double.Parse(sm3);
                Double am4 = Double.Parse(sm4);
                Double am5 = Double.Parse(sm5);

                TextBox16.Text = (am1 + am2 + am3 + am4 + am5).ToString();
                double stax = 30;
                TextBox17.Text = stax.ToString();
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            String s1 = TextBox16.Text.ToString();
            string s2 = TextBox17.Text.ToString();

            double d1 = Double.Parse(s1);
            double d2 = Double.Parse(s2);

            TextBox18.Text = (d1 + d2).ToString();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            TextBox4.Text = " ";
            TextBox5.Text = " ";
            TextBox6.Text = " ";
            TextBox7.Text = " ";
            TextBox8.Text = " ";
            TextBox9.Text = " ";
            TextBox10.Text = " ";
            TextBox11.Text = " ";
            TextBox12.Text = " ";
            TextBox13.Text = " ";
            TextBox14.Text = " ";
            TextBox15.Text = " ";
            TextBox16.Text = " ";
            TextBox17.Text = " ";
            TextBox18.Text = " ";

            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
            TextBox7.Enabled = false;
            TextBox8.Enabled = false;
            TextBox9.Enabled = false;
            TextBox10.Enabled = false;
            TextBox11.Enabled = false;
            TextBox12.Enabled = false;
            TextBox13.Enabled = false;
            TextBox14.Enabled = false;
            TextBox15.Enabled = false;
            TextBox16.Enabled = false;
            TextBox17.Enabled = false;
            TextBox18.Enabled = false;

            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
            Button8.Enabled = false;
            Button10.Enabled = false;
            Button11.Enabled = false;
            Button12.Enabled = false;

            DropDownList3.Enabled = false;
            DropDownList4.Enabled = false;
            DropDownList5.Enabled = false;
            DropDownList6.Enabled = false;
            DropDownList7.Enabled = false;
            DropDownList8.Enabled = false;
            DropDownList9.Enabled = false;
            DropDownList10.Enabled = false;

        }
    }
}