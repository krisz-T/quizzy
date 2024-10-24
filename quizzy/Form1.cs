using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Threading;
using System.Diagnostics;

namespace quizzy
{
    public partial class Form1 : Form
    {
        //Különböző hangeffektek betöltése, melyek egyes eseményeknél szólnak majd
        //a "kerdes_szam" változó tartalmazni fog egy véletlenszerű számot, mely a kérdéseket választja ki
        //a "sorrend" a lehetséges válaszok véletlenszerűségéhez szükségeltetik a későbbiekben
        System.Media.SoundPlayer helyes = new System.Media.SoundPlayer(@"fajlok/helyes.wav");
        System.Media.SoundPlayer helytelen = new System.Media.SoundPlayer(@"fajlok/helytelen.wav");
        System.Media.SoundPlayer nyertel = new System.Media.SoundPlayer(@"fajlok/nyertel.wav");
        System.Media.SoundPlayer help = new System.Media.SoundPlayer(@"fajlok/help.wav");
        System.Media.SoundPlayer nincs_help = new System.Media.SoundPlayer(@"fajlok/nincs_help.wav");

        int kerdes_szam;

        int[] sorrend = { 1, 2, 3, 4 };

        int helyes_valaszok_szama = 0;
        List<int> list = new List<int>();
        bool van_help;
        int maradek_ido;

        //Egy kérdés objektum mely funkciókkal nem rendelkezik, csupán segít egyszerűen tárolni az összefüggő adatokat
        public class kerdes
        {
            public string szoveg;
            public string valasz_1, valasz_2, valasz_3, valasz_4;
            public string helyes_valasz, csel_valasz;
        }

        kerdes jelen = new kerdes();

        //A fenti "sorrend" array-ben lévő 4 számot véletlenszerűen átrendezi | A gombok sorrendjéhez kell - mindig máshol legyen a helyes válasz
        public void random_sorrend_gombok()
        {
            var rng = new Random();
            var keys = sorrend.Select(e => rng.NextDouble()).ToArray();

            Array.Sort(keys, sorrend);
        }

        //Ez az alprogram a kérdés fájl feldolgozásával és tárolásával foglalkozik
        public void uj_kerdes()
        {
            //Tudatjuk a programmal meddig generálhat random számokat
            int kerdesek_szama = File.ReadLines(@"fajlok/kerdesek_1.txt").Count();
            Random rnd = new Random();
            kerdes_szam = rnd.Next(0, kerdesek_szama);
            
            //Ne kapjuk ugyanazt a kérdést egy játékban
            while(list.Contains(kerdes_szam))
            {
                kerdes_szam = rnd.Next(0, kerdesek_szama);
            }
            list.Add(kerdes_szam);

            //A random generált szám sorát beolvassuk a fájlból
            string sor = File.ReadLines("fajlok/kerdesek_1.txt").Skip(kerdes_szam).Take(1).First();

            // ;-vel van elválasztva a kérdés szövege és a lehetséges válaszok a fájlban
            string[] elvalasztott_sor = sor.Split(';');

            //Elkezdjük raktározni az adatokat a "jelen" objektumba
            jelen.szoveg = elvalasztott_sor[0];
            random_sorrend_gombok();
            jelen.valasz_1 = elvalasztott_sor[sorrend[0]];
            jelen.valasz_2 = elvalasztott_sor[sorrend[1]];
            jelen.valasz_3 = elvalasztott_sor[sorrend[2]];
            jelen.valasz_4 = elvalasztott_sor[sorrend[3]];
            //MEGJEGYZÉS: a kérdések fájlban mindig a szöveg után írt válasz kell a helyes legyen, ezért "elvalasztott_sor[1] a helyes"
            //A csel válasz egy buta lehetséges válasz amit senki sem választana
            jelen.helyes_valasz = elvalasztott_sor[1];
            jelen.csel_valasz = elvalasztott_sor[4];

            kerdes_mezo.Text = jelen.szoveg;
            v1_gomb.Text = jelen.valasz_1;
            v2_gomb.Text = jelen.valasz_2;
            v3_gomb.Text = jelen.valasz_3;
            v4_gomb.Text = jelen.valasz_4;

            //Lesz egy segítsége játékosoknak ami eltüntet egy lehetséges választ, ez mindig a csel válasz lesz | Ez minden kérdésnél visszaállítja a gombokat
            v1_gomb.Visible = true;
            v2_gomb.Visible = true;
            v3_gomb.Visible = true;
            v4_gomb.Visible = true;

            maradek_ido = 20;
            masodpercek.Start();

        }

