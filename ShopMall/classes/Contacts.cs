
using System.ComponentModel;

namespace ShoppingMall.Classes
{
    public class Contacts
    {
        [DisplayName("Номер телефона")]
        [ReadOnly(true)]
        public string Phone { get; set; }
        [DisplayName("Почта")]
        [ReadOnly(true)]
        public string Email { get; set; }
        public override string ToString()
        {
            return Phone;
        }
    }
}
