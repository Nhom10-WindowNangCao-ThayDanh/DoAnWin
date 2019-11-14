using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class tinhtien_BLL
    {
        tinhtien_DAL data = new tinhtien_DAL();

        public bool kt_daDongTienChua(DateTime ngayhientai, string mapt)
        {
            return data.kt_tinhtien_thangnay(ngayhientai, mapt);
        }
    }
}
