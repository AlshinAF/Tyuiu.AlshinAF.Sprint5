using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AlshinAF.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {

                y = Math.Round((3*x-1.5)/(Math.Sin(x)-3+x)+2, 2);
                if ((Math.Sin(x) - 3 + x) == 0)
                {
                    y = 0;
                }
                strY = Convert.ToString(y);


                if (x != stopValue)
                {
                    File.AppendAllText(path, strY+Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);

                }


            }
            return path;


        }
    }
}
