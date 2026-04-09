
using System.ComponentModel;

namespace ShoppingMall.Classes
{
    public class Cinema
    {
        public Cinema() { }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Количество залов")]
        public int Halls { get; set; }
        [DisplayName("Формат")]
        public string Format { get; set; }
        [DisplayName("Этаж")]
        public int Floor { get; set; }
        [DisplayName("Директор")]
        public Director Director { get; set; }
        [DisplayName("Расписание")]
        public Schedule Schedule { get; set; }
    }
}
