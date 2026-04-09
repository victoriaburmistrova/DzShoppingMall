
using System.ComponentModel;

namespace ShoppingMall.Classes
{
    public class Chef
    {
        [DisplayName("Имя")]
        [ReadOnly(true)]
        public string Name { get; set; }
        [DisplayName("Опыт работы (в годах)")]
        [ReadOnly(true)]
        public int Experience { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
