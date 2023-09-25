using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkThreads
{
    public class GenerateFibonachi
    {
        bool stopGenerate = false;
        FibonachiPauseDelegate FibonachiPauseDelegate;
        int value;   
        public Label l;
        private readonly int pause = 100;

        public GenerateFibonachi(FibonachiPauseDelegate FibonachiPauseDelegate, int value, Label l)
        {
            this.FibonachiPauseDelegate = FibonachiPauseDelegate;
            this.value = value;           
            this.l = l;
        }

        public void DoWork()
        {
            StringBuilder sb = new StringBuilder();
            int n1 = 0;
            int n2 = 1;
            int result = 0;
            sb.Append(n1.ToString() + " ");
            l.Invoke(new Action(() => l.Text = sb.ToString()));
            Thread.Sleep(50);
            sb.Append(n2.ToString() + " ");
            l.Invoke(new Action(() => l.Text = sb.ToString()));
            Thread.Sleep(50);
            while (!stopGenerate)
            {                               
                while (result < value)
                {
                    if (FibonachiPauseDelegate())
                    {                                                                
                        l.Invoke(new Action(() => l.Text = sb.ToString()));
                        result = n1 + n2;
                        sb.Append(result.ToString() + " ");
                        n1 = n2;
                        n2 = result;
                        Thread.Sleep(300);
                    }
                    else
                    {
                        Thread.Sleep(pause);
                        break;
                    }
                        
                }
            }
        }
        public void Stop()
        {
            stopGenerate = true;
        }






    }
}
