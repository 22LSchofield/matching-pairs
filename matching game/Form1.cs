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
        "P", "P", "N", "N", ",", ",",  
        "b", "b", "v", "v", "w", "w", "z", "z","W","W"

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
            if (timer1.Enabled == true)
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


               
                timer1.Start();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
      
            timer1.Stop();

           
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

           
            
            
            DialogResult dialogResult = MessageBox.Show("REPLAY?", "PLAY AGAIN", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
               
                InitializeComponent();
                AssignIconsToSquares();
                
            }
            else if (dialogResult == DialogResult.No)
            {
                Close();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
               DialogResult dialogResult1 = MessageBox.Show("HOW DARE YOU CLICK CANCEL", "NEVER CANCEL MY GAME", MessageBoxButtons.OKCancel);
                if(dialogResult1 == DialogResult.Cancel)
                {
                    MessageBoxIcon iconerror = MessageBoxIcon.Error;
                    
                    
                }
            }

           
        }
    }
}
