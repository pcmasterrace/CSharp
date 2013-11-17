using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // needs to be here so that you can use Proccess.Start(), Process.StartInfo.FileName,  ect.

namespace ChromeOpener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen(); // Makes the program open in the middle of the screen
        }

        private void button1_Click(object sender, EventArgs e)  //Gina Button
        {
            button3.Visible = true;
            button4.Visible = true;
            textBox1.Visible = false;   //changing the visibility of the forms elements in order to change the appearance
            button2.Visible = false;    //some elements were allready set by me as invisible in the properties menu
            button1.Visible = false;
            button3.Text = "Open Gina's Chrome";    //The confirmation button "Open Chrome" will be slightly personalised
            levars.userholder = "Gina"; 
        }

        private void button2_Click(object sender, EventArgs e) //Josh Button
        {
            textBox1.Visible = true;
            if (button2.Text != "Check") {
                textBox1.Text = null;
            }
            if (button2.Text == "Check") {      //the second time the button is clicked after the user has entered the password
                if (textBox1.Text == "password") // the if statement checks if the password entered in textbox_1 is correct
                {
                    button3.Visible = true;
                    button4.Visible = true;
                    textBox1.Visible = false;
                    button2.Visible = false;
                    button1.Visible = false;
                    button3.Text = "Open Josh's Chrome";
                    levars.userholder = "Josh"; // so that the program can determine which chrome to open

                }
            }
            button2.Text = "Check"; // the first time the button is clicked the text is changed to check
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //the text box
        {
            // no code in here as the buttons access and edit textbox from within their onclick methods. They use textbox1.text to access the text inside the box
        }

        private void button3_Click(object sender, EventArgs e) //this is the "open chrome button that appears"
        {
            if (levars.userholder == "Josh") {
                Process Josh = new Process();
                Josh.StartInfo.FileName = @"C:\Users\Gins\AppData\Local\Google\Chrome\Application\Aokiji - Chrome.lnk"; //Aokiji - Chrome.lnk is a shortcut file for my chrome user that opens my users chrome
                Josh.Start();
                Close(); //closes the form
            }                              
            else if (levars.userholder == "Gina") {
                Process Gina = new Process();
                Gina.StartInfo.FileName = @"C:\Users\Gins\AppData\Local\Google\Chrome\Application\Gins - Chrome.lnk"; // Same as Aokiji - Chrome.lnk but a link for my mums user
                //IMPORTANT change the Filename address in the quotes to a valid application or shortcut, otherwise the program will stuff up when you try to open chrome
                Gina.Start();   // -->README a process called "Gina" is made, the files address is assigned (Gina.StartInfo.Filename = )
                Close();        // -->README Gina.Start opens the Process at the adress set by FileName
            }
        }

        private void button4_Click(object sender, EventArgs e) // This is the Go Back Button
        {
            button3.Visible = false;
            button4.Visible = false; //We are not actually going back anywhere we are just changing the visibility of certain elements
            button2.Visible = true;
            button1.Visible = true;
            button2.Text = "Josh"; // makes sure the Josh button doesn't say check still when we go back
        }
    }
    public static class levars {    // a class I made so i can declare some variables 
                                    // i dont think this is the correct way to do it though
        public static string userholder;    //holds information on which user button (button_1 or _2) 
                                            //has been clicked for use by the code in button_3
    }
}
