using System;
using System.Collections.Generic;
using System.Text;

namespace LotusV3.Dependencies
{
    public interface IDataBase
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
