using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string url = "https://drive.google.com/file/d/1i9CUw7Eco-NrXUPbQHd26gfi-5UXebHu/view"; // URL файла для скачивания
        string savePath = "C:\\Users\\igorc\\OneDrive\\Рабочий стол\\12.txt"; // Путь, по которому нужно сохранить файл

        using (WebClient client = new WebClient())
        {
            try
            {
                // Запускаем загрузку файла
                client.DownloadFile(url, savePath);

                Console.WriteLine("Файл успешно скачан.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при скачивании файла: " + ex.Message);
            }
        }
    }
}
