using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.Input.Preview.Injection;


namespace MouseAutoClicker
{
    class CoordinateViewModel : INotifyPropertyChanged
    {
        
        private string amountCoordinates;

        private Coordinate selectedCoordinate;

        private RelayCommand addCommand;

        private RelayCommand startCommand;

        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      var pointerPosition = CoreWindow.GetForCurrentThread().PointerPosition;
                      Coordinate coordinate = new Coordinate()
                      {

                          XCoord = pointerPosition.X ,
                          YCoord = pointerPosition.Y,
                      };
                      Coordinates.Insert(0, coordinate);
                      SelectedCoordinate = coordinate;
                      AmountCoordinates = "Всего значений: "+Coordinates.Count();
                  }));
            }
        }

        public RelayCommand StartCommand
        {
            get
            {
                return startCommand ??
                  (startCommand = new RelayCommand(obj =>
                  {
                      
                      InjectedInputPoint injectedInputPoint = new InjectedInputPoint();
                      injectedInputPoint.PositionX = 1817;
                      injectedInputPoint.PositionY = 0;
                      //injectedInputPoint.PointerOptions.

                      CoreWindow.GetForCurrentThread().PointerPosition = new Point(injectedInputPoint.PositionX, injectedInputPoint.PositionY);
                      //InjectedInputMouseOptions.Absolute(); Cursor.Position = new Point(400, 700);
                      InputInjector inputInjector = InputInjector.TryCreate();
                      var down = new InjectedInputMouseInfo();
                      down.MouseOptions = InjectedInputMouseOptions.LeftDown;
                      var up = new InjectedInputMouseInfo();
                      up.MouseOptions = InjectedInputMouseOptions.LeftUp;
                      Task.Delay(1500);
                      inputInjector.InjectMouseInput(new[] { down, up });
                      injectedInputPoint.PositionX = 0;
                      injectedInputPoint.PositionY = 0;
                      CoreWindow.GetForCurrentThread().PointerPosition = new Point(injectedInputPoint.PositionX, injectedInputPoint.PositionY);
                      Task.Delay(15000);
                      inputInjector.InjectMouseInput(new[] { down});
                      injectedInputPoint.PositionX = 879;
                      injectedInputPoint.PositionY = 115;
                      CoreWindow.GetForCurrentThread().PointerPosition = new Point(injectedInputPoint.PositionX, injectedInputPoint.PositionY);
                      inputInjector.InjectMouseInput(new[] { down, up });
                      inputInjector.InjectMouseInput(new[] { down, up });

                  }));
            }
        }





        public ObservableCollection<Coordinate> Coordinates { get; set; }
        public Coordinate SelectedCoordinate
        {
            get { return selectedCoordinate; }
            set
            {
                selectedCoordinate = value;
                OnPropertyChanged("SelectedCoordinate");
            }
        }

        public string AmountCoordinates { get => amountCoordinates;
            set { amountCoordinates = value; OnPropertyChanged("AmountCoordinates"); } }

    public CoordinateViewModel()
        {
            Coordinates = new ObservableCollection<Coordinate>
            {
                new Coordinate { XCoord = 15, YCoord = 21 },
                new Coordinate { XCoord = 16, YCoord = 22 },
                new Coordinate { XCoord = 17, YCoord = 23 },
                new Coordinate { XCoord = 18, YCoord = 24 },

            };
            AmountCoordinates = "Всего значений: " + Coordinates.Count();
        }

        


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
