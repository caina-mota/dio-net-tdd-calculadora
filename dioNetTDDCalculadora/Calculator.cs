using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dioNetTDDCalculadora
{
    public class Calculator
    {
        private List<string> _history = new List<string>();
        public int Sum(int a, int b)
        {
            int res = a + b;
            SetHistory($"Sum {a} + {b} = {res}");
            return res;
        }

        public int Sub(int a, int b)
        {
            int res = a - b;
            SetHistory($"Sub {a} - {b} = {res}");
            return res;
        }

        public int Mult(int a, int b)
        {
            int res = a * b;
            SetHistory($"Mult {a} * {b} = {res}");
            return res;
        }

        public int Div(int a, int b)
        {
            int res = a / b;
            SetHistory($"Div {a} / {b} = {res}");
            return res;
        }

        public List<string> History()
        {
            return _history;
        }

        private void SetHistory(string values)
        {
            if(_history.Count > 2)
            {
                _history.RemoveAt(0);
            }
            _history.Add(values);
        }
    }
}
