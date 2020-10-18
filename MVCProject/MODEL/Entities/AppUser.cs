using CORE.CoreEntity;
using System;
using System.ComponentModel.DataAnnotations;

namespace MODEL.Entities
{
    public class AppUser: EntityRepository
    {
        //[MaxLength(50,ErrorMessage ="50 karakterden fazla giriş yapılamaz")]
        public string Name { get; set; }

        //[MaxLength(50, ErrorMessage = "50 karakterden fazla giriş yapılamaz")]
        public string LastName { get; set; }

        //[MaxLength(50, ErrorMessage = "50 karakterden fazla giriş yapılamaz")]
        //[Required(ErrorMessage ="Kullanıcı boş geçilemez")]
        public string UserName { get; set; }

        //[Required(ErrorMessage = "Email boş geçilemez")]
        //[EmailAddress(ErrorMessage ="Email formatında bir giriş yapın.")]
        public string Email { get; set; }

        //[MaxLength(20, ErrorMessage = "20 karakterden fazla giriş //yapılamaz")]
        //[Required(ErrorMessage ="Şifre Boş geçilemez")]
        public string Password { get; set; }

        //[MaxLength(250, ErrorMessage = "250 karakterden fazla giriş yapılamaz")]
        public string Address { get; set; }
       // [MaxLength(11, ErrorMessage = "11 karakterden fazla giriş yapılamaz")]
        public string PhoneNumber { get; set; }
        //[MaxLength(5, ErrorMessage = "5 karakterden fazla giriş yapılamaz")]
        public string Gender { get; set; }
        //[DataType("datetime2")]
        public DateTime  BirthDate { get; set; }
        //[MaxLength(255, ErrorMessage = "255 karakterden fazla giriş yapılamaz")]
        public string ImagePath { get; set; }
    }
}
