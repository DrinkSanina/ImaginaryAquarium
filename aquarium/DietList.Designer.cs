
namespace aquarium
{
    partial class DietList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DietList));
            this.label1 = new System.Windows.Forms.Label();
            this.size_label = new System.Windows.Forms.Label();
            this.listSizeNum = new System.Windows.Forms.NumericUpDown();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.helperLabel = new System.Windows.Forms.Label();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.outPut_title = new System.Windows.Forms.Label();
            this.output_ID = new System.Windows.Forms.Label();
            this.output_name = new System.Windows.Forms.Label();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColomn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availColomn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listSizeNum)).BeginInit();
            this.outputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 45;
            this.label1.Text = "Diet List";
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.BackColor = System.Drawing.Color.LightBlue;
            this.size_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size_label.ForeColor = System.Drawing.Color.Blue;
            this.size_label.Location = new System.Drawing.Point(8, 63);
            this.size_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(78, 24);
            this.size_label.TabIndex = 55;
            this.size_label.Text = "List Size";
            // 
            // listSizeNum
            // 
            this.listSizeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listSizeNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listSizeNum.Location = new System.Drawing.Point(91, 61);
            this.listSizeNum.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.listSizeNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.listSizeNum.Name = "listSizeNum";
            this.listSizeNum.Size = new System.Drawing.Size(120, 26);
            this.listSizeNum.TabIndex = 56;
            this.listSizeNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.listSizeNum.ValueChanged += new System.EventHandler(this.listSizeNum_ValueChanged);
            // 
            // inputPanel
            // 
            this.inputPanel.Location = new System.Drawing.Point(12, 102);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(608, 318);
            this.inputPanel.TabIndex = 57;
            // 
            // helperLabel
            // 
            this.helperLabel.AutoSize = true;
            this.helperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helperLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.helperLabel.Location = new System.Drawing.Point(348, 79);
            this.helperLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helperLabel.Name = "helperLabel";
            this.helperLabel.Size = new System.Drawing.Size(272, 20);
            this.helperLabel.TabIndex = 58;
            this.helperLabel.Text = "Type common names of food species";
            // 
            // outputPanel
            // 
            this.outputPanel.AutoScroll = true;
            this.outputPanel.Controls.Add(this.tableView);
            this.outputPanel.Controls.Add(this.outPut_title);
            this.outputPanel.Controls.Add(this.output_ID);
            this.outputPanel.Controls.Add(this.output_name);
            this.outputPanel.Location = new System.Drawing.Point(12, 439);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(608, 318);
            this.outputPanel.TabIndex = 58;
            // 
            // outPut_title
            // 
            this.outPut_title.AutoSize = true;
            this.outPut_title.BackColor = System.Drawing.Color.LightBlue;
            this.outPut_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outPut_title.ForeColor = System.Drawing.Color.Blue;
            this.outPut_title.Location = new System.Drawing.Point(4, 70);
            this.outPut_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outPut_title.Name = "outPut_title";
            this.outPut_title.Size = new System.Drawing.Size(74, 24);
            this.outPut_title.TabIndex = 57;
            this.outPut_title.Text = "Diet List";
            // 
            // output_ID
            // 
            this.output_ID.AutoSize = true;
            this.output_ID.BackColor = System.Drawing.Color.LightBlue;
            this.output_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_ID.ForeColor = System.Drawing.Color.Blue;
            this.output_ID.Location = new System.Drawing.Point(4, 36);
            this.output_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.output_ID.Name = "output_ID";
            this.output_ID.Size = new System.Drawing.Size(66, 24);
            this.output_ID.TabIndex = 56;
            this.output_ID.Text = "ID: {ID}";
            // 
            // output_name
            // 
            this.output_name.AutoSize = true;
            this.output_name.BackColor = System.Drawing.Color.LightBlue;
            this.output_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_name.ForeColor = System.Drawing.Color.Blue;
            this.output_name.Location = new System.Drawing.Point(4, 12);
            this.output_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.output_name.Name = "output_name";
            this.output_name.Size = new System.Drawing.Size(214, 24);
            this.output_name.TabIndex = 55;
            this.output_name.Text = "Common Name: {name}";
            // 
            // tableView
            // 
            this.tableView.AllowUserToAddRows = false;
            this.tableView.AllowUserToDeleteRows = false;
            this.tableView.AllowUserToResizeColumns = false;
            this.tableView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.tableView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableView.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.typeColomn,
            this.availColomn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableView.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableView.GridColor = System.Drawing.Color.MediumAquamarine;
            this.tableView.Location = new System.Drawing.Point(3, 97);
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableView.Size = new System.Drawing.Size(602, 218);
            this.tableView.TabIndex = 60;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Food Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameColumn.Width = 250;
            // 
            // typeColomn
            // 
            this.typeColomn.HeaderText = "Type";
            this.typeColomn.Name = "typeColomn";
            this.typeColomn.ReadOnly = true;
            this.typeColomn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeColomn.Width = 150;
            // 
            // availColomn
            // 
            this.availColomn.HeaderText = "Availability";
            this.availColomn.Name = "availColomn";
            this.availColomn.ReadOnly = true;
            this.availColomn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.availColomn.Width = 150;
            // 
            // DietList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(632, 837);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.helperLabel);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.listSizeNum);
            this.Controls.Add(this.size_label);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DietList";
            this.Text = "Diet list";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DietList_FormClosed);
            this.Load += new System.EventHandler(this.DietList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listSizeNum)).EndInit();
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.NumericUpDown listSizeNum;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label helperLabel;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.Label outPut_title;
        private System.Windows.Forms.Label output_ID;
        private System.Windows.Forms.Label output_name;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColomn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availColomn;
    }
}