using SampleColoredListboxViewmodel.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleColoredListboxViewmodel.Viewmodel
{
    public class MusicViewmodel: INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public List<Music> DataSet = new List<Music>
                {
                    new Music {Title="And the beat goes on", IsSpecial=false},
                    new Music {Title="Rithm of the night", IsSpecial=false},
                    new Music {Title="Careless wispers", IsSpecial=true}
                };

        public ObservableCollection<Music> MyMusic
        {
            get 
            {
                return new ObservableCollection<Music>(this.DataSet);
            }

        }

    }
}
