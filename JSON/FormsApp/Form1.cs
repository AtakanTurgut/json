using FormsApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsApp.Models;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        Repositories.WebSiteRepository webSiteRepository;

        public Form1()
        {
            InitializeComponent();
            webSiteRepository = new Repositories.WebSiteRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            List<WebSiteItem> databaseList = webSiteRepository.GetDataList();
            grdList.DataSource = databaseList;
        }

        private void btnNewRegister_Click(object sender, EventArgs e)
        {
            webSiteRepository.Save(new WebSiteItem()
            {
                id = Guid.NewGuid(),
                WebSiteName = txtWebsiteAddress.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Description = txtDescription.Text,
                CreateDate = DateTime.Now,
                ChangePasswordDate = DateTime.Now.AddDays(14),
            });
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txtWebsiteAddress.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtDescription.Clear();
        }
    }
}
