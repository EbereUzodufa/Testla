using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Threading;
using System.Speech.Synthesis;

namespace JarvisCSharp
{
    public partial class Form2 : Form
    {
        public SpeechRecognitionEngine recognizer;

        public Grammar grammar;

        public Thread RecThread;
        public Boolean RecognizerState = true;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Here we first need to setup the grammar rules:

            GrammarBuilder build = new GrammarBuilder();
            build.AppendDictation();

            grammar = new Grammar(build);

            //In here we initialize the recognizer and setup its events:

            recognizer = new SpeechRecognitionEngine();
            recognizer.LoadGrammar(grammar);
            recognizer.SetInputToDefaultAudioDevice();

            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

            //Here will initialize the recognizer thread:

            RecognizerState = true;
            RecThread = new Thread(new ThreadStart(RecThreadFunction));
            RecThread.Start();



        }
        public void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //Recognizer recognizes the speech

            if (!RecognizerState)
                return;

            this.Invoke((MethodInvoker)delegate
            {
                textBox1.Text += (" " + e.Result.Text.ToLower());
                //This will add a space between each word you say
            });
        }
        public void RecThreadFunction()
        {
            //This is on separate threads. Will loop the recognizer when receiving calls

            while (true)
            {
                try
                {
                    recognizer.Recognize();
                }
                catch
                {
                    //Handles errors
                    //Won't hear you, nothing will happen
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecognizerState = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecognizerState = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Searches google for textbox result using your default browser.
            System.Diagnostics.Process.Start("https://www.google.com/#q=" + (textBox1.Text));
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecThread.Abort();
            RecThread = null;

            recognizer.UnloadAllGrammars();
            recognizer.Dispose();

            grammar = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            int kc = Convert.ToInt32(textBox2.Text);
            speechSynthesizer.Rate = kc;
           // speechSynthesizer.State = VoiceGender.Female;
            speechSynthesizer.SelectVoiceByHints(VoiceGender.Male);
            speechSynthesizer.Speak(textBox1.Text);
            speechSynthesizer.Dispose();
        }
    }
}
