using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;





namespace Mike_Helps_us
{
    public partial class Form2 : Form
    {

        public Form2(String name)
        {
            InitializeComponent();
            label1.Text = "Hola " + name + " " + "Vamos a jugar";
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Vaca");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Gallo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Caballo");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Puerco");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Gato");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Conejo");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Perro");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Pato");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("cordero");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Guajolote");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Pollos");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Gallina");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Burro");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Mike = new SpeechSynthesizer();
            Mike.Volume = 100;
            Mike.Rate = 0;
            Mike.SpeakAsync("Toro");
        }
    }

}
