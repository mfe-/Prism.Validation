using Prism.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace UwpApp1
{
    public class HighlightFormFieldOnErrors : Behavior<FrameworkElement>
    {
        public ReadOnlyCollection<string> PropertyErrors
        {
            get { return (ReadOnlyCollection<string>)GetValue(PropertyErrorsProperty); }
            set { SetValue(PropertyErrorsProperty, value); }
        }

        public string HighlightStyleName
        {
            get { return (string)GetValue(HighlightStyleNameProperty); }
            set { SetValue(HighlightStyleNameProperty, value); }
        }

        public string OriginalStyleName
        {
            get { return (string)GetValue(OriginalStyleNameProperty); }
            set { SetValue(OriginalStyleNameProperty, value); }
        }

        public static DependencyProperty PropertyErrorsProperty =
        DependencyProperty.RegisterAttached("PropertyErrors", typeof(ReadOnlyCollection<string>), typeof(HighlightFormFieldOnErrors), new PropertyMetadata(BindableValidator.EmptyErrorsCollection, OnPropertyErrorsChanged));

        // The default for this property only applies to TextBox controls.
        public static DependencyProperty HighlightStyleNameProperty =
            DependencyProperty.RegisterAttached("HighlightStyleName", typeof(string), typeof(HighlightFormFieldOnErrors), new PropertyMetadata("HighlightTextBoxStyle"));

        // The default for this property only applies to TextBox controls.
        protected static DependencyProperty OriginalStyleNameProperty =
            DependencyProperty.RegisterAttached("OriginalStyleName", typeof(Style), typeof(HighlightFormFieldOnErrors), new PropertyMetadata("BaseTextBoxStyle"));

        private static void OnPropertyErrorsChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            if (args == null || args.NewValue == null)
            {
                return;
            }

            var control = ((Behavior<FrameworkElement>)d).AssociatedObject;
            var propertyErrors = (ReadOnlyCollection<string>)args.NewValue;

            Style style = (propertyErrors.Any()) ?
            (Style)Application.Current.Resources[((HighlightFormFieldOnErrors)d).HighlightStyleName] :
            ((Style)Application.Current.Resources[((HighlightFormFieldOnErrors)d).OriginalStyleName]);

            control.Style = style;
        }

        protected override void OnAttached()
        {
        }

        protected override void OnDetached()
        {
        }
    }

}
