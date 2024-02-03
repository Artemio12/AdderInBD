namespace AdderInBD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InsertPage = new System.Windows.Forms.TabPage();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.choosefolderButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.nextScreenButton = new System.Windows.Forms.Button();
            this.getPathPanel = new System.Windows.Forms.Panel();
            this.connectionStrComboBox = new System.Windows.Forms.ComboBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.folderPathComboBox = new System.Windows.Forms.ComboBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lastScreenButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.InsertPage.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.getPathPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InsertPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // InsertPage
            // 
            this.InsertPage.BackColor = System.Drawing.Color.Silver;
            this.InsertPage.Controls.Add(this.actionPanel);
            this.InsertPage.Controls.Add(this.getPathPanel);
            this.InsertPage.Controls.Add(this.textBox1);
            this.InsertPage.Controls.Add(this.comboBox5);
            this.InsertPage.Controls.Add(this.comboBox3);
            this.InsertPage.Controls.Add(this.comboBox2);
            this.InsertPage.Controls.Add(this.comboBox1);
            this.InsertPage.Controls.Add(this.label5);
            this.InsertPage.Controls.Add(this.label4);
            this.InsertPage.Controls.Add(this.label3);
            this.InsertPage.Controls.Add(this.label2);
            this.InsertPage.Controls.Add(this.label1);
            this.InsertPage.Controls.Add(this.pictureBox1);
            this.InsertPage.Controls.Add(this.bindingNavigator1);
            this.InsertPage.Location = new System.Drawing.Point(4, 22);
            this.InsertPage.Name = "InsertPage";
            this.InsertPage.Padding = new System.Windows.Forms.Padding(3);
            this.InsertPage.Size = new System.Drawing.Size(792, 424);
            this.InsertPage.TabIndex = 0;
            this.InsertPage.Text = "INSERT";
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.lastScreenButton);
            this.actionPanel.Controls.Add(this.choosefolderButton);
            this.actionPanel.Controls.Add(this.insertButton);
            this.actionPanel.Controls.Add(this.nextScreenButton);
            this.actionPanel.Location = new System.Drawing.Point(545, 151);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(237, 181);
            this.actionPanel.TabIndex = 24;
            this.actionPanel.Visible = false;
            // 
            // choosefolderButton
            // 
            this.choosefolderButton.Location = new System.Drawing.Point(3, 149);
            this.choosefolderButton.Name = "choosefolderButton";
            this.choosefolderButton.Size = new System.Drawing.Size(230, 32);
            this.choosefolderButton.TabIndex = 21;
            this.choosefolderButton.Text = "Choose Another Folder";
            this.choosefolderButton.UseVisualStyleBackColor = true;
            this.choosefolderButton.Click += new System.EventHandler(this.ChooseFolderButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(3, 3);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(230, 40);
            this.insertButton.TabIndex = 5;
            this.insertButton.Text = "INSERT";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // nextScreenButton
            // 
            this.nextScreenButton.Location = new System.Drawing.Point(122, 46);
            this.nextScreenButton.Name = "nextScreenButton";
            this.nextScreenButton.Size = new System.Drawing.Size(111, 101);
            this.nextScreenButton.TabIndex = 6;
            this.nextScreenButton.Text = "Next Picture";
            this.nextScreenButton.UseVisualStyleBackColor = true;
            this.nextScreenButton.Click += new System.EventHandler(this.NextScreen_Click);
            // 
            // getPathPanel
            // 
            this.getPathPanel.Controls.Add(this.connectionStrComboBox);
            this.getPathPanel.Controls.Add(this.loadButton);
            this.getPathPanel.Controls.Add(this.folderPathComboBox);
            this.getPathPanel.Controls.Add(this.browseButton);
            this.getPathPanel.Location = new System.Drawing.Point(545, 31);
            this.getPathPanel.Name = "getPathPanel";
            this.getPathPanel.Size = new System.Drawing.Size(237, 105);
            this.getPathPanel.TabIndex = 23;
            // 
            // connectionStrComboBox
            // 
            this.connectionStrComboBox.Items.AddRange(new object[] {
            resources.GetString("connectionStrComboBox.Items")});
            this.connectionStrComboBox.Location = new System.Drawing.Point(3, 3);
            this.connectionStrComboBox.Name = "connectionStrComboBox";
            this.connectionStrComboBox.Size = new System.Drawing.Size(230, 21);
            this.connectionStrComboBox.TabIndex = 0;
            this.connectionStrComboBox.Text = "Ввести строку подключения:";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(3, 61);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(230, 42);
            this.loadButton.TabIndex = 18;
            this.loadButton.Text = "Load Images";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // folderPathComboBox
            // 
            this.folderPathComboBox.FormattingEnabled = true;
            this.folderPathComboBox.Items.AddRange(new object[] {
            "C:\\Users\\artem\\OneDrive\\Изображения\\Снимки экрана\\ВанПис"});
            this.folderPathComboBox.Location = new System.Drawing.Point(3, 34);
            this.folderPathComboBox.Name = "folderPathComboBox";
            this.folderPathComboBox.Size = new System.Drawing.Size(160, 21);
            this.folderPathComboBox.TabIndex = 19;
            this.folderPathComboBox.Text = "Указать путь:";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(169, 32);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(64, 23);
            this.browseButton.TabIndex = 20;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox5.Location = new System.Drawing.Point(452, 356);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(74, 21);
            this.comboBox5.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(219, 356);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(92, 356);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox1.Location = new System.Drawing.Point(15, 356);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(462, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CloseUpFace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CoolPhrase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Arc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TimeSkip";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigator1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // lastScreenButton
            // 
            this.lastScreenButton.Location = new System.Drawing.Point(3, 46);
            this.lastScreenButton.Name = "lastScreenButton";
            this.lastScreenButton.Size = new System.Drawing.Size(113, 101);
            this.lastScreenButton.TabIndex = 22;
            this.lastScreenButton.Text = "Last Picture";
            this.lastScreenButton.UseVisualStyleBackColor = true;
            this.lastScreenButton.Click += new System.EventHandler(this.LastScreenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.InsertPage.ResumeLayout(false);
            this.InsertPage.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.getPathPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InsertPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nextScreenButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button loadButton;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.ComboBox folderPathComboBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ComboBox connectionStrComboBox;
        private System.Windows.Forms.Button choosefolderButton;
        private System.Windows.Forms.Panel getPathPanel;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button lastScreenButton;
    }
}

