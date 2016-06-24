# Prism.Extensions

The Prism.Extensions goal is to share, extensions for the [Prism](https://github.com/PrismLibrary) framework, acroos the .NET application model also known as [App models](https://en.wikipedia.org/wiki/.NET_Framework#App_models). Therefore the Prism.Extensions is shipped as PCL.

##Validation
Model classes are an good example which can be used to share them across the diffrent platforms. Also you may want to add some basic validations into the model with DataAnnotaions.

The Prism Core Libary doesn't provide a validation implementation (Related [Issue](https://github.com/PrismLibrary/Prism/issues/625) on Prism), so the Prism.Extensions libary is filling this gap. The validation is taking over from the UWP [ValidatableBindableBase](https://github.com/PrismLibrary/Prism/tree/de7b03b5e015edcac595602512877b264a1345d1/Source/Windows10/Prism.Windows/Validation) with litte adjustments.

With the Prism.Extensions you could share your model with DataAnnotaion between wpf, xamarin and uwp. 



##validations
Data Validation and Error Reporting https://msdn.microsoft.com/en-us/library/gg405484(v=pandp.40).aspx#sec14 <br />
Good old article regarding validations https://blog.magnusmontin.net/2013/08/26/data-validation-in-wpf/ <br />
INotifyDataErrorInfo Interface https://msdn.microsoft.com/en-us/library/system.componentmodel.inotifydataerrorinfo(v=vs.110).aspx <br />
