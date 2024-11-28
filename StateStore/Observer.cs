namespace App_01_ServerManagement.StateStore
{
    public class Observer
    {
        public Action? _listeners;

        public void AddStateChangeListeners(Action? listeners)
        {
            if (listeners is not null)
            {

                _listeners += listeners;
            }
        }

        public void RemoveStateChangeListeners(Action? listeners)
        {
            {
                if (_listeners != null)
                {
                    _listeners -= listeners;
                }
            }
        }

        public void BroadcastStateChange()
        {
            _listeners?.Invoke();
        }


    }
}