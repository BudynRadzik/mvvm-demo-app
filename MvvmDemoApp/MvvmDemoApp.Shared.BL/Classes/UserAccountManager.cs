using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MvvmDemoApp.Shared.BL.Interfaces;
using MvvmDemoApp.Shared.BL.Static;
using MvvmDemoApp.Shared.Models.Local;
using MvvmDemoApp.Shared.Models.Transfer;

namespace MvvmDemoApp.Shared.BL.Classes
{
    public class UserAccountManager :IUserAccountManager
    {
        public UserData UserData { get; set; } = new UserData();

        public async Task GetUserData()
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(StaticSettings.WebApiUrl);
                UserData.FirstName = DateTime.Now.ToString();
                var apiRoot = await JsonSerializer.DeserializeAsync<ApiRoot>(await response.Content.ReadAsStreamAsync());
                var tmp = apiRoot!.results.FirstOrDefault();

                UserData.Gender = tmp!.gender!;
                UserData.Title = tmp!.name.title!;
                UserData.FirstName = tmp!.name.first!;
                UserData.LastName = tmp!.name.last!;
                UserData.StreetNumber = tmp!.location.street.number;
                UserData.StreetName = tmp!.location.street.name;
                UserData.City = tmp!.location.city;
                UserData.State = tmp!.location.state;
                UserData.Country = tmp!.location.country;
                UserData.PostCode = tmp!.location.postcode;
                UserData.Latitude = tmp!.location.coordinates.latitude;
                UserData.Longitude = tmp!.location.coordinates.longitude;
                UserData.TimeZoneOffset = tmp!.location.timezone.offset;
                UserData.TimeZoneDescription = tmp!.location.timezone.description;
                UserData.Email = tmp!.email;
                UserData.UUID = tmp!.login.uuid;
                UserData.Username = tmp!.login.username;
                UserData.Password = tmp!.login.password;
                UserData.Salt = tmp!.login.salt;
                UserData.Md5 = tmp!.login.md5;
                UserData.Sha1 = tmp!.login.sha1;
                UserData.Sha256 = tmp!.login.sha256;
                UserData.BirthDate = tmp!.dob.date;
                UserData.Age = tmp!.dob.age;
                UserData.RegistrationDate = tmp!.registered.date;
                UserData.RegistrationAge = tmp!.registered.age;
                UserData.Phone = tmp!.phone;
                UserData.CellPhone = tmp!.cell;
                UserData.PictureLarge = tmp!.picture.large;
                UserData.PictureMedium = tmp!.picture.medium;
                UserData.Thumbnail = tmp!.picture.thumbnail;
                UserData.Nat = tmp!.nat;
            }
            catch (Exception ex) { }
            OnUserDataUpdated!.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler? OnUserDataUpdated;

    }
}
