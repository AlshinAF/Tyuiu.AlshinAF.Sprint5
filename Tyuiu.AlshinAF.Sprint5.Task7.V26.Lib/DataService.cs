using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AlshinAF.Sprint5.Task7.V26.Lib
{
    public class DataService : ISprint5Task7V26
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string words = line.Replace("Hello", "word").Replace("Is", "word").Replace("First", "word").Replace("Program", "word").Replace("My", "word");
                    strLine += words;
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;


        }
    }
}
