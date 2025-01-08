using Dapper;
using QuanLyBanGiay.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanGiay.Controller
{
    public class TestController
    {
        public static bool Test(int _a, int _b)
        {
            using (var db = setupConection.ConnectionFactory())
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    var transaction = db.BeginTransaction();

                    int Insert_NV = db.Execute("test",
                        new
                        {
                            a = _a,
                            b = _b,
                        },
                        commandType: CommandType.StoredProcedure,
                        transaction: transaction);
                    transaction.Commit();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
    }
}