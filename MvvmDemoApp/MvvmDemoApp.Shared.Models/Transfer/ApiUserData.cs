using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MvvmDemoApp.Shared.Models.Transfer
{
    public class ApiRoot
    {
        public List<ApiResult> results { get; set; }

        public ApiInfo info { get; set; }
    }
    public class ApiResult
    {

        public string gender { get; set; }
        public ApiName name { get; set; }
        public ApiLocation location { get; set; }
        public string email { get; set; }
        public ApiLogin login { get; set; }
        public ApiDob dob { get; set; }
        public ApiRegistered registered { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public ApiId id { get; set; }
        public ApiPicture picture { get; set; }
        public string nat { get; set; }
    }
    public class ApiInfo
    {
        public string seed { get; set; }
        public int results { get; set; }
        public int page { get; set; }
        public string version { get; set; }
    }
    public class ApiName
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }

    public class ApiLocation
    {
        public ApiStreet street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int postcode { get; set; }
        public ApiCoordinates coordinates { get; set; }
        public ApiTimezone timezone { get; set; }
    }

    public class ApiLogin
    {
        public string uuid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
    }

    public class ApiDob
    {
        public DateTime date { get; set; }
        public int age { get; set; }
    }

    public class ApiRegistered
    {
        public DateTime date { get; set; }
        public int age { get; set; }
    }

    public class ApiId
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class ApiPicture
    {
        public string large { get; set; }
        public string medium { get; set; }
        public string thumbnail { get; set; }
    }

    public class ApiCoordinates
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class ApiStreet
    {
        public int number { get; set; }
        public string name { get; set; }
    }

    public class ApiTimezone
    {
        public string offset { get; set; }
        public string description { get; set; }
    }

}
