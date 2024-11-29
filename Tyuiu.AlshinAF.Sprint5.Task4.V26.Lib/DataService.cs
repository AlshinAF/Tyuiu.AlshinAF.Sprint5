using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AlshinAF.Sprint5.Task4.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            string srtX = File.ReadAllText(path);   
            double res = Math.Round(Math.Pow(Convert.ToDouble(srtX), 3) + Math.Sin(Convert.ToDouble(srtX)) * Math.Cos(Convert.ToDouble(srtX)), 3);
            return res;
        }
    }
}
