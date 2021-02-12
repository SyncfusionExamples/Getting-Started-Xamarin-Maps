using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Map_Sample
{
    public class ElectionData
    {
        public ElectionData(string state, string candidate, int electors)
        {
            State = state;
            Candidate = candidate;
            Electors = electors;
        }

        public string State
        {
            get;
            set;
        }

        public string Candidate
        {
            get;
            set;
        }

        public int Electors
        {
            get;
            set;
        }
    }
}