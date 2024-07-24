using System.Data.SqlClient;



namespace DAL_QLKHOHANG
{
    public class DBConnect
    {
        // Kết nối đến cơ sở dữ liệu
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-M1R87C9\\THUYTIEN;Initial Catalog=QL_KhoHang;Integrated Security=True");
    }
}
