
using System.ComponentModel;

namespace ShoppingMall.Classes
{
    public class Cinema
    {
        public Cinema() { }
        [DisplayName("Название")]
        [ReadOnly(true)]
        public string Name { get; set; }
        [DisplayName("Количество залов")]
        [ReadOnly(true)]
        public int Halls { get; set; }
        [DisplayName("Формат")]
        [ReadOnly(true)]
        public string Format { get; set; }
        [DisplayName("Этаж")]
        [ReadOnly(true)]
        public int Floor { get; set; }
        [DisplayName("Директор")]
        [ReadOnly(true)]
        public Director Director { get; set; }
        [DisplayName("Расписание")]
        [ReadOnly(true)]
        public Schedule Schedule { get; set; }
    }
}
