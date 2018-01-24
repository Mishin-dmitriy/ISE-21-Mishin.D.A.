namespace laba2
{
    partial class additionalForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Shiplabel = new System.Windows.Forms.Label();
            this.Boatlabel = new System.Windows.Forms.Label();
            this.SetBoatpanel = new System.Windows.Forms.Panel();
            this.addColLabel = new System.Windows.Forms.Label();
            this.mainColLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.whiteCol = new System.Windows.Forms.Panel();
            this.greenCol = new System.Windows.Forms.Panel();
            this.greyCol = new System.Windows.Forms.Panel();
            this.pinkCol = new System.Windows.Forms.Panel();
            this.redCol = new System.Windows.Forms.Panel();
            this.brownCol = new System.Windows.Forms.Panel();
            this.purpleCol = new System.Windows.Forms.Panel();
            this.blueCol = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SetBoatpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Shiplabel);
            this.groupBox1.Controls.Add(this.Boatlabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип лодки";
            // 
            // Shiplabel
            // 
            this.Shiplabel.AutoSize = true;
            this.Shiplabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Shiplabel.Location = new System.Drawing.Point(9, 54);
            this.Shiplabel.Name = "Shiplabel";
            this.Shiplabel.Size = new System.Drawing.Size(76, 15);
            this.Shiplabel.TabIndex = 1;
            this.Shiplabel.Text = "UltaMotorShip";
            this.Shiplabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Shiplabel_MouseDown);
            // 
            // Boatlabel
            // 
            this.Boatlabel.AutoSize = true;
            this.Boatlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Boatlabel.Location = new System.Drawing.Point(30, 27);
            this.Boatlabel.Name = "Boatlabel";
            this.Boatlabel.Size = new System.Drawing.Size(30, 15);
            this.Boatlabel.TabIndex = 0;
            this.Boatlabel.Text = "Ship";
            this.Boatlabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Boatlabel_MouseDown);
            // 
            // SetBoatpanel
            // 
            this.SetBoatpanel.AllowDrop = true;
            this.SetBoatpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetBoatpanel.Controls.Add(this.addColLabel);
            this.SetBoatpanel.Controls.Add(this.mainColLabel);
            this.SetBoatpanel.Controls.Add(this.pictureBox1);
            this.SetBoatpanel.Location = new System.Drawing.Point(126, 22);
            this.SetBoatpanel.Name = "SetBoatpanel";
            this.SetBoatpanel.Size = new System.Drawing.Size(139, 228);
            this.SetBoatpanel.TabIndex = 1;
            this.SetBoatpanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.SetBoatpanel_DragDrop);
            this.SetBoatpanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.SetBoatpanel_DragEnter);
            // 
            // addColLabel
            // 
            this.addColLabel.AllowDrop = true;
            this.addColLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addColLabel.Location = new System.Drawing.Point(15, 171);
            this.addColLabel.Name = "addColLabel";
            this.addColLabel.Size = new System.Drawing.Size(106, 29);
            this.addColLabel.TabIndex = 2;
            this.addColLabel.Text = "Дополнительный цвет";
            this.addColLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.addColLabel_DragDrop);
            this.addColLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.addColLabel_DragEnter);
            // 
            // mainColLabel
            // 
            this.mainColLabel.AllowDrop = true;
            this.mainColLabel.AutoSize = true;
            this.mainColLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainColLabel.Location = new System.Drawing.Point(26, 136);
            this.mainColLabel.Name = "mainColLabel";
            this.mainColLabel.Size = new System.Drawing.Size(85, 15);
            this.mainColLabel.TabIndex = 1;
            this.mainColLabel.Text = "Основной цвет";
            this.mainColLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainColLabel_DragDrop);
            this.mainColLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainColLabel_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.whiteCol);
            this.groupBox2.Controls.Add(this.greenCol);
            this.groupBox2.Controls.Add(this.greyCol);
            this.groupBox2.Controls.Add(this.pinkCol);
            this.groupBox2.Controls.Add(this.redCol);
            this.groupBox2.Controls.Add(this.brownCol);
            this.groupBox2.Controls.Add(this.purpleCol);
            this.groupBox2.Controls.Add(this.blueCol);
            this.groupBox2.Location = new System.Drawing.Point(271, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "цвета";
            // 
            // whiteCol
            // 
            this.whiteCol.AllowDrop = true;
            this.whiteCol.BackColor = System.Drawing.Color.White;
            this.whiteCol.Location = new System.Drawing.Point(6, 150);
            this.whiteCol.Name = "whiteCol";
            this.whiteCol.Size = new System.Drawing.Size(36, 30);
            this.whiteCol.TabIndex = 4;
            // 
            // greenCol
            // 
            this.greenCol.AllowDrop = true;
            this.greenCol.BackColor = System.Drawing.Color.GreenYellow;
            this.greenCol.Location = new System.Drawing.Point(51, 111);
            this.greenCol.Name = "greenCol";
            this.greenCol.Size = new System.Drawing.Size(36, 30);
            this.greenCol.TabIndex = 3;
            // 
            // greyCol
            // 
            this.greyCol.AllowDrop = true;
            this.greyCol.BackColor = System.Drawing.Color.Silver;
            this.greyCol.Location = new System.Drawing.Point(6, 108);
            this.greyCol.Name = "greyCol";
            this.greyCol.Size = new System.Drawing.Size(36, 30);
            this.greyCol.TabIndex = 6;
            // 
            // pinkCol
            // 
            this.pinkCol.AllowDrop = true;
            this.pinkCol.BackColor = System.Drawing.Color.Pink;
            this.pinkCol.Location = new System.Drawing.Point(6, 27);
            this.pinkCol.Name = "pinkCol";
            this.pinkCol.Size = new System.Drawing.Size(36, 30);
            this.pinkCol.TabIndex = 7;
            // 
            // redCol
            // 
            this.redCol.AllowDrop = true;
            this.redCol.BackColor = System.Drawing.Color.Red;
            this.redCol.Location = new System.Drawing.Point(48, 27);
            this.redCol.Name = "redCol";
            this.redCol.Size = new System.Drawing.Size(36, 30);
            this.redCol.TabIndex = 1;
            // 
            // brownCol
            // 
            this.brownCol.AllowDrop = true;
            this.brownCol.BackColor = System.Drawing.Color.Black;
            this.brownCol.Location = new System.Drawing.Point(6, 70);
            this.brownCol.Name = "brownCol";
            this.brownCol.Size = new System.Drawing.Size(36, 30);
            this.brownCol.TabIndex = 5;
            // 
            // purpleCol
            // 
            this.purpleCol.AllowDrop = true;
            this.purpleCol.BackColor = System.Drawing.Color.Fuchsia;
            this.purpleCol.Location = new System.Drawing.Point(51, 150);
            this.purpleCol.Name = "purpleCol";
            this.purpleCol.Size = new System.Drawing.Size(36, 30);
            this.purpleCol.TabIndex = 2;
            // 
            // blueCol
            // 
            this.blueCol.AllowDrop = true;
            this.blueCol.BackColor = System.Drawing.Color.Blue;
            this.blueCol.Location = new System.Drawing.Point(48, 70);
            this.blueCol.Name = "blueCol";
            this.blueCol.Size = new System.Drawing.Size(36, 30);
            this.blueCol.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(22, 121);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(22, 170);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // additionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 262);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SetBoatpanel);
            this.Controls.Add(this.groupBox1);
            this.Name = "additionalForm";
            this.Text = "additionalForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SetBoatpanel.ResumeLayout(false);
            this.SetBoatpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Shiplabel;
        private System.Windows.Forms.Label Boatlabel;
        private System.Windows.Forms.Panel SetBoatpanel;
        private System.Windows.Forms.Label addColLabel;
        private System.Windows.Forms.Label mainColLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pinkCol;
        private System.Windows.Forms.Panel greyCol;
        private System.Windows.Forms.Panel brownCol;
        private System.Windows.Forms.Panel whiteCol;
        private System.Windows.Forms.Panel greenCol;
        private System.Windows.Forms.Panel purpleCol;
        private System.Windows.Forms.Panel redCol;
        private System.Windows.Forms.Panel blueCol;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}