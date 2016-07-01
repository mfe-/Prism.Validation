using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Prism.Validation;

namespace WpfApplication
{
    public class MainWindowViewModel : ValidatableBindableBase
    {
        public ObservableCollection<Car> CarList { get; set; } = new ObservableCollection<Car>()
        {
            new Car() { Name = "a" },
            new Car() { Name = "ab" },
            new Car() { Name = "abc" },
            new Car() { Name = "abcd" },
        };

    }
}
