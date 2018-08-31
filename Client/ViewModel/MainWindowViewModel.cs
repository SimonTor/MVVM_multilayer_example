using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Client.Annotations;
using DM.MultiLayer.Data.Repositories;
using DM.MutliLayer.Logic.PersonManagement;
using BM.MultiLayer.Logic.PersonMangement.Contacts;

namespace Client.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> Persons { get; set; }
        public ObservableCollection<Animal> Animals { get; set; }


        public IPersonManager PersonManager { get; set; }  
        public IAnimalManager AnimalManager { get; set; }

        public MainWindowViewModel(IPersonManager personManager, IAnimalManager animalManager)
        {
            PersonManager = personManager;
            Persons = new ObservableCollection<Person>(PersonManager.GetAllAdults());

            AnimalManager = animalManager;
            Animals = new ObservableCollection<Animal>(AnimalManager.GetAllAdults());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
