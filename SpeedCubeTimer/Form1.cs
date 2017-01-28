using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SpeedCubeTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //initialize variables
        String scramble;

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrUpdatesPerSecond.Start();
            scramble = Scrambler();
            txtScramble.Text = scramble;
            
        }

        //initialize more variables
        Stopwatch stpTimer = new Stopwatch();
        bool blTimer = false;
        int intSolves = 0;
        TimeSpan tsTimer;
        List<string> lstScrambles = new List<string>();
        List<TimeSpan> lstTimes = new List<TimeSpan>();
        String Best = "100000000";
        
        

        //click button
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartStop();
        }


        //updated timer
        private void tmrUpdatesPerSecond_Tick(object sender, EventArgs e)
        {
            tsTimer = stpTimer.Elapsed;
            txtTimer.Text = TimeFormatter(tsTimer);
        }

        //scrambler
        private string Scrambler()
        {
            String scramble = "";
            Random rnd = new Random();
            int number;
            int prevNumber = 0;
            String letter = "";
            String[] NormalLetters = new String[12] {"R", "R'", "L", "L'", "F", "F'", "B", "B'", "U", "U'", "D", "D'", };
            String[] DoubleLetters = new String[12] { "2R", "2R", "2L", "2L", "2F", "2F", "2B", "2B", "2U", "2U", "2D", "2D", };

            for (int i = 0; i < 20; ++i)
            {

                number = rnd.Next(1, 12);

                if (prevNumber != number)
                {
                    letter = NormalLetters[number];
                    prevNumber = number;
                }
                else
                {
                    letter = DoubleLetters[number];
                    prevNumber = 0;
                    ++i;
                }

                scramble += "  " + letter;
            }
            return scramble;
        }

        //time formatter
        private string TimeFormatter(TimeSpan ts)
        {
            string Timer = "";

            if (stpTimer.ElapsedMilliseconds > 3.6e+6)
            {
                Timer = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }
            else if (stpTimer.ElapsedMilliseconds > 60000)
            {
                Timer = String.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }
            else
            {
                Timer = String.Format("{0:00}:{1:00}", ts.Seconds, ts.Milliseconds / 10);
            }

            return Timer;
        }


        //Start/stop
        private void StartStop()
        {
            //if it's stopped, start it. if it's started, stop it
            if (blTimer == false)
            {
                blTimer = true;
                btnStart.Text = "Stop";
                stpTimer.Restart();

                lstScrambles.Add(scramble);

                scramble = Scrambler();
                txtScramble.Text = scramble;


            }
            else
            {
                blTimer = false;
                btnStart.Text = "Start";
                stpTimer.Stop();
                lstTimes.Add(tsTimer);
                lstBoxScores.Items.Insert(0, intSolves + 1 + ".   " + TimeFormatter(tsTimer) + "   " + lstScrambles[intSolves]);


                if (stpTimer.ElapsedMilliseconds < Convert.ToInt32(Best))
                {
                    Best = Convert.ToString(stpTimer.ElapsedMilliseconds);
                    txtBest.Text = TimeFormatter(tsTimer) + "   " + lstScrambles[intSolves];
                }

                intSolves++;
            }
        }

  
    }
}
