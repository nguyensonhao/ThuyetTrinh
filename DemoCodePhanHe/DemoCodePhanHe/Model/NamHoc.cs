using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCodePhanHe.Model
{
    class NamHoc
    {
        private String MaNamHoc;
        private String TenNamHoc;

        public NamHoc(string maNamHoc, string tenNamHoc)
        {
            MaNamHoc = maNamHoc;
            TenNamHoc = tenNamHoc;
        }

        public String getMaNamHoc()
        {
            return this.MaNamHoc;
        }
        public void SetMaNamHoc(String maNamHoc)
        {
            this.MaNamHoc = maNamHoc;
        }

        public String getTenNamHoc()
        {
            return this.TenNamHoc;
        }
        public void SetTenNamHoc(String tenNamHoc)
        {
            this.TenNamHoc = tenNamHoc;
        }

    }
}
