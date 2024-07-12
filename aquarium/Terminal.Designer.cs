namespace aquarium
{
    partial class Terminal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal));
            this.label_cond = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_species = new System.Windows.Forms.Label();
            this.searchBar1 = new System.Windows.Forms.TextBox();
            this.floras = new System.Windows.Forms.ListBox();
            this.fishes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dietListBtn = new System.Windows.Forms.Button();
            this.objectIcon = new System.Windows.Forms.PictureBox();
            this.searchBar2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.DataTab = new System.Windows.Forms.TabPage();
            this.InsertButton = new System.Windows.Forms.Button();
            this.Upd_button = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Delete_btn2 = new System.Windows.Forms.Button();
            this.InsertButton2 = new System.Windows.Forms.Button();
            this.Upd_button2 = new System.Windows.Forms.Button();
            this.ParametersTab = new System.Windows.Forms.TabPage();
            this.saveParameters_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.interval_label = new System.Windows.Forms.Label();
            this.intervalNum = new System.Windows.Forms.NumericUpDown();
            this.AutoSyncBox = new System.Windows.Forms.CheckBox();
            this.ImmSyncBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.temperatureDiffNum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.waterComboBox = new System.Windows.Forms.ComboBox();
            this.temperatureNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LogTab = new System.Windows.Forms.TabPage();
            this.errorStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConsoleLog = new System.Windows.Forms.RichTextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.syncTimer = new System.Windows.Forms.Timer(this.components);
            this.aquariumWater = new System.Windows.Forms.Label();
            this.aquariumTemperature = new System.Windows.Forms.Label();
            this.atd = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectIcon)).BeginInit();
            this.tabs.SuspendLayout();
            this.DataTab.SuspendLayout();
            this.ParametersTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureDiffNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureNum)).BeginInit();
            this.LogTab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_cond
            // 
            this.label_cond.AutoSize = true;
            this.label_cond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cond.Location = new System.Drawing.Point(182, 104);
            this.label_cond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cond.Name = "label_cond";
            this.label_cond.Size = new System.Drawing.Size(92, 20);
            this.label_cond.TabIndex = 43;
            this.label_cond.Text = "Conditions: ";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(182, 19);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(104, 20);
            this.label_id.TabIndex = 42;
            this.label_id.Text = "Database ID:";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(182, 82);
            this.label_age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(46, 20);
            this.label_age.TabIndex = 41;
            this.label_age.Text = "Age: ";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(182, 62);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(121, 20);
            this.label_name.TabIndex = 40;
            this.label_name.Text = "Common name:";
            // 
            // label_species
            // 
            this.label_species.AutoSize = true;
            this.label_species.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_species.Location = new System.Drawing.Point(182, 41);
            this.label_species.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_species.Name = "label_species";
            this.label_species.Size = new System.Drawing.Size(74, 20);
            this.label_species.TabIndex = 39;
            this.label_species.Text = "Species: ";
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.searchBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar1.ForeColor = System.Drawing.Color.Blue;
            this.searchBar1.Location = new System.Drawing.Point(51, 11);
            this.searchBar1.Margin = new System.Windows.Forms.Padding(2);
            this.searchBar1.MaxLength = 100;
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(260, 26);
            this.searchBar1.TabIndex = 34;
            this.searchBar1.TextChanged += new System.EventHandler(this.searchBar1_TextChanged);
            // 
            // floras
            // 
            this.floras.BackColor = System.Drawing.Color.PaleTurquoise;
            this.floras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floras.FormattingEnabled = true;
            this.floras.ItemHeight = 20;
            this.floras.Location = new System.Drawing.Point(433, 41);
            this.floras.Margin = new System.Windows.Forms.Padding(2);
            this.floras.Name = "floras";
            this.floras.Size = new System.Drawing.Size(292, 164);
            this.floras.TabIndex = 30;
            this.floras.SelectedIndexChanged += new System.EventHandler(this.floras_SelectedIndexChanged);
            // 
            // fishes
            // 
            this.fishes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.fishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fishes.FormattingEnabled = true;
            this.fishes.ItemHeight = 20;
            this.fishes.Location = new System.Drawing.Point(5, 41);
            this.fishes.Margin = new System.Windows.Forms.Padding(2);
            this.fishes.Name = "fishes";
            this.fishes.Size = new System.Drawing.Size(306, 164);
            this.fishes.TabIndex = 29;
            this.fishes.SelectedIndexChanged += new System.EventHandler(this.fishes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(324, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.TabIndex = 44;
            this.label1.Text = "Aquarium";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.dietListBtn);
            this.groupBox1.Controls.Add(this.objectIcon);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Controls.Add(this.label_species);
            this.groupBox1.Controls.Add(this.label_cond);
            this.groupBox1.Controls.Add(this.label_age);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(107, 260);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(588, 192);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Features";
            // 
            // dietListBtn
            // 
            this.dietListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dietListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dietListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dietListBtn.ForeColor = System.Drawing.Color.Black;
            this.dietListBtn.Location = new System.Drawing.Point(186, 127);
            this.dietListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dietListBtn.Name = "dietListBtn";
            this.dietListBtn.Size = new System.Drawing.Size(132, 25);
            this.dietListBtn.TabIndex = 49;
            this.dietListBtn.Text = "Diet list";
            this.dietListBtn.UseVisualStyleBackColor = false;
            this.dietListBtn.Visible = false;
            this.dietListBtn.Click += new System.EventHandler(this.dietListBtn_Click);
            // 
            // objectIcon
            // 
            this.objectIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objectIcon.Image = global::aquarium.Properties.Resources.fish;
            this.objectIcon.Location = new System.Drawing.Point(27, 22);
            this.objectIcon.Name = "objectIcon";
            this.objectIcon.Size = new System.Drawing.Size(141, 130);
            this.objectIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.objectIcon.TabIndex = 44;
            this.objectIcon.TabStop = false;
            // 
            // searchBar2
            // 
            this.searchBar2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.searchBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar2.ForeColor = System.Drawing.Color.Blue;
            this.searchBar2.Location = new System.Drawing.Point(487, 11);
            this.searchBar2.Margin = new System.Windows.Forms.Padding(2);
            this.searchBar2.MaxLength = 100;
            this.searchBar2.Name = "searchBar2";
            this.searchBar2.Size = new System.Drawing.Size(238, 26);
            this.searchBar2.TabIndex = 46;
            this.searchBar2.TextChanged += new System.EventHandler(this.searchBar2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Find";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Find";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.DataTab);
            this.tabs.Controls.Add(this.ParametersTab);
            this.tabs.Controls.Add(this.LogTab);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabs.HotTrack = true;
            this.tabs.Location = new System.Drawing.Point(-2, 86);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(841, 503);
            this.tabs.TabIndex = 49;
            this.tabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabs_Selected);
            // 
            // DataTab
            // 
            this.DataTab.BackColor = System.Drawing.Color.LightBlue;
            this.DataTab.Controls.Add(this.fishes);
            this.DataTab.Controls.Add(this.label3);
            this.DataTab.Controls.Add(this.floras);
            this.DataTab.Controls.Add(this.label2);
            this.DataTab.Controls.Add(this.InsertButton);
            this.DataTab.Controls.Add(this.searchBar2);
            this.DataTab.Controls.Add(this.Upd_button);
            this.DataTab.Controls.Add(this.groupBox1);
            this.DataTab.Controls.Add(this.Delete_btn);
            this.DataTab.Controls.Add(this.searchBar1);
            this.DataTab.Controls.Add(this.Delete_btn2);
            this.DataTab.Controls.Add(this.InsertButton2);
            this.DataTab.Controls.Add(this.Upd_button2);
            this.DataTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataTab.ForeColor = System.Drawing.Color.Blue;
            this.DataTab.Location = new System.Drawing.Point(4, 29);
            this.DataTab.Name = "DataTab";
            this.DataTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataTab.Size = new System.Drawing.Size(833, 470);
            this.DataTab.TabIndex = 0;
            this.DataTab.Text = "Data";
            this.DataTab.ToolTipText = "Information about flora and fauna in the Aquarium";
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.Chartreuse;
            this.InsertButton.BackgroundImage = global::aquarium.Properties.Resources.plus;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.InsertButton.Location = new System.Drawing.Point(315, 41);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(2);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(88, 41);
            this.InsertButton.TabIndex = 31;
            this.InsertButton.Text = "Add";
            this.InsertButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.AddButton1_Click);
            // 
            // Upd_button
            // 
            this.Upd_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Upd_button.BackgroundImage = global::aquarium.Properties.Resources.circle;
            this.Upd_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upd_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Upd_button.ForeColor = System.Drawing.Color.Yellow;
            this.Upd_button.Location = new System.Drawing.Point(315, 101);
            this.Upd_button.Margin = new System.Windows.Forms.Padding(2);
            this.Upd_button.Name = "Upd_button";
            this.Upd_button.Size = new System.Drawing.Size(88, 41);
            this.Upd_button.TabIndex = 32;
            this.Upd_button.Text = "Edit";
            this.Upd_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Upd_button.UseVisualStyleBackColor = false;
            this.Upd_button.Click += new System.EventHandler(this.Upd_button_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Maroon;
            this.Delete_btn.BackgroundImage = global::aquarium.Properties.Resources.cross;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(315, 164);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(88, 41);
            this.Delete_btn.TabIndex = 33;
            this.Delete_btn.Text = "Del";
            this.Delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn1_Click);
            // 
            // Delete_btn2
            // 
            this.Delete_btn2.BackColor = System.Drawing.Color.Maroon;
            this.Delete_btn2.BackgroundImage = global::aquarium.Properties.Resources.cross;
            this.Delete_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_btn2.ForeColor = System.Drawing.Color.White;
            this.Delete_btn2.Location = new System.Drawing.Point(729, 164);
            this.Delete_btn2.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_btn2.Name = "Delete_btn2";
            this.Delete_btn2.Size = new System.Drawing.Size(88, 41);
            this.Delete_btn2.TabIndex = 37;
            this.Delete_btn2.Text = "Del";
            this.Delete_btn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_btn2.UseVisualStyleBackColor = false;
            this.Delete_btn2.Click += new System.EventHandler(this.Delete_btn2_Click);
            // 
            // InsertButton2
            // 
            this.InsertButton2.BackColor = System.Drawing.Color.Chartreuse;
            this.InsertButton2.BackgroundImage = global::aquarium.Properties.Resources.plus;
            this.InsertButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertButton2.ForeColor = System.Drawing.Color.ForestGreen;
            this.InsertButton2.Location = new System.Drawing.Point(729, 41);
            this.InsertButton2.Margin = new System.Windows.Forms.Padding(2);
            this.InsertButton2.Name = "InsertButton2";
            this.InsertButton2.Size = new System.Drawing.Size(88, 41);
            this.InsertButton2.TabIndex = 35;
            this.InsertButton2.Text = "Add";
            this.InsertButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsertButton2.UseVisualStyleBackColor = false;
            this.InsertButton2.Click += new System.EventHandler(this.AddButton2_Click);
            // 
            // Upd_button2
            // 
            this.Upd_button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Upd_button2.BackgroundImage = global::aquarium.Properties.Resources.circle;
            this.Upd_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upd_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Upd_button2.ForeColor = System.Drawing.Color.Yellow;
            this.Upd_button2.Location = new System.Drawing.Point(729, 101);
            this.Upd_button2.Margin = new System.Windows.Forms.Padding(2);
            this.Upd_button2.Name = "Upd_button2";
            this.Upd_button2.Size = new System.Drawing.Size(88, 41);
            this.Upd_button2.TabIndex = 36;
            this.Upd_button2.Text = "Edit";
            this.Upd_button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Upd_button2.UseVisualStyleBackColor = false;
            this.Upd_button2.Click += new System.EventHandler(this.Upd_Button2_Click);
            // 
            // ParametersTab
            // 
            this.ParametersTab.BackColor = System.Drawing.Color.LightBlue;
            this.ParametersTab.Controls.Add(this.saveParameters_btn);
            this.ParametersTab.Controls.Add(this.groupBox3);
            this.ParametersTab.Controls.Add(this.groupBox2);
            this.ParametersTab.Controls.Add(this.label5);
            this.ParametersTab.Location = new System.Drawing.Point(4, 29);
            this.ParametersTab.Name = "ParametersTab";
            this.ParametersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ParametersTab.Size = new System.Drawing.Size(833, 470);
            this.ParametersTab.TabIndex = 1;
            this.ParametersTab.Text = "Parameters";
            this.ParametersTab.ToolTipText = "Aquarium and Application parameters";
            // 
            // saveParameters_btn
            // 
            this.saveParameters_btn.BackColor = System.Drawing.Color.Turquoise;
            this.saveParameters_btn.BackgroundImage = global::aquarium.Properties.Resources.sync;
            this.saveParameters_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveParameters_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveParameters_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.saveParameters_btn.Location = new System.Drawing.Point(351, 377);
            this.saveParameters_btn.Name = "saveParameters_btn";
            this.saveParameters_btn.Size = new System.Drawing.Size(95, 41);
            this.saveParameters_btn.TabIndex = 53;
            this.saveParameters_btn.Text = "Save";
            this.saveParameters_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveParameters_btn.UseVisualStyleBackColor = false;
            this.saveParameters_btn.Click += new System.EventHandler(this.saveParameters_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.interval_label);
            this.groupBox3.Controls.Add(this.intervalNum);
            this.groupBox3.Controls.Add(this.AutoSyncBox);
            this.groupBox3.Controls.Add(this.ImmSyncBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(35, 202);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(749, 131);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Application";
            // 
            // interval_label
            // 
            this.interval_label.AutoSize = true;
            this.interval_label.Enabled = false;
            this.interval_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interval_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.interval_label.Location = new System.Drawing.Point(453, 88);
            this.interval_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.interval_label.Name = "interval_label";
            this.interval_label.Size = new System.Drawing.Size(114, 20);
            this.interval_label.TabIndex = 61;
            this.interval_label.Text = "Interval (min)";
            // 
            // intervalNum
            // 
            this.intervalNum.Enabled = false;
            this.intervalNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.intervalNum.Location = new System.Drawing.Point(572, 87);
            this.intervalNum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.intervalNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalNum.Name = "intervalNum";
            this.intervalNum.Size = new System.Drawing.Size(120, 24);
            this.intervalNum.TabIndex = 61;
            this.intervalNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AutoSyncBox
            // 
            this.AutoSyncBox.AutoSize = true;
            this.AutoSyncBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AutoSyncBox.Location = new System.Drawing.Point(46, 87);
            this.AutoSyncBox.Name = "AutoSyncBox";
            this.AutoSyncBox.Size = new System.Drawing.Size(228, 22);
            this.AutoSyncBox.TabIndex = 1;
            this.AutoSyncBox.Text = "Automatic Synchronization";
            this.AutoSyncBox.UseVisualStyleBackColor = true;
            this.AutoSyncBox.CheckedChanged += new System.EventHandler(this.AutoSyncBox_CheckedChanged);
            // 
            // ImmSyncBox
            // 
            this.ImmSyncBox.AutoSize = true;
            this.ImmSyncBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ImmSyncBox.Location = new System.Drawing.Point(46, 37);
            this.ImmSyncBox.Name = "ImmSyncBox";
            this.ImmSyncBox.Size = new System.Drawing.Size(230, 22);
            this.ImmSyncBox.TabIndex = 0;
            this.ImmSyncBox.Text = "Immediate Synchronization";
            this.ImmSyncBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.temperatureDiffNum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.waterComboBox);
            this.groupBox2.Controls.Add(this.temperatureNum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(35, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(749, 111);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aquarium";
            // 
            // temperatureDiffNum
            // 
            this.temperatureDiffNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.temperatureDiffNum.Location = new System.Drawing.Point(352, 82);
            this.temperatureDiffNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.temperatureDiffNum.Name = "temperatureDiffNum";
            this.temperatureDiffNum.Size = new System.Drawing.Size(120, 24);
            this.temperatureDiffNum.TabIndex = 62;
            this.temperatureDiffNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(22, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Allowable temperature difference (ATD)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(79, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Water Type";
            // 
            // waterComboBox
            // 
            this.waterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.waterComboBox.FormattingEnabled = true;
            this.waterComboBox.Items.AddRange(new object[] {
            "salt",
            "fresh"});
            this.waterComboBox.Location = new System.Drawing.Point(195, 15);
            this.waterComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.waterComboBox.Name = "waterComboBox";
            this.waterComboBox.Size = new System.Drawing.Size(120, 25);
            this.waterComboBox.TabIndex = 59;
            // 
            // temperatureNum
            // 
            this.temperatureNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.temperatureNum.Location = new System.Drawing.Point(195, 51);
            this.temperatureNum.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.temperatureNum.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.temperatureNum.Name = "temperatureNum";
            this.temperatureNum.Size = new System.Drawing.Size(120, 24);
            this.temperatureNum.TabIndex = 44;
            this.temperatureNum.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(22, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Water Temperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(323, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 31);
            this.label5.TabIndex = 50;
            this.label5.Text = "Parameters";
            // 
            // LogTab
            // 
            this.LogTab.BackColor = System.Drawing.Color.LightBlue;
            this.LogTab.Controls.Add(this.errorStatus);
            this.LogTab.Controls.Add(this.label4);
            this.LogTab.Controls.Add(this.ConsoleLog);
            this.LogTab.Location = new System.Drawing.Point(4, 29);
            this.LogTab.Name = "LogTab";
            this.LogTab.Size = new System.Drawing.Size(833, 470);
            this.LogTab.TabIndex = 2;
            this.LogTab.Text = "Log";
            this.LogTab.ToolTipText = "Log about life in the Aquarium";
            // 
            // errorStatus
            // 
            this.errorStatus.AutoSize = true;
            this.errorStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorStatus.Location = new System.Drawing.Point(3, 48);
            this.errorStatus.Name = "errorStatus";
            this.errorStatus.Size = new System.Drawing.Size(49, 16);
            this.errorStatus.TabIndex = 51;
            this.errorStatus.Text = "status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(376, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 29);
            this.label4.TabIndex = 50;
            this.label4.Text = "Log";
            // 
            // ConsoleLog
            // 
            this.ConsoleLog.BackColor = System.Drawing.Color.Black;
            this.ConsoleLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConsoleLog.ForeColor = System.Drawing.Color.Lime;
            this.ConsoleLog.Location = new System.Drawing.Point(0, 98);
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.ReadOnly = true;
            this.ConsoleLog.Size = new System.Drawing.Size(833, 376);
            this.ConsoleLog.TabIndex = 0;
            this.ConsoleLog.Text = "Console Operational...";
            this.ConsoleLog.WordWrap = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(578, 44);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 62;
            this.statusLabel.Text = "status";
            this.statusLabel.Visible = false;
            // 
            // syncTimer
            // 
            this.syncTimer.Tick += new System.EventHandler(this.syncTimer_Tick);
            // 
            // aquariumWater
            // 
            this.aquariumWater.AutoSize = true;
            this.aquariumWater.ForeColor = System.Drawing.Color.RoyalBlue;
            this.aquariumWater.Location = new System.Drawing.Point(1, 38);
            this.aquariumWater.Name = "aquariumWater";
            this.aquariumWater.Size = new System.Drawing.Size(44, 13);
            this.aquariumWater.TabIndex = 63;
            this.aquariumWater.Text = "{Water}";
            // 
            // aquariumTemperature
            // 
            this.aquariumTemperature.AutoSize = true;
            this.aquariumTemperature.ForeColor = System.Drawing.Color.RoyalBlue;
            this.aquariumTemperature.Location = new System.Drawing.Point(1, 52);
            this.aquariumTemperature.Name = "aquariumTemperature";
            this.aquariumTemperature.Size = new System.Drawing.Size(75, 13);
            this.aquariumTemperature.TabIndex = 64;
            this.aquariumTemperature.Text = "{Temperature}";
            // 
            // atd
            // 
            this.atd.AutoSize = true;
            this.atd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.atd.Location = new System.Drawing.Point(2, 68);
            this.atd.Name = "atd";
            this.atd.Size = new System.Drawing.Size(37, 13);
            this.atd.TabIndex = 65;
            this.atd.Text = "{ATD}";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(846, 25);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::aquarium.Properties.Resources.floppy_disk;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "Sync";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::aquarium.Properties.Resources.info;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton2.Text = "About";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::aquarium.Properties.Resources.help;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "Help";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Terminal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(846, 592);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.atd);
            this.Controls.Add(this.aquariumTemperature);
            this.Controls.Add(this.aquariumWater);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Terminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Terminal_FormClosed);
            this.Load += new System.EventHandler(this.Terminal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectIcon)).EndInit();
            this.tabs.ResumeLayout(false);
            this.DataTab.ResumeLayout(false);
            this.DataTab.PerformLayout();
            this.ParametersTab.ResumeLayout(false);
            this.ParametersTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureDiffNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureNum)).EndInit();
            this.LogTab.ResumeLayout(false);
            this.LogTab.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cond;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_species;
        private System.Windows.Forms.Button Delete_btn2;
        private System.Windows.Forms.Button Upd_button2;
        private System.Windows.Forms.Button InsertButton2;
        private System.Windows.Forms.TextBox searchBar1;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Upd_button;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.ListBox floras;
        private System.Windows.Forms.ListBox fishes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage DataTab;
        private System.Windows.Forms.TabPage ParametersTab;
        private System.Windows.Forms.TabPage LogTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ConsoleLog;
        private System.Windows.Forms.Button saveParameters_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown temperatureNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox waterComboBox;
        private System.Windows.Forms.CheckBox AutoSyncBox;
        private System.Windows.Forms.CheckBox ImmSyncBox;
        private System.Windows.Forms.Label interval_label;
        private System.Windows.Forms.NumericUpDown intervalNum;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox objectIcon;
        private System.Windows.Forms.Timer syncTimer;
        private System.Windows.Forms.Button dietListBtn;
        private System.Windows.Forms.Label errorStatus;
        private System.Windows.Forms.NumericUpDown temperatureDiffNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label aquariumWater;
        private System.Windows.Forms.Label aquariumTemperature;
        private System.Windows.Forms.Label atd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}