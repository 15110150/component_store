using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BALayer;
using System.Windows.Forms;

namespace LinhKien
{
    public partial class FormNhapServer : DevExpress.XtraEditors.XtraForm
    {
        bool isLogin = false;
        BAServer BAsever = new BAServer();
        List<string> dbList;
        public FormNhapServer()
        {
            InitializeComponent();
        }
        private class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void Test()
        {
            ComboboxItem item = new ComboboxItem();
            item.Text = "HAVI";
            item.Value = "172.16.84.236";
            cbbServer.Items.Add(item);

            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "TUAN";
            item2.Value = "192.168.43.156";
            cbbServer.Items.Add(item2);


            ComboboxItem item3 = new ComboboxItem();
            item3.Text = "Quoc Anh";
            item3.Value = "192.168.137.1";


            cbbServer.Items.Add(item3);

        }
        private void FormNhapServer_Load(object sender, EventArgs e)
        {
            Test();
            txtPass.Enabled = false;
            txtUser.Enabled = false;
            btnGetData.Enabled = false;
            cbbData.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BAsever.Authentication((cbbServer.SelectedItem as ComboboxItem).Value.ToString(),
                txtUser.Text, txtPass.Text, cbbData.Text.ToString(), rdSQL.Checked))
            {
                this.isLogin = true;
                FormLogonCT fr = new FormLogonCT();
                fr.Show();
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            dbList = BAsever.getDatabaseList((cbbServer.SelectedItem as ComboboxItem).Value.ToString(), txtUser.Text, txtPass.Text);
            foreach (string i in dbList)
                cbbData.Items.Add(i);
            cbbData.Enabled = true;
        }

        private void rdSQL_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            btnGetData.Enabled = true;
        }

        private void rdWT_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.Enabled = false;
            txtUser.Enabled = false;
            btnGetData.Enabled = false;
            cbbData.Enabled = false;
        }
    }
}
