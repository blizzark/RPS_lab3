using System;
using System.Collections.Generic;

namespace Lab33.View
{
    public interface IView
    {
        string A { get; }
        string MinX { get;}
        string MaxX { get;  }
        string Period { get; }
        void DrawChart(List<double> X, List<double> Y1, List<double> Y2);
        void ShowPoints(List<double> X, List<double> Y1, List<double> Y2);
        void WrongInterval();
        void WrongData();
        void Start();
        event EventHandler buttonClick;
        event EventHandler helpClick;
    }
}
