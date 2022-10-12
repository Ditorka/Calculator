namespace BalanceCalculator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //Ініціалізація графічної форми
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
