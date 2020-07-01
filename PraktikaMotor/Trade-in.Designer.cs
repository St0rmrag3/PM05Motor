namespace PraktikaMotor
{
    partial class Trade_in
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxPredvPrice = new System.Windows.Forms.TextBox();
            this.textBoxSerNomer = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.listViewTrade = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(885, 350);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 46);
            this.buttonAdd.TabIndex = 64;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(1005, 350);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(114, 46);
            this.buttonEdit.TabIndex = 63;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(1125, 350);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(114, 46);
            this.buttonDel.TabIndex = 62;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxPredvPrice
            // 
            this.textBoxPredvPrice.Location = new System.Drawing.Point(30, 298);
            this.textBoxPredvPrice.Name = "textBoxPredvPrice";
            this.textBoxPredvPrice.Size = new System.Drawing.Size(205, 20);
            this.textBoxPredvPrice.TabIndex = 61;
            // 
            // textBoxSerNomer
            // 
            this.textBoxSerNomer.Location = new System.Drawing.Point(30, 246);
            this.textBoxSerNomer.Name = "textBoxSerNomer";
            this.textBoxSerNomer.Size = new System.Drawing.Size(205, 20);
            this.textBoxSerNomer.TabIndex = 60;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(30, 134);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(205, 20);
            this.textBoxModel.TabIndex = 58;
            // 
            // textBoxMark
            // 
            this.textBoxMark.Location = new System.Drawing.Point(30, 79);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(205, 20);
            this.textBoxMark.TabIndex = 57;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(27, 282);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(125, 13);
            this.labelEmail.TabIndex = 56;
            this.labelEmail.Text = "Предварительная цена";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(27, 230);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(93, 13);
            this.labelPhone.TabIndex = 55;
            this.labelPhone.Text = "Серийный номер";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(27, 118);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(49, 13);
            this.labelMiddleName.TabIndex = 53;
            this.labelMiddleName.Text = "Модель ";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(27, 63);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(40, 13);
            this.labelFirstName.TabIndex = 52;
            this.labelFirstName.Text = "Марка";
            // 
            // listViewTrade
            // 
            this.listViewTrade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listViewTrade.FullRowSelect = true;
            this.listViewTrade.GridLines = true;
            this.listViewTrade.HideSelection = false;
            this.listViewTrade.Location = new System.Drawing.Point(321, 39);
            this.listViewTrade.MultiSelect = false;
            this.listViewTrade.Name = "listViewTrade";
            this.listViewTrade.Size = new System.Drawing.Size(918, 295);
            this.listViewTrade.TabIndex = 51;
            this.listViewTrade.UseCompatibleStateImageBehavior = false;
            this.listViewTrade.View = System.Windows.Forms.View.Details;
            this.listViewTrade.SelectedIndexChanged += new System.EventHandler(this.listViewClient_SelectedIndexChanged);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "ID";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "ФИО клиента";
            this.columnHeader14.Width = 190;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Марка";
            this.columnHeader15.Width = 118;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Модель";
            this.columnHeader16.Width = 114;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Год";
            this.columnHeader17.Width = 83;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Серийный номер";
            this.columnHeader18.Width = 132;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Предварительная цена";
            this.columnHeader19.Width = 145;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(30, 39);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(205, 21);
            this.comboBoxClient.TabIndex = 66;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(27, 9);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(51, 13);
            this.labelClient.TabIndex = 65;
            this.labelClient.Text = "Клиенты";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(30, 184);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(205, 20);
            this.textBoxYear.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Год";
            // 
            // Trade_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 417);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.textBoxPredvPrice);
            this.Controls.Add(this.textBoxSerNomer);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.listViewTrade);
            this.Name = "Trade_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Трейд-ин";
            this.Load += new System.EventHandler(this.Trade_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxPredvPrice;
        private System.Windows.Forms.TextBox textBoxSerNomer;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.ListView listViewTrade;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label1;
    }
}