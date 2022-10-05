using System;
using System.Collections.Generic;
using Lab33.View;
using Lab33.Service;

namespace Lab33.Programs
{
    public class Program
    {
        private readonly IView view;
        private readonly ICalculate model;

        public Program(IView view, ICalculate model)
        {
            this.view = view;
            this.model = model;
        }

        public void Run()
        {
            view.buttonClick += View_buttonClick;
            view.Start();
        }

        private void View_buttonClick(object sender, EventArgs e)
        {
           GenerateDots();
        }

        public void GenerateDots()
        {
            const int maxleft = -100;
            const int maxright = 100;
            double left = 0, right = 0, a = 0;
            double per = 0;
            bool isCorrectData = false;
            try
            {
                left = Convert.ToDouble(view.MinX);
                right = Convert.ToDouble(view.MaxX);
                a = Convert.ToDouble(view.A);
                per = Convert.ToDouble(view.Period);
                isCorrectData = true;
            }
            catch(FormatException e)
            {
                view.WrongData();
            }
            if((left >= right) ||(left > maxright) || (left < maxleft) || (right > maxright) || (right < maxleft))
            {
                isCorrectData = false;
                view.WrongInterval();
            } else if(per <= 0)
            {
                isCorrectData = false;
                view.WrongData();
            }
           

            if (isCorrectData)
            {
                List<double> x = GenerateX(left, right, per);
                List<double> positiveY = GeneratePositiveY(left, right, a, per);
                List<double> negativeY = GenerateNegativeY(left, right, a, per);
                view.DrawChart(x, positiveY, negativeY);
                view.ShowPoints(x, positiveY, negativeY);
            }
        }
        
        public List<double> GenerateX(double left, double right,double period)
        {
            List<double> X = new List<double>();
            for(double i = left; i < right; i+=period)
            {
                X.Add(i);
            }
            return X;
        }

        public List<double> GeneratePositiveY(double left, double right, double a,double period)
        {
            List<double> Y = new List<double>();
            for (double i = left; i < right; i+=period)
            {
                Y.Add(model.PositiveEquation(a, i));
            }
            return Y;
        }

        public List<double> GenerateNegativeY(double left, double right, double a, double period)
        {
            List<double> Y = new List<double>();
            for (double i = left; i < right; i+=period)
            {
                Y.Add(model.NegativeEquation(a, i));
            }
            return Y;
        }
        
    }
}
