namespace VP_LAB_Assignment4.Services
{
    public class AuthenticationStateService
    {
        // Property tracking authentication status
        public bool IsAuthenticated { get; private set; } = false;

        // Event to notify components when state updates
        public event Action? OnStateChanged;

        public void LogIn()
        {
            IsAuthenticated = true;
            NotifyStateChanged();
        }

        public void LogOut()
        {
            IsAuthenticated = false;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnStateChanged?.Invoke();
    }
}