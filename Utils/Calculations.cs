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
        private List<Node> partsData { get; set; }

        public double rootChildNodeAssemblyDuration = 0;
        public int totalParts = 0;
        public double totalPartsCost = 0;

        public Calculations()
        {
            
        }

        public void Calculate(List<Node> data, List<Node> partsData)
        {
            this.data = data;
            this.partsData = partsData;

            refreshRootChildNodeAssemblyDuration();
            refreshTotalParts();
            refreshTotalPartsCost();
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

        private void refreshTotalParts()
        {
            this.totalParts = partsData.Count();
        }
        private void refreshTotalPartsCost()
        {
            double cost = 0;
            foreach (var part in this.partsData)
            {
                cost += part.Price ?? default(int);
            }
            totalPartsCost = cost;
        }
    }
}
