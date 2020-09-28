using DemoCodePhanHe.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoCodePhanHe.Manager
{
    class CTDTManager
    {
        String fileName;
        List<ChiTietDT> chitetdt = new List<ChiTietDT>();

        public CTDTManager()
        {
            this.fileName = "../../../Data/txtMonHoc";

        }
        public Boolean insertMaNganh(String IDMN, String MaNganh)
        {
            ChiTietDT ct =  chitetdt.Find(x => x.getIDMN().Equals(IDMN));

            if (ct != null)
            {
                return false;
            }
            ct = new ChiTietDT(IDMN, MaNganh);
            chitetdt.Add(ct);

            return true;
        }

        public Boolean updateMaNganh(String IDMN, String MaNganh)
        {

            ChiTietDT ct = chitetdt.Find(x => x.getIDMN().Equals(IDMN));
            if (ct != null)
            {
                return false;
            }
            ct.SetIdMN(IDMN);
            ct.SetMaNganh(MaNganh);
            return true;
        }
        List<ChiTietDT> getAll()
        {
            return chitetdt;
        }
        public Boolean readData()
        {

            StreamReader rd;
            if (!File.Exists(fileName))
            {
                FileStream fs = File.Create(fileName);
                rd = new StreamReader(fs, Encoding.UTF8);
            }
            else
            {
                rd = new StreamReader(this.fileName);
            }

            //String idMH, ma_HK, tenMH;
            //int soTC, lyThuyet, thucHanh;

            String idMN;
            idMN = rd.ReadLine();
            while (idMN != null)
            {
                ChiTietDT ct = new ChiTietDT();
                ct.SetIdMN(idMN);
                ct.SetMaNganh(rd.ReadLine());
                chitetdt.Add(ct);

                idMN = rd.ReadLine();
            }

            return true;
        }
        public Boolean writeData()
        {
            StreamWriter wt = new StreamWriter(this.fileName);

            String tmp = "";
            chitetdt.ForEach(x =>
            {
                tmp += x.getIDMN() + "\n";
                tmp += x.GetMaNganh() + "\n";
            });

            return true;
        }
    }
}
