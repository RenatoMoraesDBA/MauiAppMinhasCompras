using MauiAppMinhasCompras.Helpers;
using SQLite;


namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        static SQliteDatabaseHelper _db;

            public static SQliteDatabaseHelper Db
        {
            get
            {
                if (_db == null)
                {
                    String path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3");


                    _db = new SQliteDatabaseHelper(path);
                }

                return _db;


            }
        }

        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListaProduto());
        }
    }
}
