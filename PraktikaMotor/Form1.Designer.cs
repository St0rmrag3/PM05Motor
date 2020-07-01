namespace PraktikaMotor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonTrade = new System.Windows.Forms.Button();
            this.buttonZakaz = new System.Windows.Forms.Button();
            this.buttonPokup = new System.Windows.Forms.Button();
            this.buttonNomer = new System.Windows.Forms.Button();
            this.buttonCar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню";
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(12, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(35, 13);
            this.labelHello.TabIndex = 1;
            this.labelHello.Text = "label2";
            // 
            // buttonClients
            // 
            this.buttonClients.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClients.Location = new System.Drawing.Point(277, 223);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonClients.Size = new System.Drawing.Size(265, 48);
            this.buttonClients.TabIndex = 2;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonTrade
            // 
            this.buttonTrade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTrade.Location = new System.Drawing.Point(277, 150);
            this.buttonTrade.Name = "buttonTrade";
            this.buttonTrade.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTrade.Size = new System.Drawing.Size(265, 48);
            this.buttonTrade.TabIndex = 3;
            this.buttonTrade.Text = "Трейд-ин";
            this.buttonTrade.UseVisualStyleBackColor = true;
            this.buttonTrade.Click += new System.EventHandler(this.buttonTrade_Click);
            // 
            // buttonZakaz
            // 
            this.buttonZakaz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZakaz.Location = new System.Drawing.Point(277, 87);
            this.buttonZakaz.Name = "buttonZakaz";
            this.buttonZakaz.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonZakaz.Size = new System.Drawing.Size(265, 48);
            this.buttonZakaz.TabIndex = 4;
            this.buttonZakaz.Text = "Заказы";
            this.buttonZakaz.UseVisualStyleBackColor = true;
            this.buttonZakaz.Click += new System.EventHandler(this.buttonZakaz_Click);
            // 
            // buttonPokup
            // 
            this.buttonPokup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPokup.Location = new System.Drawing.Point(277, 291);
            this.buttonPokup.Name = "buttonPokup";
            this.buttonPokup.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPokup.Size = new System.Drawing.Size(265, 48);
            this.buttonPokup.TabIndex = 5;
            this.buttonPokup.Text = "Покупки";
            this.buttonPokup.UseVisualStyleBackColor = true;
            this.buttonPokup.Click += new System.EventHandler(this.buttonPokup_Click);
            // 
            // buttonNomer
            // 
            this.buttonNomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNomer.Location = new System.Drawing.Point(277, 359);
            this.buttonNomer.Name = "buttonNomer";
            this.buttonNomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonNomer.Size = new System.Drawing.Size(265, 48);
            this.buttonNomer.TabIndex = 6;
            this.buttonNomer.Text = "Установка номеров";
            this.buttonNomer.UseVisualStyleBackColor = true;
            this.buttonNomer.Click += new System.EventHandler(this.buttonNomer_Click);
            // 
            // buttonCar
            // 
            this.buttonCar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCar.Location = new System.Drawing.Point(277, 428);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCar.Size = new System.Drawing.Size(265, 48);
            this.buttonCar.TabIndex = 7;
            this.buttonCar.Text = "Машины";
            this.buttonCar.UseVisualStyleBackColor = true;
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PraktikaMotor.Properties.Resources.logo_bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(789, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCar);
            this.Controls.Add(this.buttonNomer);
            this.Controls.Add(this.buttonPokup);
            this.Controls.Add(this.buttonZakaz);
            this.Controls.Add(this.buttonTrade);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonTrade;
        private System.Windows.Forms.Button buttonZakaz;
        private System.Windows.Forms.Button buttonPokup;
        private System.Windows.Forms.Button buttonNomer;
        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

