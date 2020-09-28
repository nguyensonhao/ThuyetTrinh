﻿using DemoCodePhanHe.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoCodePhanHe.Manager
{
    class HocKyManager
    {
        private List<HocKy> listHK = new List<HocKy>(); // danh sach hoc ky
        private String filename;    // khoi tao bien fike name
        public HocKyManager()
        {
            // ten file
            filename = "../../../Models/Data/HocKy.txt";
            this.readfile();
        }
        /*
          lay danh sach cac hoc ky
         */
        List<HocKy> getAllHocKy()
        {
            return listHK;
        }
        /**
         * ham them hoc ky moi
         */
        public Boolean insertHocKy(string MA_HK, string MA_NH, string HK)
        {   // tim xem ma hoc ky co ton tai hay khong
            HocKy hk = listHK.Find(x => x.getMA_HK().Equals(MA_HK));
            // neu ma hk co ton tai tra ve false
            if (hk != null)
            {
                return false;
            }
            // add hoc ky vao mang
            listHK.Add(new HocKy(MA_HK, MA_NH, HK));
            return true;
        }
        /**
         * Cap nhat hoc ky
         */
        public Boolean updateHocKy(string MA_HK, string MA_NH, string HK)
        {   // tim xem ma hoc ky co ton tai hay khong 
            HocKy hk = listHK.Find(x => x.getMA_HK().Equals(MA_HK));
            // neu ma hoc ky ton tai tra ve false
            if (hk != null)
            {
                return false;
            }

            // goi ham set de sua doi thong tin
            hk.setMA_HK(MA_HK);
            hk.setMA_NH(MA_NH);
            hk.setHK(HK);
            return true;
        }

        /**
         * Doc file
         */
        public Boolean readfile()
        {
            StreamReader rd;
            // neu chua co file thi tao file
            if (!File.Exists(filename))
            {
                FileStream fs = File.Create(filename);
                rd = new StreamReader(fs, Encoding.UTF8);
            }
            else
            {
                // read file
                rd = new StreamReader(filename);
            }
            //doc Id Hoc ky
            String MA_HK = rd.ReadLine();
            //neu khong co Id hoc ky thi ngung vong lap
            while (MA_HK != null)
            {
                String Ma_HK = rd.ReadLine();
                String MA_NH = rd.ReadLine();
                String HK = rd.ReadLine();

                //add Hoc ky moi vao danh sach
                listHK.Add(new HocKy(MA_HK, MA_NH, HK));
                MA_HK = rd.ReadLine();
            }

            rd.Close();

            return true;
        }
        /**
        * Ghi file
        */
        public Boolean writeFile()
        {
            String values = "";         //noi dung file
            listHK.ForEach(x =>
            {
                values += x.getMA_HK() + "\n";
                values += x.getMA_NH() + "\n";
                values += x.getHK() + "\n";
            });

            try
            {
                StreamWriter wt = new StreamWriter(filename);
                wt.Write(values);
                wt.Close();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}

