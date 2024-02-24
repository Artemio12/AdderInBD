using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Data.Common;
using System.Net;
using System.Drawing.Imaging;
using System.Xml.Linq;
using System.Collections.Specialized;
using AdderInBD.Properties;
using ArtLibrary.Sql;
using ArtLibrary.ControlLogic;

namespace AdderInBD
{
    public enum EnumControlTags
    {
        DataControl,
        GettingControl
    }

    public enum EnumColumnName
    {
        None,
        TimeSkip,
        Arc,
        Сharacter,
        CodePhrase,
        CoolPhrase,
        СloseUpFace,
        ScreenShoot,
    }

    public partial class AdderInDB : Form
    {
        private List<Control> panels;

        private List<Control> insertDataControls;
        private List<ComboBox> dataComboBoxes;

        private List<ComboBox> gettingComboBoxes;
        private List<string> pathImages;

        private List<string> columnNames;

        AdderItems adderItems;
        BrowseButton browse;
        VisibilityInverter<Control> inverter;

        AdderSqlTextParams sqlTextParams;
        AdderSqlImageParams sqlImageParams;
        Checker checker;



        private string column1 = nameof(EnumColumnName.TimeSkip);
        private string column2 = nameof(EnumColumnName.Arc);
        private string column3 = nameof(EnumColumnName.Сharacter);
        private string column4 = nameof(EnumColumnName.CodePhrase);
        private string column5 = nameof(EnumColumnName.CoolPhrase);
        private string column6 = nameof(EnumColumnName.СloseUpFace);
        private string column7 = nameof(EnumColumnName.ScreenShoot);

        private int i = 0;

        public AdderInDB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pathImages = new List<string>();

            columnNames = new List<string>() { column1, column2, column3, column4, column5, column6};
            dataComboBoxes = new List<ComboBox>();
            gettingComboBoxes = new List<ComboBox>();

            adderItems = new AdderItems();
            browse = new BrowseButton();
            inverter = new VisibilityInverter<Control>();

            sqlTextParams = new AdderSqlTextParams();
            sqlImageParams = new AdderSqlImageParams();
            checker = new Checker();

            gettingComboBoxes = (from Control v in getPathPanel.Controls
                                   where v.Tag?.ToString() == nameof(EnumControlTags.GettingControl)
                                   select v as ComboBox).ToList();

            insertDataControls  = (from Control v in InsertPage.Controls
                                   where v.Tag?.ToString() == nameof(EnumControlTags.DataControl)
                                   orderby v.Name.Substring(v.Name.Length-1)
                                   select v).ToList();

            panels = (from Control v in InsertPage.Controls
                            where v as Panel != null
                            select v).ToList();

            foreach (var element in insertDataControls)
            {
                if (element as ComboBox != null) dataComboBoxes.Add(element as ComboBox);
            }
        }

        //private void AddComboBoxItem(List<ComboBox> comboBoxList)
        //{
        //    foreach (var comboBox in comboBoxList)
        //    {
        //        AddComboBoxItem(comboBox);
        //    }
        //}

        //private void AddComboBoxItem(ComboBox comboBox)
        //{
        //    if (!comboBox.Items.Contains(comboBox.Text))
        //    {
        //        comboBox.SelectedIndex = comboBox.Items.Add(comboBox.Text);
        //        using (var stream = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"UserData\{comboBox.Name}"), true))
        //        {
        //            stream.WriteLine(comboBox.Text);
        //        }
        //    }
        //}

        private void BackButton_Click(object sender, EventArgs e)
        {
            inverter.InvertVisibility(panels);
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            if (connectionStrComboBox.Text == string.Empty || folderPathComboBox.Text == string.Empty 
                || connectionStrComboBox.SelectedIndex == -1 || folderPathComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Данные не введены или введены неправильно, проверьте корректность данных");
                return;
            }
            else CheckData(connectionStrComboBox.Text, folderPathComboBox.Text);

            if ( connectionStrComboBox.SelectedIndex != -1 && folderPathComboBox.SelectedIndex != -1 )
            {
                if (pathImages.Count == 0)
                {
                    LoadPictures(folderPathComboBox.SelectedItem.ToString());
                    inverter.InvertVisibility(panels);
                }
                else CleanPathImages();

               adderItems.AddComboBoxItem(gettingComboBoxes);
            }
        }

