using System;
using System.Collections.Generic;
using Lab33.View;
using System.Windows.Forms;
namespace Lab33
{
    public partial class Form1 : Form,IView
    {
        public string A { get { return ParamA.Text; } }
        public string MinX { get { return LeftBorder.Text; } }
        public string MaxX { get { return RightBorder.Text; } }
        public string Period { get { return textBox1.Text; } }
        public event EventHandler buttonClick;
        public event EventHandler helpClick;

        public void DrawChart(List<double> X, List<double> Y1, List<double> Y2)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for(int i = 0; i < X.Count; i++)
            {
                chart1.Series[0].Points.AddXY(X[i], Y1[i]);
                chart1.Series[1].Points.AddXY(X[i], Y2[i]);
            }
        }
        public void ShowPoints(List<double> X, List<double> Y1, List<double> Y2)
        {
            DotsList.Rows.Clear();
            for(int i = 0; i< X.Count; i++)
            {
                if (!double.IsNaN(Y1[i]) || !double.IsNaN(Y2[i]))
                {
                    DotsList.Rows.Add(X[i], Y1[i], Y2[i]);
                }
            }
        }
        public void WrongData()
        {
            string message = "Пожалуйста, вводите числа!";
            string caption = "Неверный формат данных";
            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }
        public void WrongInterval()
        {
            string message = "Неверно указан интервал\nЛевая граница должны быть меньше правой\nВводите числа от -100 до 100";
            string caption = "Неверный интервал";
            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }
        public void Start()
        {
            this.Show();
        }

        public new void Show()
        {
            Application.Run(this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            buttonClick?.Invoke(this, null);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            helpClick?.Invoke(this, null);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данную программу разработал студент СПбГТИ(ТУ)\nФакультета Информационных технологий и управления\n475 группы: Овчинников Роман Сегреевич.", "Информация о программе");
        }
    }
}
