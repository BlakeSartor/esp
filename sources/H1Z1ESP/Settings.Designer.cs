namespace H1Z1ESP
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showAmmo = new System.Windows.Forms.CheckBox();
            this.showWeapons = new System.Windows.Forms.CheckBox();
            this.showItems = new System.Windows.Forms.CheckBox();
            this.snowAnimals = new System.Windows.Forms.CheckBox();
            this.showAggressive = new System.Windows.Forms.CheckBox();
            this.showContainers = new System.Windows.Forms.CheckBox();
            this.showPlayers = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mapTransparency = new System.Windows.Forms.TrackBar();
            this.mapLarge = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hideDead = new System.Windows.Forms.CheckBox();
            this.showPosition = new System.Windows.Forms.CheckBox();
            this.showCities = new System.Windows.Forms.CheckBox();
            this.hideESPAiming = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radarPlayers = new System.Windows.Forms.CheckBox();
            this.showRadar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapTransparency)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showAmmo);
            this.groupBox1.Controls.Add(this.showWeapons);
            this.groupBox1.Controls.Add(this.showItems);
            this.groupBox1.Controls.Add(this.snowAnimals);
            this.groupBox1.Controls.Add(this.showAggressive);
            this.groupBox1.Controls.Add(this.showContainers);
            this.groupBox1.Controls.Add(this.showPlayers);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESP";
            // 
            // showAmmo
            // 
            this.showAmmo.AutoSize = true;
            this.showAmmo.Checked = true;
            this.showAmmo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAmmo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showAmmo.Location = new System.Drawing.Point(15, 141);
            this.showAmmo.Name = "showAmmo";
            this.showAmmo.Size = new System.Drawing.Size(83, 17);
            this.showAmmo.TabIndex = 11;
            this.showAmmo.Text = "Show Ammo";
            this.showAmmo.UseVisualStyleBackColor = true;
            this.showAmmo.CheckedChanged += new System.EventHandler(this.showAmmo_CheckedChanged);
            // 
            // showWeapons
            // 
            this.showWeapons.AutoSize = true;
            this.showWeapons.Checked = true;
            this.showWeapons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showWeapons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showWeapons.Location = new System.Drawing.Point(15, 118);
            this.showWeapons.Name = "showWeapons";
            this.showWeapons.Size = new System.Drawing.Size(100, 17);
            this.showWeapons.TabIndex = 10;
            this.showWeapons.Text = "Show Weapons";
            this.showWeapons.UseVisualStyleBackColor = true;
            this.showWeapons.CheckedChanged += new System.EventHandler(this.showWeapons_CheckedChanged);
            // 
            // showItems
            // 
            this.showItems.AutoSize = true;
            this.showItems.Checked = true;
            this.showItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showItems.Location = new System.Drawing.Point(15, 164);
            this.showItems.Name = "showItems";
            this.showItems.Size = new System.Drawing.Size(79, 17);
            this.showItems.TabIndex = 9;
            this.showItems.Text = "Show Items";
            this.showItems.UseVisualStyleBackColor = true;
            this.showItems.CheckedChanged += new System.EventHandler(this.showItems_CheckedChanged);
            // 
            // snowAnimals
            // 
            this.snowAnimals.AutoSize = true;
            this.snowAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.snowAnimals.Location = new System.Drawing.Point(15, 72);
            this.snowAnimals.Name = "snowAnimals";
            this.snowAnimals.Size = new System.Drawing.Size(120, 17);
            this.snowAnimals.TabIndex = 8;
            this.snowAnimals.Text = "Show Animals (Wild)";
            this.snowAnimals.UseVisualStyleBackColor = true;
            this.snowAnimals.CheckedChanged += new System.EventHandler(this.snowAnimals_CheckedChanged);
            // 
            // showAggressive
            // 
            this.showAggressive.AutoSize = true;
            this.showAggressive.Checked = true;
            this.showAggressive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAggressive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showAggressive.Location = new System.Drawing.Point(15, 49);
            this.showAggressive.Name = "showAggressive";
            this.showAggressive.Size = new System.Drawing.Size(131, 17);
            this.showAggressive.TabIndex = 6;
            this.showAggressive.Text = "Show Aggressive NPC";
            this.showAggressive.UseVisualStyleBackColor = true;
            this.showAggressive.CheckedChanged += new System.EventHandler(this.showAggressive_CheckedChanged);
            // 
            // showContainers
            // 
            this.showContainers.AutoSize = true;
            this.showContainers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showContainers.Location = new System.Drawing.Point(15, 95);
            this.showContainers.Name = "showContainers";
            this.showContainers.Size = new System.Drawing.Size(104, 17);
            this.showContainers.TabIndex = 5;
            this.showContainers.Text = "Show Containers";
            this.showContainers.UseVisualStyleBackColor = true;
            this.showContainers.CheckedChanged += new System.EventHandler(this.showContainers_CheckedChanged);
            // 
            // showPlayers
            // 
            this.showPlayers.AutoSize = true;
            this.showPlayers.Checked = true;
            this.showPlayers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showPlayers.Location = new System.Drawing.Point(15, 26);
            this.showPlayers.Name = "showPlayers";
            this.showPlayers.Size = new System.Drawing.Size(88, 17);
            this.showPlayers.TabIndex = 4;
            this.showPlayers.Text = "Show Players";
            this.showPlayers.UseVisualStyleBackColor = true;
            this.showPlayers.CheckedChanged += new System.EventHandler(this.showPlayers_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mapTransparency);
            this.groupBox2.Controls.Add(this.mapLarge);
            this.groupBox2.Location = new System.Drawing.Point(175, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 72);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Map";
            // 
            // mapTransparency
            // 
            this.mapTransparency.AutoSize = false;
            this.mapTransparency.Location = new System.Drawing.Point(6, 43);
            this.mapTransparency.Maximum = 255;
            this.mapTransparency.Name = "mapTransparency";
            this.mapTransparency.Size = new System.Drawing.Size(168, 23);
            this.mapTransparency.TabIndex = 1;
            this.mapTransparency.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mapTransparency.Value = 210;
            this.mapTransparency.Scroll += new System.EventHandler(this.mapTransparency_Scroll);
            // 
            // mapLarge
            // 
            this.mapLarge.AutoSize = true;
            this.mapLarge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mapLarge.Location = new System.Drawing.Point(16, 26);
            this.mapLarge.Name = "mapLarge";
            this.mapLarge.Size = new System.Drawing.Size(97, 17);
            this.mapLarge.TabIndex = 0;
            this.mapLarge.Text = "Use Large Map";
            this.mapLarge.UseVisualStyleBackColor = true;
            this.mapLarge.CheckedChanged += new System.EventHandler(this.mapLarge_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hideDead);
            this.groupBox3.Controls.Add(this.showPosition);
            this.groupBox3.Controls.Add(this.showCities);
            this.groupBox3.Location = new System.Drawing.Point(175, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 140);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // hideDead
            // 
            this.hideDead.AutoSize = true;
            this.hideDead.Checked = true;
            this.hideDead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideDead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hideDead.Location = new System.Drawing.Point(16, 69);
            this.hideDead.Name = "hideDead";
            this.hideDead.Size = new System.Drawing.Size(143, 17);
            this.hideDead.TabIndex = 12;
            this.hideDead.Text = "Hide dead NPC && players";
            this.hideDead.UseVisualStyleBackColor = true;
            this.hideDead.CheckedChanged += new System.EventHandler(this.hideDead_CheckedChanged);
            // 
            // showPosition
            // 
            this.showPosition.AutoSize = true;
            this.showPosition.Checked = true;
            this.showPosition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showPosition.Location = new System.Drawing.Point(16, 23);
            this.showPosition.Name = "showPosition";
            this.showPosition.Size = new System.Drawing.Size(91, 17);
            this.showPosition.TabIndex = 11;
            this.showPosition.Text = "Show Position";
            this.showPosition.UseVisualStyleBackColor = true;
            this.showPosition.CheckedChanged += new System.EventHandler(this.showPosition_CheckedChanged);
            // 
            // showCities
            // 
            this.showCities.AutoSize = true;
            this.showCities.Checked = true;
            this.showCities.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCities.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showCities.Location = new System.Drawing.Point(16, 46);
            this.showCities.Name = "showCities";
            this.showCities.Size = new System.Drawing.Size(79, 17);
            this.showCities.TabIndex = 10;
            this.showCities.Text = "Show Cities";
            this.showCities.UseVisualStyleBackColor = true;
            this.showCities.CheckedChanged += new System.EventHandler(this.showCities_CheckedChanged);
            // 
            // hideESPAiming
            // 
            this.hideESPAiming.AutoSize = true;
            this.hideESPAiming.Checked = true;
            this.hideESPAiming.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideESPAiming.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hideESPAiming.Location = new System.Drawing.Point(12, 12);
            this.hideESPAiming.Name = "hideESPAiming";
            this.hideESPAiming.Size = new System.Drawing.Size(147, 17);
            this.hideESPAiming.TabIndex = 13;
            this.hideESPAiming.Text = "Hide All ESP when Aiming";
            this.hideESPAiming.UseVisualStyleBackColor = true;
            this.hideESPAiming.CheckedChanged += new System.EventHandler(this.hideESPAiming_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radarPlayers);
            this.groupBox4.Controls.Add(this.showRadar);
            this.groupBox4.Location = new System.Drawing.Point(12, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 65);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Radar";
            // 
            // radarPlayers
            // 
            this.radarPlayers.AutoSize = true;
            this.radarPlayers.Checked = true;
            this.radarPlayers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radarPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radarPlayers.Location = new System.Drawing.Point(15, 42);
            this.radarPlayers.Name = "radarPlayers";
            this.radarPlayers.Size = new System.Drawing.Size(120, 17);
            this.radarPlayers.TabIndex = 1;
            this.radarPlayers.Text = "Show Players Radar";
            this.radarPlayers.UseVisualStyleBackColor = true;
            this.radarPlayers.CheckedChanged += new System.EventHandler(this.radarPlayers_CheckedChanged);
            // 
            // showRadar
            // 
            this.showRadar.AutoSize = true;
            this.showRadar.Checked = true;
            this.showRadar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showRadar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showRadar.Location = new System.Drawing.Point(15, 19);
            this.showRadar.Name = "showRadar";
            this.showRadar.Size = new System.Drawing.Size(83, 17);
            this.showRadar.TabIndex = 0;
            this.showRadar.Text = "Show Radar";
            this.showRadar.UseVisualStyleBackColor = true;
            this.showRadar.CheckedChanged += new System.EventHandler(this.showRadar_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(302, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 59);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(367, 308);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.hideESPAiming);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapTransparency)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox snowAnimals;
        private System.Windows.Forms.CheckBox showAggressive;
        private System.Windows.Forms.CheckBox showContainers;
        private System.Windows.Forms.CheckBox showPlayers;
        private System.Windows.Forms.CheckBox showItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar mapTransparency;
        private System.Windows.Forms.CheckBox mapLarge;
        private System.Windows.Forms.CheckBox showWeapons;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox showCities;
        private System.Windows.Forms.CheckBox showPosition;
        private System.Windows.Forms.CheckBox hideDead;
        private System.Windows.Forms.CheckBox showAmmo;
        private System.Windows.Forms.CheckBox hideESPAiming;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox radarPlayers;
        private System.Windows.Forms.CheckBox showRadar;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}