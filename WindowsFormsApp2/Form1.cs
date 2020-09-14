using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            string EC = Input.Text.ToLower();

            EC = EC.Replace('q', '!');
            EC = EC.Replace("w", "|");
            EC = EC.Replace("e", "#");
            EC = EC.Replace("r", "@");
            EC = EC.Replace("t", "$");
            EC = EC.Replace("y", "£");
            EC = EC.Replace("u", "€");
            EC = EC.Replace("i", "%");
            EC = EC.Replace("o", "&");
            EC = EC.Replace("p", "/");
            EC = EC.Replace("å", "{");
            EC = EC.Replace("a", "(");
            EC = EC.Replace("s", "[");
            EC = EC.Replace("d", ")");
            EC = EC.Replace("f", "]");
            EC = EC.Replace("g", "=");
            EC = EC.Replace("h", "}");
            EC = EC.Replace("j", "+");
            EC = EC.Replace("k", "?");
            EC = EC.Replace("l", "´");
            EC = EC.Replace("ö", "`");
            EC = EC.Replace("ä", "¨");
            EC = EC.Replace("z", "^");
            EC = EC.Replace("x", "~");
            EC = EC.Replace("c", "'");
            EC = EC.Replace("v", "*");
            EC = EC.Replace("b", "_");
            EC = EC.Replace("n", "-");
            EC = EC.Replace("m", ":");
            EC = EC.Replace(" ", ";");

            Output.Text = EC;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            string EC = Input.Text.ToLower();

            EC = EC.Replace("!", "q");
            EC = EC.Replace("|", "w");
            EC = EC.Replace("#", "e");
            EC = EC.Replace("@", "r");
            EC = EC.Replace("$", "t");
            EC = EC.Replace("£", "y");
            EC = EC.Replace("€", "u");
            EC = EC.Replace("%", "i");
            EC = EC.Replace("&", "o");
            EC = EC.Replace("/", "p");
            EC = EC.Replace("{", "å");
            EC = EC.Replace("(", "a");
            EC = EC.Replace("[", "s");
            EC = EC.Replace(")", "d");
            EC = EC.Replace("]", "f");
            EC = EC.Replace("=", "g");
            EC = EC.Replace("}", "h");
            EC = EC.Replace("+", "j");
            EC = EC.Replace("?", "k");
            EC = EC.Replace("´", "l");
            EC = EC.Replace("`", "ö");
            EC = EC.Replace("¨", "ä");
            EC = EC.Replace("^", "z");
            EC = EC.Replace("~", "x");
            EC = EC.Replace("'", "c");
            EC = EC.Replace("*", "v");
            EC = EC.Replace("_", "b");
            EC = EC.Replace("-", "n");
            EC = EC.Replace(":", "m");
            EC = EC.Replace(";", " ");

            Output.Text = EC;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Output.Text = "";
        }
    }
}
