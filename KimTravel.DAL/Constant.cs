using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL
{
    public static class Constant
    {

        public static string CurrentSessionUser = "";

        public static List<StatusPartner> getListStatus()
        {
            List<StatusPartner> data = new List<StatusPartner>();
            data.Add(new StatusPartner { ID = 1, Name = "Bình thường" });
            data.Add(new StatusPartner { ID = 2, Name = "Ngưng hợp tác" });
            return data;
        }
        public static List<KindCar> getListKindCar()
        {
            List<KindCar> data = new List<KindCar>();
            data.Add(new KindCar { ID = 1, Name = "Dưới 10 chỗ" });
            data.Add(new KindCar { ID = 2, Name = "Từ 10-20 chỗ" });
            data.Add(new KindCar { ID = 3, Name = "Trên 20 chỗ" });
            return data;
        }
        public static List<StatusStaff> getListStatusStaff()
        {
            List<StatusStaff> data = new List<StatusStaff>();
            data.Add(new StatusStaff { ID = 1, Name = "Bình thường" });
            data.Add(new StatusStaff { ID = 2, Name = "Đã nghỉ việc" });
            data.Add(new StatusStaff { ID = 3, Name = "Nghỉ tạm thời" });
            return data;
        }
        public static List<StatusUser> getListStatusUser()
        {
            List<StatusUser> data = new List<StatusUser>();
            data.Add(new StatusUser { ID = 1, Name = "Bình thường" });
            data.Add(new StatusUser { ID = 2, Name = "Ngưng hoạt động" });
            return data;
        }
        public static List<KindStaff> getListKindStaff()
        {
            List<KindStaff> data = new List<KindStaff>();
            data.Add(new KindStaff { ID = 2, Name = "Hướng dẫn viên (Nội)" });
            data.Add(new KindStaff { ID = 3, Name = "Hướng dẫn viên (Ngoài)" });
            data.Add(new KindStaff { ID = 4, Name = "Tài xế (Nội)" });
            data.Add(new KindStaff { ID = 5, Name = "Tài xế (Ngoài)" });
            data.Add(new KindStaff { ID = 1, Name = "Nhân viên đối tác" });
            return data;
        }
    }
    public class StatusUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class StatusPartner
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class StatusStaff
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class KindStaff
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class KindCar
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
