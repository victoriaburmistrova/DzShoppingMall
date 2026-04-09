using System.ComponentModel;

namespace ShoppingMall.Classes
{
    public class Store
    {
        public Store() { }
        [DisplayName("Название")]
        [ReadOnly(true)]
        public string Name { get; set; }

        [DisplayName("Категория")]
        [ReadOnly(true)]
        public string Category { get; set; }

        [DisplayName("Этаж")]
        [ReadOnly(true)]
        public int Floor { get; set; }

        [DisplayName("Площадь (кв.м)")]
        [ReadOnly(true)]
        public int Area { get; set; }

        [DisplayName("Владелец")]
        [ReadOnly(true)]
        public Owner Owner { get; set; }

        [DisplayName("Контакты")]
        [ReadOnly(true)]
        public Contacts Contacts { get; set; }
    }
}
