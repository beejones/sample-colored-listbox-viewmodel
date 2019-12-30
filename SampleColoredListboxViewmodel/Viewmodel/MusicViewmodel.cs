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

        /// <summary>
        /// This is a sample data set. The one marked with IsSpecial will be highlighted in the UI.
        /// You can have a property method to set the property when needed.
        /// </summary>
        public List<Music> DataSet = new List<Music>
                {
                    new Music {Title="And the beat goes on", IsSpecial=false},
                    new Music {Title="Rithm of the night", IsSpecial=false},
                    new Music {Title="Careless wispers", IsSpecial=true}
                };

        /// <summary>
        /// Show the data set as a ObservableCollection needed for the UI.
        /// </summary>
        public ObservableCollection<Music> MyMusic
        {
            get 
            {
                return new ObservableCollection<Music>(this.DataSet);
            }

        }

    }
}
