using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeWorkThreads
{
    public class Generate
    {
        bool stopGenerate = false;
        GeneratePauseDelegate GeneratePauseDelegate;
        int Min;
        int Max;       
        public Label label;
        private readonly int pause=100;
        int i;

        public Generate(GeneratePauseDelegate GeneratePauseDelegate, int Min, int Max, Label label)
        {
            this.GeneratePauseDelegate = GeneratePauseDelegate;
            this.Min = Min;
            this.Max = Max;
            this.label = label;
        }

        public void DoWork()
        {
            i = Min + 1;
            while (!stopGenerate)
            {                
                for (; i < Max; i++)
                {
                    if (GeneratePauseDelegate())
                    {
                        label.Invoke(new Action(() => label.Text = i.ToString()));
                        Thread.Sleep(100);
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
            if(stopGenerate)
            {
               
                //{
                    label.Text = i.ToString();
                    Thread.Sleep(pause);


                //}
            }
           
        }

    }
}
