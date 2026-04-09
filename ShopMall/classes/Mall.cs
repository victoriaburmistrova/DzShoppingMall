

using System.ComponentModel;

namespace ShoppingMall.Classes
{
    public class Mall
    {
        public Mall() { }
        [DisplayName("Магазин")]
        public Store Store { get; set; }
        [DisplayName("Ресторан")]
        public Restaurant Restaurant { get; set; }
        [DisplayName("Кинотеатр")]
        public Cinema Cinema { get; set; }
        
    }
}
