using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.Validation.Test.UWP.Mock
{
    public class CarMock : ValidatableBindableBase
    {
        private String _Name;

        [StringLength(15, MinimumLength = 5, ErrorMessage = "Mini 5 digits, max 15 digits")]
        public String Name
        {
            get { return _Name; }
            set
            {
                SetProperty(ref _Name, value);
            }
        }
    }
}
