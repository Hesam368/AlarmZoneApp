using System;

namespace AlarmZoneApp.Services
{
    class ZoneService : IZoneService
    {
        public string DetectZone(double averageAlarmRate, double percentOutsideTarget)
        {
            // Validate inputs
            if (averageAlarmRate < 0 || averageAlarmRate > 100 || percentOutsideTarget < 0 || percentOutsideTarget > 50)
            {
                throw new ArgumentException("Invalid input values! Please ensure they are within a valid range.");
            }

            // Determine the zone
            if (averageAlarmRate < 1 && (percentOutsideTarget + averageAlarmRate * 15) < 25)
            {
                return "Robust";
            }
            else if (averageAlarmRate < 2 && (percentOutsideTarget + averageAlarmRate * 25) < 75)
            {
                return "Stable";
            }
            else if (averageAlarmRate < 10 && (percentOutsideTarget * 8 + averageAlarmRate * 25) < 450)
            {
                return "Reactive";
            }
            else
            {
                return "Overloaded";
            }
        }
    }
}
