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
    public partial class Terminal : Form
    {
        public Terminal()
        {
            InitializeComponent();
        }

        //Делегат включения элементов управления, 
        //чтобы включать их по закрытии дочерней формы
        public delegate void EnableControlsDelegate();
        EnableControlsDelegate ec;

        #region Подготовка к работе и вспомогательные функции
        private void Terminal_Load(object sender, EventArgs e)
        {
            //Присваивание делегату метода включения элементов управления
            ec = EnableControls;

            //Получение данных из SQL-таблицы
            SQLData.RetrieveData();

            //Загрузка и установка настроек аквариума и приложения из файла
            Utilities.LoadAquariumParameters();
            SetParameters();

            //Построение списков объектов
            ResetFishList();
            ResetFloraList();
        }

        /// <summary>
        /// Включение элементов управления терминалом
        /// </summary>
        private void EnableControls()
        {
            tabs.Enabled = true;
            toolStrip1.Enabled = true;
            statusLabel.Visible = false;
        }

        /// <summary>
        /// Выключение элементов управления терминалом
        /// </summary>
        private void DisableControls()
        {
            toolStrip1.Enabled = false;
            tabs.Enabled = false;
            statusLabel.Text = "Creature Card is opened. Controls are disabled";
            statusLabel.Visible = true;
        }

        /// <summary>
        /// Отображение всего списка рыб на экране
        /// </summary>
        private void ResetFishList()
        {
            fishes.DataSource = LocalData.GetFishList;
            fishes.ValueMember = "id";
            fishes.DisplayMember = "listName";
        }

        /// <summary>
        /// Отображение всего списка флоры на экране
        /// </summary>
        private void ResetFloraList()
        {
            floras.DataSource = LocalData.GetFloraList;
            floras.ValueMember = "id";
            floras.DisplayMember = "listName";
        }

        /// <summary>
        /// Установка параметров аквариума и приложения в интерфейсе программы
        /// </summary>
        private void SetParameters()
        {
            temperatureNum.Value = Utilities.aqmparameters.temperature;
            waterComboBox.Text = Utilities.aqmparameters.water;
            ImmSyncBox.Checked = Utilities.aqmparameters.immediateSync;
            AutoSyncBox.Checked = Utilities.aqmparameters.autoSync;
            temperatureDiffNum.Value = Utilities.aqmparameters.temperatureDifference;
            if (AutoSyncBox.Checked)
            {
                interval_label.Enabled = true;
                intervalNum.Enabled = true;
                intervalNum.Value = Utilities.aqmparameters.syncInterval;

                if (!syncTimer.Enabled)
                {
                    syncTimer.Enabled = true;
                    syncTimer.Interval = Utilities.aqmparameters.syncInterval * 60000;
                    syncTimer.Start();
                }

            }
            UIUpdateAquariumInfo();

        }
        #endregion

        #region Общие события и функции

        /// <summary>
        /// Событие закрытия терминала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Terminal_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Do you want to Sync information with the SQL Database?",
                    "Save before exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
            if (answer == DialogResult.Yes)
            {
                SQLData.SyncData();
            }
        }

        /// <summary>
        /// Обновление надписей слева вверху программы
        /// </summary>
        private void UIUpdateAquariumInfo()
        {
            aquariumWater.Text = $"Water: {Utilities.aqmparameters.water}";
            aquariumTemperature.Text = $"Temp: {Utilities.aqmparameters.temperature.ToString()}°C";
            atd.Text = $"ATD: {Utilities.aqmparameters.temperatureDifference}°C";
        }

        /// <summary>
        /// Выбор вкладки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabs_Selected(object sender, TabControlEventArgs e)
        {
            if (tabs.SelectedTab == ParametersTab)
            {
                SetParameters();
            }
            else if(tabs.SelectedTab == LogTab)
            {
                UpdateLog();
            }
        }
        #endregion

        #region События управления вкладки Data
        /// <summary>
        /// Построение и отображение нового списка рыб (результаты поиска)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBar1_TextChanged(object sender, EventArgs e)
        {
            if (searchBar1.Text == "")
            {
                ResetFishList();
            }
            else
            {
                BindingList<Fish> newList = LocalData.FishBuildSearchList(searchBar1.Text);
                fishes.DataSource = newList;
                fishes.ValueMember = "id";
                fishes.DisplayMember = "listName";
                if(newList.Count == 0)
                {
                    NoDataOutput("Fish");
                }
            }
        }

        /// <summary>
        /// Построение и отображение нового списка флоры (результаты поиска)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBar2_TextChanged(object sender, EventArgs e)
        {
            if (searchBar2.Text == "")
            {
                ResetFloraList();
            }
            else
            {
                BindingList<Flora> newList = LocalData.FloraBuildSearchList(searchBar2.Text);
                floras.DataSource = newList;
                floras.ValueMember = "id";
                floras.DisplayMember = "listName";
                if(newList.Count == 0)
                {
                    NoDataOutput("Flora");
                }
            }
        }

        /// <summary>
        /// Нажатие на объект из списка рыб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fishes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (fishes.SelectedIndex >= 0)
            {
                NormalDataOutput();
                Fish selected = (Fish)fishes.SelectedItem;
                label_id.Text = $"Database ID: {selected.id.ToString()}";
                label_species.Text = $"Species: {selected.info.species}";
                label_name.Text = $"Common name: {selected.info.name}";
                label_age.Text = $"Age:{selected.age.ToString()}";
                label_cond.Text = $"Conditions: {selected.CondArray[0]} water, {selected.CondArray[1]}°C";
                objectIcon.Image = Properties.Resources.fish;
                dietListBtn.Visible = true;
            }
            else
            {
                NoDataOutput("Fish");
                dietListBtn.Visible = false;
            }
            
        }

        private void NoDataOutput(string dataType)
        {
            label_id.Text = $"No available {dataType} data";
            label_age.Visible = false;
            label_name.Visible = false;
            label_species.Visible = false;
            label_cond.Visible = false;
            dietListBtn.Visible = false;
            objectIcon.Image = Properties.Resources.clearPage;
        }

        private void NormalDataOutput()
        {
            label_age.Visible = true;
            label_name.Visible = true;
            label_species.Visible = true;
            label_cond.Visible = true;
        }

        /// <summary>
        /// Нажатие на объект из списка флоры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void floras_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (floras.SelectedIndex >= 0)
            {
                NormalDataOutput();
                Flora selected = (Flora)floras.SelectedItem;
                label_id.Text = $"Database ID: {selected.id.ToString()}";
                label_species.Text = $"Species: {selected.info.species}";
                label_name.Text = $"Common name: {selected.info.name}";
                label_age.Text = $"Age:{selected.age.ToString()}";
                label_cond.Text = $"Conditions: {selected.CondArray[0]} water, {selected.CondArray[1]}°C";
                objectIcon.Image = Properties.Resources.seaweed;
                dietListBtn.Visible = false;
            }
            else
            {
                NoDataOutput("Flora");
            }
            
        }

        /// <summary>
        /// Нажатие на кнопку добавления рыбы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton1_Click(object sender, EventArgs e)
        {
            new CreatureCard(new Fish(), ec).Show();
            DisableControls();
        }

        /// <summary>
        /// Нажатие на кнопку добавления флоры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton2_Click(object sender, EventArgs e)
        {
            new CreatureCard(new Flora(), ec).Show();
            DisableControls();
        }

        /// <summary>
        /// Нажатие на кнопку удаления рыбы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_btn1_Click(object sender, EventArgs e)
        {
            if(fishes.SelectedItem != null)
            {
                Fish selected = (Fish)fishes.SelectedItem;
                DialogResult answer = MessageBox.Show(
                    $"The Fish data [{selected.info.name}, id = {selected.id}] will be deleted. Continue?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (answer == DialogResult.Yes)
                {
                    LocalData.DeleteData(selected);
                }
            }
            
        }

        /// <summary>
        /// Нажатие на кнопку удаления флоры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_btn2_Click(object sender, EventArgs e)
        {
            if(floras.SelectedItem != null)
            {
                Flora selected = (Flora)floras.SelectedItem;

                DialogResult answer = MessageBox.Show(
                    $"The Flora data [{selected.info.name}, id = {selected.id}] will be deleted. Continue?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (answer == DialogResult.Yes)
                {
                    LocalData.DeleteData(selected);
                }
            }
            
        }

        /// <summary>
        /// Нажатие на кнопку обновления рыбы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Upd_button_Click(object sender, EventArgs e)
        {
            if(fishes.SelectedItem != null)
            {
                new CreatureCard((Fish)fishes.SelectedItem, ec, true).Show();
                DisableControls();
            }
            
        }

        /// <summary>
        /// Нажатие на кнопку обновления флоры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Upd_Button2_Click(object sender, EventArgs e)
        {
            if(floras.SelectedItem != null)
            {
                new CreatureCard((Flora)floras.SelectedItem, ec, true).Show();
                DisableControls();
            }
        }

        private void dietListBtn_Click(object sender, EventArgs e)
        {
            if(fishes.SelectedItem != null)
            {
                Fish selected = (Fish)fishes.SelectedItem;
                new DietList(selected).Show();
            }
            
        }

        #endregion

        #region События управления вкладки Parameters
        /// <summary>
        /// Изменение checkbox, отвечающего за режим автосохранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoSyncBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoSyncBox.Checked)
                intervalNum.Enabled = true;
            else
                intervalNum.Enabled = false;               
        }

        /// <summary>
        /// Нажатие на кнопку сохранения параметров аквариума и приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveParameters_btn_Click(object sender, EventArgs e)
        {
            Utilities.aqmparameters.temperature = Convert.ToInt32(temperatureNum.Value);
            Utilities.aqmparameters.water = waterComboBox.Text;
            Utilities.aqmparameters.immediateSync = ImmSyncBox.Checked;
            Utilities.aqmparameters.autoSync = AutoSyncBox.Checked;
            Utilities.aqmparameters.syncInterval = Convert.ToInt32(intervalNum.Value);
            Utilities.aqmparameters.temperatureDifference = Convert.ToInt32(temperatureDiffNum.Value);

            if(Utilities.aqmparameters.autoSync)
            {
                syncTimer.Interval = Utilities.aqmparameters.syncInterval * 60000;
                syncTimer.Start();
            }
            else
            {
                syncTimer.Stop();
                syncTimer.Enabled = false;
            }


            Utilities.SaveAquariumParameters();
            UIUpdateAquariumInfo();
        }

        /// <summary>
        /// Синхронизация с БД в течение выбранного промежутка времени (при включенном режиме автосохранения)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void syncTimer_Tick(object sender, EventArgs e)
        {
            SQLData.SyncData();
        }


        #endregion

        #region Функции вкладки Log
        /// <summary>
        /// Обновление текста консоли
        /// </summary>
        private void UpdateLog()
        {
            ConsoleLog.Text = "Fetching log...";
            ConsoleLog.Text = LocalData.BuildLog();

            if (ConsoleLog.Lines.Length > 0)
            {
                errorStatus.Text = $"Status: {ConsoleLog.Lines.Length - 1} speices can't survive (Check Log for details)";
                errorStatus.ForeColor = Color.DarkRed;
            }
            else
            {
                errorStatus.Text = $"Status: Aquarium parameters match for all species";
                errorStatus.ForeColor = Color.Green;
                ConsoleLog.Text = $"Console Operational...{Environment.NewLine}No mismatches aquired";
            }


        }
        #endregion

        #region События строки инструментов сверху
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    $"Sokolov & Romas. Coursework\r\nVariant №20\r\nAquarium ver. 1.0",
                    "About",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SQLData.SyncData();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                   "The application allows you to record the flora and fauna of the aquarium in the database and monitor the conditions." + Environment.NewLine + Environment.NewLine +
                   "To add a new object to the aquarium, press the Add button and enter the required data." + Environment.NewLine +
                   "To modify an existing object, select it in the list and press the Edit button." + Environment.NewLine +
                   "To delete an object, select it in the list and click the Del button" + Environment.NewLine + Environment.NewLine +
                   "Aquarium parameters, as well as synchronization with the database, can be configured in the Parameters tab " + Environment.NewLine +
                   "In the Log tab you can see the mismatches between the parameters of the aquarium and the living conditions of the objects." + Environment.NewLine +
                   "To save the data, click the Sync button in the toolbar.",
                   "Help",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1); ;
        }


        #endregion


    }
}
