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
            this.button_dodaj = new System.Windows.Forms.Button();
            this.button_modyfikuj = new System.Windows.Forms.Button();
            this.button_usun = new System.Windows.Forms.Button();
            this.button_wyjscie = new System.Windows.Forms.Button();
            this.button_pokaz = new System.Windows.Forms.Button();
            this.button_archiwum = new System.Windows.Forms.Button();
            this.button_szukaj = new System.Windows.Forms.Button();
            this.zabytkiDataSet = new EL_Muze.zabytkiDataSet();
            this.zabytkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zabytkiTableAdapter = new EL_Muze.zabytkiDataSetTableAdapters.zabytkiTableAdapter();
            this.tableAdapterManager = new EL_Muze.zabytkiDataSetTableAdapters.TableAdapterManager();
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
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingNavigator)).BeginInit();
            this.zabytkiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button_dodaj
            // 
            this.button_dodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_dodaj.BackColor = System.Drawing.Color.Lime;
            this.button_dodaj.Location = new System.Drawing.Point(29, 280);
            this.button_dodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(139, 70);
            this.button_dodaj.TabIndex = 2;
            this.button_dodaj.Text = "Dodaj zabytek";
            this.button_dodaj.UseVisualStyleBackColor = false;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // button_modyfikuj
            // 
            this.button_modyfikuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_modyfikuj.BackColor = System.Drawing.Color.Yellow;
            this.button_modyfikuj.Location = new System.Drawing.Point(196, 280);
            this.button_modyfikuj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_modyfikuj.Name = "button_modyfikuj";
            this.button_modyfikuj.Size = new System.Drawing.Size(139, 70);
            this.button_modyfikuj.TabIndex = 3;
            this.button_modyfikuj.Text = "Modyfikuj zabytek";
            this.button_modyfikuj.UseVisualStyleBackColor = false;
            this.button_modyfikuj.Click += new System.EventHandler(this.button_modyfikuj_Click);
            // 
            // button_usun
            // 
            this.button_usun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_usun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_usun.Location = new System.Drawing.Point(354, 280);
            this.button_usun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_usun.Name = "button_usun";
            this.button_usun.Size = new System.Drawing.Size(130, 70);
            this.button_usun.TabIndex = 4;
            this.button_usun.Text = "Usuń zabytek";
            this.button_usun.UseVisualStyleBackColor = false;
            this.button_usun.Click += new System.EventHandler(this.button_usun_Click);
            // 
            // button_wyjscie
            // 
            this.button_wyjscie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_wyjscie.BackColor = System.Drawing.Color.Red;
            this.button_wyjscie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wyjscie.Location = new System.Drawing.Point(1087, 277);
            this.button_wyjscie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_wyjscie.Name = "button_wyjscie";
            this.button_wyjscie.Size = new System.Drawing.Size(135, 70);
            this.button_wyjscie.TabIndex = 5;
            this.button_wyjscie.Text = "Wyjscie";
            this.button_wyjscie.UseVisualStyleBackColor = false;
            this.button_wyjscie.Click += new System.EventHandler(this.button_wyjscie_Click);
            // 
            // button_pokaz
            // 
            this.button_pokaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_pokaz.BackColor = System.Drawing.Color.Cyan;
            this.button_pokaz.Location = new System.Drawing.Point(502, 280);
            this.button_pokaz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_pokaz.Name = "button_pokaz";
            this.button_pokaz.Size = new System.Drawing.Size(141, 70);
            this.button_pokaz.TabIndex = 6;
            this.button_pokaz.Text = "Pokaż szczegóły zabytku";
            this.button_pokaz.UseVisualStyleBackColor = false;
            this.button_pokaz.Click += new System.EventHandler(this.button_pokaz_Click);
            // 
            // button_archiwum
            // 
            this.button_archiwum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_archiwum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_archiwum.Location = new System.Drawing.Point(926, 280);
            this.button_archiwum.Name = "button_archiwum";
            this.button_archiwum.Size = new System.Drawing.Size(148, 67);
            this.button_archiwum.TabIndex = 7;
            this.button_archiwum.Text = "Archiwum zabytków";
            this.button_archiwum.UseVisualStyleBackColor = false;
            this.button_archiwum.Click += new System.EventHandler(this.button_archiwum_Click);
            // 
            // button_szukaj
            // 
            this.button_szukaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_szukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_szukaj.Location = new System.Drawing.Point(674, 280);
            this.button_szukaj.Name = "button_szukaj";
            this.button_szukaj.Size = new System.Drawing.Size(134, 67);
            this.button_szukaj.TabIndex = 8;
            this.button_szukaj.Text = "Wyszukaj zabytek";
            this.button_szukaj.UseVisualStyleBackColor = false;
            this.button_szukaj.Click += new System.EventHandler(this.button_szukaj_Click);
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
            this.zabytkiBindingNavigator.Size = new System.Drawing.Size(1242, 25);
            this.zabytkiBindingNavigator.TabIndex = 9;
            this.zabytkiBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 15);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // zabytkiBindingNavigatorSaveItem
            // 
            this.zabytkiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zabytkiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zabytkiBindingNavigatorSaveItem.Image")));
            this.zabytkiBindingNavigatorSaveItem.Name = "zabytkiBindingNavigatorSaveItem";
            this.zabytkiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.zabytkiBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.zabytkiBindingNavigatorSaveItem.Click += new System.EventHandler(this.zabytkiBindingNavigatorSaveItem_Click_1);
            // 
            // zabytkiDataGridView
            // 
            this.zabytkiDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zabytkiDataGridView.AutoGenerateColumns = false;
            this.zabytkiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.zabytkiDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.zabytkiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zabytkiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.zabytkiDataGridView.DataSource = this.zabytkiBindingSource;
            this.zabytkiDataGridView.Location = new System.Drawing.Point(0, 28);
            this.zabytkiDataGridView.Name = "zabytkiDataGridView";
            this.zabytkiDataGridView.Size = new System.Drawing.Size(1242, 220);
            this.zabytkiDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ulica";
            this.dataGridViewTextBoxColumn2.HeaderText = "ulica";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "numer";
            this.dataGridViewTextBoxColumn3.HeaderText = "numer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 61;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "obiekt";
            this.dataGridViewTextBoxColumn4.HeaderText = "obiekt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 61;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nr_rejestru";
            this.dataGridViewTextBoxColumn5.HeaderText = "nr_rejestru";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 81;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "data_wpisu";
            this.dataGridViewTextBoxColumn6.HeaderText = "data_wpisu";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 86;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "decyzja";
            this.dataGridViewTextBoxColumn7.HeaderText = "decyzja";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 68;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "modyfikowano";
            this.dataGridViewCheckBoxColumn1.HeaderText = "modyfikowano";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 81;
            // 
            // Przegladarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 371);
            this.Controls.Add(this.zabytkiDataGridView);
            this.Controls.Add(this.zabytkiBindingNavigator);
            this.Controls.Add(this.button_szukaj);
            this.Controls.Add(this.button_archiwum);
            this.Controls.Add(this.button_pokaz);
            this.Controls.Add(this.button_wyjscie);
            this.Controls.Add(this.button_usun);
            this.Controls.Add(this.button_modyfikuj);
            this.Controls.Add(this.button_dodaj);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Przegladarka";
            this.Text = "Przeglądarka";
            this.Load += new System.EventHandler(this.Przegladarka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiBindingNavigator)).EndInit();
            this.zabytkiBindingNavigator.ResumeLayout(false);
            this.zabytkiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zabytkiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_modyfikuj;
        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.Button button_wyjscie;
        private System.Windows.Forms.Button button_pokaz;
        private System.Windows.Forms.Button button_archiwum;
        private System.Windows.Forms.Button button_szukaj;
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
        public System.Windows.Forms.DataGridView zabytkiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}