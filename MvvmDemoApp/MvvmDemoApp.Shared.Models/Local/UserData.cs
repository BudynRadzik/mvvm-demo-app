using MvvmDemoApp.Shared.Models.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemoApp.Shared.Models.Local
{
    public class UserData
    {
        public string Gender { get; set; }

        // From ApiName
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // From ApiLocation
        // From ApiStreet
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PostCode { get; set; }

        // From ApiCoordinates
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        // From ApiTimezone
        public string TimeZoneOffset { get; set; }
        public string TimeZoneDescription { get; set; }

        public string Email { get; set; }

        // From ApiLogin
        public string UUID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }

        // From ApiDob
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }

        // From ApiRegistered
        public DateTime RegistrationDate { get; set; }
        public int RegistrationAge { get; set; }

        public string Phone { get; set; }
        public string CellPhone { get; set; }

        // From ApiPicture
        public string PictureLarge { get; set; }
        public string PictureMedium { get; set; }
        public string Thumbnail { get; set; }

        public string Nat { get; set; }
    }
}

 
