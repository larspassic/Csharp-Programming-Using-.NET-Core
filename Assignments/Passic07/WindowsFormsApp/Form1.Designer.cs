
namespace WindowsFormsApp
{
    partial class FormSodaMachine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSodaMachine));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelExactChangeRequired = new System.Windows.Forms.Label();
            this.labelTotalMoneyInserted = new System.Windows.Forms.Label();
            this.pictureBoxRegularFlavor = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrangeFlavor = new System.Windows.Forms.PictureBox();
            this.pictureBoxLemonFlavor = new System.Windows.Forms.PictureBox();
            this.buttonRegular = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonLemon = new System.Windows.Forms.Button();
            this.textBoxTotalMoneyInserted = new System.Windows.Forms.TextBox();
            this.buttonCoinReturn = new System.Windows.Forms.Button();
            this.labelInsertCoins = new System.Windows.Forms.Label();
            this.buttonInsertHalfDollar = new System.Windows.Forms.Button();
            this.buttonInsertQuarter = new System.Windows.Forms.Button();
            this.buttonInsertDime = new System.Windows.Forms.Button();
            this.buttonInsertNickel = new System.Windows.Forms.Button();
            this.richTextBoxCoinReturnTray = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVend = new System.Windows.Forms.TabPage();
            this.tabService = new System.Windows.Forms.TabPage();
            this.groupBoxChangeBoxCoinStock = new System.Windows.Forms.GroupBox();
            this.listViewChangeBoxInventory = new System.Windows.Forms.ListView();
            this.buttonEmptyChangeBox = new System.Windows.Forms.Button();
            this.groupBoxCanStock = new System.Windows.Forms.GroupBox();
            this.numericUpDownCanCount = new System.Windows.Forms.NumericUpDown();
            this.labelCanCount = new System.Windows.Forms.Label();
            this.listBoxCanStock = new System.Windows.Forms.ListBox();
            this.buttonRefillCanRack = new System.Windows.Forms.Button();
            this.labelService = new System.Windows.Forms.Label();
            this.buttonEmptyTempBox = new System.Windows.Forms.Button();
            this.labelServiceControls = new System.Windows.Forms.Label();
            this.columnHeaderCoinType = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCount = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderValue = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegularFlavor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrangeFlavor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLemonFlavor)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabVend.SuspendLayout();
            this.tabService.SuspendLayout();
            this.groupBoxChangeBoxCoinStock.SuspendLayout();
            this.groupBoxCanStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCanCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(109, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(374, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Please insert money to buy a can of soda";
            // 
            // labelExactChangeRequired
            // 
            this.labelExactChangeRequired.AutoSize = true;
            this.labelExactChangeRequired.ForeColor = System.Drawing.Color.Red;
            this.labelExactChangeRequired.Location = new System.Drawing.Point(126, 41);
            this.labelExactChangeRequired.Name = "labelExactChangeRequired";
            this.labelExactChangeRequired.Size = new System.Drawing.Size(332, 15);
            this.labelExactChangeRequired.TabIndex = 1;
            this.labelExactChangeRequired.Text = "WARNING: Exact change is required! No change will be given.";
            // 
            // labelTotalMoneyInserted
            // 
            this.labelTotalMoneyInserted.AutoSize = true;
            this.labelTotalMoneyInserted.Location = new System.Drawing.Point(639, 59);
            this.labelTotalMoneyInserted.Name = "labelTotalMoneyInserted";
            this.labelTotalMoneyInserted.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalMoneyInserted.Size = new System.Drawing.Size(123, 15);
            this.labelTotalMoneyInserted.TabIndex = 2;
            this.labelTotalMoneyInserted.Text = "Total money inserted: ";
            this.labelTotalMoneyInserted.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBoxRegularFlavor
            // 
            this.pictureBoxRegularFlavor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegularFlavor.Image")));
            this.pictureBoxRegularFlavor.Location = new System.Drawing.Point(9, 62);
            this.pictureBoxRegularFlavor.Name = "pictureBoxRegularFlavor";
            this.pictureBoxRegularFlavor.Size = new System.Drawing.Size(167, 333);
            this.pictureBoxRegularFlavor.TabIndex = 3;
            this.pictureBoxRegularFlavor.TabStop = false;
            // 
            // pictureBoxOrangeFlavor
            // 
            this.pictureBoxOrangeFlavor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrangeFlavor.Image")));
            this.pictureBoxOrangeFlavor.Location = new System.Drawing.Point(205, 62);
            this.pictureBoxOrangeFlavor.Name = "pictureBoxOrangeFlavor";
            this.pictureBoxOrangeFlavor.Size = new System.Drawing.Size(167, 333);
            this.pictureBoxOrangeFlavor.TabIndex = 4;
            this.pictureBoxOrangeFlavor.TabStop = false;
            // 
            // pictureBoxLemonFlavor
            // 
            this.pictureBoxLemonFlavor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLemonFlavor.Image")));
            this.pictureBoxLemonFlavor.Location = new System.Drawing.Point(396, 62);
            this.pictureBoxLemonFlavor.Name = "pictureBoxLemonFlavor";
            this.pictureBoxLemonFlavor.Size = new System.Drawing.Size(166, 333);
            this.pictureBoxLemonFlavor.TabIndex = 5;
            this.pictureBoxLemonFlavor.TabStop = false;
            // 
            // buttonRegular
            // 
            this.buttonRegular.Location = new System.Drawing.Point(58, 401);
            this.buttonRegular.Name = "buttonRegular";
            this.buttonRegular.Size = new System.Drawing.Size(75, 23);
            this.buttonRegular.TabIndex = 6;
            this.buttonRegular.Text = "Regular";
            this.buttonRegular.UseVisualStyleBackColor = true;
            this.buttonRegular.Click += new System.EventHandler(this.buttonRegular_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.Location = new System.Drawing.Point(253, 401);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(75, 23);
            this.buttonOrange.TabIndex = 7;
            this.buttonOrange.Text = "Orange";
            this.buttonOrange.UseVisualStyleBackColor = true;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonLemon
            // 
            this.buttonLemon.Location = new System.Drawing.Point(437, 401);
            this.buttonLemon.Name = "buttonLemon";
            this.buttonLemon.Size = new System.Drawing.Size(75, 23);
            this.buttonLemon.TabIndex = 8;
            this.buttonLemon.Text = "Lemon";
            this.buttonLemon.UseVisualStyleBackColor = true;
            this.buttonLemon.Click += new System.EventHandler(this.buttonLemon_Click);
            // 
            // textBoxTotalMoneyInserted
            // 
            this.textBoxTotalMoneyInserted.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxTotalMoneyInserted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTotalMoneyInserted.Location = new System.Drawing.Point(662, 88);
            this.textBoxTotalMoneyInserted.Name = "textBoxTotalMoneyInserted";
            this.textBoxTotalMoneyInserted.ReadOnly = true;
            this.textBoxTotalMoneyInserted.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotalMoneyInserted.TabIndex = 9;
            // 
            // buttonCoinReturn
            // 
            this.buttonCoinReturn.Location = new System.Drawing.Point(679, 304);
            this.buttonCoinReturn.Name = "buttonCoinReturn";
            this.buttonCoinReturn.Size = new System.Drawing.Size(86, 23);
            this.buttonCoinReturn.TabIndex = 10;
            this.buttonCoinReturn.Text = "Coin Return";
            this.buttonCoinReturn.UseVisualStyleBackColor = true;
            this.buttonCoinReturn.Click += new System.EventHandler(this.buttonCoinReturn_Click);
            // 
            // labelInsertCoins
            // 
            this.labelInsertCoins.AutoSize = true;
            this.labelInsertCoins.Location = new System.Drawing.Point(690, 139);
            this.labelInsertCoins.Name = "labelInsertCoins";
            this.labelInsertCoins.Size = new System.Drawing.Size(72, 15);
            this.labelInsertCoins.TabIndex = 11;
            this.labelInsertCoins.Text = "Insert Coins:";
            // 
            // buttonInsertHalfDollar
            // 
            this.buttonInsertHalfDollar.Location = new System.Drawing.Point(690, 157);
            this.buttonInsertHalfDollar.Name = "buttonInsertHalfDollar";
            this.buttonInsertHalfDollar.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertHalfDollar.TabIndex = 12;
            this.buttonInsertHalfDollar.Text = "Half Dollar";
            this.buttonInsertHalfDollar.UseVisualStyleBackColor = true;
            this.buttonInsertHalfDollar.Click += new System.EventHandler(this.buttonInsertHalfDollar_Click);
            // 
            // buttonInsertQuarter
            // 
            this.buttonInsertQuarter.Location = new System.Drawing.Point(690, 187);
            this.buttonInsertQuarter.Name = "buttonInsertQuarter";
            this.buttonInsertQuarter.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertQuarter.TabIndex = 13;
            this.buttonInsertQuarter.Text = "Quarter";
            this.buttonInsertQuarter.UseVisualStyleBackColor = true;
            this.buttonInsertQuarter.Click += new System.EventHandler(this.buttonInsertQuarter_Click);
            // 
            // buttonInsertDime
            // 
            this.buttonInsertDime.Location = new System.Drawing.Point(690, 217);
            this.buttonInsertDime.Name = "buttonInsertDime";
            this.buttonInsertDime.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertDime.TabIndex = 14;
            this.buttonInsertDime.Text = "Dime";
            this.buttonInsertDime.UseVisualStyleBackColor = true;
            this.buttonInsertDime.Click += new System.EventHandler(this.buttonInsertDime_Click);
            // 
            // buttonInsertNickel
            // 
            this.buttonInsertNickel.Location = new System.Drawing.Point(690, 247);
            this.buttonInsertNickel.Name = "buttonInsertNickel";
            this.buttonInsertNickel.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertNickel.TabIndex = 15;
            this.buttonInsertNickel.Text = "Nickel";
            this.buttonInsertNickel.UseVisualStyleBackColor = true;
            this.buttonInsertNickel.Click += new System.EventHandler(this.buttonInsertNickel_Click);
            // 
            // richTextBoxCoinReturnTray
            // 
            this.richTextBoxCoinReturnTray.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxCoinReturnTray.Location = new System.Drawing.Point(572, 333);
            this.richTextBoxCoinReturnTray.Name = "richTextBoxCoinReturnTray";
            this.richTextBoxCoinReturnTray.Size = new System.Drawing.Size(193, 62);
            this.richTextBoxCoinReturnTray.TabIndex = 16;
            this.richTextBoxCoinReturnTray.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVend);
            this.tabControl1.Controls.Add(this.tabService);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 457);
            this.tabControl1.TabIndex = 17;
            // 
            // tabVend
            // 
            this.tabVend.Controls.Add(this.labelTitle);
            this.tabVend.Controls.Add(this.richTextBoxCoinReturnTray);
            this.tabVend.Controls.Add(this.labelExactChangeRequired);
            this.tabVend.Controls.Add(this.buttonInsertNickel);
            this.tabVend.Controls.Add(this.pictureBoxRegularFlavor);
            this.tabVend.Controls.Add(this.buttonInsertDime);
            this.tabVend.Controls.Add(this.pictureBoxOrangeFlavor);
            this.tabVend.Controls.Add(this.buttonInsertQuarter);
            this.tabVend.Controls.Add(this.pictureBoxLemonFlavor);
            this.tabVend.Controls.Add(this.buttonInsertHalfDollar);
            this.tabVend.Controls.Add(this.labelInsertCoins);
            this.tabVend.Controls.Add(this.buttonRegular);
            this.tabVend.Controls.Add(this.buttonCoinReturn);
            this.tabVend.Controls.Add(this.buttonOrange);
            this.tabVend.Controls.Add(this.buttonLemon);
            this.tabVend.Controls.Add(this.labelTotalMoneyInserted);
            this.tabVend.Controls.Add(this.textBoxTotalMoneyInserted);
            this.tabVend.Location = new System.Drawing.Point(4, 24);
            this.tabVend.Name = "tabVend";
            this.tabVend.Padding = new System.Windows.Forms.Padding(3);
            this.tabVend.Size = new System.Drawing.Size(768, 429);
            this.tabVend.TabIndex = 0;
            this.tabVend.Text = "Vend";
            this.tabVend.UseVisualStyleBackColor = true;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.groupBoxChangeBoxCoinStock);
            this.tabService.Controls.Add(this.groupBoxCanStock);
            this.tabService.Controls.Add(this.labelService);
            this.tabService.Controls.Add(this.buttonEmptyTempBox);
            this.tabService.Controls.Add(this.labelServiceControls);
            this.tabService.Location = new System.Drawing.Point(4, 24);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(768, 429);
            this.tabService.TabIndex = 1;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            this.tabService.Enter += new System.EventHandler(this.tabService_Enter);
            // 
            // groupBoxChangeBoxCoinStock
            // 
            this.groupBoxChangeBoxCoinStock.Controls.Add(this.listViewChangeBoxInventory);
            this.groupBoxChangeBoxCoinStock.Controls.Add(this.buttonEmptyChangeBox);
            this.groupBoxChangeBoxCoinStock.Location = new System.Drawing.Point(244, 50);
            this.groupBoxChangeBoxCoinStock.Name = "groupBoxChangeBoxCoinStock";
            this.groupBoxChangeBoxCoinStock.Size = new System.Drawing.Size(200, 300);
            this.groupBoxChangeBoxCoinStock.TabIndex = 10;
            this.groupBoxChangeBoxCoinStock.TabStop = false;
            this.groupBoxChangeBoxCoinStock.Text = "Change Box Coin Stock";
            // 
            // listViewChangeBoxInventory
            // 
            this.listViewChangeBoxInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCoinType,
            this.columnHeaderCount,
            this.columnHeaderValue});
            this.listViewChangeBoxInventory.HideSelection = false;
            this.listViewChangeBoxInventory.Location = new System.Drawing.Point(6, 22);
            this.listViewChangeBoxInventory.Name = "listViewChangeBoxInventory";
            this.listViewChangeBoxInventory.Size = new System.Drawing.Size(188, 154);
            this.listViewChangeBoxInventory.TabIndex = 6;
            this.listViewChangeBoxInventory.UseCompatibleStateImageBehavior = false;
            this.listViewChangeBoxInventory.View = System.Windows.Forms.View.Details;
            // 
            // buttonEmptyChangeBox
            // 
            this.buttonEmptyChangeBox.Location = new System.Drawing.Point(60, 271);
            this.buttonEmptyChangeBox.Name = "buttonEmptyChangeBox";
            this.buttonEmptyChangeBox.Size = new System.Drawing.Size(134, 23);
            this.buttonEmptyChangeBox.TabIndex = 2;
            this.buttonEmptyChangeBox.Text = "Empty Change Box";
            this.buttonEmptyChangeBox.UseVisualStyleBackColor = true;
            // 
            // groupBoxCanStock
            // 
            this.groupBoxCanStock.Controls.Add(this.numericUpDownCanCount);
            this.groupBoxCanStock.Controls.Add(this.labelCanCount);
            this.groupBoxCanStock.Controls.Add(this.listBoxCanStock);
            this.groupBoxCanStock.Controls.Add(this.buttonRefillCanRack);
            this.groupBoxCanStock.Location = new System.Drawing.Point(14, 50);
            this.groupBoxCanStock.Name = "groupBoxCanStock";
            this.groupBoxCanStock.Size = new System.Drawing.Size(200, 300);
            this.groupBoxCanStock.TabIndex = 9;
            this.groupBoxCanStock.TabStop = false;
            this.groupBoxCanStock.Text = "Can Stock";
            // 
            // numericUpDownCanCount
            // 
            this.numericUpDownCanCount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownCanCount.Location = new System.Drawing.Point(126, 243);
            this.numericUpDownCanCount.Name = "numericUpDownCanCount";
            this.numericUpDownCanCount.ReadOnly = true;
            this.numericUpDownCanCount.Size = new System.Drawing.Size(68, 23);
            this.numericUpDownCanCount.TabIndex = 7;
            // 
            // labelCanCount
            // 
            this.labelCanCount.AutoSize = true;
            this.labelCanCount.Location = new System.Drawing.Point(53, 245);
            this.labelCanCount.Name = "labelCanCount";
            this.labelCanCount.Size = new System.Drawing.Size(65, 15);
            this.labelCanCount.TabIndex = 6;
            this.labelCanCount.Text = "Can count:";
            // 
            // listBoxCanStock
            // 
            this.listBoxCanStock.FormattingEnabled = true;
            this.listBoxCanStock.ItemHeight = 15;
            this.listBoxCanStock.Location = new System.Drawing.Point(6, 22);
            this.listBoxCanStock.Name = "listBoxCanStock";
            this.listBoxCanStock.Size = new System.Drawing.Size(188, 214);
            this.listBoxCanStock.TabIndex = 5;
            // 
            // buttonRefillCanRack
            // 
            this.buttonRefillCanRack.Location = new System.Drawing.Point(60, 271);
            this.buttonRefillCanRack.Name = "buttonRefillCanRack";
            this.buttonRefillCanRack.Size = new System.Drawing.Size(134, 23);
            this.buttonRefillCanRack.TabIndex = 0;
            this.buttonRefillCanRack.Text = "Refill Can Rack";
            this.buttonRefillCanRack.UseVisualStyleBackColor = true;
            this.buttonRefillCanRack.Click += new System.EventHandler(this.buttonRefillCanRack_Click);
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelService.Location = new System.Drawing.Point(332, 9);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(76, 25);
            this.labelService.TabIndex = 4;
            this.labelService.Text = "Service";
            // 
            // buttonEmptyTempBox
            // 
            this.buttonEmptyTempBox.Location = new System.Drawing.Point(614, 136);
            this.buttonEmptyTempBox.Name = "buttonEmptyTempBox";
            this.buttonEmptyTempBox.Size = new System.Drawing.Size(134, 23);
            this.buttonEmptyTempBox.TabIndex = 3;
            this.buttonEmptyTempBox.Text = "Empty Temp Box";
            this.buttonEmptyTempBox.UseVisualStyleBackColor = true;
            this.buttonEmptyTempBox.Click += new System.EventHandler(this.buttonEmptyTempBox_Click);
            // 
            // labelServiceControls
            // 
            this.labelServiceControls.AutoSize = true;
            this.labelServiceControls.Location = new System.Drawing.Point(636, 50);
            this.labelServiceControls.Name = "labelServiceControls";
            this.labelServiceControls.Size = new System.Drawing.Size(92, 15);
            this.labelServiceControls.TabIndex = 1;
            this.labelServiceControls.Text = "Service Controls";
            // 
            // columnHeaderCoinType
            // 
            this.columnHeaderCoinType.Text = "Coin type";
            // 
            // columnHeaderCount
            // 
            this.columnHeaderCount.Text = "Count";
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            // 
            // FormSodaMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSodaMachine";
            this.Text = "My Windows Forms App Soda Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegularFlavor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrangeFlavor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLemonFlavor)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabVend.ResumeLayout(false);
            this.tabVend.PerformLayout();
            this.tabService.ResumeLayout(false);
            this.tabService.PerformLayout();
            this.groupBoxChangeBoxCoinStock.ResumeLayout(false);
            this.groupBoxCanStock.ResumeLayout(false);
            this.groupBoxCanStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCanCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelExactChangeRequired;
        private System.Windows.Forms.Label labelTotalMoneyInserted;
        private System.Windows.Forms.PictureBox pictureBoxRegularFlavor;
        private System.Windows.Forms.PictureBox pictureBoxOrangeFlavor;
        private System.Windows.Forms.PictureBox pictureBoxLemonFlavor;
        private System.Windows.Forms.Button buttonRegular;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonLemon;
        private System.Windows.Forms.TextBox textBoxTotalMoneyInserted;
        private System.Windows.Forms.Button buttonCoinReturn;
        private System.Windows.Forms.Label labelInsertCoins;
        private System.Windows.Forms.Button buttonInsertHalfDollar;
        private System.Windows.Forms.Button buttonInsertQuarter;
        private System.Windows.Forms.Button buttonInsertDime;
        private System.Windows.Forms.Button buttonInsertNickel;
        private System.Windows.Forms.RichTextBox richTextBoxCoinReturnTray;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVend;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.Button buttonRefillCanRack;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Button buttonEmptyTempBox;
        private System.Windows.Forms.Button buttonEmptyChangeBox;
        private System.Windows.Forms.Label labelServiceControls;
        private System.Windows.Forms.ListView listViewChangeBoxInventory;
        private System.Windows.Forms.ListBox listBoxCanStock;
        private System.Windows.Forms.GroupBox groupBoxChangeBoxCoinStock;
        private System.Windows.Forms.GroupBox groupBoxCanStock;
        private System.Windows.Forms.NumericUpDown numericUpDownCanCount;
        private System.Windows.Forms.Label labelCanCount;
        private System.Windows.Forms.ColumnHeader columnHeaderCoinType;
        private System.Windows.Forms.ColumnHeader columnHeaderCount;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
    }
}