        private void CheckData(string connectionString, string path)
        {
            checker.CheckConnection(connectionString);
            checker.CheckFolderPath(path);
        } 
        //private void CheckConnection(string connectionString)
        //{
        //    try
        //    {   
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            if (connection.State == ConnectionState.Open)
        //            {
        //                MessageBox.Show("Подключение к базе данных успешно установлено");
        //                this.connectionString = connectionString;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Не получилось установить подключение к базе данных. Проверьте правильность строки подключения");
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Строка подключения не введена или не соответствует формату. Проверьте правильность строки подключения");
        //    }
        //}
        //private void CheckPath(string path)
        //{
        //    if (!Directory.Exists(@path))
        //    {
        //        MessageBox.Show("Папки не существует. Проверьте правильность пути");
        //    }
        //}

        private void LoadPictures(string path)
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
                pictureBox1.Image = Image.FromFile(pathImages[i]);
            } 
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
           browse.BrowseFolder();
           folderPathComboBox.Text = browse.FolderPath;
        }

        private void ChooseFolderButton_Click(object sender, EventArgs e)
        {
            if (!backButton.Visible) backButton.Visible = true;
            folderPathComboBox.SelectedIndex = -1;
            inverter.InvertVisibility(panels);
        }
        private void LastScreenButton_Click(object sender, EventArgs e)
        {
            if (i != 0)
            {
                i--;
                ShowPicture(i);
            }
            else MessageBox.Show("Это первое изображение в папке");
        }
        private void NextScreen_Click(object sender, EventArgs e)
        {
            if (i != pathImages.Count - 1)
            {
                i++;
                ShowPicture(i);
            }
            else MessageBox.Show("Все изображения в папке показаны");
        }
        private void ShowPicture(int i)
        {
            pictureBox1.Image = Image.FromFile(pathImages[i]);
        }
        private void InsertButton_Click(object sender, EventArgs e)
        {
            adderItems.AddComboBoxItem(dataComboBoxes);
            InsertInDB();
        }
        private void InsertInDB()
        {
            using (SqlConnection connection = new SqlConnection(checker.CheckedConnectionString))
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText =
                    "INSERT INTO [OnePieceScreens] (TimeSkip, Arc, Сharacter, CodePhrase, CoolPhrase, СloseUpFace, ScreenShoot)" +
                    " VALUES (@TimeSkip, @Arc, @Сharacter, @CodePhrase, @CoolPhrase, @СloseUpFace, @ScreenShoot)";

                sqlTextParams.Add(cmd, columnNames, insertDataControls);
                sqlImageParams.Add(cmd, column7, pictureBox1.Image, ImageFormat.Png);
                //foreach (var element in columnNames.Zip(insertDataControls, Tuple.Create))
                //{
                //    command.Parameters.AddWithValue(element.Item1, element.Item2.Text);
                //}

                //command.Parameters.Add(uploader.CreateSqlParameter(column7, pictureBox1.Image));

                if (coolPhrase_5.Text != string.Empty) coolPhrase_5.Clear();
                if (codePhraseTextBox_4.Text != string.Empty) codePhraseTextBox_4.Clear();

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void CleanPathImages()
        {
            DialogResult result = MessageBox.Show("Очистить загруженные изображения?", "Загрузить новые файлы", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    pathImages.Clear();
                    i = 0;
                    LoadPictures(folderPathComboBox.SelectedItem.ToString());
                    break;
                case DialogResult.No:
                    LoadPictures(folderPathComboBox.SelectedItem.ToString());
                    break;
            }
        }
        private void GetIndex()
        {
            DialogResult result = MessageBox.Show("Продолжить с последнего загруженного изображения?", "Продолжить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void AdderInDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.ImageIndex = i;
            Settings.Default.Save();
        }
    }
}
