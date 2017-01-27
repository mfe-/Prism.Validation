using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.Validation.Test.Wpf.Mock
{
    public class CarViewModelMock : ValidatableBindableBase
    {
        public CarViewModelMock()
        {
        }
        public ObservableCollection<CarMock> CarList { get; set; } = new ObservableCollection<CarMock>()
        {
            new CarMock() { Name = "a" },
            new CarMock() { Name = "ab" },
            new CarMock() { Name = "abc" },
            new CarMock() { Name = "abcd" },
        };

        private CarMock _SelectedCar;

        [Required]
        public CarMock SelectedCar
        {
            get { return _SelectedCar; }
            set { SetProperty(ref _SelectedCar, value); }
        }


    }
}
