namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
            string value1 = getHoge().Result;
            string value2 = getFuga().Result;
            string value3 = getPiyo().Result;
            */


            doHogeFugaPiyo();

        }

        public static async Task doHogeFugaPiyo() 
        {
            // 準備
            Task task1 = Task.Run(() =>
            {
                getHoge();
            });

            Task task2 = Task.Run(() =>
            {
                getFuga();
            });

            Task task3 = Task.Run(() =>
            {
                getPiyo();
            });

            // ここで同時実行
            Task.WaitAll(task1, task2, task3);
        }

        public static async Task<string> getHoge() 
        {
            Thread.Sleep(6000);
            Console.WriteLine("hoge");
            return "hoge";
        }

        public static async Task<string> getFuga()
        {
            Thread.Sleep(2000);
            Console.WriteLine("fuga");
            return "fuga";
        }

        public static async Task<string> getPiyo()
        {
            Thread.Sleep(100);
            Console.WriteLine("piyo");
            return "piyo";
        }
    }
}