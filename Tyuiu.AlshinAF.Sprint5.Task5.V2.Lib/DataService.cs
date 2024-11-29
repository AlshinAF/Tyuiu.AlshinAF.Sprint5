using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AlshinAF.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            string[] s;
            double res = 0;
            double count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                s = reader.ReadToEnd().Split(',');

                foreach (string number in s)

                {
                    double x = Math.Round(Convert.ToDouble(number), 3);
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
