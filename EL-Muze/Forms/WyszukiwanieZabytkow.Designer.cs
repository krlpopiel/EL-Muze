namespace EL_Muze.Forms
{
    partial class WyszukiwanieZabytkow
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label ulicaLabel;
            System.Windows.Forms.Label numerLabel;
            System.Windows.Forms.Label obiektLabel;
            System.Windows.Forms.Label nr_rejestruLabel;
            System.Windows.Forms.Label decyzjaLabel;
            this.data_wpisu_od_Label = new System.Windows.Forms.Label();
            this.data_wpisu_do_Label = new System.Windows.Forms.Label();
            this.zabytkiDataSet = new EL_Muze.zabytkiDataSet();
            this.zabytkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zabytkiTableAdapter = new EL_Muze.zabytkiDataSetTableAdapters.zabytkiTableAdapter();
            this.tableAdapterManager = new EL_Muze.zabytkiDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.numerTextBox = new System.Windows.Forms.TextBox();
            this.obiektTextBox = new System.Windows.Forms.TextBox();
            this.nr_rejestruTextBox = new System.Windows.Forms.TextBox();
            this.data_wpisu_od_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.decyzjaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_wpisu_do_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.button_wyszukaj = new System.Windows.Forms.Button();
            this.button_wyjscie = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            ulicaLabel = new System.Windows.Forms.Label();
            numerLabel = new System.Windows.Forms.Label();
            obiektLabel = new System.Windows.Forms.Label();
            nr_rejestruLabel = new System.Windows.Forms.Label();
            decyzjaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 35);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Location = new System.Drawing.Point(12, 61);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new System.Drawing.Size(32, 13);
            ulicaLabel.TabIndex = 3;
            ulicaLabel.Text = "ulica:";
            // 
            // numerLabel
            // 
            numerLabel.AutoSize = true;
            numerLabel.Location = new System.Drawing.Point(12, 87);
            numerLabel.Name = "numerLabel";
            numerLabel.Size = new System.Drawing.Size(39, 13);
            numerLabel.TabIndex = 5;
            numerLabel.Text = "numer:";
            // 
            // obiektLabel
            // 
            obiektLabel.AutoSize = true;
            obiektLabel.Location = new System.Drawing.Point(12, 113);
            obiektLabel.Name = "obiektLabel";
            obiektLabel.Size = new System.Drawing.Size(39, 13);
            obiektLabel.TabIndex = 7;
            obiektLabel.Text = "obiekt:";
            // 
            // nr_rejestruLabel
            // 
            nr_rejestruLabel.AutoSize = true;
            nr_rejestruLabel.Location = new System.Drawing.Point(12, 139);
            nr_rejestruLabel.Name = "nr_rejestruLabel";
            nr_rejestruLabel.Size = new System.Drawing.Size(56, 13);
            nr_rejestruLabel.TabIndex = 9;
            nr_rejestruLabel.Text = "nr rejestru:";
            // 
            // data_wpisu_od_Label
            // 
            this.data_wpisu_od_Label.AutoSize = true;
            this.data_wpisu_od_Label.Location = new System.Drawing.Point(12, 166);
            this.data_wpisu_od_Label.Name = "data_wpisu_od_Label";
            this.data_wpisu_od_Label.Size = new System.Drawing.Size(76, 13);
            this.data_wpisu_od_Label.TabIndex = 11;
            this.data_wpisu_od_Label.Text = "data wpisu od:";
            // 
            // decyzjaLabel
            // 
            decyzjaLabel.AutoSize = true;
            decyzjaLabel.Location = new System.Drawing.Point(12, 217);
            decyzjaLabel.Name = "decyzjaLabel";
            decyzjaLabel.Size = new System.Drawing.Size(46, 13);
            decyzjaLabel.TabIndex = 13;
            decyzjaLabel.Text = "decyzja:";
            // 
            // data_wpisu_do_Label
            // 
            this.data_wpisu_do_Label.AutoSize = true;
            this.data_wpisu_do_Label.Location = new System.Drawing.Point(12, 192);
            this.data_wpisu_do_Label.Name = "data_wpisu_do_Label";
            this.data_wpisu_do_Label.Size = new System.Drawing.Size(76, 13);
            this.data_wpisu_do_Label.TabIndex = 16;
            this.data_wpisu_do_Label.Text = "data wpisu do:";
            // 
            // zabytkiDataSet
            // 
            this.zabytkiDataSet.DataSetName = "zabytkiDataSet";
            this.zabytkiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zabytkiBindingSource
            // 
            this.zabytkiBindingSource.DataMember = "zabytki";
            this.zabytkiBindingSource.DataSource = this.zabytkiDataSet;
            // 
            // zabytkiTableAdapter
            // 
            this.zabytkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = EL_Muze.zabytkiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zabytkiTableAdapter = this.zabytkiTableAdapter;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(95, 32);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "ulica", true));
            this.ulicaTextBox.Location = new System.Drawing.Point(95, 58);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(200, 20);
            this.ulicaTextBox.TabIndex = 4;
            // 
            // numerTextBox
            // 
            this.numerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "numer", true));
            this.numerTextBox.Location = new System.Drawing.Point(95, 84);
            this.numerTextBox.Name = "numerTextBox";
            this.numerTextBox.Size = new System.Drawing.Size(200, 20);
            this.numerTextBox.TabIndex = 6;
            // 
            // obiektTextBox
            // 
            this.obiektTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "obiekt", true));
            this.obiektTextBox.Location = new System.Drawing.Point(95, 110);
            this.obiektTextBox.Name = "obiektTextBox";
            this.obiektTextBox.Size = new System.Drawing.Size(200, 20);
            this.obiektTextBox.TabIndex = 8;
            // 
            // nr_rejestruTextBox
            // 
            this.nr_rejestruTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "nr_rejestru", true));
            this.nr_rejestruTextBox.Location = new System.Drawing.Point(95, 136);
            this.nr_rejestruTextBox.Name = "nr_rejestruTextBox";
            this.nr_rejestruTextBox.Size = new System.Drawing.Size(200, 20);
            this.nr_rejestruTextBox.TabIndex = 10;
            // 
            // data_wpisu_od_DateTimePicker
            // 
            this.data_wpisu_od_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zabytkiBindingSource, "data_wpisu", true));
            this.data_wpisu_od_DateTimePicker.Location = new System.Drawing.Point(95, 162);
            this.data_wpisu_od_DateTimePicker.Name = "data_wpisu_od_DateTimePicker";
            this.data_wpisu_od_DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_wpisu_od_DateTimePicker.TabIndex = 12;
            // 
            // decyzjaTextBox
            // 
            this.decyzjaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "decyzja", true));
            this.decyzjaTextBox.Location = new System.Drawing.Point(95, 214);
            this.decyzjaTextBox.Name = "decyzjaTextBox";
            this.decyzjaTextBox.Size = new System.Drawing.Size(200, 20);
            this.decyzjaTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Wprowadź dane do wyszukania:";
            // 
            // data_wpisu_do_DateTimePicker
            // 
            this.data_wpisu_do_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zabytkiBindingSource, "data_wpisu", true));
            this.data_wpisu_do_DateTimePicker.Location = new System.Drawing.Point(95, 188);
            this.data_wpisu_do_DateTimePicker.Name = "data_wpisu_do_DateTimePicker";
            this.data_wpisu_do_DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_wpisu_do_DateTimePicker.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(301, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Zawrzyj w wyszukaniu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(301, 61);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(131, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Zawrzyj w wyszukaniu";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(301, 87);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(131, 17);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Zawrzyj w wyszukaniu";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(301, 113);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(131, 17);
            this.checkBox4.TabIndex = 21;
            this.checkBox4.Text = "Zawrzyj w wyszukaniu";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(301, 138);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(131, 17);
            this.checkBox5.TabIndex = 22;
            this.checkBox5.Text = "Zawrzyj w wyszukaniu";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(301, 161);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(131, 17);
            this.checkBox6.TabIndex = 23;
            this.checkBox6.Text = "Zawrzyj w wyszukaniu";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(301, 188);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(131, 17);
            this.checkBox7.TabIndex = 24;
            this.checkBox7.Text = "Zawrzyj w wyszukaniu";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(301, 217);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(131, 17);
            this.checkBox8.TabIndex = 25;
            this.checkBox8.Text = "Zawrzyj w wyszukaniu";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // button_wyszukaj
            // 
            this.button_wyszukaj.BackColor = System.Drawing.Color.Lime;
            this.button_wyszukaj.Location = new System.Drawing.Point(15, 311);
            this.button_wyszukaj.Name = "button_wyszukaj";
            this.button_wyszukaj.Size = new System.Drawing.Size(138, 50);
            this.button_wyszukaj.TabIndex = 26;
            this.button_wyszukaj.Text = "Szukaj!";
            this.button_wyszukaj.UseVisualStyleBackColor = false;
            this.button_wyszukaj.Click += new System.EventHandler(this.button_wyszukaj_Click);
            // 
            // button_wyjscie
            // 
            this.button_wyjscie.BackColor = System.Drawing.Color.Red;
            this.button_wyjscie.Location = new System.Drawing.Point(295, 311);
            this.button_wyjscie.Name = "button_wyjscie";
            this.button_wyjscie.Size = new System.Drawing.Size(133, 50);
            this.button_wyjscie.TabIndex = 27;
            this.button_wyjscie.Text = "Wyjście!";
            this.button_wyjscie.UseVisualStyleBackColor = false;
            this.button_wyjscie.Click += new System.EventHandler(this.button_wyjscie_Click);
            // 
            // WyszukiwanieZabytkow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 373);
            this.Controls.Add(this.button_wyjscie);
            this.Controls.Add(this.button_wyszukaj);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.data_wpisu_do_Label);
            this.Controls.Add(this.data_wpisu_do_DateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(ulicaLabel);
            this.Controls.Add(this.ulicaTextBox);
            this.Controls.Add(numerLabel);
            this.Controls.Add(this.numerTextBox);
            this.Controls.Add(obiektLabel);
            this.Controls.Add(this.obiektTextBox);
            this.Controls.Add(nr_rejestruLabel);
            this.Controls.Add(this.nr_rejestruTextBox);
            this.Controls.Add(this.data_wpisu_od_Label);
            this.Controls.Add(this.data_wpisu_od_DateTimePicker);
            this.Controls.Add(decyzjaLabel);
            this.Controls.Add(this.decyzjaTextBox);
            this.Name = "WyszukiwanieZabytkow";
            this.Text = "WyszukiwanieZabytkow";
            this.Load += new System.EventHandler(this.WyszukiwanieZabytkow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private zabytkiDataSet zabytkiDataSet;
        private System.Windows.Forms.BindingSource zabytkiBindingSource;
        private zabytkiDataSetTableAdapters.zabytkiTableAdapter zabytkiTableAdapter;
        private zabytkiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private System.Windows.Forms.TextBox numerTextBox;
        private System.Windows.Forms.TextBox obiektTextBox;
        private System.Windows.Forms.TextBox nr_rejestruTextBox;
        private System.Windows.Forms.DateTimePicker data_wpisu_od_DateTimePicker;
        private System.Windows.Forms.TextBox decyzjaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker data_wpisu_do_DateTimePicker;
        private System.Windows.Forms.Label data_wpisu_od_Label;
        private System.Windows.Forms.Label data_wpisu_do_Label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Button button_wyszukaj;
        private System.Windows.Forms.Button button_wyjscie;
    }
}