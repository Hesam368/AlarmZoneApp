using AlarmZoneApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmZoneApp
{
    public partial class ZoneForm: Form
    {
        private readonly IZoneService _zoneService;
        public ZoneForm(IZoneService zoneService)
        {
            InitializeComponent();
            _zoneService = zoneService;
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtAlarmRate.Text, out double averageAlarmRate) ||
                !double.TryParse(txtPercentOutside.Text, out double percentOutsideTarget))
                {
                    MessageBox.Show("Please Enter numeric values", "Invalid input", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string zone = _zoneService.DetectZone(averageAlarmRate, percentOutsideTarget);
                lblResult.Text = zone;

                switch (zone)
                {
                    case "Robust":
                        lblResult.ForeColor = Color.Green; // Safe zone
                        break;
                    case "Stable":
                        lblResult.ForeColor = Color.Blue; // Acceptable
                        break;
                    case "Reactive":
                        lblResult.ForeColor = Color.Orange; // Warning
                        break;
                    case "Overloaded":
                        lblResult.ForeColor = Color.Red; // Critical
                        break;
                    default:
                        lblResult.ForeColor = Color.Black; // Default color
                        break;
                }

            }
            catch (Exception ex)
            {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
