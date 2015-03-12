using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace H1Z1ESP
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.showPlayers.Checked = Main.ShowPlayers;
            this.showAggressive.Checked = Main.ShowAggressive;
            this.snowAnimals.Checked = Main.ShowAnimals;
            this.showContainers.Checked = Main.ShowContainers;
            this.showWeapons.Checked = Main.ShowWeapons;
            this.showAmmo.Checked = Main.ShowAmmo;
            this.showItems.Checked = Main.ShowItems;
            this.hideESPAiming.Checked = Main.HideESPWhenAiming;



            this.showPosition.Checked = Main.ShowPosition;
            this.showCities.Checked = Main.ShowCities;
            this.hideDead.Checked = Main.HideDead;

            this.mapLarge.Checked = Main.ShowMapLarge;
            this.mapTransparency.Value = Main.MapTransparency;
            this.showRadar.Checked = Main.ShowRadar;

            this.radarPlayers.Checked = Main.RadarPlayers;
        }

        private void showPlayers_CheckedChanged(object sender, EventArgs e)
        {
            Main.ShowPlayers = this.showPlayers.Checked;
            Main.Ini.IniWriteValue("ESP", "ShowPlayers", Main.ShowPlayers.ToString());
        }

        private void showAggressive_CheckedChanged(object sender, EventArgs e)
        {
            Main.ShowAggressive = this.showAggressive.Checked;
            Main.Ini.IniWriteValue("ESP", "ShowAggressive", Main.ShowAggressive.ToString());
        }

        private void snowAnimals_CheckedChanged(object sender, EventArgs e)
        {
            Main.ShowAnimals = this.snowAnimals.Checked;
            Main.Ini.IniWriteValue("ESP", "ShowAnimals", Main.ShowAnimals.ToString());
        }

        private void showContainers_CheckedChanged(object sender, EventArgs e)
        {
            Main.ShowContainers = this.showContainers.Checked;
            Main.Ini.IniWriteValue("ESP", "ShowContainers", Main.ShowContainers.ToString());
        }

        private void showWeapons_CheckedChanged(object sender, EventArgs e)
        {
            Main.ShowWeapons = this.showWeapons.Checked;
            Main.Ini.IniWriteValue("ESP", "ShowWeapons", Main.ShowWeapons.ToString());
        }

        private void showAmmo_CheckedChanged(object sender, EventArgs e)
        {
            Main.ShowAmmo = this.showAmmo.Checked;
            Main.Ini.IniWriteValue("ESP", "ShowAmmo", Main.ShowAmmo.ToString());
        }

        private void showItems_CheckedChanged(object sender, EventArgs e)
        {
            Main.ShowItems = this.showItems.Checked;
            Main.Ini.IniWriteValue("ESP", "ShowItems", Main.ShowItems.ToString());
        }


        private void showPosition_CheckedChanged(object sender, EventArgs e)
        {
            Main.ShowPosition = this.showPosition.Checked;
            Main.Ini.IniWriteValue("Misc", "ShowPosition", Main.ShowPosition.ToString());
        }

        private void showCities_CheckedChanged(object sender, EventArgs e)
        {
            Main.ShowCities = this.showCities.Checked;
            Main.Ini.IniWriteValue("Misc", "ShowCities", Main.ShowCities.ToString());
        }

        private void hideDead_CheckedChanged(object sender, EventArgs e)
        {
            Main.HideDead = this.hideDead.Checked;
            Main.Ini.IniWriteValue("Misc", "HideDead", Main.HideDead.ToString());
        }

        private void hideESPAiming_CheckedChanged(object sender, EventArgs e)
        {
            Main.HideESPWhenAiming = this.hideESPAiming.Checked;
            Main.Ini.IniWriteValue("Misc", "HideESPWhenAiming", Main.HideESPWhenAiming.ToString());
        }

        private void mapLarge_CheckedChanged(object sender, EventArgs e)
        {
            Main.ShowMapLarge = this.mapLarge.Checked;
            Main.Ini.IniWriteValue("Map", "LargeMap", Main.ShowMapLarge.ToString());
        }

        private void mapTransparency_Scroll(object sender, EventArgs e)
        {
            Main.MapTransparency = this.mapTransparency.Value;
            Main.Ini.IniWriteValue("Map", "Transparency", Main.MapTransparency.ToString());
        }

        private void showRadar_CheckedChanged(object sender, EventArgs e)
        {
            Main.ShowRadar = this.showRadar.Checked;
            Main.Ini.IniWriteValue("Radar", "Show", Main.ShowRadar.ToString());
        }

        
        private void radarPlayers_CheckedChanged(object sender, EventArgs e)
        {
            Main.RadarPlayers = this.radarPlayers.Checked;
            Main.Ini.IniWriteValue("Radar", "Players", Main.RadarPlayers.ToString());
        }

    }
}