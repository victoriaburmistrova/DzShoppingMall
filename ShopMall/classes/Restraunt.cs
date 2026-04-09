
using System.ComponentModel;

namespace ShoppingMall.Classes
{
    public class Restaurant
    {
        public Restaurant() { }
        [DisplayName("Название")]
        [ReadOnly(true)]
        public string Name { get; set; }

        [DisplayName("Кухня")]
        [ReadOnly(true)]
        public string Cuisine { get; set; }

        [DisplayName("Этаж")]
        [ReadOnly(true)]
        public int Floor { get; set; }

        [DisplayName("Кол-во мест")]
        [ReadOnly(true)]
        public int Seats { get; set; }

        [DisplayName("Шеф-повар")]
        [ReadOnly(true)]
        public Chef Chef { get; set; }

        [DisplayName("Контакты")]
        [ReadOnly(true)]
        public Contacts Contacts { get; set; }


    }
}
