using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = converter(textBox1.Text, Convert.ToInt64(textBox2.Text), Convert.ToInt64(textBox3.Text));
        }

        private static Int64 Number(char x)
        {
            if (x >= '0' && x <= '9')
                return x - '0';
            return 10 + x - 'A';
        }

        private static char Char_from_Number(Int64 c)
        {
            if (c < 10)
                return Convert.ToChar(c + '0');
            return Convert.ToChar(c + 'A');
        }

        private static string converter(string num, Int64 bas, Int64 to)
        {
            Int64 res = 0, po = 1;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                res += Number(num[i]) * po;
                po *= bas;
            }
            string ans = "";
            while (res > 0)
            {
                ans += Char_from_Number(res % to);
                res /= to;
            }
            string ansans = "";
            for (int i = ans.Length - 1; i >= 0; i--)
                ansans += ans[i];
            return ansans;
        }
    }
}
