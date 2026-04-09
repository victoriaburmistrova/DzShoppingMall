
using System.ComponentModel;

namespace ShoppingMall.Classes
{
    public class Schedule
    {
        [DisplayName("Фильм")]
        [ReadOnly(true)]
        public string Movie { get; set; }
        [DisplayName("Время")]
        [ReadOnly(true)]
        public string Time { get; set; }
        public override string ToString()
        {
            return Movie;
        }
    }
}
