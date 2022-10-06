using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.DataContext
{
    public class AppConfiguration
    {

        // We will create a class that receives a connection path to the database dynamically,
        //according to the main folder path
        public AppConfiguration()
        {
            // There can be a situation where the library will be used and the path will not be to windows app, i.e. build
            try
            {
                ConfigurationBuilder configBuildr = new ConfigurationBuilder();
                //the url end at bin\Debug\net6.0-windows\ -> want parent
                DirectoryInfo pathToApp = Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!;

                string path = Path.Combine(pathToApp!.FullName, "appsettings.json");
                configBuildr.AddJsonFile(path, false); // Not Optional Mast Be There
                IConfigurationRoot root = configBuildr.Build();
                IConfigurationSection appSeting = root.GetSection("ConnectionStrings:DefaultConnestion");
                sqlConectionString = appSeting.Value;
            }
            catch (Exception ex)
            {
                sqlConectionString = "";
                Console.WriteLine(ex.Message);
            }
        }

        public string sqlConectionString { get; set; }

    }
}
