using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Turistapp4.Annotations;
using Turistapp4.Common;
using Turistapp4.Model;

namespace Turistapp4.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private Kategori underholdning = new Kategori("Underholdning");
        private Kategori kultur = new Kategori("Kultur");
        private Kategori musik = new Kategori("Musik");
        private Kategori spisesteder = new Kategori("Spisesteder");
        private ObservableCollection<Kategori> kategoriviser;


        public MainViewModel()
        {
            kategoriviser = new ObservableCollection<Kategori>();
            kategoriviser.Add(underholdning);

            kategoriviser.Add(kultur);

            kategoriviser.Add(musik);

            kategoriviser.Add(spisesteder);

        }

        public ObservableCollection<Kategori> Kategoriviser
        {
            get { return kategoriviser; }
            set { kategoriviser = value; }
        }

        public Kategori Underholdning
        {
            get { return underholdning; }
            set { underholdning = value; }
        }

        public Kategori Kultur
        {
            get { return kultur; }
            set { kultur = value; }
        }

        public Kategori Musik
        {
            get { return musik; }
            set { musik = value; }
        }

        public Kategori Spisesteder
        {
            get { return spisesteder; }
            set { spisesteder = value; }
        }

        public static Kategori SelectedKategori { get; set; }

      public override string ToString()
       {
          return string.Format("Underholdning: {0}, Kultur: {1}, Musik: {2}, Spisesteder: {3}", underholdning, kultur, musik, spisesteder);
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
