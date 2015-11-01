using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToTwitter;

namespace Presentation
{
  public class TweetModel
  {
    private TweetController _controller;
    private string _tweetText;
    private string _tweetUser;
    public TweetModel(TweetController controller)
    {
      _controller = controller;

    }

    public string TweetText 
    {
      get 
      {
        return _tweetText;
      }
      set 
      {
        _tweetText = value;
      }
    }
    public string TweetUser
    {
      get 
      {
        return _tweetUser;
      }
      set 
      {
        _tweetUser = value;
      }
    }
    
  }
}
