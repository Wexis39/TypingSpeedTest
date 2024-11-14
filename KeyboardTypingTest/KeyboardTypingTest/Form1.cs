using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace KeyboardTypingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] words = {
    "ocean", "forest", "computer", "sunset", "keyboard", "mountain",
    "freedom", "science", "planet", "library", "jungle", "guitar",
    "happiness", "river", "adventure", "puzzle", "history", "city",
    "galaxy", "imagination", "mystery", "desert", "universe", "friendship",
    "energy", "storm", "garden", "shadow", "journey", "castle",
    "courage", "mirror", "fireplace", "nature", "dream", "thunder",
    "painting", "oasis", "memory", "festival", "voyage", "legend",
    "treasure", "wisdom", "horizon", "island", "whisper", "glacier",
    "volcano", "flower", "freedom", "bridge", "compass", "snowflake",
    "silence", "wisdom", "canyon", "rainbow", "village", "starlight",
    "harmony", "moonlight", "butterfly", "enigma", "wind", "sandstorm",
    "sunrise", "tranquility", "serenity", "sunshine", "illusion", "phoenix",
    "reflection", "companion", "peace", "pyramid", "knowledge", "wanderer",
    "miracle", "exploration", "rainforest", "lightning", "spark", "glow",
    "unity", "seeker", "map", "skyline", "cloud", "lighthouse", "stone",
    "whale", "cliff", "lunar", "solstice", "wonder", "captain", "light",
    "chamber", "secret", "tide", "tranquil", "twilight", "illumination",
    "philosophy", "valley", "meadow", "pinnacle", "summit", "abyss",
    "cavern", "horizon", "mirage", "sanctuary", "cascade", "paradise",
    "grove", "harbor", "lagoon", "reef", "diamond", "crystal", "riverbank",
    "sunbeam", "orchard", "waterfall", "starship", "journey", "frontier",
    "echo", "compassion", "landscape", "horizon", "glimmer", "harmony",
    "harvest", "infinity", "pathway", "passion", "nebula", "destination"
};

        Random rnd = new Random();
        int seconds;
        string[] words9 = new string[9];
        bool isStart = false;
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            picFinish.Hide();
            lblRank.Text = "";
            isStart = true;
            lblScore.Text = "Score:";
            txtInput.Text = "";
            currentNum = 0;
            lblTime.Text = "1:00";
            timer1.Start();
            seconds = 59;
            RandomWords();
            btnStart.Hide();
            flwPanelWords.Controls[currentNum].BackColor = Color.LightGray;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 1)
            {
                picFinish.Show();
                if (score <= 8)
                {
                    lblRank.Text = $"Your Score is: {score}\nYour Rank is: Very Slow";
                }
                else if(score > 8 && score <= 10)
                {
                    lblRank.Text = $"Your Score is: {score}\nYour Rank is: Slow";
                }
                else if (score > 10 && score <= 18)
                {
                    lblRank.Text = $"Your Score is: {score}\nYour Rank is: Average";
                }
                else if (score > 18 && score <= 26)
                {
                    lblRank.Text = $"Your Score is: {score}\nYour Rank is: Fast";
                }
                else if (score > 26 && score <= 38)
                {
                    lblRank.Text = $"Your Score is: {score}\nYour Rank is: Very Fast";
                }
                else if (score > 38 && score <= 50)
                {
                    lblRank.Text = $"Your Score is: {score}\nYour Rank is: Champion";
                }
                else if (score > 50)
                {
                    lblRank.Text = $"Your Score is: {score}\nYour Rank is: Legend";
                }
            }
            if (seconds == 1)
            {
                isStart =false;
            }
            if (seconds > 9)
            {
                lblTime.Text = $"0:{seconds.ToString()}";
            }
            else
            {
                lblTime.Text = $"0:0{seconds.ToString()}";
            }
            seconds--;
            if (seconds == 0)
            {
                timer1.Stop();
                btnStart.Show();
                lblTime.Text = "1:00";
                flwPanelWords.Controls.Clear();
            }
        }
        private void RandomWords()
        {
            for (int i = 0; i < 8; i++)
            {
                int randomNumber = rnd.Next(words.Length);
                string randomWord = words[randomNumber];
                words9[i] = randomWord;

                Label wordLabel = new Label();
                wordLabel.Text = words9[i];
                wordLabel.AutoSize = true;
                wordLabel.ForeColor = Color.Black;
                wordLabel.Font = new Font("Arial", 20, FontStyle.Bold);

                flwPanelWords.Controls.Add(wordLabel);
            }
        }
        bool nextLevel = false;
        private void LevelSys()
        {
            if (levelScores == 8)
            {
                nextLevel = true;
                levelScores = 0;
            }
        }

        int levelScores;
        int currentNum = 0;
        int score = 0;
        bool nextWord;
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (isStart)
            {
                WordControl();
                WordCheck();
                LevelSys();
                if (nextLevel)
                {
                    nextLevel = false;
                    flwPanelWords.Controls.Clear();
                    words9 = new string[9];
                    currentNum = 0;
                    RandomWords();
                }
            }

        }
        private void WordControl()
        {
            string currentWord = words9[currentNum];
            try
            {
                if (txtInput.Text == "")
                {
                    flwPanelWords.Controls[currentNum].BackColor = Color.LightGray;
                }
                if (txtInput.Text == currentWord)
                {
                    flwPanelWords.Controls[currentNum].ForeColor = Color.Green;
                    flwPanelWords.Controls[currentNum].BackColor = Color.White;
                    score += 1;
                    lblScore.Text = $"Score:{score.ToString()}";
                }

                for (int i = 0; i < txtInput.Text.Length; i++)
                {
                    if (txtInput.Text[i] == currentWord[i])
                    {
                        flwPanelWords.Controls[currentNum].BackColor = Color.LightGray;
                    }
                    else
                    {
                        flwPanelWords.Controls[currentNum].BackColor = Color.Red;
                        break;
                    }
                }
            }
            catch
            {
            }

        }
        private int ChangeNum()
        {
            currentNum++;
            return currentNum;
        }
        private void WordCheck()
        {
            if (txtInput.Text.Contains(" "))
            {
                if (flwPanelWords.Controls[currentNum].ForeColor != Color.Green)
                {
                    flwPanelWords.Controls[currentNum].ForeColor = Color.Red;
                    flwPanelWords.Controls[currentNum].BackColor = Color.White;
                }
                else
                {
                    flwPanelWords.Controls[currentNum].BackColor = Color.White;
                }
                ChangeNum();
                levelScores++;
                txtInput.Clear();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            score = 0;
            nextLevel = false;
            flwPanelWords.Controls.Clear();
            words9 = new string[9];
            currentNum = 0;
            button1_Click_1(this, EventArgs.Empty);
        }
    }
}
