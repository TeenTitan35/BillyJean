using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SoundplayerTutor
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer;
        public Form1()
        {
            InitializeComponent();
            SetBut();
        }

        public void SetBut()
        {
            button2.Image = Image.FromFile("C:\\Games\\джинн.jpg");
            // Align the image and text on the button.
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            // Give the button a flat appearance.
            button2.FlatStyle = FlatStyle.Flat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _soundPlayer = new SoundPlayer("билли.wav");
            if (button1.Focused)
            {
                _soundPlayer.Play();
                System.Threading.Thread.Sleep(1);
            }
            else
            {
                _soundPlayer.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            _soundPlayer = new SoundPlayer("джинн.wav");
            if (button2.Focused)
            {
                _soundPlayer.Play();
                System.Threading.Thread.Sleep(1);
            }
            else
            {
                _soundPlayer.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _soundPlayer = new SoundPlayer("насрал.wav");
            if (button3.Focused)
            {
                _soundPlayer.Play();
                System.Threading.Thread.Sleep(1);
            }
            else
            {
                _soundPlayer.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _soundPlayer = new SoundPlayer("кувшин.wav");
            if (button4.Focused)
            {
                _soundPlayer.Play();
                
                System.Threading.Thread.Sleep(1);
            }
            else
            {
                _soundPlayer.Stop();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _soundPlayer = new SoundPlayer("ау.wav");
            if (button5.Focused)
            {
                _soundPlayer.Play();
                System.Threading.Thread.Sleep(1);
            }
            else
            {
                _soundPlayer.Stop();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _soundPlayer = new SoundPlayer("ауау.wav");
            if (button6.Focused)
            {
                _soundPlayer.Play();
                System.Threading.Thread.Sleep(1);
            }
            else
            {
                _soundPlayer.Stop();
            }
        }
    }
}
