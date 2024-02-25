using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using ArtLibrary.Sql;           //My custom 
using ArtLibrary.ControlLogic; // libraries

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
        private PictureWorker pictureWorker;

        private AdderItems adderItems;
        private BrowseButton browse;
        private VisibilityInverter<Control> inverter;

        private AdderSqlTextParams textAdder;
        private AdderSqlImageParams imageAdder;
        private Checker checker;

        private List<Control> panels;

        private List<Control> insertDataControls;
        private List<ComboBox> dataComboBoxes;

        private List<ComboBox> gettingComboBoxes;
        private List<string> pathImages;

        private List<string> columnNames;

        private string column1 = nameof(EnumColumnName.TimeSkip);
        private string column2 = nameof(EnumColumnName.Arc);
        private string column3 = nameof(EnumColumnName.Сharacter);
        private string column4 = nameof(EnumColumnName.CodePhrase);
        private string column5 = nameof(EnumColumnName.CoolPhrase);
        private string column6 = nameof(EnumColumnName.СloseUpFace);
        private string column7 = nameof(EnumColumnName.ScreenShoot);

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

            pictureWorker = new PictureWorker(pictureBox1);

            adderItems = new AdderItems();
            browse = new BrowseButton();
            inverter = new VisibilityInverter<Control>();

            textAdder = new AdderSqlTextParams();
            imageAdder = new AdderSqlImageParams();
            checker = new Checker();

            var comboBoxes = from Control v in InsertPage.Controls
                             where v as ComboBox != null
                             select v as ComboBox;

            insertDataControls = (from Control v in InsertPage.Controls
                                  where v.Tag?.ToString() == nameof(EnumControlTags.DataControl)
                                  orderby v.Name.Substring(v.Name.Length - 1)
                                  select v).ToList();

            panels = (from Control v in InsertPage.Controls
                      where v as Panel != null
                      select v).ToList();

            gettingComboBoxes = (from v in comboBoxes
                                   where v.Tag?.ToString() == nameof(EnumControlTags.GettingControl)
                                   select v ).ToList();

            dataComboBoxes = (from v in comboBoxes
                              where v.Tag?.ToString() == nameof(EnumControlTags.DataControl)
                              select v ).ToList();
        }

        private void CheckData(string connectionString, string path)
        {
            checker.CheckConnection(connectionString);
            checker.CheckFolderPath(path);
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            if (connectionStrComboBox.Text == string.Empty || folderPathComboBox.Text == string.Empty)
            {
                MessageBox.Show("Данные не введены или введены неправильно, проверьте корректность данных");
                return;
            }
            else CheckData(connectionStrComboBox.Text, folderPathComboBox.Text);

            if ( checker.CheckedConnection && checker.CheckedPath)
            {
                if (pathImages.Count == 0)
                {
                    pictureWorker.LoadPictures(folderPathComboBox.SelectedItem.ToString());
                    inverter.InvertVisibility(panels);
                }
                else pictureWorker.CleanPathImages(folderPathComboBox.SelectedItem.ToString());

                adderItems.AddComboBoxItem(gettingComboBoxes);
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
           browse.Browse();
           folderPathComboBox.Text = browse.FolderPath;
        }
        private void ChooseFolderButton_Click(object sender, EventArgs e)
        {
            if (!backButton.Visible) backButton.Visible = true;
            folderPathComboBox.SelectedIndex = -1;
            inverter.InvertVisibility(panels);
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            inverter.InvertVisibility(panels);
        }

        private void LastScreenButton_Click(object sender, EventArgs e)
        {
            pictureWorker.SwitchButton(SwitchButtonEnum.LastPicture);
        }
        private void NextScreen_Click(object sender, EventArgs e)
        {
            pictureWorker.SwitchButton(SwitchButtonEnum.NextPicture);
        }
   
        private void InsertButton_Click(object sender, EventArgs e)
        {
            adderItems.AddComboBoxItem(dataComboBoxes);
            InsertInDB();
        }
        private void InsertInDB()
        {
            if (checker.CheckedConnection)
            {
                using (var connection = new SqlConnection(checker.ConnectionString))
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText =
                        "INSERT INTO [OnePieceScreens] (TimeSkip, Arc, Сharacter, CodePhrase, CoolPhrase, СloseUpFace, ScreenShoot)" +
                        " VALUES (@TimeSkip, @Arc, @Сharacter, @CodePhrase, @CoolPhrase, @СloseUpFace, @ScreenShoot)";

                    textAdder.Add(cmd, columnNames, insertDataControls);
                    imageAdder.Add(cmd, column7, pictureBox1.Image, ImageFormat.Png);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void AdderInDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureWorker.SaveIndex();
        }
    }
}
