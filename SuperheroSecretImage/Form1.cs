using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SuperheroSecretImage
{
   
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer wmpJoker = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer wmpVenom = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer wmpWolv = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer wmpCat = new WMPLib.WindowsMediaPlayer();


        public Form1()
        {
            InitializeComponent();
            wmp.URL = "Dlya_supergeroev_-_Supergerojskaya_muzyka_(Gybka.com).mp3";
            wmpJoker.URL = "Джокер - Смех (www.hotplayer.ru).mp3";
            wmpVenom.URL = "Мы Веном We Are Venom 2018 Rus.mp3";
            wmpWolv.URL = "Радиоктивные Люди - заставка (www.hotplayer.ru).mp3";
            wmpCat.URL= "Животные - Мурчание Кота (www.hotplayer.ru).mp3";
            wmpJoker.controls.stop();
            wmpWolv.controls.stop();
            wmpCat.controls.stop();
            wmpVenom.controls.stop();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Spider;
            wmp.controls.play();
            wmpJoker.controls.stop();
            wmpWolv.controls.stop();
            wmpCat.controls.stop();
            wmpVenom.controls.stop();
        }

        private void BatmenButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Batmen1;
            wmp.controls.play();
            wmpJoker.controls.stop();
            wmpWolv.controls.stop();
            wmpCat.controls.stop();
            wmpVenom.controls.stop();
        }

        private void CatwomenButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.catwomen;
            wmp.controls.play();
            wmpJoker.controls.stop();
            wmpWolv.controls.stop();
            wmpCat.controls.stop();
            wmpVenom.controls.stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Wolwerine;
            wmp.controls.play();
            wmpJoker.controls.stop();
            wmpWolv.controls.stop();
            wmpCat.controls.stop();
            wmpVenom.controls.stop();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > Size.Width/4&e.X<Size.Width/3.5)
            {
                if (e.Y > Size.Height/4.5&e.Y<Size.Height/3)
                {
                    wmp.controls.stop();
                    wmpJoker.controls.play();
                    this.BackgroundImage = Properties.Resources.Batmen_Joker;
                    BatmenButton.BackColor = Color.Red;
                    WolverineButton.BackColor = Color.Red;
                    SpiderButton.BackColor = Color.Red;
                    CatwomenButton.BackColor = Color.Red;
                }
            }
            if (e.X < Size.Width / 1 & e.X > Size.Width / 1.5)
            {
                if (e.Y > Size.Height / 4 & e.Y < Size.Height / 3.5)
                {
                    wmp.controls.stop();
                    wmpVenom.controls.play();
                    this.BackgroundImage = Properties.Resources.venom;
                    BatmenButton.BackColor = Color.White;
                    WolverineButton.BackColor = Color.White;
                    SpiderButton.BackColor = Color.White;
                    CatwomenButton.BackColor = Color.White;
                }
            }
            if (e.X < Size.Width / 1 & e.X > Size.Width / 1.5)
            {
                if (e.Y < Size.Height / 1 & e.Y > Size.Height / 1.5)
                {
                    wmp.controls.stop();
                    wmpCat.controls.play();
                    this.BackgroundImage = Properties.Resources.catbat;
                    BatmenButton.BackColor = Color.Gray;
                    WolverineButton.BackColor = Color.Gray;
                    SpiderButton.BackColor = Color.Gray;
                    CatwomenButton.BackColor = Color.Gray;
                }
            }
            if (e.X > Size.Width / 4 & e.X < Size.Width /3.5)
            {
                if (e.Y < Size.Height / 1 & e.Y > Size.Height / 1.5)
                {
                    wmp.controls.stop();
                    wmpWolv.controls.play();
                    this.BackgroundImage = Properties.Resources.logan2;
                    BatmenButton.BackColor = Color.Yellow;
                    WolverineButton.BackColor = Color.Yellow;
                    SpiderButton.BackColor = Color.Yellow;
                    CatwomenButton.BackColor = Color.Yellow;
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
