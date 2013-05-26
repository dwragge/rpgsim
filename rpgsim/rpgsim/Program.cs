namespace rpgsim
{
    using System.Windows.Forms;

#if WINDOWS || XBOX
    public static class Program
    {
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new OptionsDialog();
            var result = form.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            using (Game1 game = new Game1(form))
            {
                game.Run();
            }
        }
    }
#endif
}