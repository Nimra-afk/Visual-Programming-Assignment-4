namespace VP_LAB_Assignment4.Services
{
    public class NotificationConfig
    {
        public int DefaultNumberOfNotifications { get; set; } = 3;
        public string NotificationStyle { get; set; } = "Detailed"; // Options: "Compact" or "Detailed"
    }
}