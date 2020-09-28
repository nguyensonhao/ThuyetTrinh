using DemoCodePhanHe.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DemoCodePhanHe.Management
{
    public class MonHocManager
    {
        String fileName;
        List<MonHoc> monHoc = new List<MonHoc>();

        public MonHocManager() {
            this.fileName = "../../../Data/txtMonHoc";
            this.readData();
        }
        public Boolean insertMonHoc(String idMH, String ma_HK, String tenMH, int soTC, int lyThuyet, int thucHanh)
        {
            MonHoc mh = monHoc.Find(x => x.GetIdMH().Equals(idMH));

            if (mh != null) {
                return false;
            }
            mh = new MonHoc(idMH, ma_HK, tenMH, soTC, lyThuyet, thucHanh);
            monHoc.Add(mh);

            return true;
        }

        public Boolean UpdateMonHoc(String idMH, String ma_HK, String tenMH, int soTC, int lyThuyet, int thucHanh) {

            MonHoc mh = monHoc.Find(x => x.GetIdMH().Equals(idMH));
            if (mh == null)
            {
                return false;
            }
            //mh.SetIdMH(idMH);
            mh.SetMa_HK(ma_HK);
            mh.SetTenMH(tenMH);
            mh.SetSoTC(soTC);
            mh.SetLyThuyet(lyThuyet);
            mh.SetThucHanh(thucHanh);

            return true;
        }
        List<MonHoc> getAll() {
            return monHoc;
        }
        public Boolean readData() {

            StreamReader rd;
            if (!File.Exists(fileName))
            {
                FileStream fs = File.Create(fileName);
                rd = new StreamReader(fs, Encoding.UTF8);
            }
            else {
                rd = new StreamReader(this.fileName);
            }

            //String idMH, ma_HK, tenMH;
            //int soTC, lyThuyet, thucHanh;

            String idMH;
            idMH = rd.ReadLine();
            while (idMH != null) {
                MonHoc mh = new MonHoc();
                mh.SetIdMH(idMH);
                mh.SetMa_HK(rd.ReadLine());
                mh.SetTenMH(rd.ReadLine());
                mh.SetSoTC(Convert.ToInt32(rd.ReadLine()));
                mh.SetLyThuyet(Convert.ToInt32(rd.ReadLine()));
                mh.SetThucHanh(Convert.ToInt32(rd.ReadLine()));

                monHoc.Add(mh);

                idMH = rd.ReadLine();
            }

            return true;
        }
        public Boolean writeData()
        {
            StreamWriter wt = new StreamWriter(this.fileName);

            String tmp = "";
            monHoc.ForEach(x =>
            {
                tmp += x.GetIdMH() + "\n";
                tmp += x.GetMa_HK() + "\n";
                tmp += x.GetTenMH() + "\n";
                tmp += x.GetSoTC() + "\n";
                tmp += x.GetLyThuyet() + "\n";
                tmp += x.GetThucHanh() + "\n";
            });

            return true;
        }
    }
}
