using Faberis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faberis.Utils
{
    internal class Calculations
    {
        private List<Node> data { get; set; }

        public double rootChildNodeAssemblyDuration = 0;

        public Calculations(List<Node> data) 
        {
            this.data = data;
        }

        public void Calculate()
        {
            refreshRootChildNodeAssemblyDuration();
        }
        private void refreshRootChildNodeAssemblyDuration()
        {
            double assemblyDuration = 0;
            foreach (var item in this.data)
            {
                assemblyDuration += (double)item.CombinedAssemblyTime;
            }
            this.rootChildNodeAssemblyDuration = assemblyDuration;
        }
    }
}
