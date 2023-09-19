using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShotGunSpel
{
    public partial class ShotgunSpel : Form
    {
        private SoundPlayer soundPlayerShoot = new SoundPlayer(@"D:\Visual Studio c#\ShotGunSpel\shoot.wav");
        private SoundPlayer soundPlayerLoad = new SoundPlayer(@"D:\Visual Studio c#\ShotGunSpel\load.wav");
        private SoundPlayer soundPlayerBlock = new SoundPlayer(@"D:\Visual Studio c#\ShotGunSpel\block.wav");
        private SoundPlayer soundPlayerVictory = new SoundPlayer(@"D:\Visual Studio c#\ShotGunSpel\victory.wav");

        private int Player1Bullet = 0;
        private int Player2Bullet = 0;
        private bool isMuted = true;
        private string playerAction;
        private bool isGameOver = false;
        private string winnerName;



        public ShotgunSpel()
        {
            InitializeComponent();
            InitializeGame();
            DisplayInstructions();

        }

        private void DisplayInstructions()
        {
            string instructionsText = @"
            ****************Shotgun Game Rules*************

            Objective:
            - Defeat your opponent by using the ""Shotgun"" 
              move or strategically managing your shots.
 
            Player Actions:
            1. **Shoot**:
               - Costs one shot.
               - You lose a shot if your opponent Blocks.
               - If both players ""Shoot,"" no one wins, but 
                 both lose a shot.
                 

            2. **Load**:
               - Gains one shot.
               - Your opponent's action doesn't affect your 
                 shot count.

            3. **Block**:
               - Defends against your opponent's Shoot.
               - You don't lose shots if your opponent 
                 Shoots.


            Special Move:
            - Use ""Shotgun"" when you have at least three 
              shots to instantly win the game.
              

            Gameplay:
            - Both players start with zero shots.
            - Players take turns choosing actions.
            - The computer's action is randomly 
              determined.
            - The game ends when a player wins, or it's a 
              tie.
            - You can play again after the game ends.

            Winning:
            - Use Shotgun with three or more shots to win.
            - Alternatively, outsmart your opponent by 
              managing your shots effectively.
              

            ****************Enjoy the Shotgun Game!****************
            ";

            InstructionstextBox.Text = instructionsText;
            InstructionstextBox.Select(0, 18);
            InstructionstextBox.SelectionAlignment = HorizontalAlignment.Left;
            InstructionstextBox.SelectionFont = new Font(InstructionstextBox.Font, FontStyle.Bold);
        }

        private void InitializeGame()
        {
            Player1Bullet = 0;
            Player2Bullet = 0;
            lblPlayerBullets.Text = $"Bullets: {Player1Bullet}";
            lblPlayerBullets2.Text = $"Bullets: {Player2Bullet}";
            victorybtn.Enabled = false;
            listBox1.Items.Clear();
        }

        private void UpdateBulletLabels()
        {
            lblPlayerBullets.Text = $"Bullets: {Player1Bullet}";
            lblPlayerBullets2.Text = $"Bullets: {Player2Bullet}";
        }

        private string ComputerAction()
        {

            if (Player2Bullet <= 0)
            {
                Random random = new Random();
                int action = random.Next(1, 3);

                switch (action)
                {
                    case 1:
                        player2.Text = "Load";
                        return "Load";
                    case 2:
                        player2.Text = "Block";
                        return "Block";
                    default:
                        return "Unknown";
                }
            }
            else
            {
                Random random = new Random();
                int action = random.Next(1, 4);

                switch (action)
                {
                    case 1:
                        player2.Text = "Shoot";
                        return "Shoot";
                    case 2:
                        player2.Text = "Load";
                        return "Load";
                    case 3:
                        player2.Text = "Block";
                        return "Block";
                    default:
                        return "Unknown";
                }
            }
        }

        private void PerformPlayerAction(string action)
        {
            if (isGameOver)
            {
                return;
            }

            string computerAction = ComputerAction();

            UpdateBulletLabels();

            switch (action)
            {
                case "Shoot":
                    if (Player1Bullet > 0)
                    {
                        if (computerAction == "Load")
                        {
                            listBox1.Items.Clear();
                            listBox1.Items.Add($"{playerNameLabel.Text} wins the game with Shotgun!");
                            winnerName = playerNameLabel.Text;
                            victorybtn.Enabled = true;
                            isGameOver = true;
                            btnShoot.Enabled = false;
                            btnLoad.Enabled = false;
                            btnBlock.Enabled = false;
                            return;
                        }
                        else if (computerAction == "Block")
                        {
                            listBox1.Items.Clear();
                            listBox1.Items.Add($"{playerNameLabel.Text} loses a shot!");
                            Player1Bullet--;
                        }
                        else if (computerAction == "Shoot")
                        {
                            listBox1.Items.Clear();
                            listBox1.Items.Add("Both players lose a shot!");
                            Player1Bullet--;
                            Player2Bullet--;
                        }
                    }
                    break;

                case "Load":
                    if (computerAction == "Load")
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add("Both players get a shot.");
                        Player1Bullet++;
                        Player2Bullet++;
                    }
                    else if (computerAction == "Block")
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add($"{playerNameLabel.Text} gets an extra shot.");
                        Player1Bullet++;
                    }
                    else if (computerAction == "Shoot")
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add($" ThunderBolt wins the game with Shotgun!");
                        winnerName = "ThunderBolt";
                        victorybtn.Enabled = true;
                        isGameOver = true;
                        btnShoot.Enabled = false;
                        btnLoad.Enabled = false;
                        btnBlock.Enabled = false;
                        return;
                    }
                    break;

                case "Block":
                    if (computerAction == "Load")
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add("Thunderbolt gets a shot.");

                        Player2Bullet++;
                    }
                    else if (computerAction == "Block")
                    {
                        listBox1.Items.Clear();
                    }
                    else if (computerAction == "Shoot")
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add($" ThunderBolt loasing one shot!");
                        Player2Bullet--;
                    }
                    break;
            }
            CheckForWin();
        }


        private void CheckForWin()
        {
            if (Player1Bullet >= 3 && Player2Bullet >= 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("It's a Tie");
                victorybtn.Enabled = false;
                isGameOver = true;
                btnShoot.Enabled = false;
                btnLoad.Enabled = false;
                btnBlock.Enabled = false;
            }
            else if (Player1Bullet >= 3)
            {
                listBox1.Items.Clear();
                victorybtn.Enabled = true;
                listBox1.Items.Add($"{playerNameLabel.Text} wins the game.");
                winnerName = playerNameLabel.Text;
                isGameOver = true;
                btnShoot.Enabled = false;
                btnLoad.Enabled = false;
                btnBlock.Enabled = false;
            }
            else if (Player2Bullet >= 3)
            {
                listBox1.Items.Clear();
                victorybtn.Enabled = true;
                listBox1.Items.Add("ThunderBolt wins the game.");
                winnerName = "ThunderBolt";
                isGameOver = true;
                btnShoot.Enabled = false;
                btnLoad.Enabled = false;
                btnBlock.Enabled = false;
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {

            if (isMuted)
            {
                btnMute.BackgroundImage = Image.FromFile(@"D:\Visual Studio c#\ShotGunSpel\unmute.png");
                isMuted = false;

            }
            else
            {
                btnMute.BackgroundImage = Image.FromFile(@"D:\Visual Studio c#\ShotGunSpel\mute.png");
                isMuted = true;

            }

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {

            if (Player1Bullet > 0)
            {
                playerAction = "Shoot";
                PerformPlayerAction(playerAction);
                UpdateBulletLabels();
                if (isMuted)
                {
                    soundPlayerShoot.Play();
                }
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            playerAction = "Load";
            PerformPlayerAction(playerAction);
            UpdateBulletLabels();
            if (isMuted)
            {
                soundPlayerLoad.Play();
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            playerAction = "Block";
            PerformPlayerAction(playerAction);
            UpdateBulletLabels();
            if (isMuted)
            {
                soundPlayerBlock.Play();
            }
        }

        private void victorybtn_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox1.Items.Add($"{winnerName} is the winner!");

            if (isMuted)
            {
                soundPlayerVictory.Play();
            }


        }

        private void txtPlayerName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string playerName = txtPlayerName.Text.Trim();
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (!string.IsNullOrEmpty(playerName))
                {
                    playerNameLabel.Text = playerName;
                    txtPlayerName.Clear();
                    this.ActiveControl = null;
                    nameRequiredLabel.Text = "";
                    InitializeGame();
                }
                else
                {
                    nameRequiredLabel.Text = "Please enter a valid player name.";
                }
            }
        }

        private void PlayAgainbtn_Click(object sender, EventArgs e)
        {
            InitializeGame();
            isGameOver = false;
            playerNameLabel.Text = "";
            btnShoot.Enabled = true;
            btnLoad.Enabled = true;
            btnBlock.Enabled = true;
        }


    }
}
