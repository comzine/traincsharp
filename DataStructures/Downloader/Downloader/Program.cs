using System.Threading.Tasks;

namespace Downloader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Downloader downloader = new Downloader();
            List<Action> actions = new List<Action> {
                () => downloader.DownloadFile("http://www.google.com"),
                () => downloader.DownloadFile("http://www.microsoft.com"),
                () => downloader.DownloadFile("http://www.apple.com"),
                () => downloader.DownloadFile("http://www.amazon.com"),
                () => downloader.DownloadFile("http://www.facebook.com"),
                () => downloader.DownloadFile("http://www.twitter.com"),
                () => downloader.DownloadFile("http://www.stackoverflow.com"),
                () => downloader.DownloadFile("http://www.reddit.com"),
                () => downloader.DownloadFile("http://www.wikipedia.org"),
                () => downloader.DownloadFile("http://www.youtube.com"),
            };
            List<Task> tasks = new List<Task>();
            foreach (Action action in actions)
            {
                tasks.Add(Task.Run(action));
            }
            // output info when a task is completed
            while (tasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(tasks);
                tasks.Remove(finishedTask);
                Console.WriteLine($"Task {finishedTask.Id} completed.");
            }

            Console.WriteLine("All downloads completed.");
        }
    }
}
