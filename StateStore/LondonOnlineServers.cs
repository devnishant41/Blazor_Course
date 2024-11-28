namespace App_01_ServerManagement.StateStore
{
    public class LondonOnlineServers : Observer
    {
        private int _numberOfServersOnline;

        public int GetNumberOfServersOnline()
        {
            return _numberOfServersOnline;
        }

        public void SetNumberOfServersOnline(int number)
        {
            _numberOfServersOnline = number;
            base.BroadcastStateChange();
        }

    }
}
