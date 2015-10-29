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
            if (_model.Slides.Count > _model.CurrentSlide +1)
            {
                // next slide is good
                return _model.Slides[_model.CurrentSlide + 1];
            }
            else
            {
                //start over
                return _model.Slides.First();
            }
        }

        public SlideController GetCurrentSlide()
        {
            return _model.Slides[_model.CurrentSlide];
        }

        public SlideController GetPrevSlide()
        {
            if (_model.CurrentSlide - 1 >= 0)
            {
                // prev slide is good
                return _model.Slides[_model.CurrentSlide - 1];
            }
            else
            {
                //start over
                return _model.Slides[_model.Slides.Count -1];
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
                        ImageController image = new ImageController();
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
