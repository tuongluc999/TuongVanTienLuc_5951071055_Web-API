using TuongVanTienLuc_5951071055.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TuongVanTienLuc_5951071055.Controllers
{
    public class StudentController: ApiController
    {
        public IEnumerable<StudentInfo> Get()
        {
            var studentInfoList = new List<StudentInfo>();
            var StudentInfo = new StudentInfo
            {
                hoTen = "Tuong Van Tien Luc",
                msv = "5951071055",
                lop ="Cong Nghe Thong Tin K59"
            };
            studentInfoList.Add(StudentInfo);
            return studentInfoList;
        }
    }
}