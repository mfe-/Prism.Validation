# Prism.Validation

[<img src="https://ci.appveyor.com/api/projects/status/github/mfe-/Prism.Validation?branch=master&svg=true">](https://ci.appveyor.com/project/mfe-/prism-extensions)

The Prism.Validation is based on [Prism](https://github.com/PrismLibrary). It allows you to use Validations based on the ValidationAttributes in your Model, ViewModel and so on. 
Because most of you want to share your code acroos the .NET application model (also known as [App models](https://en.wikipedia.org/wiki/.NET_Framework#App_models)) the Prism.Validation is shipped as PCL.

##Install
[Install](https://www.nuget.org/packages/Prism.Validation/) with nuget ```Install-Package Prism.Validation```

##Useage for version 1.1.0.0 (Use Prism.Validation in a Library Project)
1. In you PCL set your Targeting to at least .NETStandard 1.4
2. Make sure your NETStandard.Library is up to date (1.6.1) 
3. Open project.json and replace ```"frameworks": {
    "netstandard1.4": { }
  }```.
4. to ``` "frameworks": {
   "netstandard1.4": {
     "imports": "portable45-net45+win8+wp8+wpa81"
   }
 }``` (this allows us to install Prism.Core - since this dependency doesnt provide a nuget package for .netstandard)
5. Install Nuget Package Prism.Validation

##Useage for version 1.0.0.0
1. Use in your PCL Profile ```Profile7``` (Set in your .csproj```<TargetFrameworkProfile>Profile7</TargetFrameworkProfile>```)
2. Install Prism.Validation in your project with nuget ```Install-Package Prism.Validation``` 
3. Create your model class and inherit from ```ValidatableBindableBase```.
4. Decorate your properties with DataAnnotations like ```[StringLength(2, ErrorMessage = "Max 2 digits")]```
5. Set Binding in XAML like ```<TextBox Text="{Binding Name,Mode=TwoWay,ValidatesOnDataErrors=True,UpdateSourceTrigger=PropertyChanged}" />``` 

##Validation
Model classes are a good example which can be used to share across different platforms. Also you may want to add some basic validations into the model with DataAnnotaions.

The Prism Core Libary doesn't provide a validation implementation (Related [Issue](https://github.com/PrismLibrary/Prism/issues/625) on Prism), so the Prism.Validation libary is filling this gap. The validation was taken over from the UWP [ValidatableBindableBase](https://github.com/PrismLibrary/Prism/tree/de7b03b5e015edcac595602512877b264a1345d1/Source/Windows10/Prism.Windows/Validation) with litte adjustments.

With the Prism.Validation you could share your model with DataAnnotaion between wpf, xamarin and uwp. 

##Changelog

###1.1.0.0

- Replaced [Portable Data Annotations](https://www.nuget.org/packages/Portable.DataAnnotations/) with [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations/)
- Changed Prism.Validation PCL to portable45-net45+win8
- [#4](https://github.com/mfe-/Prism.Validation/issues/4) Fixed by using System.ComponentModel.Annotations
- [#5](https://github.com/mfe-/Prism.Validation/issues/5) Upgrade packages to Prism 6.2
- [#3](https://github.com/mfe-/Prism.Validation/issues/3) Rename Prism.Extensions to Prism.Validation enhancement

###1.0.0.0
- Init (The validation was taken over from the UWP [ValidatableBindableBase](https://github.com/PrismLibrary/Prism/tree/de7b03b5e015edcac595602512877b264a1345d1/Source/Windows10/Prism.Windows/Validation) with litte adjustments.)
- Used [Portable Data Annotations](https://www.nuget.org/packages/Portable.DataAnnotations/)

##Contribute
Contribute if you want.
