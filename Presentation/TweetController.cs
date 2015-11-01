using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
  public class TweetController
  {
    private TweetModel _model;
    private TweetView _view;

    public TweetController()
    {
      _model = new TweetModel(this);
      _view = new TweetView(this);
    }
    public void SetTweet(string user, string text)
    {
      _model.TweetUser = user;
      _model.TweetText = text;
      _view.UpdateView();
    }
    public TweetModel GetModel()
    {
      return _model;
    }
    public TweetView GetView()
    {
      return _view;
    }



  }
}
