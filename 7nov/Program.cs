using System;
using System.IO;

namespace _7nov
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            try
            {
                try
                {
                    Circle c = new Circle(rnd.Next(-2, 10));
                    Triangle tr = new Triangle(rnd.Next(-2, 10), rnd.Next(-2, 10), rnd.Next(-2, 10));
                    Quadrangle qd = new Quadrangle(rnd.Next(-2, 10), rnd.Next(-2, 10), rnd.Next(-2, 10), rnd.Next(-2, 10));
                }
                catch (CircleException e)
                {
                    throw;
                }
                catch (GeometryException e)
                {
                    StreamWriter logFileWriter = File.AppendText("tri_quad_log_file.txt");
                    logFileWriter.WriteLine(e.Message);
                    logFileWriter.WriteLine("Parameters: {0}", string.Join("; ", e.Parameters));
                    logFileWriter.Close();

                    throw;
                }
            }
            catch (GeometryException e)
            {
                StreamWriter logFileWriter = File.AppendText("common_log_file.txt");
                logFileWriter.WriteLine(e.Message);
                logFileWriter.WriteLine("Parameters: {0}", string.Join("; ", e.Parameters));
                logFileWriter.Close();
            }
        }
    }
}
