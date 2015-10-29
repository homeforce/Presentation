using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PresentationView : Form
    {
        private PresentationController _controller;

        public PresentationView(PresentationController controller)
        {
            _controller = controller;

            InitializeComponent();
        }

        private void PresentationView_Load(object sender, EventArgs e)
        {
          TweetController tweet = new TweetController();
          tweet.SetTweet("Rubends", "wauw, wat eeen mooie app");
          //ImageController image = new ImageController();
          //image.SetImage(@"C:\Users\ruben_000\Dropbox\Photos\Pictures\70skate3.jpg");
          SlideController slide = new SlideController();
          slide.SetSlide(tweet);

          Controls.Add(slide.GetView());
        }

        private void PresentationView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("closed form");
            Application.Exit();
        }

        public void startPresentation()
        {
            //List<SlideController> slides = _controller.getModel().Slides;
            //foreach (SlideController slide in slides)
            //{
            //    int xPos = this.Width * slides.IndexOf(slide);
            //    slide.GetView().Location = new Point(xPos, 0);
            //    Controls.Add(slide.GetView());
            //}

            ShowSlide(0);


        }

        public void ShowSlide(int slideNr)
        {
            Controls.Add(_controller.getModel().Slides[slideNr].GetView());
            _controller.getModel().CurrentSlide = slideNr;
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            NextSlide();
        }

        public void NextSlide()
        {
            SlideController nextSlide = _controller.GetNextSlide();
            SlideController prevSlide = _controller.GetPrevSlide();
            SlideController currSlide = _controller.GetCurrentSlide();
            nextSlide.GetView().Location = new Point(60, 0);
            Controls.Add(nextSlide.GetView());
            Controls.Remove(currSlide.GetView());
            Console.WriteLine("Next slide");
        }
    }
}
