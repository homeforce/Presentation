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
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            NextSlide();
        }

        public void NextSlide()
        {
            // remove previous slide
            SlideController currSlide = _controller.GetCurrentSlide();
            Controls.Remove(currSlide.GetView());

            // add requested slide
            SlideView nextSlide = _controller.GetNextSlide().GetView();
            nextSlide.Dock = DockStyle.Fill;
            Controls.Add(nextSlide);
            Console.WriteLine("Next slide");
        }
    }
}
