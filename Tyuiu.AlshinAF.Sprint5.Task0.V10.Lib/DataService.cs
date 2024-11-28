using System.IO;
using System.IO.Compression;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AlshinAF.Sprint5.Task0.V10.Lib
{
    public class DataService : ISprint5Task0V10
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            double z = (1.6 * Math.Pow((double)x, 3) - 2.1 * Math.Pow((double)x, 2) + 7 * x);
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
