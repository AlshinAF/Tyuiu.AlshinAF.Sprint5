using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AlshinAF.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        string x = Convert.ToString(line[i]);
                        if (x.Length == 4)
                        {
                            count++;
                        }

                    }

                }

            }
            return count;
        }
    }
}
