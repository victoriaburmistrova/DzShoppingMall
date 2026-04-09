
using System.ComponentModel;

namespace ShoppingMall.Classes
{
    public class Restaurant
    {
        public Restaurant() { }
        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Кухня")]
        public string Cuisine { get; set; }

        [DisplayName("Этаж")]
        public int Floor { get; set; }

        [DisplayName("Кол-во мест")]
        public int Seats { get; set; }

        [DisplayName("Шеф-повар")]
        public Chef Chef { get; set; }

        [DisplayName("Контакты")]
        public Contacts Contacts { get; set; }


    }
}