        //Ez fog futni ha a játékos veszít | csúnya hang + visszaállítja a kezdőértékeket + indít egy újat
        public void game_over()
        {
            list.Clear();
            helytelen.Play();
            MessageBox.Show("VESZTETTÉL!", "GAME OVER");
            helyes_valaszok_szama = 0;
            kerdes_szamolo.Text = Convert.ToString(helyes_valaszok_szama+1);
            van_help = true;
            uj_kerdes();
        }

        //Ez fog futni ha a játékos nyert | taps + visszaállítja a kezdőértékeket + eldöntheti a játékos, hogy újrakezdi-e
        public void game_won()
        {
            list.Clear();
            nyertel.Play();
            DialogResult ujra=MessageBox.Show("Nyertél!", ":D", MessageBoxButtons.RetryCancel);
            if(ujra==DialogResult.Cancel)
            {
                Close();
            }
            else
            {
                nyertel.Stop();
                helyes_valaszok_szama = 0;
                kerdes_szamolo.Text = Convert.ToString(helyes_valaszok_szama+1);
                van_help = true;
                uj_kerdes();
            }
        }

        public Form1()
        {
            InitializeComponent();
            van_help = true;
            uj_kerdes();
            kerdes_szamolo.Text = Convert.ToString(helyes_valaszok_szama+1);
            maradek_ido = 20;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void kerdes_mezo_TextChanged(object sender, EventArgs e)
        {

        }


        //Minden gombnyomásnál leteszteli, hogy nyert-e a játékos, ha nem, akkor dob egy új kérdést és számlálja a helyes válaszokat
        public void jo_dontes()
        {
            helyes.Play();
            if(helyes_valaszok_szama == 9)
            {
                game_won();
            }
            else
            {
                uj_kerdes();
                helyes_valaszok_szama += 1;
                kerdes_szamolo.Text = Convert.ToString(helyes_valaszok_szama+1);
            }
        }

        //Kb. 60 sor egyszerű alprogram meghívások és stilisztikai döntések
        private void v1_gomb_Click(object sender, EventArgs e)
        {
            if (v1_gomb.Text==jelen.helyes_valasz)
            {
                jo_dontes();
            }
            else
            {
                v1_gomb.BackColor = Color.Red;
                game_over();
                v1_gomb.BackColor = Color.Transparent;
            }
        }

        private void v2_gomb_Click(object sender, EventArgs e)
        {
            if (v2_gomb.Text == jelen.helyes_valasz)
            {
                jo_dontes();
            }
            else
            {
                v2_gomb.BackColor = Color.Red;
                game_over();
                v2_gomb.BackColor = Color.Transparent;
            }
        }

        private void v3_gomb_Click(object sender, EventArgs e)
        {
            if (v3_gomb.Text == jelen.helyes_valasz)
            {
                jo_dontes();
            }
            else
            {
                v3_gomb.BackColor = Color.Red;
                game_over();
                v3_gomb.BackColor = Color.Transparent;
            }
        }

        private void v4_gomb_Click(object sender, EventArgs e)
        {
            if (v4_gomb.Text == jelen.helyes_valasz)
            {
                jo_dontes();
            }
            else
            {
                v4_gomb.BackColor = Color.Red;
                game_over();
                v4_gomb.BackColor = Color.Transparent;
            }
        }

        private void kerdes_szamolo_TextChanged(object sender, EventArgs e)
        {

        }

        //A játékosok segítség gombja | egy van belőle játékonként
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(van_help==true)
            {
                help.Play();
                if (v1_gomb.Text == jelen.csel_valasz) v1_gomb.Visible = false;
                else if (v2_gomb.Text == jelen.csel_valasz) v2_gomb.Visible = false;
                else if (v3_gomb.Text == jelen.csel_valasz) v3_gomb.Visible = false;
                else if (v4_gomb.Text == jelen.csel_valasz) v4_gomb.Visible = false;
                van_help = false;
            }
            else
            {
                nincs_help.Play();
                MessageBox.Show("Nem maradt segítséged.", "Hoppá!");
            }
        }

        //Visszaszámláló + kirajzolja a maradék időt, ha letelik, vesztett a játékos
        private void masodpercek_Tick(object sender, EventArgs e)
        {
            masodperc_mutato.Text = maradek_ido--.ToString();
            if(maradek_ido < 0)
            {
                masodpercek.Stop();
                game_over();
            }
            if(Convert.ToInt32(masodperc_mutato.Text)>10) masodperc_mutato.ForeColor = Color.Green;
            else if (Convert.ToInt32(masodperc_mutato.Text) <= 10 && Convert.ToInt32(masodperc_mutato.Text) > 5) masodperc_mutato.ForeColor = Color.Orange;
            else if (Convert.ToInt32(masodperc_mutato.Text) <= 5) masodperc_mutato.ForeColor = Color.Red;
        }
    }
}

// Balázs Krisztián-Zsombor
