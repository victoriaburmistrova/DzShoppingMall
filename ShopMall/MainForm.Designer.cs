using Newtonsoft.Json;
using ShoppingMall.Classes;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ShopMall
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView = new System.Windows.Forms.TreeView();
            this.splitter = new System.Windows.Forms.Splitter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelForHelper = new System.Windows.Forms.Panel();
            this.labelToWarn = new System.Windows.Forms.Label();
            this.labelForHelper = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.loadContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.загрузитьJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxCat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelForHelper.SuspendLayout();
            this.loadContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.Brown;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView.ForeColor = System.Drawing.Color.White;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(164, 464);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.Color.Maroon;
            this.splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter.Location = new System.Drawing.Point(164, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(31, 464);
            this.splitter.TabIndex = 1;
            this.splitter.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView.Location = new System.Drawing.Point(195, 281);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(622, 183);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellMouseEnter);
            this.dataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellMouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Brown;
            this.panelTop.Controls.Add(this.panelForHelper);
            this.panelTop.Controls.Add(this.labelForHelper);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnLoad);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(195, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(606, 288);
            this.panelTop.TabIndex = 3;
            // 
            // panelForHelper
            // 
            this.panelForHelper.BackColor = System.Drawing.Color.White;
            this.panelForHelper.Controls.Add(this.labelToWarn);
            this.panelForHelper.Location = new System.Drawing.Point(33, 60);
            this.panelForHelper.Name = "panelForHelper";
            this.panelForHelper.Size = new System.Drawing.Size(181, 45);
            this.panelForHelper.TabIndex = 5;
            // 
            // labelToWarn
            // 
            this.labelToWarn.AutoSize = true;
            this.labelToWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToWarn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelToWarn.Location = new System.Drawing.Point(12, 10);
            this.labelToWarn.Name = "labelToWarn";
            this.labelToWarn.Size = new System.Drawing.Size(132, 25);
            this.labelToWarn.TabIndex = 3;
            this.labelToWarn.Text = "Подсказка! ";
            // 
            // labelForHelper
            // 
            this.labelForHelper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForHelper.ForeColor = System.Drawing.Color.White;
            this.labelForHelper.Location = new System.Drawing.Point(29, 108);
            this.labelForHelper.Name = "labelForHelper";
            this.labelForHelper.Size = new System.Drawing.Size(549, 170);
            this.labelForHelper.TabIndex = 4;
            this.labelForHelper.Text = resources.GetString("labelForHelper.Text");
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(326, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(252, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(33, 16);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(228, 38);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // loadContextMenu
            // 
            this.loadContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.loadContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьJsonToolStripMenuItem,
            this.загрузитьXMLToolStripMenuItem});
            this.loadContextMenu.Name = "loadContextMenu";
            this.loadContextMenu.Size = new System.Drawing.Size(186, 52);
            // 
            // загрузитьJsonToolStripMenuItem
            // 
            this.загрузитьJsonToolStripMenuItem.Name = "загрузитьJsonToolStripMenuItem";
            this.загрузитьJsonToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.загрузитьJsonToolStripMenuItem.Text = "Загрузить JSON";
            this.загрузитьJsonToolStripMenuItem.Click += new System.EventHandler(this.загрузитьJsonToolStripMenuItem_Click);
            // 
            // загрузитьXMLToolStripMenuItem
            // 
            this.загрузитьXMLToolStripMenuItem.Name = "загрузитьXMLToolStripMenuItem";
            this.загрузитьXMLToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.загрузитьXMLToolStripMenuItem.Text = "Загрузить XML";
            this.загрузитьXMLToolStripMenuItem.Click += new System.EventHandler(this.загрузитьXMLToolStripMenuItem_Click);
            // 
            // pictureBoxCat
            // 
            this.pictureBoxCat.Image = global::ShopMall.Properties.Resources.котик;
            this.pictureBoxCat.Location = new System.Drawing.Point(0, 294);
            this.pictureBoxCat.Name = "pictureBoxCat";
            this.pictureBoxCat.Size = new System.Drawing.Size(164, 170);
            this.pictureBoxCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCat.TabIndex = 4;
            this.pictureBoxCat.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 464);
            this.Controls.Add(this.pictureBoxCat);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.treeView);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelForHelper.ResumeLayout(false);
            this.panelForHelper.PerformLayout();
            this.loadContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoad;
        private ContextMenuStrip loadContextMenu;
        private ToolStripMenuItem загрузитьJsonToolStripMenuItem;
        private ToolStripMenuItem загрузитьXMLToolStripMenuItem;
        private Label labelForHelper;
        private Label labelToWarn;
        private Panel panelForHelper;
        private PictureBox pictureBoxCat;
    }
}



