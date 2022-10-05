using System;
using Lab33.Service;
using System.Windows.Forms;

namespace Lab33
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Programs.Program program = new Programs.Program(new Form1(), new Calculate());
            try
            {
                program.Run();
            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
