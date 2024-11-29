using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AlshinAF.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) > 0)
                    {
                        count++;
                        res = res + Convert.ToDouble(line);
                    }

                }

            }
            res = res / count;
            return res;
        }
    }
}
