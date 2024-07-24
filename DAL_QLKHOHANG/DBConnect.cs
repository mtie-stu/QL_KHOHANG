using System.Data.SqlClient;



namespace DAL_QLKHOHANG
{
    public class DBConnect
    {
        // Kết nối đến cơ sở dữ liệu
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-J0BL307\\DOT;Initial Catalog=QL_KhoHang;Integrated Security=True;Encrypt=False");
    }
}
