using System.Text;

namespace HomeWorkThreads
{
    public delegate bool GeneratePauseDelegate();
    public delegate bool FibonachiPauseDelegate();

    public partial class Form1 : Form
    {
        Thread? thread;
        Thread? threadFib;
        static bool generateRun;
        static bool fibonachiRun;
        int Min;
        int Max;
        Generate? generate;
        GenerateFibonachi? generateFibonachi;

        static bool GenerateRun()
        {
            return generateRun;
        }
        static bool FibonachiRun()
        {
            return fibonachiRun;
        }

        public Form1()
        {
            InitializeComponent();
            generateRun = true;
            fibonachiRun = true;

        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMin.Text == "")
                textBoxMin.Text = "2";
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = true;
            generateRun = true;
            if (textBoxMax.Text == "" && textBoxMin.Text != "")
            {
                Min = Convert.ToInt32(textBoxMin.Text);
            }
            if (textBoxMax.Text == "" && textBoxMin.Text == "")
            {
                Min = 2;
                Max = 1000;
            }
            else
            {
                Min = Convert.ToInt32(textBoxMin.Text);
                Max = Convert.ToInt32(textBoxMax.Text);

            }
         
            generate = new Generate(new GeneratePauseDelegate(GenerateRun), Min, Max, labelRandom);
            thread = new Thread(generate.DoWork);
            thread.IsBackground = true;
            thread.Start();

        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            while (thread?.ThreadState != ThreadState.Stopped)
            {
                if (generateRun == true)
                {
                    generateRun = false;
                    buttonPause.Text = "Продолжить поток";
                    break;
                }

                else
                {
                    generateRun = true;
                    buttonPause.Text = "Приостановить поток";
                    break;
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {           
            generate?.Stop();
            generateRun = false;
            thread?.Join(1);
            thread = null;
            generate = null;
            buttonExecute.Text = "Начать заново";  
            buttonStop.Enabled = false;
        }
        
        private void buttonFib_Click(object sender, EventArgs e)
        {
            buttonFibStop.Enabled = true;
            fibonachiRun = true;
            int value = 0;
            if (textBoxFib.Text == "")
                value = 12000000;
            else
                value = Convert.ToInt32(textBoxFib.Text);

            generateFibonachi = new GenerateFibonachi(new FibonachiPauseDelegate(FibonachiRun), value, labelFib);
            threadFib = new Thread(generateFibonachi.DoWork);
            threadFib.IsBackground = true;
            threadFib.Start();

        }

        private void buttonFibStop_Click(object sender, EventArgs e)
        {

            generateFibonachi?.Stop();

           
            fibonachiRun = false;
            threadFib?.Join(1);
            threadFib = null;
            generateFibonachi = null;
            buttonFib.Text = "Начать заново Фибоначи";
            buttonFibStop.Enabled = false;
        }

        public void Fibonachi(int m)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine();
            int n1 = 0;
            int n2 = 1;
            int result = 0;
            while (result < m)
            {
                Thread.Sleep(200);
                sb.Append(result.ToString() + " ");
                labelFib.Text = sb.ToString();
                result = n1 + n2;
                n1 = n2;
                n2 = result;
            }
        }

        private void buttonPauseFib_Click(object sender, EventArgs e)
        {
            while (threadFib?.ThreadState != ThreadState.Stopped)
            {
                if (fibonachiRun == true)
                {
                    fibonachiRun = false;
                    buttonPauseFib.Text = "Продолжить поток";
                    break;
                }

                else
                {
                    fibonachiRun = true;
                    buttonPauseFib.Text = "Приостановить поток";
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate?.Stop();
            generateFibonachi?.Stop();
        }

    }
}