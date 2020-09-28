using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCodePhanHe.Model
{
    class ChiTietDT
    {
        private String IDMN;
        private String MaNganh;

        public ChiTietDT()
        {

        }

        public ChiTietDT(string iDMN, string maNganh)
        {
            IDMN = iDMN;
            MaNganh = maNganh;
        }

        public String getIDMN()
        {
            return this.IDMN;
        }
        public void SetIdMN(String idMN)
        {
            this.IDMN = idMN;
        }
        public String GetMaNganh()
        {
            return this.MaNganh;
        }
        public void SetMaNganh(String maNganh)
        {
            this.MaNganh = maNganh;
        }
    }
}
