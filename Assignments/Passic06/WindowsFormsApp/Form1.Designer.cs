
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegularFlavor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrangeFlavor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLemonFlavor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(315, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(222, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Please insert money to buy a can of soda";
            // 
            // labelExactChangeRequired
            // 
            this.labelExactChangeRequired.AutoSize = true;
            this.labelExactChangeRequired.ForeColor = System.Drawing.Color.Red;
            this.labelExactChangeRequired.Location = new System.Drawing.Point(653, 67);
            this.labelExactChangeRequired.Name = "labelExactChangeRequired";
            this.labelExactChangeRequired.Size = new System.Drawing.Size(138, 15);
            this.labelExactChangeRequired.TabIndex = 1;
            this.labelExactChangeRequired.Text = "Exact change is required!";
            // 
            // labelTotalMoneyInserted
            // 
            this.labelTotalMoneyInserted.AutoSize = true;
            this.labelTotalMoneyInserted.Location = new System.Drawing.Point(665, 23);
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
            this.pictureBoxRegularFlavor.Location = new System.Drawing.Point(43, 77);
            this.pictureBoxRegularFlavor.Name = "pictureBoxRegularFlavor";
            this.pictureBoxRegularFlavor.Size = new System.Drawing.Size(167, 333);
            this.pictureBoxRegularFlavor.TabIndex = 3;
            this.pictureBoxRegularFlavor.TabStop = false;
            // 
            // pictureBoxOrangeFlavor
            // 
            this.pictureBoxOrangeFlavor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrangeFlavor.Image")));
            this.pictureBoxOrangeFlavor.Location = new System.Drawing.Point(216, 77);
            this.pictureBoxOrangeFlavor.Name = "pictureBoxOrangeFlavor";
            this.pictureBoxOrangeFlavor.Size = new System.Drawing.Size(167, 333);
            this.pictureBoxOrangeFlavor.TabIndex = 4;
            this.pictureBoxOrangeFlavor.TabStop = false;
            // 
            // pictureBoxLemonFlavor
            // 
            this.pictureBoxLemonFlavor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLemonFlavor.Image")));
            this.pictureBoxLemonFlavor.Location = new System.Drawing.Point(389, 77);
            this.pictureBoxLemonFlavor.Name = "pictureBoxLemonFlavor";
            this.pictureBoxLemonFlavor.Size = new System.Drawing.Size(166, 333);
            this.pictureBoxLemonFlavor.TabIndex = 5;
            this.pictureBoxLemonFlavor.TabStop = false;
            // 
            // buttonRegular
            // 
            this.buttonRegular.Location = new System.Drawing.Point(95, 416);
            this.buttonRegular.Name = "buttonRegular";
            this.buttonRegular.Size = new System.Drawing.Size(75, 23);
            this.buttonRegular.TabIndex = 6;
            this.buttonRegular.Text = "Regular";
            this.buttonRegular.UseVisualStyleBackColor = true;
            // 
            // buttonOrange
            // 
            this.buttonOrange.Location = new System.Drawing.Point(264, 416);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(75, 23);
            this.buttonOrange.TabIndex = 7;
            this.buttonOrange.Text = "Orange";
            this.buttonOrange.UseVisualStyleBackColor = true;
            // 
            // buttonLemon
            // 
            this.buttonLemon.Location = new System.Drawing.Point(441, 416);
            this.buttonLemon.Name = "buttonLemon";
            this.buttonLemon.Size = new System.Drawing.Size(75, 23);
            this.buttonLemon.TabIndex = 8;
            this.buttonLemon.Text = "Lemon";
            this.buttonLemon.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalMoneyInserted
            // 
            this.textBoxTotalMoneyInserted.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTotalMoneyInserted.Location = new System.Drawing.Point(673, 41);
            this.textBoxTotalMoneyInserted.Name = "textBoxTotalMoneyInserted";
            this.textBoxTotalMoneyInserted.ReadOnly = true;
            this.textBoxTotalMoneyInserted.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotalMoneyInserted.TabIndex = 9;
            // 
            // buttonCoinReturn
            // 
            this.buttonCoinReturn.Location = new System.Drawing.Point(709, 86);
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
            this.labelInsertCoins.Location = new System.Drawing.Point(673, 217);
            this.labelInsertCoins.Name = "labelInsertCoins";
            this.labelInsertCoins.Size = new System.Drawing.Size(72, 15);
            this.labelInsertCoins.TabIndex = 11;
            this.labelInsertCoins.Text = "Insert Coins:";
            // 
            // buttonInsertHalfDollar
            // 
            this.buttonInsertHalfDollar.Location = new System.Drawing.Point(673, 235);
            this.buttonInsertHalfDollar.Name = "buttonInsertHalfDollar";
            this.buttonInsertHalfDollar.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertHalfDollar.TabIndex = 12;
            this.buttonInsertHalfDollar.Text = "Half Dollar";
            this.buttonInsertHalfDollar.UseVisualStyleBackColor = true;
            this.buttonInsertHalfDollar.Click += new System.EventHandler(this.buttonInsertHalfDollar_Click);
            // 
            // buttonInsertQuarter
            // 
            this.buttonInsertQuarter.Location = new System.Drawing.Point(673, 265);
            this.buttonInsertQuarter.Name = "buttonInsertQuarter";
            this.buttonInsertQuarter.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertQuarter.TabIndex = 13;
            this.buttonInsertQuarter.Text = "Quarter";
            this.buttonInsertQuarter.UseVisualStyleBackColor = true;
            this.buttonInsertQuarter.Click += new System.EventHandler(this.buttonInsertQuarter_Click);
            // 
            // buttonInsertDime
            // 
            this.buttonInsertDime.Location = new System.Drawing.Point(673, 295);
            this.buttonInsertDime.Name = "buttonInsertDime";
            this.buttonInsertDime.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertDime.TabIndex = 14;
            this.buttonInsertDime.Text = "Dime";
            this.buttonInsertDime.UseVisualStyleBackColor = true;
            this.buttonInsertDime.Click += new System.EventHandler(this.buttonInsertDime_Click);
            // 
            // buttonInsertNickel
            // 
            this.buttonInsertNickel.Location = new System.Drawing.Point(673, 325);
            this.buttonInsertNickel.Name = "buttonInsertNickel";
            this.buttonInsertNickel.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertNickel.TabIndex = 15;
            this.buttonInsertNickel.Text = "Nickel";
            this.buttonInsertNickel.UseVisualStyleBackColor = true;
            this.buttonInsertNickel.Click += new System.EventHandler(this.buttonInsertNickel_Click);
            // 
            // FormSodaMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInsertNickel);
            this.Controls.Add(this.buttonInsertDime);
            this.Controls.Add(this.buttonInsertQuarter);
            this.Controls.Add(this.buttonInsertHalfDollar);
            this.Controls.Add(this.labelInsertCoins);
            this.Controls.Add(this.buttonCoinReturn);
            this.Controls.Add(this.textBoxTotalMoneyInserted);
            this.Controls.Add(this.buttonLemon);
            this.Controls.Add(this.buttonOrange);
            this.Controls.Add(this.buttonRegular);
            this.Controls.Add(this.pictureBoxLemonFlavor);
            this.Controls.Add(this.pictureBoxOrangeFlavor);
            this.Controls.Add(this.pictureBoxRegularFlavor);
            this.Controls.Add(this.labelTotalMoneyInserted);
            this.Controls.Add(this.labelExactChangeRequired);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormSodaMachine";
            this.Text = "My Windows Forms App Soda Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegularFlavor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrangeFlavor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLemonFlavor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

