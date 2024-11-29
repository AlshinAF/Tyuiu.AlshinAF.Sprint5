using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AlshinAF.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            string path1 = File.ReadAllText(path);
            string value = path1.Replace(",", "");
  
            double res = 0;
            double count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double x = Math.Round(Convert.ToDouble(line), 3);
                    if (x > 0)
                    {
                        count++;
                        res = res + x;
                    }

                }

            }
            res = res / count;
            return res;
        }
    }
}
