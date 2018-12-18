namespace labatehpr
{
    partial class FormCarConfig
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
            this.pictureBoxAircraft = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFAircraft = new System.Windows.Forms.Label();
            this.labelAircraft = new System.Windows.Forms.Label();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelLime = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBrown = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBye = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelCreate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAircraft
            // 
            this.pictureBoxAircraft.Location = new System.Drawing.Point(3, 29);
            this.pictureBoxAircraft.Name = "pictureBoxAircraft";
            this.pictureBoxAircraft.Size = new System.Drawing.Size(196, 130);
            this.pictureBoxAircraft.TabIndex = 0;
            this.pictureBoxAircraft.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFAircraft);
            this.groupBox1.Controls.Add(this.labelAircraft);
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип самолёта";
            // 
            // labelFAircraft
            // 
            this.labelFAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFAircraft.Location = new System.Drawing.Point(15, 113);
            this.labelFAircraft.Name = "labelFAircraft";
            this.labelFAircraft.Size = new System.Drawing.Size(148, 66);
            this.labelFAircraft.TabIndex = 1;
            this.labelFAircraft.Text = "Истребитель";
            this.labelFAircraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFAircraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFAircraft_MouseDown);
            // 
            // labelAircraft
            // 
            this.labelAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAircraft.Location = new System.Drawing.Point(15, 30);
            this.labelAircraft.Name = "labelAircraft";
            this.labelAircraft.Size = new System.Drawing.Size(149, 66);
            this.labelAircraft.TabIndex = 0;
            this.labelAircraft.Text = "Обычный самолёт";
            this.labelAircraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAircraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAircraft_MouseDown);
            // 
            // panelCreate
            // 
            this.panelCreate.AllowDrop = true;
            this.panelCreate.Controls.Add(this.labelDopColor);
            this.panelCreate.Controls.Add(this.labelMainColor);
            this.panelCreate.Controls.Add(this.pictureBoxAircraft);
            this.panelCreate.Location = new System.Drawing.Point(206, 38);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(201, 263);
            this.panelCreate.TabIndex = 2;
            this.panelCreate.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCreate_DragDrop);
            this.panelCreate.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCreate_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(8, 215);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(178, 29);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(9, 172);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(178, 28);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelGold);
            this.groupBox2.Controls.Add(this.panelLime);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelPurple);
            this.groupBox2.Controls.Add(this.panelPink);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelBrown);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Location = new System.Drawing.Point(466, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 346);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Gold;
            this.panelGold.Location = new System.Drawing.Point(111, 241);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(70, 46);
            this.panelGold.TabIndex = 7;
            this.panelGold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelLime
            // 
            this.panelLime.BackColor = System.Drawing.Color.Lime;
            this.panelLime.Location = new System.Drawing.Point(20, 241);
            this.panelLime.Name = "panelLime";
            this.panelLime.Size = new System.Drawing.Size(69, 46);
            this.panelLime.TabIndex = 6;
            this.panelLime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.MediumBlue;
            this.panelBlue.Location = new System.Drawing.Point(110, 171);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(72, 48);
            this.panelBlue.TabIndex = 5;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(20, 171);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(69, 49);
            this.panelPurple.TabIndex = 4;
            this.panelPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Pink;
            this.panelPink.Location = new System.Drawing.Point(110, 100);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(72, 44);
            this.panelPink.TabIndex = 3;
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(20, 100);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(69, 45);
            this.panelGreen.TabIndex = 2;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBrown
            // 
            this.panelBrown.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelBrown.Location = new System.Drawing.Point(110, 30);
            this.panelBrown.Name = "panelBrown";
            this.panelBrown.Size = new System.Drawing.Size(73, 46);
            this.panelBrown.TabIndex = 1;
            this.panelBrown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(20, 30);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(70, 46);
            this.panelRed.TabIndex = 0;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(14, 227);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 26);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBye
            // 
            this.buttonBye.Location = new System.Drawing.Point(92, 266);
            this.buttonBye.Name = "buttonBye";
            this.buttonBye.Size = new System.Drawing.Size(84, 25);
            this.buttonBye.TabIndex = 5;
            this.buttonBye.Text = "Отмена";
            this.buttonBye.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.buttonBye);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelCreate);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCarConfig";
            this.Text = "FormCarConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelCreate.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAircraft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFAircraft;
        private System.Windows.Forms.Label labelAircraft;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelLime;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBrown;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBye;
    }
}