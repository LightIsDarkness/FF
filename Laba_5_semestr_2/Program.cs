namespace Laba_5_semestr_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}