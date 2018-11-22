namespace labatehpr
{
    partial class FormHangar
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
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.buttonAircraft = new System.Windows.Forms.Button();
            this.buttonFighterAircraft = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.ButtonTake = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxHangar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxHangar.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(628, 415);
            this.pictureBoxHangar.TabIndex = 0;
            this.pictureBoxHangar.TabStop = false;
            // 
            // buttonAircraft
            // 
            this.buttonAircraft.Location = new System.Drawing.Point(650, 12);
            this.buttonAircraft.Name = "buttonAircraft";
            this.buttonAircraft.Size = new System.Drawing.Size(144, 43);
            this.buttonAircraft.TabIndex = 1;
            this.buttonAircraft.Text = "Поставить самолёт";
            this.buttonAircraft.UseVisualStyleBackColor = true;
            this.buttonAircraft.Click += new System.EventHandler(this.buttonAircraft_Click);
            // 
            // buttonFighterAircraft
            // 
            this.buttonFighterAircraft.Location = new System.Drawing.Point(653, 61);
            this.buttonFighterAircraft.Name = "buttonFighterAircraft";
            this.buttonFighterAircraft.Size = new System.Drawing.Size(141, 43);
            this.buttonFighterAircraft.TabIndex = 2;
            this.buttonFighterAircraft.Text = "Поставить истребитель";
            this.buttonFighterAircraft.UseVisualStyleBackColor = true;
            this.buttonFighterAircraft.Click += new System.EventHandler(this.buttonFighterAircraft_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTake);
            this.groupBox1.Controls.Add(this.ButtonTake);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(646, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать самолёт";
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(9, 80);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(136, 115);
            this.pictureBoxTake.TabIndex = 3;
            this.pictureBoxTake.TabStop = false;
            // 
            // ButtonTake
            // 
            this.ButtonTake.Location = new System.Drawing.Point(21, 57);
            this.ButtonTake.Name = "ButtonTake";
            this.ButtonTake.Size = new System.Drawing.Size(89, 23);
            this.ButtonTake.TabIndex = 2;
            this.ButtonTake.Text = "Забрать";
            this.ButtonTake.UseVisualStyleBackColor = true;
            this.ButtonTake.Click += new System.EventHandler(this.ButtonTake_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(70, 31);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(652, 116);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(138, 95);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFighterAircraft);
            this.Controls.Add(this.buttonAircraft);
            this.Controls.Add(this.pictureBoxHangar);
            this.Name = "FormHangar";
            this.Text = "Ангар";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangar;
        private System.Windows.Forms.Button buttonAircraft;
        private System.Windows.Forms.Button buttonFighterAircraft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}