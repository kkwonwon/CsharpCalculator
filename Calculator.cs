using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        private Operator op;
        private double curruent;
        private double before;
        public void Update(double value)
        {
            curruent = value;
        }
        public void Update(Operator op)
        {
            this.op = op;
            before = curruent;
        }
        public void Execute()
        {
            switch(op)
            {
                case Operator.ADD:
                    curruent = before + curruent;
                    break;
                case Operator.SUB:
                    curruent = before - curruent;
                    break;
                case Operator.MUL:
                    curruent = before * curruent;
                    break;
                case Operator.DIV:
                    curruent = before / curruent;
                    break;
            }
        }
        public double GetResult()
        {
            return curruent;
        }
    }
}
