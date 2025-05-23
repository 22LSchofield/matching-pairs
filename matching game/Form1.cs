using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matching_game
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
           
            AssignIconsToSquares();
        }


        
        Label firstClicked = null;

       
        Label secondClicked = null;

       
        Random random = new Random();

      
        List<string> icons = new List<string>()
    {
        "a","a","b","b","c","c","d","d","e","e","f","f","g","g","h","h","i","i","j","j","k","k","l","l","m","m","n","n","o","o","p","p","q","q","r","r","s","s","t","t","u","u","v","v","w","w","x","x","y","y",
        "z","z","A","A","B","B","C","C","D","D","E","E","F","F","G","G","H","H","I","I","J","J","K","K","L","L","M","M","N","N","O","O","P","P","Q","Q","W","W","1","1","8","8","0","0","?","?","$","$",",",","


};


        private void AssignIconsToSquares()
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }





        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        { 
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
       
                if (clickedLabel.ForeColor == Color.Black)
                    return;

         
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;


          
                CheckForWinner();

 
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }


               
                click_delay.Start();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
      
            click_delay.Stop();

           
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;


            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
         
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                   
                    
                }
            }

            DialogResult dialogResult = MessageBox.Show("REPLAY ?", "PLAY AGAIN", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               
                InitializeComponent();
                AssignIconsToSquares();
                
            }
            else if (dialogResult == DialogResult.No)
            {
                Close();
            }
            

           
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label89_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }


        }

        private void label31_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label20_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label22_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label28_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label27_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label25_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label100_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label99_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label98_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label97_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label96_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label95_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label94_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label93_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label92_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label91_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label90_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label88_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label87_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label86_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label85_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label84_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label83_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label82_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label81_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label80_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label79_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label78_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label77_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label76_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label75_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label74_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label73_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label72_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label71_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label70_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label69_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label68_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label67_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label66_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label65_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label64_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label63_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label62_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label61_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label60_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label59_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label58_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label57_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label56_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label55_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label54_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label53_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label52_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label51_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label50_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label49_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label48_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label47_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label46_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label45_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label44_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label43_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label42_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label41_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label40_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label39_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label38_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label37_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label36_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label35_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label34_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label33_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label32_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label30_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label29_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label24_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label23_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (click_delay.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }


                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;



                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }



                click_delay.Start();
            }

        }
    }
}
