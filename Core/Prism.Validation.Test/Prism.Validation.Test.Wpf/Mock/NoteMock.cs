using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.Validation.Test.Wpf.Mock
{
    public class NoteMock : IDataErrorInfo, INotifyPropertyChanged
    {
        private String _Note;
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Mini 5 digits, max 15 digits")]
        public String Note
        {
            get { return _Note; }
            set { SetField<String>(ref _Note, value, nameof(Note)); }
        }

        public string Error
        {
            get
            {
                return String.Empty;
            }
        }

        #region IDataErrorInfo
        public string this[string propertyName]
        {
            get
            {
                if (propertyName == nameof(Note))
                    return ValidateProperty(Note, propertyName);

                return String.Empty;
            }
        }


        protected string ValidateProperty(object value, string propertyName)
        {
            var info = this.GetType().GetProperty(propertyName);
            IEnumerable<string> errorInfos =
                  (from va in info.GetCustomAttributes(true).OfType<ValidationAttribute>()
                   where !va.IsValid(value)
                   select va.FormatErrorMessage(string.Empty)).ToList();


            if (errorInfos.Count() > 0)
            {
                return errorInfos.FirstOrDefault<string>();
            }
            return String.Empty;
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion
    }
}
