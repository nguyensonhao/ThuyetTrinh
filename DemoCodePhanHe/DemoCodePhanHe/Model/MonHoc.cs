using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCodePhanHe.Model
{
    class MonHoc
    {
        public String idMH;    
        public String ma_HK;
        public String tenMH;
        public int soTC;
        public int lyThuyet;
        public int thucHanh;

        public MonHoc() { }
        public MonHoc(String idMH, String ma_HK, String tenMH, int soTC, int lyThuyet, int thucHanh) {
            
            this.idMH = idMH;
            this.ma_HK = ma_HK;
            this.tenMH = tenMH;
            this.soTC = soTC;
            this.lyThuyet = lyThuyet;
            this.thucHanh = thucHanh;

        }

        public String GetIdMH() {
            return this.idMH;
        }
        public void SetIdMH(String idMH)
        {
            this.idMH = idMH;
        }
        public String GetMa_HK()
        {
            return this.ma_HK;
        }
        public void SetMa_HK(String ma_HK)
        {
            this.ma_HK = ma_HK;
        }
        public String GetTenMH()
        {
            return this.tenMH;
        }
        public void SetTenMH(String tenMH)
        {
            this.tenMH = tenMH;
        }

        public int GetSoTC()
        {
            return this.soTC;
        }
        public void SetSoTC(int soTC)
        {
            this.soTC = soTC;
        }

        public int GetLyThuyet()
        {
            return this.lyThuyet;
        }
        public void SetLyThuyet(int lyThuyet)
        {
            this.lyThuyet = lyThuyet;
        }

        public int GetThucHanh()
        {
            return this.thucHanh;
        }
        public void SetThucHanh(int thucHanh)
        {
            this.thucHanh = thucHanh;
        }
    }
}
