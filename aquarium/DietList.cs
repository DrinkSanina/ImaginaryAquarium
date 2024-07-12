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
    public partial class DietList : Form
    {
        private string dietListStr;
        private CreatureCard.EnableControlsDelegate ECD;
        private List<TextBox> inputBoxes;
        private Fish import;

        //true - режим просмотра
        //false - режим редактирования
        private bool view;


        private bool init;
        public DietList(string _dietListStr, CreatureCard.EnableControlsDelegate _ECD)
        {
            InitializeComponent();
            view = false;
            init = false;
            ECD = _ECD;
            dietListStr = _dietListStr;
            inputBoxes = new List<TextBox>();
        }

        public DietList(Fish f)
        {
            InitializeComponent();
            view = true;
            dietListStr = f.dietStr;
            import = f;

            output_name.Text = $"Common name: {f.info.name}";
            output_ID.Text = $"ID: {f.id}";
        }

        /// <summary>
        /// Изменение количества TextBox на экране
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listSizeNum_ValueChanged(object sender, EventArgs e)
        {
            ChangeBoxesAmount(Convert.ToInt32(listSizeNum.Value));
        }

        private void ChangeBoxesAmount(int newAmount)
        {
            if(init)
            {
                int existsCount = inputBoxes.Count;

                if (existsCount > newAmount)
                {
                    for (int i = existsCount - 1; i >= newAmount; i--)
                    {
                        inputPanel.Controls.Remove(inputBoxes[i]);
                        inputBoxes.RemoveAt(i);
                    }
                }
                else
                {
                    for (int i = existsCount; i < newAmount; i++)
                    {
                        TextBox newBox = CreateTextBox();
                        inputBoxes.Add(newBox);
                        inputPanel.Controls.Add(newBox);
                    }
                }
            }
            
        }

        private TextBox CreateTextBox()
        {
            TextBox result = new TextBox();
            result.BackColor = Color.PaleTurquoise;
            result.Size = new Size(135, 26);

            int rowNum = inputBoxes.Count / 10;
            int colNum = inputBoxes.Count % 10;

            int x = 12 + 149 * rowNum;
            int y = 11 + 31 * colNum;

            result.Location = new Point(x, y);

            return result;
        }

        /// <summary>
        /// Закрытие формы и сбор сведений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DietList_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!view)
            {
                SaveData();
                ECD(dietListStr);
            }
        }

        private void SaveData()
        {
            bool hasData = false;
            foreach(TextBox t in inputBoxes)
            {
                if(Utilities.CheckName(t.Text))
                {
                    dietListStr += $"{t.Text};";
                    hasData = true;
                }
                
            }
            if (hasData)
                dietListStr = dietListStr.Substring(0, dietListStr.Length - 1);
            else
                dietListStr = "not stated";

            inputPanel.Controls.Clear();
            inputBoxes.Clear();
        }

        /// <summary>
        /// Загрузка формы и построение известных элементов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DietList_Load(object sender, EventArgs e)
        {
            if (view)
                ViewInit();
            else
                EditInit();

            init = true;
            this.Size = new Size(648, 470);
        }

        private void EditInit()
        {
            if (dietListStr != "")
            {
                string[] dietArray = dietListStr.Split(';');
                listSizeNum.Value = dietArray.Length;

                for (int i = 0; i < dietArray.Length; i++)
                {
                    TextBox newBox = CreateTextBox();
                    inputBoxes.Add(newBox);
                    inputPanel.Controls.Add(newBox);
                }

                for (int i = 0; i < dietArray.Length; i++)
                {
                    inputBoxes[i].Text = dietArray[i];
                }
                dietListStr = "";
            }
            else
            {
                TextBox first = CreateTextBox();
                inputBoxes.Add(first);
                inputPanel.Controls.Add(first);
            }
        }

        private void ViewInit()
        {
            listSizeNum.Visible = false;
            size_label.Visible = false;
            helperLabel.Visible = false;
            inputPanel.Visible = false;
            outputPanel.Location = size_label.Location;
            BuildTable();
        }

        private void BuildTable()
        {
            foreach(string foodObject in import.DietArray)
            {
                string name = foodObject;
                string type = "unknown";
                string status = "NO";

                IWaterCreature searchResult = LocalData.SearchObject(name);
                if(searchResult != null)
                {
                    type = searchResult.GetType().Name;
                    status = "OK";
                }

                tableView.Rows.Add(name, type, status);
            }
        }
    }
}
