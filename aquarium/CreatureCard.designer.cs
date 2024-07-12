namespace aquarium
{
    partial class CreatureCard
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
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.waterComboBox = new System.Windows.Forms.ComboBox();
            this.temperatureNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ageNum = new System.Windows.Forms.NumericUpDown();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.speciesBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dietListBtn = new System.Windows.Forms.Button();
            this.diet_label = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNum)).BeginInit();
            this.SuspendLayout();
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(308, 329);
            this.noButton.Margin = new System.Windows.Forms.Padding(4);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(133, 47);
            this.noButton.TabIndex = 60;
            this.noButton.Text = "Cancel";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.cancel_Click);
            // 
            // yesButton
            // 
            this.yesButton.Enabled = false;
            this.yesButton.Location = new System.Drawing.Point(73, 329);
            this.yesButton.Margin = new System.Windows.Forms.Padding(4);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(136, 47);
            this.yesButton.TabIndex = 59;
            this.yesButton.Text = "Action";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // waterComboBox
            // 
            this.waterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.waterComboBox.FormattingEnabled = true;
            this.waterComboBox.Items.AddRange(new object[] {
            "salt",
            "fresh"});
            this.waterComboBox.Location = new System.Drawing.Point(228, 201);
            this.waterComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.waterComboBox.Name = "waterComboBox";
            this.waterComboBox.Size = new System.Drawing.Size(165, 25);
            this.waterComboBox.TabIndex = 58;
            // 
            // temperatureNum
            // 
            this.temperatureNum.Location = new System.Drawing.Point(228, 242);
            this.temperatureNum.Margin = new System.Windows.Forms.Padding(4);
            this.temperatureNum.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.temperatureNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.temperatureNum.Name = "temperatureNum";
            this.temperatureNum.Size = new System.Drawing.Size(165, 24);
            this.temperatureNum.TabIndex = 57;
            this.temperatureNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(44, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Temperature: ";
            // 
            // ageNum
            // 
            this.ageNum.Location = new System.Drawing.Point(228, 157);
            this.ageNum.Margin = new System.Windows.Forms.Padding(4);
            this.ageNum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ageNum.Name = "ageNum";
            this.ageNum.Size = new System.Drawing.Size(165, 24);
            this.ageNum.TabIndex = 55;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.LightBlue;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.Blue;
            this.titleLabel.Location = new System.Drawing.Point(183, 27);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(45, 24);
            this.titleLabel.TabIndex = 54;
            this.titleLabel.Text = "Title";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(228, 115);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(215, 24);
            this.nameBox.TabIndex = 53;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // speciesBox
            // 
            this.speciesBox.Location = new System.Drawing.Point(228, 73);
            this.speciesBox.Margin = new System.Windows.Forms.Padding(4);
            this.speciesBox.Name = "speciesBox";
            this.speciesBox.Size = new System.Drawing.Size(215, 24);
            this.speciesBox.TabIndex = 52;
            this.speciesBox.TextChanged += new System.EventHandler(this.speciesBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(44, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Water: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(44, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Age: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(41, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Common name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(41, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Species: ";
            // 
            // dietListBtn
            // 
            this.dietListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dietListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dietListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dietListBtn.ForeColor = System.Drawing.Color.Black;
            this.dietListBtn.Location = new System.Drawing.Point(228, 279);
            this.dietListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dietListBtn.Name = "dietListBtn";
            this.dietListBtn.Size = new System.Drawing.Size(165, 25);
            this.dietListBtn.TabIndex = 61;
            this.dietListBtn.Text = "Diet list";
            this.dietListBtn.UseVisualStyleBackColor = false;
            this.dietListBtn.Visible = false;
            this.dietListBtn.Click += new System.EventHandler(this.dietListBtn_Click);
            // 
            // diet_label
            // 
            this.diet_label.AutoSize = true;
            this.diet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diet_label.ForeColor = System.Drawing.Color.DarkBlue;
            this.diet_label.Location = new System.Drawing.Point(48, 281);
            this.diet_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diet_label.Name = "diet_label";
            this.diet_label.Size = new System.Drawing.Size(42, 20);
            this.diet_label.TabIndex = 62;
            this.diet_label.Text = "Diet:";
            this.diet_label.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(241, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 63;
            this.statusLabel.Text = "status";
            this.statusLabel.Visible = false;
            // 
            // CreatureCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(482, 401);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.diet_label);
            this.Controls.Add(this.dietListBtn);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.waterComboBox);
            this.Controls.Add(this.temperatureNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ageNum);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.speciesBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreatureCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creature Card";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreatureCard_FormClosed);
            this.Load += new System.EventHandler(this.CreatureCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.ComboBox waterComboBox;
        private System.Windows.Forms.NumericUpDown temperatureNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ageNum;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox speciesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dietListBtn;
        private System.Windows.Forms.Label diet_label;
        private System.Windows.Forms.Label statusLabel;
    }
}