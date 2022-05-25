using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SEMANA7VK
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();  
    }
}
