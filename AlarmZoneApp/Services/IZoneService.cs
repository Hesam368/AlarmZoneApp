namespace AlarmZoneApp.Services
{
    public interface IZoneService
    {
        string DetectZone(double averageAlarmRate, double percentOutsideTarget);
    }
}
