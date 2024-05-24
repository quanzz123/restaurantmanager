using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace restaurant_manager_app.DTO
{
    public class Bill
    {
        public Bill(int id, int trigia, string manv,int soban, DateTime? ngayhd, string status)
        {
            this.Id = id;
            this.Trigia = trigia;
            this.Manv = manv;
            this.Soban = soban;
            this.Ngayhd = ngayhd;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["SoHD"];
            this.Trigia = (int)Convert.ToDouble(row["TriGia"].ToString());
            this.Manv = row["MaNV"].ToString();
            this.Soban = (int)row["SoBan"];
            var check = row["NgayHD"];
            if(check.ToString() != "")
                this.Ngayhd = (DateTime?)row["NgayHD"];
            this.Status = row["TrangThai"].ToString();
        }
        private int id;
        private int trigia;
        private string manv;
        private int soban;
        private DateTime? ngayhd;
        private string status;

        public int Id { get => id; set => id = value; }
        public int Trigia { get => trigia; set => trigia = value; }
        public DateTime? Ngayhd { get => ngayhd; set => ngayhd = value; }
        public string Status { get => status; set => status = value; }
        public string Manv { get => manv; set => manv = value; }
        public int Soban { get => soban; set => soban = value; }
    }
}
