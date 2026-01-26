namespace EL_Muze.Forms
{
    partial class Zabytek
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
            System.Windows.Forms.Label data_wpisuLabel;
            System.Windows.Forms.Label decyzjaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zabytek));
            this.button_exit = new System.Windows.Forms.Button();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.zabytkiDataSet = new EL_Muze.zabytkiDataSet();
            this.zabytkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zabytkiTableAdapter = new EL_Muze.zabytkiDataSetTableAdapters.zabytkiTableAdapter();
            this.tableAdapterManager = new EL_Muze.zabytkiDataSetTableAdapters.TableAdapterManager();
            this.zabytkiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zabytkiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.numerTextBox = new System.Windows.Forms.TextBox();
            this.obiektTextBox = new System.Windows.Forms.TextBox();
            this.nr_rejestruTextBox = new System.Windows.Forms.TextBox();
            this.data_wpisuDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.decyzjaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ulicaLabel = new System.Windows.Forms.Label();
            numerLabel = new System.Windows.Forms.Label();
            obiektLabel = new System.Windows.Forms.Label();
            nr_rejestruLabel = new System.Windows.Forms.Label();
            data_wpisuLabel = new System.Windows.Forms.Label();
            decyzjaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingNavigator)).BeginInit();
            this.zabytkiBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(40, 93);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 17;
            idLabel.Text = "id:";
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Location = new System.Drawing.Point(40, 119);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new System.Drawing.Size(32, 13);
            ulicaLabel.TabIndex = 19;
            ulicaLabel.Text = "ulica:";
            // 
            // numerLabel
            // 
            numerLabel.AutoSize = true;
            numerLabel.Location = new System.Drawing.Point(40, 145);
            numerLabel.Name = "numerLabel";
            numerLabel.Size = new System.Drawing.Size(39, 13);
            numerLabel.TabIndex = 21;
            numerLabel.Text = "numer:";
            // 
            // obiektLabel
            // 
            obiektLabel.AutoSize = true;
            obiektLabel.Location = new System.Drawing.Point(40, 171);
            obiektLabel.Name = "obiektLabel";
            obiektLabel.Size = new System.Drawing.Size(39, 13);
            obiektLabel.TabIndex = 23;
            obiektLabel.Text = "obiekt:";
            // 
            // nr_rejestruLabel
            // 
            nr_rejestruLabel.AutoSize = true;
            nr_rejestruLabel.Location = new System.Drawing.Point(40, 197);
            nr_rejestruLabel.Name = "nr_rejestruLabel";
            nr_rejestruLabel.Size = new System.Drawing.Size(56, 13);
            nr_rejestruLabel.TabIndex = 25;
            nr_rejestruLabel.Text = "nr rejestru:";
            // 
            // data_wpisuLabel
            // 
            data_wpisuLabel.AutoSize = true;
            data_wpisuLabel.Location = new System.Drawing.Point(40, 224);
            data_wpisuLabel.Name = "data_wpisuLabel";
            data_wpisuLabel.Size = new System.Drawing.Size(61, 13);
            data_wpisuLabel.TabIndex = 27;
            data_wpisuLabel.Text = "data wpisu:";
            // 
            // decyzjaLabel
            // 
            decyzjaLabel.AutoSize = true;
            decyzjaLabel.Location = new System.Drawing.Point(40, 249);
            decyzjaLabel.Name = "decyzjaLabel";
            decyzjaLabel.Size = new System.Drawing.Size(46, 13);
            decyzjaLabel.TabIndex = 29;
            decyzjaLabel.Text = "decyzja:";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Red;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.Location = new System.Drawing.Point(244, 321);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(86, 35);
            this.button_exit.TabIndex = 15;
            this.button_exit.Text = "Zamknij";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_zapisz
            // 
            this.button_zapisz.BackColor = System.Drawing.Color.Lime;
            this.button_zapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zapisz.Location = new System.Drawing.Point(11, 321);
            this.button_zapisz.Margin = new System.Windows.Forms.Padding(2);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(164, 35);
            this.button_zapisz.TabIndex = 16;
            this.button_zapisz.Text = "Zapisz zmiany";
            this.button_zapisz.UseVisualStyleBackColor = false;
            this.button_zapisz.Click += new System.EventHandler(this.button1_Click);
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
            // zabytkiBindingNavigator
            // 
            this.zabytkiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zabytkiBindingNavigator.BindingSource = this.zabytkiBindingSource;
            this.zabytkiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zabytkiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zabytkiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.zabytkiBindingNavigatorSaveItem});
            this.zabytkiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zabytkiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zabytkiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zabytkiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zabytkiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zabytkiBindingNavigator.Name = "zabytkiBindingNavigator";
            this.zabytkiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zabytkiBindingNavigator.Size = new System.Drawing.Size(353, 25);
            this.zabytkiBindingNavigator.TabIndex = 17;
            this.zabytkiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
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
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // zabytkiBindingNavigatorSaveItem
            // 
            this.zabytkiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zabytkiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zabytkiBindingNavigatorSaveItem.Image")));
            this.zabytkiBindingNavigatorSaveItem.Name = "zabytkiBindingNavigatorSaveItem";
            this.zabytkiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.zabytkiBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.zabytkiBindingNavigatorSaveItem.Click += new System.EventHandler(this.zabytkiBindingNavigatorSaveItem_Click_1);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(107, 90);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 18;
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "ulica", true));
            this.ulicaTextBox.Location = new System.Drawing.Point(107, 116);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(200, 20);
            this.ulicaTextBox.TabIndex = 20;
            // 
            // numerTextBox
            // 
            this.numerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "numer", true));
            this.numerTextBox.Location = new System.Drawing.Point(107, 142);
            this.numerTextBox.Name = "numerTextBox";
            this.numerTextBox.Size = new System.Drawing.Size(200, 20);
            this.numerTextBox.TabIndex = 22;
            // 
            // obiektTextBox
            // 
            this.obiektTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "obiekt", true));
            this.obiektTextBox.Location = new System.Drawing.Point(107, 168);
            this.obiektTextBox.Name = "obiektTextBox";
            this.obiektTextBox.Size = new System.Drawing.Size(200, 20);
            this.obiektTextBox.TabIndex = 24;
            // 
            // nr_rejestruTextBox
            // 
            this.nr_rejestruTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "nr_rejestru", true));
            this.nr_rejestruTextBox.Location = new System.Drawing.Point(107, 194);
            this.nr_rejestruTextBox.Name = "nr_rejestruTextBox";
            this.nr_rejestruTextBox.Size = new System.Drawing.Size(200, 20);
            this.nr_rejestruTextBox.TabIndex = 26;
            // 
            // data_wpisuDateTimePicker
            // 
            this.data_wpisuDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zabytkiBindingSource, "data_wpisu", true));
            this.data_wpisuDateTimePicker.Location = new System.Drawing.Point(107, 220);
            this.data_wpisuDateTimePicker.Name = "data_wpisuDateTimePicker";
            this.data_wpisuDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_wpisuDateTimePicker.TabIndex = 28;
            // 
            // decyzjaTextBox
            // 
            this.decyzjaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zabytkiBindingSource, "decyzja", true));
            this.decyzjaTextBox.Location = new System.Drawing.Point(107, 246);
            this.decyzjaTextBox.Name = "decyzjaTextBox";
            this.decyzjaTextBox.Size = new System.Drawing.Size(200, 20);
            this.decyzjaTextBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Wprowadź dane";
            // 
            // Zabytek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 376);
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
            this.Controls.Add(data_wpisuLabel);
            this.Controls.Add(this.data_wpisuDateTimePicker);
            this.Controls.Add(decyzjaLabel);
            this.Controls.Add(this.decyzjaTextBox);
            this.Controls.Add(this.zabytkiBindingNavigator);
            this.Controls.Add(this.button_zapisz);
            this.Controls.Add(this.button_exit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Zabytek";
            this.Text = "Zabytek";
            this.Load += new System.EventHandler(this.Zabytek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingNavigator)).EndInit();
            this.zabytkiBindingNavigator.ResumeLayout(false);
            this.zabytkiBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_zapisz;
        private zabytkiDataSet zabytkiDataSet;
        private System.Windows.Forms.BindingSource zabytkiBindingSource;
        private zabytkiDataSetTableAdapters.zabytkiTableAdapter zabytkiTableAdapter;
        private zabytkiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zabytkiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zabytkiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private System.Windows.Forms.TextBox numerTextBox;
        private System.Windows.Forms.TextBox obiektTextBox;
        private System.Windows.Forms.TextBox nr_rejestruTextBox;
        private System.Windows.Forms.DateTimePicker data_wpisuDateTimePicker;
        private System.Windows.Forms.TextBox decyzjaTextBox;
        private System.Windows.Forms.Label label1;
    }
}