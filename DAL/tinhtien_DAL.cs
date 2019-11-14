using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tinhtien_DAL
    {
        data_tinhtienDataContext data = new data_tinhtienDataContext();

        public bool kt_tinhtien_thangnay(DateTime ngayhientai,string mapt)
        {
            var Qlthutien = from d in data.QLTHUTIENs where d.NgayThu == ngayhientai where d.MaPT == mapt select new { d.NgayThu }  ;

            int x = Qlthutien.ToList().Count();

            if (x != 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
