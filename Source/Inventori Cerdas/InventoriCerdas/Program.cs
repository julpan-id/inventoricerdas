using InventoriCerdas.Forms;
using InventoriCerdas.Models;
using LinqToDB.Data;
using System;
using System.Windows.Forms;

namespace InventoriCerdas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var connectionString = "Data Source = (LocalDb)\\MSSQLLocalDB; Initial Catalog = InventoriCerdas; Integrated Security = SSPI; AttachDBFilename =InventoriCerdas.mdf";
            // Set DB Connection Setting for LinqToDB
            DataConnection.DefaultSettings = new LinqToDBConfig(connectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
