using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämingsuppgift_2__Shotgun
{
    public partial class Form1 : Form
    {
        
        CPU Bot = new CPU();
        Player Me = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            textBoxCPU.Clear();
            textBoxPlayer.Clear();
        }

        public class CPU
        {
            public int CPUShells { get; set; }

            public string[] Choice = new string[] { "Shoot", "Reload", "Block" };

            public int RandomNumber = 0;

            public Random CPUSelection = new Random();
            public string CPUChoice { get; set; }

            public void RandomChoice()
            {
                RandomNumber = CPUSelection.Next(0, Choice.Length);

                CPUChoice = Choice[RandomNumber];
            }
        }

        public class Player
        {
            public int PlayerShells { get; set; }
        }
       
        public void buttonShoot_Click(object sender, EventArgs e)
        {          
            Bot.RandomChoice();
            
            if (Bot.CPUShells == 3)
            {
                ClearTextBoxes();
                Me.PlayerShells--;
                Bot.CPUShells = 0;
                labelShellsCPU.Text = Bot.CPUShells.ToString();
                labelShells.Text = Me.PlayerShells.ToString();
                textBoxPlayer.Text = "Player shoots";
                textBoxCPU.Text = "CPU uses Shotgun";
                MessageBox.Show("CPU won the game by Using Shotgun!");
                Bot.RandomNumber = 4;
            }
                      
            if (Bot.RandomNumber == 2)
            {
               
                if (Me.PlayerShells == 0)
                {
                    ClearTextBoxes();
                    textBoxPlayer.Text = "Player tried to shoot but have no shells";
                    textBoxCPU.Text = "CPU blocks";
                }
                else if (Bot.RandomNumber == 2)
                {
                    ClearTextBoxes();
                    Me.PlayerShells--;
                    labelShells.Text = Me.PlayerShells.ToString();
                    textBoxPlayer.Text = "Player shoots";
                    textBoxCPU.Text = "CPU blocks";
                }               
                
            }
            else if (Bot.RandomNumber == 0)
            {
                if (Bot.CPUShells == 1 || Bot.CPUShells == 2 && Me.PlayerShells == 1 || Me.PlayerShells == 2)
                {
                    ClearTextBoxes();
                    Me.PlayerShells--;
                    Bot.CPUShells--;
                    labelShellsCPU.Text = Bot.CPUShells.ToString();
                    labelShells.Text = Me.PlayerShells.ToString();
                    textBoxPlayer.Text = "Player shoots";
                    textBoxCPU.Text = "CPU shoots";
                }
                else if (Me.PlayerShells == 0 && Bot.CPUShells == 1 || Bot.CPUShells == 2)
                {
                    ClearTextBoxes();
                    Bot.CPUShells--;
                    labelShellsCPU.Text = Bot.CPUShells.ToString();
                    textBoxCPU.Text = "CPU shoots";
                    textBoxPlayer.Text = "Player tried to shoot but had no shells";
                    MessageBox.Show("CPU has won the game by shooting Player");
                }
                else if (Bot.CPUShells == 0 && Me.PlayerShells == 1 || Me.PlayerShells == 2)
                {
                    Bot.RandomNumber = 1;
                    ClearTextBoxes();
                    Me.PlayerShells--;
                    Bot.CPUShells++;
                    labelShells.Text = Me.PlayerShells.ToString();
                    textBoxPlayer.Text = "Player shoots";
                    textBoxCPU.Text = "CPU reloads";
                    MessageBox.Show("Player has won the game by shooting CPU");
                }
                else if (Me.PlayerShells == 0 && Bot.CPUShells == 0)
                {
                    Bot.RandomNumber = 1;
                    ClearTextBoxes();
                    Bot.CPUShells++;
                    labelShellsCPU.Text = Bot.CPUShells.ToString();
                    textBoxPlayer.Text = "Player tried to shoot but had no shells";
                    textBoxCPU.Text = "CPU reloads";
                }                                                                     
                                
            }
            else if (Bot.RandomNumber == 1)
            {
                if (Me.PlayerShells == 0)
                {
                    ClearTextBoxes();
                    Bot.CPUShells++;
                    labelShellsCPU.Text = Bot.CPUShells.ToString();
                    textBoxPlayer.Text = "Player tried to shoot but have no shells";
                    textBoxCPU.Text = "CPU reloads";
                }
                else if (Me.PlayerShells == 1 || Me.PlayerShells == 2)
                {
                    ClearTextBoxes();
                    Me.PlayerShells--;
                    Bot.CPUShells++;
                    labelShells.Text = Me.PlayerShells.ToString();
                    labelShellsCPU.Text = Bot.CPUShells.ToString();
                    textBoxPlayer.Text = "Player shoots";
                    textBoxCPU.Text = "CPU Reloads";
                    MessageBox.Show("Player has won the game by shooting CPU");
                }               
            }           
        }
        
        public void buttonReload_Click(object sender, EventArgs e)
        {           

            Bot.RandomChoice();

            if (Bot.CPUShells == 3)
            {
                ClearTextBoxes();
                Me.PlayerShells++;
                Bot.CPUShells = 0;
                labelShellsCPU.Text = Bot.CPUShells.ToString();
                labelShells.Text = Me.PlayerShells.ToString();
                textBoxPlayer.Text = "Player reloads";
                textBoxCPU.Text = "CPU uses Shotgun";
                MessageBox.Show("CPU won the game by Using Shotgun!");
                Bot.RandomNumber = 4;
            }
                      
            if (Bot.RandomNumber == 1)
            {
                ClearTextBoxes();
                Me.PlayerShells++;
                Bot.CPUShells++;
                labelShellsCPU.Text = Bot.CPUShells.ToString();
                labelShells.Text = Me.PlayerShells.ToString();
                textBoxPlayer.Text = "Player reloads";
                textBoxCPU.Text = "CPU Reloads";
            }
            else if (Bot.RandomNumber == 2)
            {
                ClearTextBoxes();
                Me.PlayerShells++;
                labelShells.Text = Me.PlayerShells.ToString();
                textBoxPlayer.Text = "Player reloads";
                textBoxCPU.Text = "CPU blocks";
            }
            else if (Bot.RandomNumber == 0)
            {
                if (Bot.CPUShells == 0)
                {
                    Bot.RandomNumber = 1;
                    ClearTextBoxes();
                    Me.PlayerShells++;
                    Bot.CPUShells++;
                    labelShellsCPU.Text = Bot.CPUShells.ToString();
                    labelShells.Text = Me.PlayerShells.ToString();
                    textBoxPlayer.Text = "Player reloads";
                    textBoxCPU.Text = "CPU reloads";
                }
                else if (Bot.CPUShells == 1 || Bot.CPUShells == 2)
                {
                    ClearTextBoxes();
                    Bot.CPUShells--;
                    Me.PlayerShells++;
                    labelShells.Text = Me.PlayerShells.ToString();
                    labelShellsCPU.Text = Bot.CPUShells.ToString();
                    textBoxPlayer.Text = "Player reloads";
                    textBoxCPU.Text = "CPU shoots";
                    MessageBox.Show("CPU has won the game by shooting Player");
                }                
            }
                       
        }
       

        public void buttonBlock_Click(object sender, EventArgs e)
        {
           
            Bot.RandomChoice();

            if (Bot.CPUShells == 3)
            {
                ClearTextBoxes();
                Bot.CPUShells = 0;
                labelShellsCPU.Text = Bot.CPUShells.ToString();
                textBoxPlayer.Text = "Player blocks";
                textBoxCPU.Text = "CPU uses Shotgun";
                MessageBox.Show("CPU won the game by Using Shotgun!");
                Bot.RandomNumber = 4;
            }
                     

            if (Bot.RandomNumber == 0)
            {
                if (Bot.CPUShells == 0)
                {
                    Bot.RandomNumber = 1;
                    ClearTextBoxes();
                    Bot.CPUShells++;
                    labelShellsCPU.Text = Bot.CPUShells.ToString();
                    textBoxPlayer.Text = "Player blocks";
                    textBoxCPU.Text = "CPU reloads";
                }
                else if (Bot.CPUShells == 1 || Bot.CPUShells == 2)
                {
                    ClearTextBoxes();
                    Bot.CPUShells--;
                    labelShellsCPU.Text = Bot.CPUShells.ToString();
                    textBoxPlayer.Text = "Player blocks";
                    textBoxCPU.Text = "CPU shoots";
                }                                               
                                                
            }
            else if (Bot.RandomNumber == 1)
            {
                ClearTextBoxes();
                Bot.CPUShells++;
                labelShellsCPU.Text = Bot.CPUShells.ToString();
                textBoxPlayer.Text = "Player blocks";
                textBoxCPU.Text = "CPU reloads";
            }
            else if (Bot.RandomNumber == 2)
            {
               ClearTextBoxes();
                textBoxPlayer.Text = "Player blocks";
                textBoxCPU.Text = "CPU blocks";
            }
           

        }

        public void buttonShotgun_Click(object sender, EventArgs e)
        {

            if (Me.PlayerShells == 3)
            {
                if (Me.PlayerShells == 3 && Bot.CPUShells == 3)
                {                    
                    Bot.RandomNumber = 4;
                    ClearTextBoxes();
                    Bot.CPUShells = 0;
                    Me.PlayerShells = 0;
                    labelShells.Text = Me.PlayerShells.ToString();
                    labelShellsCPU.Text = Bot.CPUShells.ToString();
                    textBoxCPU.Text = "CPU used shotgun";
                    textBoxPlayer.Text = "Player used shotgun";
                    MessageBox.Show("It's a draw!");

                }
                else if (Me.PlayerShells == 3)
                {
                    ClearTextBoxes();
                    Me.PlayerShells = 0;
                    labelShells.Text = Me.PlayerShells.ToString();
                    textBoxPlayer.Text = "Player used Shoutgun";
                    textBoxCPU.Text = "CPU did not stand a chance against the Shotgun";
                    MessageBox.Show("Player has won the game by using Shotgun");
                }                
                
            }
            else if (Me.PlayerShells == 0 || Me.PlayerShells == 1 || Me.PlayerShells == 2)
            {
                ClearTextBoxes();
                textBoxPlayer.Text = "Player does not have 3 shells";
                textBoxCPU.Text = "CPU is waiting for Player to make a move";
            }
            
        }

        public void buttonAgain_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            Bot.CPUShells = 0;
            Me.PlayerShells = 0;
            labelShells.Text = Me.PlayerShells.ToString();
            labelShellsCPU.Text = Bot.CPUShells.ToString();
        }
        
    }
}
