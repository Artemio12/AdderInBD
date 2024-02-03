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

namespace AdderInBD
{
    public enum EnumColumnName
    {
        None,
        TimeSkip,
        Arc,
        Сharacter,
        CoolPhrase,
        CloseUpFace,
        ScreenShoot,
    }

    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private List<ComboBox> comboBoxes;
        private List<string> pathImages;
        private List<ComboBox> gettingComboboxes;
        private int i = 0;
        private string column1 = nameof(EnumColumnName.TimeSkip);
        private string column2 = nameof(EnumColumnName.Arc);
        private string column3 = nameof(EnumColumnName.Сharacter);
        private string column4 = nameof(EnumColumnName.CoolPhrase);
        private string column5 = nameof(EnumColumnName.CloseUpFace);
        private string column6 = nameof(EnumColumnName.ScreenShoot);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pathImages = new List<string>();
            comboBoxes = new List<ComboBox>() {comboBox2,comboBox3};
            gettingComboboxes = new List<ComboBox> { connectionStrComboBox, folderPathComboBox};
        }

        private void AddComboBoxItem(List<ComboBox> comboBoxList)
        {
            foreach (var comboBox in comboBoxList)
            {
                AddComboBoxItem(comboBox, comboBox.Text);
            }
        }
        private void AddComboBoxItem(ComboBox comboBox, string text)
        {
            if (!comboBox.Items.Contains(comboBox.Text))
                comboBox.SelectedIndex = comboBox.Items.Add(text);
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
                MessageBox.Show("Подключение к базе данных успешно устаноновлено");
                AddComboBoxItem(gettingComboboxes);
               
                getPathPanel.Visible = false;
                actionPanel.Visible = true;
                LoadPictures(folderPathComboBox.SelectedItem.ToString());
            }
            folderPathComboBox.SelectedIndex = -1;
        }

        private void CheckData(string connectionString, string path)
        {
            CheckConnection(connectionString);
            CheckPath(path);
        } 
        private void CheckConnection(string connectionString)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Не получилось установить подключение к базе данных. Проверьте правильность строки подключения");
                    }
                    else
                    {
                        AddComboBoxItem(connectionStrComboBox, connectionString);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Строка подключения не введена или не соответствует формату. Проверьте правильность строки подключения");
            }
        }
        private void CheckPath(string path)
        {
            if (!Directory.Exists(@path))
            {
                MessageBox.Show("Папки не существует. Проверьте правильность пути");
            }
            else AddComboBoxItem(folderPathComboBox, path);
        }

        private void LoadPictures(string path)
        {
            foreach (var file in Directory.GetFiles(@path))
            {
                pathImages.Add(file);
            }
            CheckLoadPictures();
        }
        private void CheckLoadPictures()
        {
            if (pathImages.Count == 0) MessageBox.Show("Нет доступных изображений, выберите другую папку");
            else pictureBox1.Image = Image.FromFile(pathImages[i]);
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            DirDialog.Description = "Выбор директории";

            if (DirDialog.ShowDialog() == DialogResult.OK)
                AddComboBoxItem(folderPathComboBox, DirDialog.SelectedPath);
        }

        private void ChooseFolderButton_Click(object sender, EventArgs e)
        {
            getPathPanel.Visible = true;
            actionPanel.Visible = false;
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
            if (i != pathImages.Count - 1 || i != 0)
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
            AddComboBoxItem(comboBoxes);
            AddInDB();
        }
        private void AddInDB()
        {
            using (connection)
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO [OnePieceScreens] (TimeSkip, Arc, Character, CoolPhrase, CloseUpFace, ScreenShoot)" +
               "VALUES (@TimeSkip, @Arc, @Character, @CoolPhrase, @CloseUpFace, @ScreenShoot)";

                var image = new Bitmap(pictureBox1.Image);
                using (var stream = new MemoryStream())
                {
                    image.Save(stream, ImageFormat.Png);
                    stream.Position = 0;
                }


                command.Parameters.AddWithValue(column1, comboBox1.SelectedItem.ToString());
                command.Parameters.AddWithValue(column2, comboBox2.SelectedItem.ToString());
                command.Parameters.AddWithValue(column3, comboBox3.SelectedItem.ToString());
                command.Parameters.AddWithValue(column4, textBox1.Text);
                textBox1.Clear();
                command.Parameters.AddWithValue(column5, comboBox5.SelectedItem.ToString());
                // sqlCommand.Parameters.AddWithValue(column6, pictureBox1.Image); НУЖНО ИСПРАВИТЬ

                connection.Open();
                command.ExecuteNonQuery();
            }

        }
    }
}
