
using System.ComponentModel;

namespace ShoppingMall.Classes
{
    public class Director
    {
        [DisplayName("Имя")]
        [ReadOnly(true)]
        public string Name { get; set; }
        [DisplayName("Возраст")]
        [ReadOnly(true)]
        public int Age { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
