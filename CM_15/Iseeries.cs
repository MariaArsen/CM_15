using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_15
{
    interface Iseries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }

    class ArithProgression : Iseries
    {
        int step;
        int startValue;
        int currentValue;
        public int getNext()
        {
            currentValue+=step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue; 
        }

        public void setStart(int x)
        {
            startValue=x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
    class GeomProgression : Iseries
    {
        int step;
        int startValue;
        int currentValue;
        public int getNext()
        {
            currentValue *= step;
            return currentValue;
        }
        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}


