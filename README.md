# Winforms Design Pattern Examples
This is a project that demonstrates basic principles of UI design patterns that can be utilized on Winforms Applications. A simple calculator has been designed with UI. There are several tabs:
* Naive
* MVP - Model View Presenter
* MVVM - Model View View-Presenter (in progress)

# Basic Requirements of Calculator
* Primitive math operations should be satisfied.
* Several buttons should be exist that are mapped to numbers, operations and delete operations.
* A history should be shown.
* The resulting value should be yellow if the value is negative.

# Troubleshooting
## Reference Issues on Visual Studio
Please follow the steps given below to refresh your packages:
* To open the console in Visual Studio, go to the main menu and select Tools > NuGet Package Manager > Package Manager Console
* Run ```Update-Package -reinstall ```