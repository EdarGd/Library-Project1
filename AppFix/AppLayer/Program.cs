namespace AppLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DataAccessLayer.Entities.User user = new DataAccessLayer.Entities.User()
            {
                Id = "318441649",
                Email = "aa.aa@aa.aa",
                FirstName = "dan",
                LastName = "ita",
                Password = "a!Asdewqra",
                Type = true
            };
            //Application.Run(new Main(user));
            Application.Run(new AppLayer.Components.Single.singleBookMain());
            //Application.Run(new AppLayer.Components.Single.singleBookMain());




            ////////// *******************************              Start *****************************
            Application.Run(new programForm());
        }
    }
}