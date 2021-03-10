using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploStorageBlob
{
    public partial class Form1: Form
    {
        ServiceStorageBlobs service;

        public Form1 ()
        {
            InitializeComponent();
            this.service = new ServiceStorageBlobs();
            this.btnsubirblob.Enabled = false;
            this.btneliminarblob.Enabled = false;
            //this.btncrearcontenedor.Enabled = false;
            this.CargarContainers();
        }

        private void CargarContainers()
        {
            this.lstcontenedores.Items.Clear();
            foreach (String c in this.service.GetContainers())
            {
                this.lstcontenedores.Items.Add(c);
            }
        }

        private async void btncrearcontenedor_Click(object sender, EventArgs e)
        {
            await this.service.CreateContainerAsync(this.txtcontenedor.Text.ToLower());
            this.CargarContainers();
        }

        private void CargarBlobs()
        {
            this.lsvblobs.Items.Clear();
            String containername = this.lstcontenedores.SelectedItem.ToString();
            foreach (CloudBlockBlob blob in this.service.GetBlobs(containername))
            {
                String uri = blob.StorageUri.PrimaryUri.ToString();
                String size = blob.Properties.Length.ToString();
                ListViewItem it = new ListViewItem();
                it.Text = uri;
                it.SubItems.Add(size);
                this.lsvblobs.Items.Add(it);
            }
        }

        private async void btnsubirblob_Click(object sender, EventArgs e)
        {
            if (this.lstcontenedores.SelectedIndex != -1)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    String path = ofd.FileName;
                    String filename = path.Substring(path.LastIndexOf(@"\") + 1);
                    String containername = this.lstcontenedores.SelectedItem.ToString();
                    await this.service.UploadBlobAsync(containername, filename, path);
                    this.CargarBlobs();
                }
            }
        }

        private void lstcontenedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstcontenedores.SelectedIndex != -1)
            {
                this.CargarBlobs();
                this.btnsubirblob.Enabled = true;
            }
            else
            {
                this.btnsubirblob.Enabled = false;
            }
        }

        private void lsvblobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvblobs.SelectedItems.Count != 0)
            {
                String uri = this.lsvblobs.SelectedItems[0].Text;
                this.pictureBox.Load(uri);
                this.btneliminarblob.Enabled = true;
            }
            else
            {
                this.btneliminarblob.Enabled = false;
            }
        }

        private async void btneliminarblob_Click(object sender, EventArgs e)
        {
            if (this.lsvblobs.SelectedIndices.Count != 0)
            {
                String uri = this.lsvblobs.SelectedItems[0].Text;
                String filename = uri.Substring(uri.LastIndexOf("/") + 1);
                String containername = this.lstcontenedores.SelectedItem.ToString();
                await this.service.DeleteBlobAsync(containername, filename);
                this.CargarBlobs();
                this.btneliminarblob.Enabled = false;
            }
        }

        private void txtcontenedor_TextChanged(object sender, EventArgs e)
        {
            if (this.txtcontenedor.Text.Length > 0)
            {
                this.btncrearcontenedor.Enabled = true;
            }
        }
    }
}
