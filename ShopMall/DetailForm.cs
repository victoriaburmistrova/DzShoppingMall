using System;
using System.Windows.Forms;

namespace ShopMall
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }
        public DetailForm(object selectedObject)
        {
            InitializeComponent(); 
            propertyGrid.SelectedObject = selectedObject;

            if (selectedObject != null)
            {
                this.Text = $"Свойства: {selectedObject.GetType().Name}";
            }
        }
        private void buttonForBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
