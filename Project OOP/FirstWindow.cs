using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP
{
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

         /*
         * Function Name: Password_Length_Text_Box_KeyPress
         * Input: object, KeyPressEventArgs
         * Process: Allows only numeric digits to be inside the Password_Length_Text_Box
         *          upon keypress inside the text box.
         * Return: N/A
         */
        private void Password_Length_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled= true;
            }
        }

        /*
         * Function Name: Password_Length_Slider_Scroll
         * Input: object, EventArgs
         * Process: Dynamically changes the password digit length in the password length
         *          box as the password length slider is changed.
         * Return: N/A
         */
        private void Password_Length_Slider_Scroll(object sender, EventArgs e)
        {
            int size = 1;
            size = Password_Length_Slider.Value;
            Generate_Password(sender, e, size);
            Password_Length_Text_Box.Text = Password_Length_Slider.Value.ToString();

        }

        private void About_Strip_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void Tutorial_Strip_Click(object sender, EventArgs e)
        {
            Tutorial_Box tutorial = new Tutorial_Box();
            tutorial.ShowDialog();
        }

        private void Generate_Password(object sender, EventArgs e, int size)
        {
            Password_Text_Box.Text = KeyGenerator.GetUniqueKey(size, Symbols_Check_Box.Checked,Numbers_Check_Box.Checked,Uppercase_Check_Box.Checked,Lowercase_Check_Box.Checked);
        }

        private void Password_Length_Text_Box_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Password_Length_Text_Box.Text, out int j))
            {
                if(j < 256 && j > 0)
                {
                    Password_Length_Slider.Value = j;
                }
            }
            else
            {
                Console.WriteLine("String could not be parsed.");
            }
        }

        private void Copy_Button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Password_Text_Box.Text);
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            int size = 1;
            size = Password_Length_Slider.Value;
            Generate_Password(sender, e, size);
        }
    }
}
