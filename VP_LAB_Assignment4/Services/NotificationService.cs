namespace VP_LAB_Assignment4.Services
{
    public class NotificationService
    {
        private readonly NotificationConfig _config;

        // Injecting NotificationConfig through constructor injection
        public NotificationService(NotificationConfig config)
        {
            _config = config;
        }

        public Task<List<string>> GetNotificationsAsync(int? numberOfNotifications = null)
        {
            // Use user input count if provided, otherwise fall back to the singleton configuration default
            int count = numberOfNotifications ?? _config.DefaultNumberOfNotifications;

            var list = new List<string>();
            for (int i = 1; i <= count; i++)
            {
                if (_config.NotificationStyle == "Compact")
                {
                    list.Add($"[Alert #{i}] Short message summary.");
                }
                else
                {
                    list.Add($"[System Update #{i}] Comprehensive log detail: Task pipeline completed execution cycle at step entry index.");
                }
            }

            return Task.FromResult(list);
        }
    }
}
