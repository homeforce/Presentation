using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToTwitter;

namespace Presentation
{
  public partial class TweetView : UserControl
  {
    private TweetController _controller;
    public TweetView(TweetController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    private void TweetView_Load(object sender, EventArgs e)
    {

    }

    public void UpdateView()
    {
      lblText.Text = _controller.GetModel().TweetText;
      lblUser.Text = _controller.GetModel().TweetUser;
    }
  }
}
