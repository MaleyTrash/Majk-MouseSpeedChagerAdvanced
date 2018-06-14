using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
namespace MouseSpeedChangerAdvanced
{
    public class ViewModels : INotifyPropertyChanged
    {
        private ProfileData _currentData = new ProfileData();
        public ProfileData currentData {
            get => _currentData;
            set
            {
                _currentData = value;
                OnPropertyChanged("currentData");
            }
        }
        public RelayCommand saveSettings { get; private set; }
        public RelayCommand useSettings { get; private set; }
        
        private int _selecteIndex = -1;
        public int SelecteIndex
        {
            get => _selecteIndex;
            set
            {
                _selecteIndex = value;
                OnPropertyChanged("SelecteIndex");
            }
        }
        public ObservableCollection<ProfileData> allData { get; set; } = new ObservableCollection<ProfileData>();
        private DataLoader dataLoader = new DataLoader();
        private MouseSetter mouseSetter = new MouseSetter();

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModels()
        {
            allData = dataLoader.LoadData();
            saveSettings = new RelayCommand(this.saveProfile);
            useSettings = new RelayCommand(this.useMouseSettings);
        }
        public void saveProfile()
        {
            if (_selecteIndex < 0)
            {
                allData.Add(_currentData);
            }
            else
            {
                allData[_selecteIndex] = _currentData;
            }
            dataLoader.SaveData(allData);
        }
        public void useMouseSettings()
        {
            mouseSetter.setMouse(_currentData);
        }
        protected void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }
    }
}
