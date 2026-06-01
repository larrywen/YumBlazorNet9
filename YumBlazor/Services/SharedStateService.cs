namespace YumBlazor.Services
{
    public class SharedStateService
    {
        public event Action OnChange; //notify subscribers when a state is updated
        private int _totalCartCount;

        public int TotalCartCount
        {
            get => _totalCartCount;
            set
            {
                _totalCartCount = value;
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
