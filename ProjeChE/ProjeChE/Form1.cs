using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graph = System.Windows.Forms.DataVisualization.Charting;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace ProjeChE
{
    public partial class Form1 : Form
    {
        //
        //Fenske
        //
        double LKB;
        double HKB;
        double LKD;
        double HKD;
        double RelavolaLK;
        double RelavolaHK;
        double numberofstage;
  
        //
        //McCabe Thiele
        //
        //For graph
        double graphmin = 0;
        double graphmax = 1.1;
        double graphinterval = 0.1;

        //
        //Voice and Speech
        //
        public SpeechRecognitionEngine recognizer;
        public Grammar grammar;
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();


        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.Icon =@"C:\Users\Ebere\Documents\Visual Studio 2013\Projects\ProjeChE\ProjeChE\bin\Debug\Logomakr_7mh2NY.ico";
            label5.Left = (label5.Parent.Width / 2) - (label5.Width / 2);
            //
            //Fenske
            labelLK.Hide();
            labelHK.Hide();
            radioButton1.Checked = true;
            comboBox1.Items.Add("Kg/h");
            comboBox1.Items.Add("g/h");
            comboBox1.Items.Add("Kg/s");
            comboBox1.Items.Add("g/s");
            comboBox1.Items.Add("lb/h");
            comboBox1.Items.Add("lb/s");
            //
            //McCabe_Thiele
            RadioButtonrv.Checked = true;
            comboBoxUni.SelectedIndex = 1;
            ListBoxbottomx.Items.Clear();
            ListBoxbottomy.Items.Clear();
            ListBoxtopx.Items.Clear();
            ListBoxtopy.Items.Clear();
            ListBoxx.Items.Clear();
            ListBoxy.Items.Clear();
            ListBoxzx.Items.Clear();
            ListBoxzy.Items.Clear();
            chart1.Series.Clear();
            TextBoxq.Clear();
            TextBoxx.Clear();
            TextBoxy.Clear();
            TextBoxR.Clear();
            TextBoxrelvol.Clear();
            TextBoxXab.Clear();
            TextBoxXad.Clear();
            TextBoxZf.Clear();

            //Add Components to ComboBox
            for (int i = 0; i < listBoxCompForm.Items.Count; i++)
            {
                string formula = listBoxCompForm.Items[i].ToString();
                string CompName = listBoxCompName.Items[i].ToString();
                comboBoxComp.Items.Add(CompName + " | " + formula);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.White;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Show Fenske Page
            tabControl1.SelectedTab = tabPageFenskeCalc;
        }

        private void button4_Click(object sender, EventArgs e)//Add components
        {

            string textofbottom = (textBoxBottom.Text).Trim();
            string textoffeed = (textBoxFeed.Text).Trim();
            string textofdistillate = (textBoxDistillate.Text).Trim();
            string textofrelativevola = (textBoxRelativeVolate.Text).Trim();
            double Ntester = 0; //test for numbers

            if (textBoxBottom.Text == "" || textBoxDistillate.Text == ""
                || textBoxComponent.Text == "" || textBoxFeed.Text == "" || textBoxRelativeVolate.Text == "")
            // Check if any the textboxes for Component values are empty, if true then
            {
                MessageBox.Show("Please Go Through Data You Entered, Some boxes are empty");
                return;
            }
            else // Check if any the textboxes for Component values are empty, if false then
            {
                foreach (char OneCharacterbottom in textofbottom) //if a non numeric character is entered in Bottom Value
                {
                    string ConChar = Convert.ToString(OneCharacterbottom);

                    if (double.TryParse(ConChar, out Ntester) || ConChar == ".")
                    {
                        //Continue
                    }
                    else
                    {
                        MessageBox.Show("The Bottom Value Contains a Non Numeric Character: " + ConChar);
                        return;
                    }
                }

                foreach (char OneCharacterdistillate in textofdistillate)//if a non numeric character is entered in Distillate Value
                {
                    string ConChar = Convert.ToString(OneCharacterdistillate);

                    if (double.TryParse(ConChar, out Ntester) || ConChar == ".")
                    {
                        //Continue
                    }
                    else
                    {
                        MessageBox.Show("The Distillate Value Contains a Non Numeric Character: " + ConChar);
                        return;
                    }
                }

                foreach (char OneCharacterfeed in textoffeed)//if a non numeric character is entered in Feed Value
                {
                    string ConChar = Convert.ToString(OneCharacterfeed);

                    if (double.TryParse(ConChar, out Ntester) || ConChar == ".")
                    {
                        //Continue
                    }
                    else
                    {
                        MessageBox.Show("The Feed Value Contains a Non Numeric Character: " + ConChar);
                        return;
                    }
                }

                foreach (char OneCharacterrelative in textofrelativevola)//if a non numeric character is entered in Feed Value
                {
                    string ConChar = Convert.ToString(OneCharacterrelative);

                    if (double.TryParse(ConChar, out Ntester) || ConChar == ".")
                    {
                    }
                    else
                    {
                        MessageBox.Show("The Relative Volatility Value Contains a Non Numeric Character: " + ConChar);
                        return;
                    }
                }

                double txtbtt = Convert.ToDouble(textBoxBottom.Text);
                double txtdist = Convert.ToDouble(textBoxDistillate.Text);
                double txtfeed = Convert.ToDouble(textBoxFeed.Text);
                double txtrel = Convert.ToDouble(textBoxRelativeVolate.Text);

                listBoxBottom.Items.Add(txtbtt);
                listBoxDistillate.Items.Add(txtdist);
                listBoxFeed.Items.Add(txtfeed);
                listBoxRelativeVolatility.Items.Add(txtrel);
                listBoxComponent.Items.Add(textBoxComponent.Text);
            }

            // add to Serial Number
            int count;
            count = Convert.ToInt32(listBoxFeed.Items.Count);
            if (count>0)
            {
            listBoxSn.Items.Add(count);          
            }

            else
            {
                //Do nothing
            }

            //Refresh Textboxes
            textBoxBottom.Clear();
            textBoxComponent.Clear();
            textBoxFeed.Clear();
            textBoxRelativeVolate.Clear();
            textBoxDistillate.Clear();
            sum();
            comboBoxComp.Text = "--Select Component--";
        }

        private void button3_Click(object sender, EventArgs e) //Clear All
        {
            ClearFenske();
        }

        private void ClearFenske()
        {
            listBoxBottom.Items.Clear();
            listBoxComponent.Items.Clear();
            listBoxDistillate.Items.Clear();
            listBoxSn.Items.Clear();
            listBoxFeed.Items.Clear();
            listBoxRelativeVolatility.Items.Clear();
            textBoxBottom.Clear();
            textBoxComponent.Clear();
            textBoxDistillate.Clear();
            textBoxFeed.Clear();
            comboBoxComp.Text = "--Select Component--";
            sum();
            labelLK.Hide();
            labelHK.Hide();
            buttonStage.Text = "0";
        }

        private void buttonRemove_Click(object sender, EventArgs e) //Remove Component
        {
            try
            {
                double Ntester = 0; //test for numbers
                foreach (char OneCharacterRemove in textBoxRemove.Text) //if a non numeric character is entered in Bottom Value
                {
                    string ConChar = Convert.ToString(OneCharacterRemove);

                    if (double.TryParse(ConChar, out Ntester))
                    {
                        //Continue
                    }
                    else
                    {
                        MessageBox.Show("The Value Entered to Remove Contains a Non Numeric Character: " + ConChar);
                        return;
                    }
                }
                int remove;
                remove = Convert.ToInt32(textBoxRemove.Text) - 1;
                listBoxSn.Items.RemoveAt(remove);
                listBoxFeed.Items.RemoveAt(remove);
                listBoxRelativeVolatility.Items.RemoveAt(remove);
                listBoxDistillate.Items.RemoveAt(remove);
                listBoxComponent.Items.RemoveAt(remove);
                listBoxBottom.Items.RemoveAt(remove);

                sum();

                // Reset Serial Number
                listBoxSn.Items.Clear();
                int count;
                count = Convert.ToInt32(listBoxFeed.Items.Count);
                if (count>0)
                {
                    for (int i = 0; i < listBoxFeed.Items.Count; i++)
                    {
                         listBoxSn.Items.Add(i+1);                                
                    }

                }
                else
                {
                    //Do Nothing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sum() //Find sum of streams 
        {
            double sumfeed = 0;
            double sumdistillate = 0;
            double sumbottom = 0;
            if (listBoxFeed.Items.Count >= 1)
            {
                for (int i = 0; i <= listBoxSn.Items.Count - 1; i++)
                {
                    sumfeed = sumfeed + Convert.ToDouble(listBoxFeed.Items[i]);
                    sumdistillate = sumdistillate + Convert.ToDouble(listBoxDistillate.Items[i]);
                    sumbottom = sumbottom + Convert.ToDouble(listBoxBottom.Items[i]);
                }
            }
            labelsumbottom.Text = (Math.Round(sumbottom, 4)).ToString();
            Labelsumdistillate.Text = (Math.Round(sumdistillate, 4)).ToString();
            Labelsumfeed.Text = (Math.Round(sumfeed, 4)).ToString();

        }

        private void LKHK() //Find LK and HK when we have move than 3 component
        {
            ListBoxName.Items.Clear();
            ListBoxHK.Items.Clear();
            listBoxLK.Items.Clear();
            for (int i = 0; i < listBoxDistillate.Items.Count; i++)
            {
                if ((Convert.ToDouble(listBoxDistillate.Items[i]) > 0.0004) || (Convert.ToDouble(listBoxBottom.Items[i]) > 0.0004))
                {
                    //if this is mwt, add the following to the listbox
                    listBoxLKp.Items.Add(listBoxDistillate.Items[i]);
                    listBoxHkp.Items.Add(listBoxBottom.Items[i]);
                    ListBoxNamep.Items.Add(listBoxComponent.Items[i]);
                    ListBoxalphap.Items.Add(listBoxRelativeVolatility.Items[i]);

                }
                
                
               
            }

            for (int i = 0; i < listBoxLKp.Items.Count; i++)
            {
                if ((Convert.ToDouble(listBoxLKp.Items[i]) == 0.00) || (Convert.ToDouble(listBoxHkp.Items[i]) == 0.00))
                {
                    // Continue and Do not add
                }
                else
                {
                    //if this is mwt, add the following to the listbox
                    listBoxLK.Items.Add(listBoxLKp.Items[i]);
                    ListBoxHK.Items.Add(listBoxHkp.Items[i]);
                    ListBoxName.Items.Add(ListBoxNamep.Items[i]);
                    ListBoxalpha.Items.Add(ListBoxalphap.Items[i]);
                }
            }

            // Add to appropriate stream

            for (int i = 0; i < listBoxLKp.Items.Count; i++)
            {
                if ((Convert.ToDouble(listBoxLKp.Items[i]) == 0.00))
                {
                    //Bottom elements
                    listBoxHKVal.Items.Add(listBoxHkp.Items[i]);
                    listBoxNameHK.Items.Add(ListBoxNamep.Items[i]);
                }
                else if ((Convert.ToDouble(listBoxHkp.Items[i]) == 0.00))
                {
                    //Distillate Element
                    listBoxLKVal.Items.Add(listBoxLKp.Items[i]);
                    listBoxNameLK.Items.Add(ListBoxNamep.Items[i]);
                }
                else
                {
                    //Both streams
                    listBoxLKVal.Items.Add(listBoxLKp.Items[i]);
                    listBoxHKVal.Items.Add(listBoxHkp.Items[i]);
                    listBoxNameHK.Items.Add(ListBoxNamep.Items[i]);
                    listBoxNameLK.Items.Add(ListBoxNamep.Items[i]);
                }
            }

            if (listBoxLK.Items.Count>2)
            {
                //Assuming this section cannot have more or equal to 18 
                double[] complk = new double[18];
                double[] comphk = new double[18];
                double[] compalpha = new double[18];
                for (int i = 0; i < listBoxLK.Items.Count - 1; i++)
                {
                    complk[i] = Convert.ToDouble(listBoxLK.Items[i]);
                    comphk[i] = Convert.ToDouble(ListBoxHK.Items[i]);
                    compalpha[i] = Convert.ToDouble(ListBoxalpha.Items[i]);              
                }

             //to check the least and highest
                for (int i = 0; i < listBoxLK.Items.Count - 1; i++)
                {

                    //    to find light key

                    if ((complk[i] >= complk[1]) || (complk[i] >= complk[2]) || (complk[i] >= complk[3]) ||
                        (complk[i] >= complk[4]) || (complk[i] >= complk[5]) || (complk[i] >= complk[6]) ||
                        (complk[i] >= complk[7]) || (complk[i] >= complk[8]) || (complk[i] >= complk[9]) ||
                        (complk[i] >= complk[10]) || (complk[i] >= complk[11]) || (complk[i] >= complk[12]) ||
                        (complk[i] >= complk[13]) || (complk[i] >= complk[14]) || (complk[i] >= complk[15]) ||
                        (complk[i] >= complk[16]) || (complk[i] >= complk[17]) || (complk[i] >= complk[18]))
                    {
                        LKD = complk[i];
                        LKB = comphk[i];
                        RelavolaLK = compalpha[i];
                        labelLK.Text = "The Light Key is " + ListBoxName.Items[i];
                    }

                    //   to find heavy key

                    if ((comphk[i] >= comphk[1]) || (comphk[i] >= comphk[2]) || (comphk[i] >= comphk[3]) ||
                    (comphk[i] >= comphk[4]) || (comphk[i] >= comphk[5]) || (comphk[i] >= comphk[6]) ||
                    (comphk[i] >= comphk[7]) || (comphk[i] >= comphk[8]) || (comphk[i] >= comphk[9]) ||
                    (comphk[i] >= comphk[10]) || (comphk[i] >= comphk[11]) || (comphk[i] >= comphk[12]) ||
                    (comphk[i] >= comphk[13]) || (comphk[i] >= comphk[14]) || (comphk[i] >= comphk[15]) ||
                    (comphk[i] >= comphk[16]) || (comphk[i] >= comphk[17]) || (comphk[i] >= comphk[18]))
                    {
                        HKD = comphk[i];
                        HKB = comphk[i];
                        RelavolaHK = compalpha[i];
                        labelHK.Text = "The Heavy Key is " + ListBoxName.Items[i];
                    }
                }
  
            }

            else if (listBoxLK.Items.Count <= 2) 
            {
                double[] complk = new double[2];
                double[] comphk = new double[2];
                double[] compalpha = new double[2];

                for (int i = 0; i < listBoxLK.Items.Count ; i++)
                {
                    complk[i] = Convert.ToDouble(listBoxLK.Items[i]);
                    comphk[i] = Convert.ToDouble(ListBoxHK.Items[i]);
                    compalpha[i] = Convert.ToDouble(ListBoxalpha.Items[i]);
                }
               

                if (complk[0]>complk[1])
                {
                    //Light Key

                    LKD = Convert.ToDouble(listBoxLK.Items[0]);
                    LKB = Convert.ToDouble(ListBoxHK.Items[0]);
                    RelavolaLK = Convert.ToDouble(ListBoxalpha.Items[0]);
                    labelLK.Text = "The Light Key is " + ListBoxName.Items[0];

                    //Heavy Key

                    HKD = Convert.ToDouble(listBoxLK.Items[1]);
                    HKB = Convert.ToDouble(ListBoxHK.Items[1]);
                    RelavolaHK = Convert.ToDouble(ListBoxalpha.Items[1]);
                    labelHK.Text = "The Heavy Key is " + ListBoxName.Items[1];

                }
                else
                {
                    //Light Key

                    LKD = Convert.ToDouble(listBoxLK.Items[1]);
                    LKB = Convert.ToDouble(ListBoxHK.Items[1]);
                    RelavolaLK = Convert.ToDouble(ListBoxalpha.Items[1]);
                    labelLK.Text = "The Light Key is " + ListBoxName.Items[1];

                    //Heavy Key

                    HKD = Convert.ToDouble(listBoxLK.Items[0]);
                    HKB = Convert.ToDouble(ListBoxHK.Items[0]);
                    RelavolaHK = Convert.ToDouble(ListBoxalpha.Items[0]);
                    labelHK.Text = "The Heavy Key is " + ListBoxName.Items[0];

                }
            }
            labelLK.Show();
            labelHK.Show();
        }

        private void binary() //for binary mixture
        {
            if ((Convert.ToDouble(listBoxDistillate.Items[0])) > (Convert.ToDouble(listBoxDistillate.Items[1])))
            {
                LKD = (Convert.ToDouble(listBoxDistillate.Items[0]));
                LKB = (Convert.ToDouble(listBoxBottom.Items[0]));
                HKD = (Convert.ToDouble(listBoxDistillate.Items[1]));
                HKB = (Convert.ToDouble(listBoxBottom.Items[1]));
                RelavolaHK = (Convert.ToDouble(listBoxRelativeVolatility.Items[1]));
                RelavolaLK = (Convert.ToDouble(listBoxRelativeVolatility.Items[0]));
                labelHK.Text = "The Heavy Key is " + listBoxComponent.Items[1];
                labelLK.Text = "The Light Key is " + listBoxComponent.Items[0];
            }
            else
            {
                LKD = (Convert.ToDouble(listBoxDistillate.Items[1]));
                LKB = (Convert.ToDouble(listBoxBottom.Items[1]));
                HKD = (Convert.ToDouble(listBoxDistillate.Items[0]));
                HKB = (Convert.ToDouble(listBoxBottom.Items[0]));
                RelavolaHK = (Convert.ToDouble(listBoxRelativeVolatility.Items[0]));
                RelavolaLK = (Convert.ToDouble(listBoxRelativeVolatility.Items[1]));
                labelHK.Text = "The Heavy Key is " + listBoxComponent.Items[0];
                labelLK.Text = "The Light Key is " + listBoxComponent.Items[1];
            }
            labelLK.Show();
            labelHK.Show();
        }

        private void button5_Click(object sender, EventArgs e)//TO CALCULATE FENSKE
        {
            if ((Convert.ToInt32(buttonStage.Text)) !=0 )
            {
                tabControl1.SelectedTab=tabPageFenskeDia;
                return;
            }

            if ((Convert.ToInt32(listBoxComponent.Items.Count)) == 0)
            {
                MessageBox.Show("NO COMPONENT WAS ENTERED!!!");
                return;
            }

            else if (listBoxComponent.Items.Count == 1)
            {
                MessageBox.Show("NUMBER OF STAGES CANNOT BE CALCULATED USING JUST ONE COMPONENT!!!");
                return;
            }
            double DistillateRatio;  //LKD/HKD
            double BottomRatio;
            double RelavolaRatio;
            double numerator;
            double denominator;
            double numberofstage1;
            listBoxFed.Items.Clear();
            listBoxBott.Items.Clear();
            listBoxDist.Items.Clear();

            if (listBoxDistillate.Items.Count <= 2)
            {
                binary();
            }
            else if (listBoxDistillate.Items.Count > 2)
            {
                LKHK();
            }
            sum();
            DistillateRatio = LKD / HKD;
            BottomRatio = HKB / LKB;
            RelavolaRatio = RelavolaLK / RelavolaHK;
            string dist = null;
            string kim = null;
            //To calculate numerator of Fenske
            numerator = Math.Log10(DistillateRatio * BottomRatio);
            denominator = Math.Log10(RelavolaRatio);
            numberofstage1 = numerator / denominator;
            numberofstage = Math.Round(numberofstage1, 2);
            //MessageBox.Show("The Number Of Stages is " + numberofstage);
            buttonStage.Text = numberofstage.ToString();
            for (int i = 0; i <= listBoxFeed.Items.Count - 1; i++)
            {
                kim =(listBoxComponent.Items[i].ToString() + " | " + listBoxFeed.Items[i]);
                listBoxFed.Items.Add(kim);
            }
            

            string light = null;
            string heavy = null;
            string light1 = null;
            string heavy1 = null;

            //Add to streams

            if (listBoxDistillate.Items.Count == 2)
            {
                for (int j = 0; j <= listBoxDistillate.Items.Count - 1; j++)
                {
                    light = (listBoxComponent.Items[j] + " | " + listBoxDistillate.Items[j]);
                    heavy =(listBoxComponent.Items[j] + " | " + listBoxBottom.Items[j]); 
                    listBoxDist.Items.Add(light);
                    listBoxBott.Items.Add(heavy);
                }
               
            }
                
            else if (listBoxDistillate.Items.Count > 2)
            {
                for (int k = 0; k <= listBoxNameLK.Items.Count - 1; k++)
                {
                    light1 = (listBoxNameLK.Items[k] + " | " + listBoxLKVal.Items[k]);
                    listBoxDist.Items.Add(light1);
                }

                for (int k = 0; k <= listBoxNameHK.Items.Count - 1; k++)
                {
                    heavy1 = (listBoxNameHK.Items[k] + " | " + listBoxHKVal.Items[k]);
                    listBoxBott.Items.Add(heavy1);
                }
            }
            tabControl1.SelectedTab = tabPageFenskeDia;
    
            //Speak I command You
            speechSynthesizer.Rate = 1;
            speechSynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            speechSynthesizer.Speak("The Number Of Stages is " + numberofstage);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
              // this tell the app what to put as unit. i dim a variable, put it in a hidden textbox, the text does the work   
        {

            string a;
            textBoxUnit.Text = comboBox1.Text;
            a = textBoxUnit.Text;
            Labelbottomunit.Text = a;
            Labeloverheadunit.Text = a;
            Labelfeedunit.Text = a;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
              //Molar Units     
        {

            comboBox1.Show();
            comboBox1.Text = "Kg/h";
            Labelfeedunit.Show();
            Labeloverheadunit.Show();
            Labelbottomunit.Show();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
              // Hide uncessary combo     
        {

            comboBox1.Hide();
            Labeloverheadunit.Hide();
            Labelbottomunit.Hide();
            Labelfeedunit.Hide();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        //back to Home Page
        {
            tabControl1.SelectedTab = tabPageIntro;
        }

        private void equilibriumline()
        // Basic equation: y= (alpha*x)/(1+((alpha-1)*x))
        {
            double[] y = new double[11];
            double[] x = new double[11];
            x[0] = 0;
            x[1] = 0.1;
            x[2] = 0.2;
            x[3] = 0.3;
            x[4] = 0.4;
            x[5] = 0.5;
            x[6] = 0.6;
            x[7] = 0.7;
            x[8] = 0.8;
            x[9] = 0.9;
            x[10] = 1.0;
            double alpha;
            alpha = Convert.ToDouble(TextBoxrelvol.Text);
            for (int i = 0; i < 10; i++)
            {
                y[i] = (alpha * x[i]) / (1 + ((alpha - 1) * x[i]));
                ListBoxy.Items.Add(Math.Round(y[i], 3));
                ListBoxx.Items.Add(Math.Round(x[i], 3));
            }
            ListBoxy.Items.Add(1);
            ListBoxx.Items.Add(1);
            plotequlin();
        }

        private void feedline()
        {
            double x;
            x = Convert.ToDouble(TextBoxZf.Text);
            double q = Convert.ToDouble(TextBoxq.Text);
            double feedx;
            double feedy;
            feedx = x + 0.1;
            feedy = ((q * feedx) / (q - 1)) - (x / (q - 1));
            if ((x > feedy) || (x == feedy))
            {
                feedlineL();
            }

            else if (x < feedy)
            {
                feedlineG();
            }
            else if (q == 1)
            {
                feedlineq();
            }
        }

        private void topoperator()
        {
            //Top Operating Line Equation
            //
            double R = Convert.ToDouble(TextBoxR.Text);
            double y1 = Convert.ToDouble(TextBoxXad.Text);
            double y2;
            double x1=y1;
            double x2 = 0;
            y2 = x1 / (R + 1);
            ListBoxtopx.Items.Add(x1);
            ListBoxtopx.Items.Add(x2);
            ListBoxtopy.Items.Add(y1);
            ListBoxtopy.Items.Add(y2);


            chart1.Series.Add("TOP OPERATING LINE");
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = ("x");
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = ("y");
            chart1.Series["TOP OPERATING LINE"].ChartType = Graph.SeriesChartType.Spline; 
            for (int i = 0; i < ListBoxtopx.Items.Count; i++)
            {
                chart1.Series["TOP OPERATING LINE"].Points.AddXY((Convert.ToDouble(ListBoxtopx.Items[i])), (Convert.ToDouble(ListBoxtopy.Items[i])));
            }
        }

        private void diagonal()
        {
            double[] x = new double[2];
            double[] y = new double[2];
            x[0] = 0;
            x[1] = 1;
            y[0] = 0;
            y[1] = 1;
            chart1.Series.Add("DIAGONAL");
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = ("x");
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = ("y");
            chart1.Series["DIAGONAL"].ChartType = Graph.SeriesChartType.Spline;

            for (int i = 0; i < 2; i++)
            {
                chart1.Series["DIAGONAL"].Points.AddXY(x[i], y[i]);
            }
        }

        private void bottomoperator()
        {
            double R = Convert.ToDouble(TextBoxR.Text);
            double q = Convert.ToDouble(TextBoxq.Text);
            double xd = Convert.ToDouble(TextBoxXad.Text);
            double zf = Convert.ToDouble(TextBoxZf.Text);
            double y1 = Convert.ToDouble(TextBoxXab.Text);
            double y2;
            double x1 = y1;
            double x2;
            x2 = ((xd * (q - 1)) + (zf * (R + 1))) / (R + q);
            y2 = ((R * x2) + xd) / (R + 1);
            ListBoxbottomx.Items.Add(Math.Round((x1), 3));
            ListBoxbottomx.Items.Add(Math.Round((x2), 3));
            ListBoxbottomy.Items.Add(Math.Round((y1), 3));
            ListBoxbottomy.Items.Add(Math.Round((y2), 3));


            chart1.Series.Add("BOTTOM OPERATING LINE");
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = ("x");
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = ("y");
            chart1.Series["BOTTOM OPERATING LINE"].ChartType = Graph.SeriesChartType.Spline;
            for (int i = 0; i < ListBoxbottomx.Items.Count; i++)
            {
                chart1.Series["BOTTOM OPERATING LINE"].Points.AddXY((Convert.ToDouble(ListBoxbottomx.Items[i])), (Convert.ToDouble(ListBoxbottomy.Items[i])));
            }
        }

        private void feedlineG()
        {
            double x;
            x = Convert.ToDouble(TextBoxZf.Text);
            double q = Convert.ToDouble(TextBoxq.Text);
            for (int i = 0; i < 10; i++)
            {
                double feedx;
                double feedy;
                feedx = x + (i * 0.1);
                feedy = ((q * feedx) / (q - 1)) - (x / (q - 1));
                if ((feedx > 1) || (feedy == 0))
                {
                    return;
                }
                else
                {
                    ListBoxzx.Items.Add(Math.Round((feedx), 3));
                    ListBoxzy.Items.Add(Math.Round((feedy), 3));
                }

            }

            chart1.Series.Add("FEED LINE");
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = ("x");
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = ("y");
            chart1.Series["FEED LINE"].ChartType = Graph.SeriesChartType.Spline;
            for (int i = 0; i < ListBoxzx.Items.Count-1; i++)
            {
                chart1.Series["FEED LINE"].Points.AddXY((Convert.ToDouble(ListBoxzx.Items[i])), (Convert.ToDouble(ListBoxzy.Items[i])));
            }
        }

        private void feedlineL()
        {
            double x;
            x = Convert.ToDouble(TextBoxZf.Text);
            double q = Convert.ToDouble(TextBoxq.Text);
            for (int i = 0; i < 10; i++)
            {
                double feedx;
                double feedy;
                feedx = x - (i * 0.1);
                feedy = ((q * feedx) / (q - 1)) - (x / (q - 1));
                if ((feedx < 0) || (feedy == 0))
                {
                    return;
                }

                else
                {
                    ListBoxzx.Items.Add(Math.Round((feedx), 3));
                    ListBoxzy.Items.Add(Math.Round((feedy), 3));
                }
            }

            chart1.Series.Add("FEED LINE");
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = ("x");
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = ("y");
            chart1.Series["FEED LINE"].ChartType = Graph.SeriesChartType.Spline;
            for (int i = 0; i < ListBoxzx.Items.Count - 1; i++)
            {
                chart1.Series["FEED LINE"].Points.AddXY((Convert.ToDouble(ListBoxzx.Items[i])), (Convert.ToDouble(ListBoxzy.Items[i])));		 
            }
        }

        private void feedlineq()
        {
            //when q=1
            double x;
            x = Convert.ToDouble(TextBoxZf.Text);
            double q = Convert.ToDouble(TextBoxq.Text);
            for (int i = 0; i < 10; i++)
            {

                double feedx;
                double feedy;
                feedx = x;
                feedy = (x - 0.1) + (i * 0.1);
                if ((feedx < 0) || (feedy == 0))
                {
                    return;
                }
                else
                {
                    ListBoxzx.Items.Add(Math.Round((feedx), 3));
                    ListBoxzy.Items.Add(Math.Round((feedy), 3));
                }
            }

            chart1.Series.Add("FEED LINE");
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = ("x");
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = ("y");
            chart1.Series["FEED LINE"].ChartType = Graph.SeriesChartType.Spline;
            for (int i = 0; i < ListBoxzx.Items.Count - 1; i++)
            {
                chart1.Series["FEED LINE"].Points.AddXY((Convert.ToDouble(ListBoxzx.Items[i])), (Convert.ToDouble(ListBoxzy.Items[i])));		 
            }
        }

        private void Smokers()
        {
            double md;
            double mB;
            double bD;
            double bB;
            double xD = Convert.ToDouble(TextBoxXad.Text);
            double xB = Convert.ToDouble(TextBoxXab.Text);
            double XDD;
            double XBB;
            double km=0;
            double k1;
            double k2;
            double z1;
            double z2;
            double z3;
            double z4;
            double x;
            double xf = Convert.ToDouble(TextBoxZf.Text);
            double xn;
            double xm;
            double cD;
            double relative = Convert.ToDouble(TextBoxrelvol.Text);
            double R = Convert.ToDouble(TextBoxR.Text);
            double q = Convert.ToDouble(TextBoxq.Text);

            //for number of stage in rectifying section

            double Nr;
            md = R / (R + 1);
            bD = xD / (R + 1);
            z1 = md * (relative - 1);
            z2 = md + (bD * (relative - 1)) - relative;
            z3 = Math.Sqrt((z2 * z2) - (4 * z1 * bD));
            z4 = 2 * z1;
            k1 = ((-z2) + z3) / z4;
            k2 = ((-z2) - z3) / z4;

            if (k1 < k2)
            {
                km = k2;
            }

            else if (k1 > k2)
            {
                km = k1;
            }

            cD = 1 + ((relative - 1) * km);
            XDD = xD - km;
            xn = xf - km;
            double betaD;
            betaD = ((md * cD) * (relative - 1)) / (relative - (md * (cD * cD)));
            double log1;
            double log2;
            log1 = Math.Abs(XDD * (1 - (betaD * xn)));
            log2 = Math.Abs(xn * (1 - (betaD * XDD)));
            double log3;
            log3 = Math.Abs(relative / (md * (cD * cD)));
            Nr = (Math.Log10(log1 / log2)) / (Math.Log10(log3));
            Nr = Math.Round(Nr, 2);

            //For number of stage in stripping section
            double Ns;
            double kb=0;
            mB = ((R * xf) + xD - (xB * (R + 1))) / ((R + 1) * (xf - xB));
            bB = (xB * (xf - xD)) / ((R + 1) * (xf - xB));
            if (q == 1)
            {
                x = xf;
            }

            else
            {
                x = (bB + (xf / (q - 1))) / ((q / (q - 1)) - mB);
            }

            double z1b;
            double z2b;
            double z3b;
            double z4b;
            double k1b;
            double k2b;
            double cb;
            z1b = mB * (relative - 1);
            z2b = mB + (bB * (relative - 1)) - relative;
            z3b = Math.Sqrt((z2b * z2b) - (4 * z1b * bB));
            z4b = 2 * z1b;
            k1b = ((-z2b) + z3b) / z4b;
            k2b = ((-z2b) - z3b) / z4b;

            if (k1b < k2b)
            {
                kb = k2b;
            }
            else if (k1b > k2b)
            {
                kb = k1b;
            }

            cb = 1 + ((relative - 1) * kb);
            xm = x - kb;
            XBB = xB - kb;
            double betab;
            betab = ((mB * cb) * (relative - 1)) / (relative - (mB * (cb * cb)));
            double log11;
            double log21;
            log21 = Math.Abs(XBB * (1 - (betab * xm)));
            log11 = Math.Abs(xm * (1 - (betab * XBB)));
            double log31;
            log31 = Math.Abs(relative / (mB * (cb * cb)));
            Ns = (Math.Log10(log11 / log21)) / (Math.Log10(log31));
            Ns = Math.Round(Ns, 2);

            double N;
            N = Ns + Nr;
            LabelTotalStages.Text = "TOTAL NUMBER OF STAGE REQUIRED IS " + N + " STAGES";
            LabelRStages.Text = "THERE ARE " + Nr + " STAGES IN RECTIFYING SECTION";
            LabelSStages.Text = "THERE ARE " + Ns + " STAGES IN STRIPPING SECTION";
            LabelTotalStages.Show();
            LabelRStages.Show();
            LabelSStages.Show();
        }

        private void plotequlin()
        {
            //To plot equilibrium line
            //
            chart1.Series.Add("EQUILIBRIUM LINE");
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = ("x");
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = graphmin;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = graphmax;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = graphinterval;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = ("y");
            chart1.Series["EQUILIBRIUM LINE"].ChartType = Graph.SeriesChartType.Spline; //DataVisualization.charting.seriescharttype.spline;
            for (int i = 0; i < ListBoxx.Items.Count; i++)
            {
                chart1.Series["EQUILIBRIUM LINE"].Points.AddXY((Convert.ToDouble(ListBoxx.Items[i])), (Convert.ToDouble(ListBoxy.Items[i])));         
            }
        }

        private void RadioButtonrv_CheckedChanged(object sender, EventArgs e)
        {
            // USING RELATIVE VOLATILITY TO PLOT
            labelRelvol.Text = TextBoxrelvol.Text;
            labelRelvol.Show();
            TextBoxx.Hide();
            TextBoxy.Hide();
            labelX.Hide();
            labelY.Hide();
            buttonAddXY.Hide();
            comboBoxUni.Hide();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            // USING X-Y Values TO PLOT
            labelRelvol.Hide();
            TextBoxx.Show();
            TextBoxy.Show();
            labelX.Show();
            labelY.Show();
            buttonAddXY.Show();
            comboBoxUni.Show();
        }

        private void labelRelvol_Click(object sender, EventArgs e)
        {
            labelRelvol.Text = TextBoxrelvol.Text;
        }

        private void TextBoxrelvol_TextChanged(object sender, EventArgs e)
        {
            labelRelvol.Text = TextBoxrelvol.Text;
        }

        private void buttonAddXY_Click(object sender, EventArgs e)
        {
            //Adding x,y for McCabe Thiele Plot
            //
            string  textofx = (TextBoxx.Text).Trim();
            string textofy =  (TextBoxy.Text).Trim();
            double Ntester =0;//test for numbers

            if ((Convert.ToDouble(textofx) > 1) && (comboBoxUni.Text == "decimal"))
            {
                MessageBox.Show(" VALUE OF x IS GREATER THAN 1.00");
                return;
            }

            else if ((Convert.ToDouble(textofy) > 1) && (comboBoxUni.Text == "decimal"))
            {
                MessageBox.Show(" VALUE OF y IS GREATER THAN 1.00");
                return;
            }

            if ((textofx=="") || (textofy==""))
	        {
		        MessageBox.Show("SOME BOXES ARE EMPTY");
                return;
	        }
       
            else
            {
               foreach (char OneCharacterx in textofx)
	                {
		                string ConChar = Convert.ToString(OneCharacterx);

                        if (double.TryParse(ConChar, out Ntester) || ConChar == ".")
	                    {
		                    //Continue
	                    }
                       else
                       {
                            MessageBox.Show("The x Value Contains a Non Numeric Character: " + ConChar);
                            return;
                       }
	                }

                               
                foreach (char OneCharactery in textofy)
	                {
		                string ConChar = Convert.ToString(OneCharactery);

                        if (double.TryParse(ConChar, out Ntester) || ConChar == ".")
	                    {
		                    //Continue
	                    }
                       else
                       {
                            MessageBox.Show("The y Value Contains a Non Numeric Character: " + ConChar);
                            return;
                       }
	                }

            }
                double x  = Convert.ToDouble(TextBoxx.Text);
                double y = Convert.ToDouble(TextBoxy.Text);

                if( comboBoxUni.Text == "%" )
                {
                    x = x / 100;
                    y = y / 100;
                }
                else if (comboBoxUni.Text == "decimal" )
                {
                    x = x;
                    y = y;
                }
                ListBoxx.Items.Add(x);
                ListBoxy.Items.Add(y);
                TextBoxx.Clear();
                TextBoxy.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear All
        ListBoxbottomx.Items.Clear();
        ListBoxbottomy.Items.Clear();
        ListBoxtopx.Items.Clear();
        ListBoxtopy.Items.Clear();
        ListBoxx.Items.Clear();
        ListBoxy.Items.Clear();
        ListBoxzx.Items.Clear();
        ListBoxzy.Items.Clear();
        chart1.Series.Clear();
        TextBoxq.Clear();
        TextBoxR.Clear();
        TextBoxrelvol.Clear();
        TextBoxXab.Clear();
        TextBoxXad.Clear();
        TextBoxZf.Clear();
        LabelRStages.Hide();
        LabelSStages.Hide();
        LabelTotalStages.Hide();

        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
        //Solve McCabe Thiele

        string textOneCharacterxab = (TextBoxXab.Text).Trim();
        string textOneCharacterxad =(TextBoxXad.Text).Trim();
        string textOneCharacterza =(TextBoxZf.Text).Trim();
        string textOneCharacterR =(TextBoxR.Text).Trim();
        string textOneCharacterq =(TextBoxq.Text).Trim();
        string textOneCharacterRelV =(TextBoxrelvol.Text).Trim();
        ListBoxbottomx.Items.Clear();
        ListBoxbottomy.Items.Clear();
        ListBoxtopx.Items.Clear();
        ListBoxtopy.Items.Clear();
        ListBoxx.Items.Clear();
        ListBoxy.Items.Clear();
        ListBoxzx.Items.Clear();
        ListBoxzy.Items.Clear();
        chart1.Series.Clear();
        double Ntester=0;

        if (Convert.ToDouble(TextBoxq.Text) > 1)
        {
            MessageBox.Show(" VALUE OF q IS GREATER THAN 1.00");
            return;
        }
        if (Convert.ToDouble(TextBoxZf.Text) > 1 )
        {
            MessageBox.Show(" VALUE OF Zf IS GREATER THAN 1.00");
            return;
        }
        else if (Convert.ToDouble(TextBoxXab.Text) > 1)
        {
            MessageBox.Show(" VALUE OF Xab IS GREATER THAN 1.00");
            return;
        }
        else if (Convert.ToDouble(TextBoxXad.Text) > 1)
        {
            MessageBox.Show(" VALUE OF Xab IS GREATER THAN 1.00");
            return;
        }

        if ((RadioButtonrv.Checked == true) && ((TextBoxq.Text).Trim() == "") || ((TextBoxR.Text).Trim() == "") || ((TextBoxrelvol.Text).Trim() == "") || ((TextBoxXab.Text).Trim() == "") || ((TextBoxXad.Text).Trim() == "") || ((TextBoxZf.Text).Trim() == ""))
            {
            MessageBox.Show(" SOMEBOXES ARE EMPTY");
            return;
            }
        else if ((radioButton6.Checked == true) && (((TextBoxq.Text).Trim() == "") || ((TextBoxR.Text).Trim() == "") || ((TextBoxXab.Text).Trim() == "") || ((TextBoxXad.Text).Trim() == "") || ((TextBoxZf.Text).Trim() == "")))
        {
            MessageBox.Show(" SOMEBOXES ARE EMPTY");
            return;
        }
        else
        {
            foreach (Char OneCharacterxab in textOneCharacterxab)
	        {
     		        string ConChar = Convert.ToString(OneCharacterxab);

                if (double.TryParse(ConChar,out Ntester)|| ConChar==".")
	            {
		            //Continue
	            }
                else
                {
                    MessageBox.Show("The Xab Value Contains a Non Numeric Character: " + ConChar);
                    return;
                }
	        }

            foreach (Char OneCharacterxad in textOneCharacterxad)
	        {
     		        string ConChar = Convert.ToString(OneCharacterxad);

                    if (double.TryParse(ConChar, out Ntester) || ConChar == ".")
	            {
		            //Continue
	            }
                else
                {
                    MessageBox.Show("The Xad Value Contains a Non Numeric Character: " + ConChar);
                    return;
                }
	        }

            foreach (Char OneCharacterza in textOneCharacterza)
	        {
     		        string ConChar = Convert.ToString(OneCharacterza);

                    if (double.TryParse(ConChar, out Ntester) || ConChar == ".")
	            {
		            //Continue
	            }
                else
                {
                    MessageBox.Show("The Zf Value Contains a Non Numeric Character: " + ConChar);
                    return;
                }
	        }

            foreach (Char OneCharacterR in textOneCharacterR)
	        {
     		        string ConChar = Convert.ToString(OneCharacterR);

                    if (double.TryParse(ConChar, out Ntester) || ConChar == ".")
	            {
		            //Continue
	            }
                else
                {
                    MessageBox.Show("The Reflux (R) Value Contains a Non Numeric Character: " + ConChar);
                    return;
                }
	        }

            foreach (Char OneCharacterq in textOneCharacterq)
	        {
     		        string ConChar = Convert.ToString(OneCharacterq);

                    if (double.TryParse(ConChar, out Ntester) || ConChar == ".")
	            {
		            //Continue
	            }
                else
                {
                    MessageBox.Show("The q Value Contains a Non Numeric Character: " + ConChar);
                    return;
                }
	        }

            foreach (Char OneCharacterRelV in textOneCharacterRelV)
	        {
     		        string ConChar = Convert.ToString(OneCharacterRelV);

                    if (double.TryParse(ConChar, out Ntester) || ConChar == ".")
	            {
		            //Continue
	            }
                else
                {
                    MessageBox.Show("The Relative Value Contains a Non Numeric Character: " + ConChar);
                    return;
                }
	        }
          
        }


        if (RadioButtonrv.Checked == true)
            {
             equilibriumline();
             feedline();
             topoperator();
             bottomoperator();
             Smokers();
             diagonal();
            }
        else if (radioButton6.Checked == true)
        {
             plotequlin();
             feedline();
             topoperator();
             bottomoperator();
             Smokers();
             diagonal();
        }

        chart1.Show();

        speechSynthesizer.Rate = 1;
        speechSynthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
        speechSynthesizer.Speak(LabelSStages.Text);
        speechSynthesizer.Speak(LabelRStages.Text);
        speechSynthesizer.Speak(LabelTotalStages.Text);

     }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Go back to Fenske Calculation
            tabControl1.SelectedTab = tabPageFenskeCalc;
        }

        private void buttonNewFenske_Click(object sender, EventArgs e)
        {
            // New Fenske Calculation
            ClearFenske();
            tabControl1.SelectedTab = tabPageFenskeCalc;
        }
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Show McCAbe-Thiele Page
            tabControl1.SelectedTab = tabPageMcCabe;
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            //hide part of chart for x,y plotting
            TextBoxy.Show();
            TextBoxx.Show();
            comboBoxUni.Show();
            label10.Show();
            labelX.Show();
            labelY.Show();
            labelRelvol.Hide();
        }

        private void RadioButtonrv_CheckedChanged_1(object sender, EventArgs e)
        {
            //hide part of chart for x,y plotting
            TextBoxy.Hide();
            TextBoxx.Hide();
            comboBoxUni.Hide();
            label10.Hide();
            labelX.Hide();
            labelY.Hide();
            labelRelvol.Show();
        }

        private void comboBoxComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxComponent.Text = comboBoxComp.SelectedItem.ToString();
        }

        private void comboBoxComp_Click(object sender, EventArgs e)
        {
            comboBoxComp.Text = "";
        }

        private void TextBoxrelvol_TextChanged_1(object sender, EventArgs e)
        {
            labelRelvol.Text = TextBoxrelvol.Text;
        }

        
                   
    }
   }
