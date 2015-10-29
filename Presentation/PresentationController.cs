using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public class PresentationController
    {
        private PresentationView _view;
        private MainController _mainController;
        private PresentationModel _model;

        public PresentationController(MainController mainController)
        {
            _view = new PresentationView(this);
            _model = new PresentationModel(this);
            _view.Show();
            _mainController = mainController;

            // set empty slide 
            _model.EmptySlide = new SlideController();
            TweetController emptyTweet = new TweetController();
            emptyTweet.SetTweet("No slides", "Please load images or tweets?");
            _model.EmptySlide.SetSlide(emptyTweet);
            _model.addSlide(_model.EmptySlide);
            _view.startPresentation();
        }

        public PresentationView getView()
        {
            return _view;
        }

        public PresentationModel getModel()
        {
            return _model;
        }

        public SlideController GetNextSlide()
        {
            if(_model.Slides.Count > 0)
            {
                if (_model.Slides.Count > _model.CurrentSlide + 1)
                {
                    // next slide is good
                    _model.CurrentSlide++;
                    return _model.Slides[_model.CurrentSlide];
                }
                else
                {
                    //start over
                    _model.CurrentSlide = 0;
                    return _model.Slides.First();
                }
            } else
            {
                _model.CurrentSlide = 0;
                return _model.EmptySlide;
            }
        }

        public SlideController GetCurrentSlide()
        {
            if (_model.Slides.Count > 0) return _model.Slides[_model.CurrentSlide];
            else
            {
                _model.CurrentSlide = 0;
                return _model.EmptySlide;
            }
        }

        public SlideController PrevSlide()
        {
            if(_model.Slides.Count > 0)
            {
                if (_model.CurrentSlide - 1 >= 0)
                {
                    // prev slide is good
                    _model.CurrentSlide--;
                    return _model.Slides[_model.CurrentSlide];
                }
                else
                {
                    //start over
                    _model.CurrentSlide = _model.Slides.Count - 1;
                    return _model.Slides[_model.CurrentSlide];
                }
            } else
            {
                _model.CurrentSlide = 0;
                return _model.EmptySlide;
            }
        }

        public void loadImages()
        {
            string imagesPath = _mainController.getSettingsController().getImagesFolderPath(); // image path uit settings Model
            if (imagesPath == null)
            {
                MessageBox.Show("No image folder path set!", "Error");
            }
            else
            {
                ImageDirectory imagesDir = new ImageDirectory(imagesPath);
                if (imagesDir.getLength() > 0)
                {
                    MessageBox.Show("Files loaded: " + imagesDir.getLength().ToString(), "Message");
                    foreach(string imagePath in imagesDir.getImagePaths())
                    {
                        ImageController image = new ImageController(this);
                        image.SetImage(imagePath);
                        SlideController slide = new SlideController();
                        slide.SetSlide(image);
                        _model.addSlide(slide);
                        _view.startPresentation();
                    }
                }
                else
                {
                    MessageBox.Show("No files found.", "Error");
                }
            }
        }
    }
}
