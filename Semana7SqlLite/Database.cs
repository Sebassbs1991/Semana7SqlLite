using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Semana7SqlLite
{
    public interface Database
    {
        //Metodo de conexion
        SQLiteAsyncConnection GetConnection();


    }
}
