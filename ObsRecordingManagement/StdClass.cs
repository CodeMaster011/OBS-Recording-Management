using System.ComponentModel;

namespace ObsRecordingManagement
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
