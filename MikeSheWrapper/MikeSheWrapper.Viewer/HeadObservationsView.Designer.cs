﻿namespace MikeSheWrapper.Viewer
{
  partial class HeadObservationsView
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
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.ButtonReadWells = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxObsFile = new System.Windows.Forms.TextBox();
      this.buttonReadObs = new System.Windows.Forms.Button();
      this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.MinNumber = new System.Windows.Forms.TextBox();
      this.RefreshButton = new System.Windows.Forms.Button();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.button4 = new System.Windows.Forms.Button();
      this.textBoxMikeSHe = new System.Windows.Forms.TextBox();
      this.buttonSelectMShe = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.button5 = new System.Windows.Forms.Button();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
      this.listBoxIntakes = new System.Windows.Forms.ListBox();
      this.OpenSheFileForSelection = new System.Windows.Forms.OpenFileDialog();
      this.buttonLSFile = new System.Windows.Forms.Button();
      this.radioButtonMax = new System.Windows.Forms.RadioButton();
      this.radioButtonMin = new System.Windows.Forms.RadioButton();
      this.buttonNovanaShape = new System.Windows.Forms.Button();
      this.listBoxAnlaeg = new System.Windows.Forms.ListBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.observationWellBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.observationWellBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.Filter = "Known file types (*.she, *.mdb, *.shp)|*.she;*.mdb;*.shp";
      this.openFileDialog1.ShowReadOnly = true;
      this.openFileDialog1.Title = "Select file with data for wells";
      // 
      // ButtonReadWells
      // 
      this.ButtonReadWells.Location = new System.Drawing.Point(468, 29);
      this.ButtonReadWells.Name = "ButtonReadWells";
      this.ButtonReadWells.Size = new System.Drawing.Size(26, 23);
      this.ButtonReadWells.TabIndex = 0;
      this.ButtonReadWells.Text = "...";
      this.ButtonReadWells.UseVisualStyleBackColor = true;
      this.ButtonReadWells.Click += new System.EventHandler(this.ReadButton_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(657, 31);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(79, 20);
      this.textBox1.TabIndex = 1;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(120, 30);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(342, 20);
      this.textBox2.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Read in wells";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 83);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(107, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Read in observations";
      // 
      // textBoxObsFile
      // 
      this.textBoxObsFile.Enabled = false;
      this.textBoxObsFile.Location = new System.Drawing.Point(120, 83);
      this.textBoxObsFile.Name = "textBoxObsFile";
      this.textBoxObsFile.Size = new System.Drawing.Size(342, 20);
      this.textBoxObsFile.TabIndex = 6;
      // 
      // buttonReadObs
      // 
      this.buttonReadObs.Enabled = false;
      this.buttonReadObs.Location = new System.Drawing.Point(468, 80);
      this.buttonReadObs.Name = "buttonReadObs";
      this.buttonReadObs.Size = new System.Drawing.Size(26, 23);
      this.buttonReadObs.TabIndex = 5;
      this.buttonReadObs.Text = "...";
      this.buttonReadObs.UseVisualStyleBackColor = true;
      this.buttonReadObs.Click += new System.EventHandler(this.button2_Click);
      // 
      // openFileDialog2
      // 
      this.openFileDialog2.Filter = "Jupiter Access database (*.mdb)|*.mdb";
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(657, 57);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(79, 20);
      this.textBox4.TabIndex = 9;
      // 
      // MinNumber
      // 
      this.MinNumber.Location = new System.Drawing.Point(798, 125);
      this.MinNumber.Name = "MinNumber";
      this.MinNumber.Size = new System.Drawing.Size(93, 20);
      this.MinNumber.TabIndex = 10;
      // 
      // RefreshButton
      // 
      this.RefreshButton.Location = new System.Drawing.Point(919, 125);
      this.RefreshButton.Name = "RefreshButton";
      this.RefreshButton.Size = new System.Drawing.Size(75, 23);
      this.RefreshButton.TabIndex = 11;
      this.RefreshButton.Text = "Refresh";
      this.RefreshButton.UseVisualStyleBackColor = true;
      this.RefreshButton.Click += new System.EventHandler(this.button3_Click);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(515, 127);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
      this.dateTimePicker1.TabIndex = 12;
      this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
      // 
      // dateTimePicker2
      // 
      this.dateTimePicker2.Location = new System.Drawing.Point(645, 127);
      this.dateTimePicker2.Name = "dateTimePicker2";
      this.dateTimePicker2.Size = new System.Drawing.Size(122, 20);
      this.dateTimePicker2.TabIndex = 13;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(515, 108);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "Start date";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(642, 108);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(50, 13);
      this.label4.TabIndex = 15;
      this.label4.Text = "End date";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(795, 90);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(114, 13);
      this.label5.TabIndex = 16;
      this.label5.Text = "Min or Max No. of obs.";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(537, 34);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(89, 13);
      this.label6.TabIndex = 17;
      this.label6.Text = "Total No. of wells";
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(15, 800);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(104, 23);
      this.button4.TabIndex = 18;
      this.button4.Text = "Create dfs0-files";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // textBoxMikeSHe
      // 
      this.textBoxMikeSHe.Location = new System.Drawing.Point(120, 140);
      this.textBoxMikeSHe.Name = "textBoxMikeSHe";
      this.textBoxMikeSHe.Size = new System.Drawing.Size(342, 20);
      this.textBoxMikeSHe.TabIndex = 21;
      // 
      // buttonSelectMShe
      // 
      this.buttonSelectMShe.Location = new System.Drawing.Point(468, 137);
      this.buttonSelectMShe.Name = "buttonSelectMShe";
      this.buttonSelectMShe.Size = new System.Drawing.Size(26, 23);
      this.buttonSelectMShe.TabIndex = 20;
      this.buttonSelectMShe.Text = "...";
      this.buttonSelectMShe.UseVisualStyleBackColor = true;
      this.buttonSelectMShe.Click += new System.EventHandler(this.buttonSelectMShe_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(15, 143);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(96, 13);
      this.label7.TabIndex = 22;
      this.label7.Text = "Select by MikeShe";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(537, 60);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(107, 13);
      this.label10.TabIndex = 27;
      this.label10.Text = "Selected No. of wells";
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(132, 800);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(104, 23);
      this.button5.TabIndex = 28;
      this.button5.Text = "Create shape file";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // propertyGrid1
      // 
      this.propertyGrid1.Location = new System.Drawing.Point(468, 539);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new System.Drawing.Size(230, 255);
      this.propertyGrid1.TabIndex = 29;
      // 
      // listBoxIntakes
      // 
      this.listBoxIntakes.FormattingEnabled = true;
      this.listBoxIntakes.Location = new System.Drawing.Point(468, 208);
      this.listBoxIntakes.Name = "listBoxIntakes";
      this.listBoxIntakes.Size = new System.Drawing.Size(210, 316);
      this.listBoxIntakes.TabIndex = 30;
      this.listBoxIntakes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // OpenSheFileForSelection
      // 
      this.OpenSheFileForSelection.Filter = "MikeShe imput file(*.she)|*.she";
      // 
      // buttonLSFile
      // 
      this.buttonLSFile.Location = new System.Drawing.Point(390, 800);
      this.buttonLSFile.Name = "buttonLSFile";
      this.buttonLSFile.Size = new System.Drawing.Size(104, 23);
      this.buttonLSFile.TabIndex = 31;
      this.buttonLSFile.Text = "Create ls file";
      this.buttonLSFile.UseVisualStyleBackColor = true;
      this.buttonLSFile.Click += new System.EventHandler(this.buttonLSFile_Click);
      // 
      // radioButtonMax
      // 
      this.radioButtonMax.AutoSize = true;
      this.radioButtonMax.Location = new System.Drawing.Point(798, 106);
      this.radioButtonMax.Name = "radioButtonMax";
      this.radioButtonMax.Size = new System.Drawing.Size(45, 17);
      this.radioButtonMax.TabIndex = 32;
      this.radioButtonMax.Text = "Max";
      this.radioButtonMax.UseVisualStyleBackColor = true;
      // 
      // radioButtonMin
      // 
      this.radioButtonMin.AutoSize = true;
      this.radioButtonMin.Checked = true;
      this.radioButtonMin.Location = new System.Drawing.Point(849, 106);
      this.radioButtonMin.Name = "radioButtonMin";
      this.radioButtonMin.Size = new System.Drawing.Size(42, 17);
      this.radioButtonMin.TabIndex = 33;
      this.radioButtonMin.TabStop = true;
      this.radioButtonMin.Text = "Min";
      this.radioButtonMin.UseVisualStyleBackColor = true;
      // 
      // buttonNovanaShape
      // 
      this.buttonNovanaShape.Enabled = false;
      this.buttonNovanaShape.Location = new System.Drawing.Point(242, 800);
      this.buttonNovanaShape.Name = "buttonNovanaShape";
      this.buttonNovanaShape.Size = new System.Drawing.Size(142, 23);
      this.buttonNovanaShape.TabIndex = 34;
      this.buttonNovanaShape.Text = "Create NOVANA shape file";
      this.buttonNovanaShape.UseVisualStyleBackColor = true;
      this.buttonNovanaShape.Click += new System.EventHandler(this.WriteNovanaShape);
      // 
      // listBoxAnlaeg
      // 
      this.listBoxAnlaeg.FormattingEnabled = true;
      this.listBoxAnlaeg.Location = new System.Drawing.Point(12, 208);
      this.listBoxAnlaeg.Name = "listBoxAnlaeg";
      this.listBoxAnlaeg.Size = new System.Drawing.Size(210, 368);
      this.listBoxAnlaeg.TabIndex = 35;
      this.listBoxAnlaeg.SelectedIndexChanged += new System.EventHandler(this.listBoxAnlaeg_SelectedIndexChanged);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(242, 208);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(210, 368);
      this.listBox1.TabIndex = 36;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(12, 189);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(36, 13);
      this.label8.TabIndex = 37;
      this.label8.Text = "Plants";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(252, 189);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(33, 13);
      this.label9.TabIndex = 38;
      this.label9.Text = "Wells";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(465, 189);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(42, 13);
      this.label11.TabIndex = 39;
      this.label11.Text = "Intakes";
      // 
      // observationWellBindingSource
      // 
      this.observationWellBindingSource.DataSource = typeof(MikeSheWrapper.Tools.ObservationWell);
      // 
      // HeadObservationsView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1009, 861);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.listBoxAnlaeg);
      this.Controls.Add(this.buttonNovanaShape);
      this.Controls.Add(this.radioButtonMin);
      this.Controls.Add(this.radioButtonMax);
      this.Controls.Add(this.buttonLSFile);
      this.Controls.Add(this.listBoxIntakes);
      this.Controls.Add(this.propertyGrid1);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.textBoxMikeSHe);
      this.Controls.Add(this.buttonSelectMShe);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dateTimePicker2);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.RefreshButton);
      this.Controls.Add(this.MinNumber);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBoxObsFile);
      this.Controls.Add(this.buttonReadObs);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.ButtonReadWells);
      this.Name = "HeadObservationsView";
      this.Text = "Wells and observations";
      this.Load += new System.EventHandler(this.HeadObservationsView_Load);
      ((System.ComponentModel.ISupportInitialize)(this.observationWellBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button ButtonReadWells;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxObsFile;
    private System.Windows.Forms.Button buttonReadObs;
    private System.Windows.Forms.OpenFileDialog openFileDialog2;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox MinNumber;
    private System.Windows.Forms.Button RefreshButton;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.DateTimePicker dateTimePicker2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.TextBox textBoxMikeSHe;
    private System.Windows.Forms.Button buttonSelectMShe;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.PropertyGrid propertyGrid1;
    private System.Windows.Forms.ListBox listBoxIntakes;
    private System.Windows.Forms.BindingSource observationWellBindingSource;
    private System.Windows.Forms.OpenFileDialog OpenSheFileForSelection;
    private System.Windows.Forms.Button buttonLSFile;
    private System.Windows.Forms.RadioButton radioButtonMax;
    private System.Windows.Forms.RadioButton radioButtonMin;
    private System.Windows.Forms.Button buttonNovanaShape;
    private System.Windows.Forms.ListBox listBoxAnlaeg;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label11;
  }
}

