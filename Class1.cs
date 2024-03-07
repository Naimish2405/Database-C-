using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace emplogin
{
    class Class1
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Naimishcs\emplogin\emplogin\bin\Debug\bin\Debug\Database1.mdf;Integrated Security=True;User Instance=True");
    }
}
