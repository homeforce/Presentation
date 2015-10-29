using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
  public partial class SlideView : UserControl
  {
    private SlideController _controller;
    public SlideView(SlideController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    public void UpdateView()
    {
      if(_controller.GetModel().SlideType == GlobalVar.SLIDE_TYPE_TWEET)
            {
                _controller.GetModel().Tweet.GetView().Dock = DockStyle.Fill;
                Controls.Add(_controller.GetModel().Tweet.GetView());
      }
      else if (_controller.GetModel().SlideType == GlobalVar.SLIDE_TYPE_IMAGE)
      {
            _controller.GetModel().Image.GetView().Dock = DockStyle.Fill;
            Controls.Add(_controller.GetModel().Image.GetView());
      }
    }
    private void SlideView_Load(object sender, EventArgs e)
    {

    }
  }
}
