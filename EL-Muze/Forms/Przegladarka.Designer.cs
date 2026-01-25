namespace EL_Muze.Forms
{
    partial class Przegladarka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Przegladarka));
            this.centrala_muzeumDataSet = new EL_Muze.centrala_muzeumDataSet();
            this.zabytkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zabytkiTableAdapter = new EL_Muze.centrala_muzeumDataSetTableAdapters.zabytkiTableAdapter();
            this.tableAdapterManager = new EL_Muze.centrala_muzeumDataSetTableAdapters.TableAdapterManager();
            this.zabytkiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.zabytkiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.zabytkiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.button_modyfikuj = new System.Windows.Forms.Button();
            this.button_usun = new System.Windows.Forms.Button();
            this.button_wyjscie = new System.Windows.Forms.Button();
            this.button_pokaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.centrala_muzeumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingNavigator)).BeginInit();
            this.zabytkiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // centrala_muzeumDataSet
            // 
            this.centrala_muzeumDataSet.DataSetName = "centrala_muzeumDataSet";
            this.centrala_muzeumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zabytkiBindingSource
            // 
            this.zabytkiBindingSource.DataMember = "zabytki";
            this.zabytkiBindingSource.DataSource = this.centrala_muzeumDataSet;
            // 
            // zabytkiTableAdapter
            // 
            this.zabytkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = EL_Muze.centrala_muzeumDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zabytkiTableAdapter = this.zabytkiTableAdapter;
            // 
            // zabytkiBindingNavigator
            // 
            this.zabytkiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zabytkiBindingNavigator.BindingSource = this.zabytkiBindingSource;
            this.zabytkiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zabytkiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zabytkiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.zabytkiBindingNavigator.Size = new System.Drawing.Size(1307, 27);
            this.zabytkiBindingNavigator.TabIndex = 0;
            this.zabytkiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // zabytkiBindingNavigatorSaveItem
            // 
            this.zabytkiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zabytkiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zabytkiBindingNavigatorSaveItem.Image")));
            this.zabytkiBindingNavigatorSaveItem.Name = "zabytkiBindingNavigatorSaveItem";
            this.zabytkiBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.zabytkiBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.zabytkiBindingNavigatorSaveItem.Click += new System.EventHandler(this.zabytkiBindingNavigatorSaveItem_Click);
            // 
            // zabytkiDataGridView
            // 
            this.zabytkiDataGridView.AutoGenerateColumns = false;
            this.zabytkiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zabytkiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.zabytkiDataGridView.DataSource = this.zabytkiBindingSource;
            this.zabytkiDataGridView.Location = new System.Drawing.Point(0, 32);
            this.zabytkiDataGridView.Name = "zabytkiDataGridView";
            this.zabytkiDataGridView.RowHeadersWidth = 51;
            this.zabytkiDataGridView.RowTemplate.Height = 24;
            this.zabytkiDataGridView.Size = new System.Drawing.Size(1295, 285);
            this.zabytkiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ulica";
            this.dataGridViewTextBoxColumn2.HeaderText = "ulica";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "numer";
            this.dataGridViewTextBoxColumn3.HeaderText = "numer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "obiekt";
            this.dataGridViewTextBoxColumn4.HeaderText = "obiekt";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nr_rejestru";
            this.dataGridViewTextBoxColumn5.HeaderText = "nr_rejestru";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "data_wpisu";
            this.dataGridViewTextBoxColumn6.HeaderText = "data_wpisu";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "decyzja";
            this.dataGridViewTextBoxColumn7.HeaderText = "decyzja";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // button_dodaj
            // 
            this.button_dodaj.BackColor = System.Drawing.Color.Lime;
            this.button_dodaj.Location = new System.Drawing.Point(39, 345);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(185, 86);
            this.button_dodaj.TabIndex = 2;
            this.button_dodaj.Text = "Dodaj zabytek";
            this.button_dodaj.UseVisualStyleBackColor = false;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // button_modyfikuj
            // 
            this.button_modyfikuj.BackColor = System.Drawing.Color.Yellow;
            this.button_modyfikuj.Location = new System.Drawing.Point(261, 345);
            this.button_modyfikuj.Name = "button_modyfikuj";
            this.button_modyfikuj.Size = new System.Drawing.Size(185, 86);
            this.button_modyfikuj.TabIndex = 3;
            this.button_modyfikuj.Text = "Modyfikuj zabytek";
            this.button_modyfikuj.UseVisualStyleBackColor = false;
            this.button_modyfikuj.Click += new System.EventHandler(this.button_modyfikuj_Click);
            // 
            // button_usun
            // 
            this.button_usun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_usun.Location = new System.Drawing.Point(472, 345);
            this.button_usun.Name = "button_usun";
            this.button_usun.Size = new System.Drawing.Size(174, 86);
            this.button_usun.TabIndex = 4;
            this.button_usun.Text = "Usuń zabytek";
            this.button_usun.UseVisualStyleBackColor = false;
            this.button_usun.Click += new System.EventHandler(this.button_usun_Click);
            // 
            // button_wyjscie
            // 
            this.button_wyjscie.BackColor = System.Drawing.Color.Red;
            this.button_wyjscie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wyjscie.Location = new System.Drawing.Point(1115, 345);
            this.button_wyjscie.Name = "button_wyjscie";
            this.button_wyjscie.Size = new System.Drawing.Size(180, 86);
            this.button_wyjscie.TabIndex = 5;
            this.button_wyjscie.Text = "Wyjscie";
            this.button_wyjscie.UseVisualStyleBackColor = false;
            this.button_wyjscie.Click += new System.EventHandler(this.button_wyjscie_Click);
            // 
            // button_pokaz
            // 
            this.button_pokaz.BackColor = System.Drawing.Color.Cyan;
            this.button_pokaz.Location = new System.Drawing.Point(796, 345);
            this.button_pokaz.Name = "button_pokaz";
            this.button_pokaz.Size = new System.Drawing.Size(188, 86);
            this.button_pokaz.TabIndex = 6;
            this.button_pokaz.Text = "Pokaż szczegóły zabytku";
            this.button_pokaz.UseVisualStyleBackColor = false;
            this.button_pokaz.Click += new System.EventHandler(this.button_pokaz_Click);
            // 
            // Przegladarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 457);
            this.Controls.Add(this.button_pokaz);
            this.Controls.Add(this.button_wyjscie);
            this.Controls.Add(this.button_usun);
            this.Controls.Add(this.button_modyfikuj);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.zabytkiDataGridView);
            this.Controls.Add(this.zabytkiBindingNavigator);
            this.Name = "Przegladarka";
            this.Text = "Przeglądarka";
            this.Load += new System.EventHandler(this.Przegladarka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.centrala_muzeumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingNavigator)).EndInit();
            this.zabytkiBindingNavigator.ResumeLayout(false);
            this.zabytkiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private centrala_muzeumDataSet centrala_muzeumDataSet;
        private System.Windows.Forms.BindingSource zabytkiBindingSource;
        private centrala_muzeumDataSetTableAdapters.zabytkiTableAdapter zabytkiTableAdapter;
        private centrala_muzeumDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_modyfikuj;
        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.Button button_wyjscie;
        private System.Windows.Forms.Button button_pokaz;
        public System.Windows.Forms.DataGridView zabytkiDataGridView;
    }
}