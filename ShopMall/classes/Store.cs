using System.ComponentModel;

namespace ShoppingMall.Classes
{
    public class Store
    {
        public Store() { }
        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Категория")]
        public string Category { get; set; }

        [DisplayName("Этаж")]
        public int Floor { get; set; }

        [DisplayName("Площадь (кв.м)")]
        public int Area { get; set; }

        [DisplayName("Владелец")]
        public Owner Owner { get; set; }

        [DisplayName("Контакты")]
        public Contacts Contacts { get; set; }
    }
}
