using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxyPlotSample.ViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            DataList = new List<DataPoint>
            {
                {new DataPoint(0, 0)},
                {new DataPoint(2, 4)},
                {new DataPoint(5, 8)},
                {new DataPoint(8, 3)},
                {new DataPoint(12, 5)},
            };
        }

        public List<DataPoint> DataList { get; }
    }
}
