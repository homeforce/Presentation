﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Presentation
{
  public partial class ImageView : UserControl
  {
    private ImageController _controller;
    public ImageView(ImageController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    private void ImageView_Load(object sender, EventArgs e)
    {

    }
    public void UpdateView()
    {
      //FileStream fs = new System.IO.FileStream(_controller.GetModel().ImagePath, FileMode.Open, FileAccess.Read);
      //pictureBox1.Image = Image.FromStream(fs);
      //fs.Close();
      pictureBox1.Image = Image.FromFile(@"C:\Users\ruben_000\Dropbox\Photos\Pictures\70skate3.jpg");

    }
  }
}