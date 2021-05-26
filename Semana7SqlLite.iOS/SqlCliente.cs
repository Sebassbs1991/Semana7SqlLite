using Foundation;
using Semana7SqlLite.iOS;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;


[assembly: Xamarin.Forms.Dependency(typeof(SqlCliente))]
namespace Semana7SqlLite.iOS
{
    class SqlCliente : Database
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentPath, "uisraeldb3");
            return new SQLiteAsyncConnection(path);

        }
    }
}