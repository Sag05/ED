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
        //all variabels
        string E0 = "!";
        string E1 = ("|");
        string E2 = ("#");
        string E3 = ("@");
        string E4 = ("$");
        string E5 = ("£");
        string E6 = ("€");
        string E7 = ("%");
        string E8 = ("&");
        string E9 = ("/");
        string E10 = ("{");
        string E11 = ("(");
        string E12 = ("[");
        string E13 = (")");
        string E14 = ("]");
        string E15 = ("=");
        string E16 = ("}");
        string E17 = ("+");
        string E18 = ("?");
        string E19 = ("´");
        string E20 = (">");
        string E21 = ("¨");
        string E22 = ("^");
        string E23 = ("~");
        string E24 = ("'");
        string E25 = ("*");
        string E26 = ("_");
        string E27 = ("-");
        string E28 = (":");
        string E29 = (";");



        private void inputBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            string EC = Input.Text.ToLower();


            EC = EC.Replace("?", "§");
            EC = EC.Replace("!", "½");
            EC = EC.Replace("q", E0);
            EC = EC.Replace("w", E1);
            EC = EC.Replace("e", E2);
            EC = EC.Replace("r", E3);
            EC = EC.Replace("t", E4);
            EC = EC.Replace("y", E5);
            EC = EC.Replace("u", E6);
            EC = EC.Replace("i", E7);
            EC = EC.Replace("o", E8);
            EC = EC.Replace("p", E9);
            EC = EC.Replace("å", E10);
            EC = EC.Replace("a", E11);
            EC = EC.Replace("s", E12);
            EC = EC.Replace("d", E13);
            EC = EC.Replace("f", E14);
            EC = EC.Replace("g", E15);
            EC = EC.Replace("h", E16);
            EC = EC.Replace("j", E17);
            EC = EC.Replace("k", E18);
            EC = EC.Replace("l", E19);
            EC = EC.Replace("ö", E20);
            EC = EC.Replace("ä", E21);
            EC = EC.Replace("z", E22);
            EC = EC.Replace("x", E23);
            EC = EC.Replace("c", E24);
            EC = EC.Replace("v", E25);
            EC = EC.Replace("b", E26);
            EC = EC.Replace("n", E27);
            EC = EC.Replace("m", E28);
            EC = EC.Replace(" ", E29);

            Output.Text = EC;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            string EC = Input.Text.ToLower();

            EC = EC.Replace(E0, "q");
            EC = EC.Replace(E1, "w");
            EC = EC.Replace(E2, "e");
            EC = EC.Replace(E3, "r");
            EC = EC.Replace(E4, "t");
            EC = EC.Replace(E5, "y");
            EC = EC.Replace(E6, "u");
            EC = EC.Replace(E7, "i");
            EC = EC.Replace(E8, "o");
            EC = EC.Replace(E9, "p");
            EC = EC.Replace(E10, "å");
            EC = EC.Replace(E11, "a");
            EC = EC.Replace(E12, "s");
            EC = EC.Replace(E13, "d");
            EC = EC.Replace(E14, "f");
            EC = EC.Replace(E15, "g");
            EC = EC.Replace(E16, "h");
            EC = EC.Replace(E17, "j");
            EC = EC.Replace(E18, "k");
            EC = EC.Replace(E19, "l");
            EC = EC.Replace(E20, "ö");
            EC = EC.Replace(E21, "ä");
            EC = EC.Replace(E22, "z");
            EC = EC.Replace(E23, "x");
            EC = EC.Replace(E24, "c");
            EC = EC.Replace(E25, "v");
            EC = EC.Replace(E26, "b");
            EC = EC.Replace(E27, "n");
            EC = EC.Replace(E28, "m");
            EC = EC.Replace(E29, " ");

            Output.Text = EC;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Output.Text = "";
        }


        private void ChangeKey_Click(object sender, EventArgs e)
        {
            /*
            Keys:
            #113763
            #793721
            */

            string key = Keybox.Text;

            if (key == "#113763")
            {
                E0 = ("!");
                E1 = ("|");
                E2 = ("#");
                E3 = ("@");
                E4 = ("$");
                E5 = ("£");
                E6 = ("€");
                E7 = ("%");
                E8 = ("&");
                E9 = ("/");
                E10 = ("{");
                E11 = ("(");
                E12 = ("[");
                E13 = (")");
                E14 = ("]");
                E15 = ("=");
                E16 = ("}");
                E17 = ("+");
                E18 = ("?");
                E19 = ("´");
                E20 = (">");
                E21 = ("¨");
                E22 = ("^");
                E23 = ("~");
                E24 = ("'");
                E25 = ("*");
                E26 = ("_");
                E27 = ("-");
                E28 = (":");
                E29 = (";");
            }
            if (key == "#793721")
            {
                E0 = (";");
                E1 = (":");
                E2 = ("-");
                E3 = ("_");
                E4 = ("*");
                E5 = ("'");
                E6 = ("~");
                E7 = ("^");
                E8 = ("¨");
                E9 = (">");
                E10 = ("´");
                E11 = ("?");
                E12 = ("+");
                E13 = ("}");
                E14 = ("=");
                E15 = ("]");
                E16 = (")");
                E17 = ("[");
                E18 = ("(");
                E19 = ("{");
                E20 = ("/");
                E21 = ("&");
                E22 = ("%");
                E23 = ("€");
                E24 = ("£");
                E25 = ("$");
                E26 = ("@");
                E27 = ("#");
                E28 = ("|");
                E29 = ("!");
            }
        }
    }
}
