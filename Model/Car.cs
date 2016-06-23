using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Prism.Extensions.Validation;

namespace Model
{
    public class Car : ValidatableBindableBase
    {
        private String _Name;

        [StringLength(2, ErrorMessage = "Max 2 digits")]
        public String Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value);
            }
        }

    }
}
