using Newtonsoft.Json;
using ShoppingMall.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ShopMall
{
    public partial class MainForm : Form
    {
        Mall mall;
        public MainForm()
        {
            
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Point menuPoint = new Point(0, btn.Height); 
            loadContextMenu.Show(btn, menuPoint);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            object cellValue = dataGridView[e.ColumnIndex, e.RowIndex].Value;
            if (cellValue != null && cellValue.GetType().Namespace == "ShoppingMall.Classes")
            {
                DetailForm detailForm = new DetailForm(cellValue);
                detailForm.ShowDialog(); 
            }
        }
        private void FillTree()
        {
            treeView.Nodes.Clear();
            TreeNode root = new TreeNode("Торговый центр");
            TreeNode store = new TreeNode("Магазин");
            TreeNode restaurant = new TreeNode("Ресторан");
            TreeNode cinema = new TreeNode("Кинотеатр");
            root.Nodes.Add(store);
            root.Nodes.Add(restaurant);
            root.Nodes.Add(cinema);
            treeView.Nodes.Add(root);
            treeView.ExpandAll();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Магазин")
                dataGridView.DataSource = new List<Store> { mall.Store };
            if (e.Node.Text == "Ресторан")
                dataGridView.DataSource = new List<Restaurant> { mall.Restaurant };
            if (e.Node.Text == "Кинотеатр")
                dataGridView.DataSource = new List<Cinema> { mall.Cinema };
        }

        private void загрузитьJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAndDeserializeFile(".json");
        }

        private void загрузитьXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAndDeserializeFile(".xml");
        }

        private void LoadAndDeserializeFile(string fileExtension)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (fileExtension == ".json")
            {
                ofd.Filter = "JSON files (*.json)|*.json";
            }
            else if (fileExtension == ".xml")
            {
                ofd.Filter = "XML files (*.xml)|*.xml";
            }

            ofd.Title = "Выберите файл";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;

                try 
                {
                    if (fileExtension == ".json")
                    {
                        string json = File.ReadAllText(path);
                        mall = JsonConvert.DeserializeObject<Mall>(json);
                    }
                    else if (fileExtension == ".xml")
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Mall));
                        using (FileStream fs = new FileStream(path, FileMode.Open))
                        {
                            mall = (Mall)serializer.Deserialize(fs);
                        }
                    }

                    if (mall != null)
                    {
                        FillTree();
                        MessageBox.Show("Файл успешно загружен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось десериализовать файл. Возможно, он пустой или имеет неверный формат.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при чтении или обработке файла:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object cellValue = dataGridView[e.ColumnIndex, e.RowIndex].Value;

                if (cellValue != null && cellValue.GetType().Namespace == "ShoppingMall.Classes")
                {
                    dataGridView.Cursor = Cursors.Hand;
                }
                
            }
        }
        
        private void dataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.Cursor = Cursors.Default;
        }
    }
}
