using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator1._1
{
    public partial class calculator : Form
    {
        string[] snum = new string[2];
        char[] sop = new char[2];

        int index;
        bool newnumber;
        bool errorflag;
        char gfp;

        public calculator()
        {
            InitializeComponent();
            reset();
            gfp = findformat();
            if(gfp == '\0')
            {
                MessageBox.Show(default(IWin32Window),"Unknown decimal format.","Error:",
                    default(MessageBoxButtons),(MessageBoxIcon)0x40);
                return;
            }
            this.opera_komma.Text = gfp.ToString();
        }

        private char findformat()
        {
            double d0;
            string tstr0, tstr1;

            tstr0 = "47.43";
            tstr1 = "4,743";

            d0 = Convert.ToDouble(tstr0);
            d0 += Convert.ToDouble(tstr1);

            if(d0 == 4747.743)
                return ',';
            else if(d0 == 4790.43)
                return '.';
            else
                return '\0';
        }

        private void tinput_KeyPress(object sender, KeyPressEventArgs e)
        {

            char a0 = e.KeyChar;

            if (a0 == '.' || a0 == ',')
                a0 = gfp;

            //'\x8' ...

            if((a0 >= '0' && a0 <= '9') || a0 == gfp)
                function_number(a0);
            else
                function_opera(a0);

            e.KeyChar = '\x3';
            tinput.SelectAll();
            tinput.Select(tinput.SelectionLength, 0);


        }

        private void tinput_TextChanged(object sender,  EventArgs e)
        {

            toutput.Text = snum[0] + " " + sop[0] + " " + snum[1];

        }

        private void tinput_GotFocus(object sender, System.EventArgs e)
        {

            tinput.SelectAll();
            tinput.Select(tinput.SelectionLength, 0);

        }

        private void reset()
        {
            errorflag = false;
            index = 0;
            snum[0] = "";
            snum[1] = "";
            sop[0] = '\0';
            tinput.Text = "";
            tinput.Text = "0";
            newnumber = true;
        }

        private void function_number(char ckey)
        {
            if (errorflag == true)
            {
                ckey = '\x03';
                return;
            }

            if (ckey == gfp && tinput.Text.Contains(gfp))
                return;

            if (newnumber && index == 0)
            {
                snum[1] = "";
                sop[0] = '\0';
            }

            if (newnumber || tinput.Text == "0")
            {
                snum[index] = "";
                tinput.Text = "";
            }

            if (ckey == gfp && tinput.Text == "")
            {
                snum[index] = "0";
                tinput.Text = "0";
            }

            snum[index] = snum[index] + ckey;
            tinput.Text = tinput.Text + ckey;

            newnumber = false;
        }

        private void function_opera(char ckey)
        {
            if (ckey == '\x1b')
                errorflag = false;

            if (errorflag == true)
            {
                ckey = '\x03';
                return;
            }

            if (snum[index] == "")
                snum[index] = "0";

            switch (ckey)
            {
                case 'r':
                    if (index == 0)
                    {
                        snum[1] = "";
                        sop[0] = '\0';
                    }
                    snum[index] = "";
                    tinput.Text = "";
                    tinput.Text = "0";
                    break;
                case '\x8':
                    if (newnumber)
                    {
                        ckey = '\x3';
                        return;
                    }
                    if (tinput.Text.Length <= 1 || (tinput.Text.Length <= 2 && tinput.Text.Contains('-')))
                    {
                        ckey = '\x3';
                        snum[index] = "";
                        tinput.Text = "";
                        tinput.Text = "0";
                        return;
                    }

                    snum[index] = tinput.Text.Remove(tinput.Text.Length - 1, 1);
                    tinput.Text = tinput.Text.Remove(tinput.Text.Length - 1, 1);
                    return;
                case '\x1b':
                    reset();
                    break;
                case 'o':
                    function_changesign();
                    ckey = '\x3';
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    function_2op(ckey);
                    ckey = '\x3';
                    break;
                case '=':
                case '\r':
                    if (snum[0] != "" && snum[1] != "" && sop[0] != '\0')
                    {
                        tinput.Text = getresult(snum[0], snum[1], sop[0]);
                        newnumber = true;
                        index = 0;
                    }
                    else
                        return;
                    break;



            }



        }

        private void function_changesign()
        {
            double d0;

            if (newnumber)
                return;

            d0 = Convert.ToDouble(tinput.Text);

            if (d0 < 0)
            {
                snum[index] = snum[index].Trim('-');
                tinput.Text = tinput.Text.Trim('-');
            }
            else if (d0 > 0)
            {
                snum[index] = '-' + snum[index];
                tinput.Text = '-' + tinput.Text;
            }

            

        }

        private void function_1op(char keychar)
        {
            newnumber = true;






        }

        private void function_2op(char ckey)
        {
            newnumber = true;


            if (index == 0 && snum[index] != tinput.Text)
            {
                snum[0] = tinput.Text;
                snum[1] = "";
                sop[0] = ckey;
                tinput.Text = "0";
            }


            if (index == 0)
            {
                sop[0] = ckey;
                index++;
            }
            else
            {

                snum[0] = getresult(snum[0], snum[1], sop[0]);

                sop[0] = ckey;
                snum[1] = "";
            }
            tinput.Text = "";
            tinput.Text = "0";

        }

        private string getresult(string str0, string str1, char opera)
        {
            if (str0 == "")
                str0 = "0";
            if (str1 == "")
                str1 = "0";

            switch(opera)
            {
                case '+':
                    return Convert.ToString(Convert.ToDouble(str0) + Convert.ToDouble(str1));
                case '-':
                    return Convert.ToString(Convert.ToDouble(str0) - Convert.ToDouble(str1));
                case '*':
                    return Convert.ToString(Convert.ToDouble(str0) * Convert.ToDouble(str1));
                case '/':
                    if (str1 == "0")
                    {
                        errorflag = true;
                        return "ERROR";
                    }
                    return Convert.ToString(Convert.ToDouble(str0) / Convert.ToDouble(str1));
            }
            //*/

            return "unknown operand";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            function_number('0');
            tinput.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            function_number('1');
            tinput.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            function_number('2');
            tinput.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            function_number('3');
            tinput.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            function_number('4');
            tinput.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            function_number('5');
            tinput.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            function_number('6');
            tinput.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            function_number('7');
            tinput.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            function_number('8');
            tinput.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            function_number('9');
            tinput.Focus();
        }

        private void opera_komma_Click(object sender, EventArgs e)
        {
            function_number(gfp);
            tinput.Focus();
        }

        private void opera_changesign_Click(object sender, EventArgs e)
        {
            function_opera('o');
            tinput.Focus();
        }

        private void opera_add_Click(object sender, EventArgs e)
        {
            function_opera('+');
            tinput.Focus();
        }

        private void opera_sub_Click(object sender, EventArgs e)
        {
            function_opera('-');
            tinput.Focus();
        }

        private void opera_mul_Click(object sender, EventArgs e)
        {
            function_opera('*');
            tinput.Focus();
        }

        private void opera_div_Click(object sender, EventArgs e)
        {
            function_opera('/');
            tinput.Focus();
        }

        private void opera_result_Click(object sender, EventArgs e)
        {
            function_opera('\r');
            tinput.Focus();
        }

        private void key_clear_Click(object sender, EventArgs e)
        {
            function_opera('\x1b');
            tinput.Focus();
        }

        private void key_back_Click(object sender, EventArgs e)
        {
            function_opera('\x8');
            tinput.Focus();
        }

        private void key_clearentry_Click(object sender, EventArgs e)
        {
            function_opera('r');
            tinput.Focus();
        }







    }
}
