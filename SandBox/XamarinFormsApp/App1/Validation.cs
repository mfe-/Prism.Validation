using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace App1
{
    public static class Validation
    {
        public static readonly BindableProperty ErrorsProperty =
            BindableProperty.CreateAttached(
                "Errors",
                typeof(ReadOnlyCollection<string>),
                typeof(Validation),
                null,//Validator.EmptyErrorsCollection,
                propertyChanged: OnPropertyErrorsChanged);

        public static ReadOnlyCollection<string> GetErrors(BindableObject element)
        {
            return (ReadOnlyCollection<string>)element.GetValue(ErrorsProperty);
        }

        public static void SetErrors(BindableObject element, ReadOnlyCollection<string> value)
        {
            element.SetValue(ErrorsProperty, value);
        }
        private static Color OldColor = Color.Transparent;
        private static void OnPropertyErrorsChanged(BindableObject element, object oldValue, object newValue)
        {
            var view = element as View;
            if (view == null /*| oldValue == null*/ || newValue == null)
            {
                return;
            }
            
            var propertyErrors = (ReadOnlyCollection<string>)newValue;
            if (propertyErrors.Any())
            {
                OldColor = view.BackgroundColor;
                view.BackgroundColor = Color.Red;
            }
            else
            {
                view.BackgroundColor = OldColor;
            }
        }
    }
}
