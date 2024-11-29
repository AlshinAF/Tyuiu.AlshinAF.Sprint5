using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AlshinAF.Sprint5.Task4.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            string path1 = File.ReadAllText(path);
            string value = path1.Replace(".", ",");
            string[] valueArray = value.Split(' ');
            double x = Math.Round(Convert.ToDouble(valueArray), 3);

            double res = Math.Round(Math.Pow(x, 3) + Math.Sin(x) * Math.Cos(x),3);
            return res;
        }
    }
}
