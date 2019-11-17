# CSharp_CarRental_TieredApp
Visual Studio C# Object Orientated Project for a Car Rental Company made up of a tiered application stack! Company Car Rentals Windows app, Customer Windows mobile phone app and Windows API async middle man server app using a local MS SQL Server .md file not instance, for data management.

These application allow you to host a Windows-based API command line server which handles connections asynchronously, and the Business app which allows the company to add, modify or delete vehicles from the system, see car rental bookings, update paid bookings, etc. The Customer windows mobile app allows the clients to see what cars are available to rent, prices and detaisl, then proceed to book a vehicle providing their own details.

## Database:
The Database files are found inside the ServiceClient API app folder and belong with the API server if deployed or testing.

## Required Packages:
This Solution requires the following Visual Studio packages to be functional!! Please Install them with the VS Package Manager!

-> Microsoft.AspNet.WebApi.Client   /   For the Windows Phone Client App and Windows Business App Only

-> Microsoft.AspNet.WebApi.Core

-> Microsoft.AspNet.WebApi.SelfHost  /  For the Service Client only

-> Newtonsoft.Json

-> Xamarin.Forms     /    For the Windows Phone App Only

## How To Use:
Simple download the files and open the project solution in Visual Studio to see the 3 indididual tiered projects for it all, Then install the requires Visual Studio Packages Correctly and potentially the Visual Studio MS SQL Server package which is part of the developer MS SQL Server installation needed on your System! Then everything should work fine.
