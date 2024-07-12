using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aquarium
{
    public partial class CreatureCard : Form
    {
        //Делегат включения элементов управления данной формой
        public delegate void EnableControlsDelegate(string data);
        EnableControlsDelegate ECD;

        IWaterCreature importedData;
        string typeString;

        Terminal.EnableControlsDelegate sendBack;
        string savedDiet;

        //true - рыба
        //false - растение
        bool isFish;

        //true - режим редактирования
        //false - режим добавления
        bool edit;

        /// <summary>
        /// Создание карточки существа в режиме Рыбы
        /// </summary>
        /// <param name="f">Экземпляр рыбы</param>
        /// <param name="enable">Делегат включения управления</param>
        /// <param name="openMode">Режим открытия</param>
        public CreatureCard(Fish f, Terminal.EnableControlsDelegate enable, bool openMode = false)
        {
            InitializeComponent();

            ECD = EnableControlsAndGetData;
            typeString = "Fish";
            edit = openMode;
            sendBack = enable;
            importedData = f;

            isFish = true;
            this.Icon = Properties.Resources.fishIcon;
            diet_label.Visible = true;
            dietListBtn.Visible = true;
        }

        /// <summary>
        /// Создание карточки существа в режиме Флоры
        /// </summary>
        /// <param name="f"></param>
        /// <param name="enable"></param>
        /// <param name="openMode"></param>
        public CreatureCard(Flora f, Terminal.EnableControlsDelegate enable, bool openMode = false)
        {
            InitializeComponent();

            ECD = EnableControlsAndGetData;
            typeString = "Flora";
            edit = openMode;
            sendBack = enable;
            importedData = f;

            isFish = false;
            this.Icon = Properties.Resources.seaweedIcon;
        }

        private void CreatureCard_Load(object sender, EventArgs e)
        {
            //Открытие в режиме Редактирования
            if(edit)
            {
                titleLabel.Text = "Edit ";
                yesButton.Text = "Update";
                yesButton.Click += new System.EventHandler(yesButtonUpdate);

                speciesBox.Text = importedData.info.species;
                nameBox.Text = importedData.info.name;
                ageNum.Value = importedData.age;

                string[] conditionsSeparated = importedData.conditions.Split(';');
                waterComboBox.Text = conditionsSeparated[0];
                temperatureNum.Value = Convert.ToInt32(conditionsSeparated[1]);

                if(isFish)
                {
                    Fish f = (Fish) importedData;
                    savedDiet = f.dietStr;
                    diet_label.Text = $"Diet ({savedDiet.Split(';').Length} objects):";
                }
            }
            //Открытие в режиме добавления
            else
            {
                titleLabel.Text = "Add new ";
                yesButton.Text = "Add";
                waterComboBox.Text = Utilities.aqmparameters.water;
                yesButton.Click += new System.EventHandler(yesButtonAdd);
                savedDiet = "";
            }

            titleLabel.Text += typeString;
        }

        /// <summary>
        /// Нажатие на кнопку Action в режиме Редактирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yesButtonUpdate(object sender, EventArgs e)
        {
            if(isFish)
            {
                Fish f = new Fish()
                {
                    id = 0,
                    info = new Species()
                    {
                        species = speciesBox.Text,
                        name = nameBox.Text
                    },
                    age = Convert.ToInt32(ageNum.Value.ToString()),
                    dietStr = savedDiet,
                    conditions = $"{waterComboBox.SelectedItem.ToString()};{temperatureNum.Value.ToString()}"
                };

                LocalData.RefreshData(importedData.id, f);
            }
            else
            {
                Flora f = new Flora()
                {
                    id = 0,
                    info = new Species()
                    {
                        species = speciesBox.Text,
                        name = nameBox.Text
                    },
                    age = Convert.ToInt32(ageNum.Value.ToString()),
                    conditions = $"{waterComboBox.SelectedItem.ToString()};{temperatureNum.Value.ToString()}"
                };

                LocalData.RefreshData(importedData.id, f);

            }
            if (Utilities.aqmparameters.immediateSync == true)
                SQLData.SyncData();

            this.Close();
        }

        /// <summary>
        /// Нажатие на кнопку Action в режиме Добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yesButtonAdd(object sender, EventArgs e)
        {
            if(isFish)
            {
                Fish f = new Fish()
                {
                    id = LocalData.FishMaxInd + 1,
                    info = new Species()
                    {
                        species = speciesBox.Text,
                        name = nameBox.Text
                    },
                    age = Convert.ToInt32(ageNum.Value.ToString()),
                    dietStr = savedDiet,
                    conditions = $"{waterComboBox.SelectedItem.ToString()};{temperatureNum.Value.ToString()}"
                };

                LocalData.AddData(f);
            }
            else
            {
                Flora f = new Flora()
                {
                    id = LocalData.FloraMaxInd + 1,
                    info = new Species()
                    {
                        species = speciesBox.Text,
                        name = nameBox.Text
                    },
                    age = Convert.ToInt32(ageNum.Value.ToString()),
                    conditions = $"{waterComboBox.SelectedItem.ToString()};{temperatureNum.Value.ToString()}"
                };

                LocalData.AddData(f);
            }
            if (Utilities.aqmparameters.immediateSync == true)
                SQLData.SyncData();

            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
               "The data will not be saved. Continue?",
               "Warning",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            } 
     
        }

        private void DisableControls()
        {
            this.Enabled = false;
            statusLabel.Text = "Diet List is opened. Controls are disabled";
            statusLabel.ForeColor = Color.Red;
            statusLabel.Visible = true;
        }

        /// <summary>
        /// Метод, вызываемый, когда закрывается DietList - получает из него данные
        /// </summary>
        /// <param name="data"></param>
        private void EnableControlsAndGetData(string data)
        {
            this.Enabled = true;
            statusLabel.Visible = false;
            if(data != "")
            {
                savedDiet = data;
                diet_label.Text = $"Diet ({savedDiet.Split(';').Length} objects):";
            }
            
        }

        /// <summary>
        /// По закрытию формы включается управление в Терминале
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreatureCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            sendBack();
        }

        /// <summary>
        /// Нажатие на кнопку Diet List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dietListBtn_Click(object sender, EventArgs e)
        {
            DietList dl = new DietList(savedDiet, ECD);
            dl.Show();
            DisableControls();
        }

        private void speciesBox_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void CheckInput()
        {
            if (Utilities.CheckName(speciesBox.Text) && Utilities.CheckName(nameBox.Text))
                yesButton.Enabled = true;
            else
                yesButton.Enabled = false;
        }
    }
}
