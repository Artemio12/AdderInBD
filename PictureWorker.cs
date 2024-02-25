using AdderInBD.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using ArtLibrary.ControlLogic;

namespace AdderInBD
{
    internal class PictureWorker
    {
        private List<string> pathImages;
        private PictureBox pictureBox;
        private SwitchImageButtons switchButton;

        private int i = 0;

        public PictureWorker(PictureBox pictureBox)
        {
            pathImages = new List<string>();
            switchButton = new SwitchImageButtons();

            this.pictureBox = pictureBox;
        }

        public void LoadPictures(string path)
        {
            foreach (var file in Directory.EnumerateFiles(@path).Where(s => s.EndsWith(".png") || s.EndsWith(".jpg")))
            {
                if (!pathImages.Contains(file)) pathImages.Add(file);
            }
            CheckLoadPictures();
        }
        private void CheckLoadPictures()
        {
            if (pathImages.Count == 0) MessageBox.Show("Нет доступных изображений, выберите другую папку");
            else
            {
                if (Settings.Default.ImageIndex != 0) GetIndex();
                pictureBox.Image = Image.FromFile(pathImages[i]);

                switchButton.PathImages = pathImages;
                switchButton.PictureBox = pictureBox;
            }
        }

        public void CleanPathImages(string path)
        {
            DialogResult result =
                MessageBox.Show("Очистить загруженные изображения?", "Загрузить новые файлы", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    i = 0;
                    pathImages.Clear();
                    LoadPictures(path);
                    break;
                case DialogResult.No:
                    LoadPictures(path);
                    break;
            }
        }

        public void SwitchButton(SwitchButtonEnum button)
        {
            switchButton.SwitchButton(button, ref i);
        }

        private void GetIndex()
        {
            DialogResult result =
                MessageBox.Show("Продолжить с последнего загруженного изображения?", "Продолжить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    i = Settings.Default.ImageIndex;
                    break;
                case DialogResult.No:
                    i = 0;
                    break;
            }
        }
        public void SaveIndex()
        {
            Settings.Default.ImageIndex = i;
            Settings.Default.Save();
        }
       
    }
}
