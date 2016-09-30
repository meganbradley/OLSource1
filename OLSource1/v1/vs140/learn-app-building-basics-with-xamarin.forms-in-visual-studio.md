---
title: "Learn app-building basics with Xamarin.Forms in Visual Studio"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d22b5186-9e03-4e85-afc9-7cbe28522a6d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Learn app-building basics with Xamarin.Forms in Visual Studio
Once you've done the steps in [Setup and install](../vs140/setup-and-install.md) and [Verify your Xamarin environment](../vs140/verify-your-xamarin-environment.md), this walkthrough shows you how to build a basic app (shown below) with Xamarin.Forms. With Xamarin.Forms you'll write all of your UI code once in a portable class library (PCL). Xamarin will then automatically render the native UI controls for the iOS, Android, and Windows platforms. We recommend this approach because the PCL option best supports using only those .NET APIs that are supported across all target platforms, and because Xamarin.Forms lets you share UI code across platforms.  
  
 ![The Weather App sample on Android, iOS, and Windows Phone](../vs140/media/crossplat-xamarin-formsguide-1.png "CrossPlat Xamarin FormsGuide 1")  
  
 You'll do these things to build it:  
  
-   [Set up your solution](#solution)  
  
-   [Write shared data service code](#dataservice)  
  
-   [Begin writing shared UI code](#uicode)  
  
-   [Test your app](#test)  
  
-   [Finish the UI with a native look and feel across platforms](#finish)  
  
> [!TIP]
>  You can find the complete source code for this project in the [xamarin-forms-samples repository on GitHub](https://github.com/xamarin/xamarin-forms-samples/tree/master/Weather).  
  
##  \<a name="solution">\</a> Set up your solution  
 These steps create a Xamarin.Forms solution that contains a PCL for shared code and two added NuGet packages.  
  
1.  In Visual Studio, create a new **Blank App (Xamarin.Forms Portable)** solution and name it **WeatherApp**. You can find this template most easily by entering **Xamarin.Forms** into the search field.  
  
     If it’s not there, you might have to install Xamarin or enable the Visual Studio 2015 feature, see [Setup and install](../vs140/setup-and-install.md).  
  
     ![Creating a new Blank App &#40;Xamarin.Forms Portable&#41; project](../vs140/media/crossplat-xamarin-formsguide-2.png "CrossPlat Xamarin FormsGuide 2")  
  
2.  After clicking OK to create the solution, you’ll have a number of individual projects:  
  
    -   **WeatherApp (Portable)**: the PCL where you’ll write code that is shared across platforms, including common business logic and UI code using with Xamarin.Forms.  
  
    -   **WeatherApp.Droid**: the project that contains the native Android code. This is set as the default startup project.  
  
    -   **WeatherApp.iOS**: the project that contains the native iOS code.  
  
    -   **WeatherApp.UWP**: the project that contains Windows 10 UWP code.  
  
    -   **WeatherApp.Windows (Windows 8.1)**: the project that contains native Windows 8.1 code.  
  
    -   **WeatherApp.WinPhone (Windows Phone 8.1)**: the project that contains the native Windows Phone code.  
  
    > [!NOTE]
    >  You're free to delete any of the projects for a platform that you're not targeting. For the purposes of this walkthrough, we'll be referring to the Android, iOS, and Windows Phone 8.1 projects. Working with the UWP and Windows 8.1 projects is very similar to working with the Windows Phone 8.1 project.  
  
     Within each native project you have access to the native designer for the corresponding platform and can implement platform specific screens and functionality as needed.  
  
3.  Upgrade the Xamarin.Forms NuGet package in your solution to the latest stable version as follows. We recommend doing this whenever you create a new Xamarin solution:  
  
    -   Select **Tools > NuGet Package Manager > Manage NuGet Packages for Solution**.  
  
    -   Under the **Updates** tab, check the **Xamarin.Forms** update and check to update all the projects in your solution. (Note: leave any updates for Xamarin.Android.Support unchecked.)  
  
    -   Update the **Version** field to the **Latest stable** version that is available.  
  
    -   Click **Update**.  
  
         ![Updating the Xamarin.Forms NuGet package](../vs140/media/crossplat-xamarin-formsguide-4.png "CrossPlat Xamarin FormsGuide 4")  
  
4.  Add the **Newtonsoft.Json** and NuGet package to the PCL project, which you’ll use to process information retrieved from a weather data service:  
  
    -   In the NuGet Package Manager (still open from step 3), select the **Browse** tab and search for **Newtonsoft**.  
  
    -   Select **Newtonsoft.Json**.  
  
    -   Check the **WeatherApp** project (this is the only project in which you need to install the package).  
  
    -   Ensure the **Version** field is set to the **Latest stable** version.  
  
    -   Click **Install**.  
  
    -   ![Locating and installing the Newtonsoft.Json NuGet package](../vs140/media/crossplat-xamarin-formsguide-5.png "CrossPlat Xamarin FormsGuide 5")  
  
5.  Repeat step 4 to find and install the **Microsoft.Net.Http** package.  
  
6.  Build your solution and verify that there are no build errors.  
  
##  \<a name="dataservice">\</a> Write shared data service code  
 The **WeatherApp (Portable)** project is where you’ll write code for the portable class library (PCL) that’s shared across all platforms. The PCL is automatically included in the app packages build by the iOS, Android, and Windows Phone projects.  
  
 To run this sample you must first sign up for a free API key at [http://openweathermap.org/appid](http://openweathermap.org/appid).  
  
 The following steps add then code to the PCL to access and store data from that weather service:  
  
1.  Right-click the **WeatherApp** project and select **Add > Class…**. In the **Add New Item** dialog, name the file **Weather.cs**. You’ll use this class to store data from the weather data service.  
  
2.  Replace the entire contents of **Weather.cs** with the following:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Add another class to the PCL project named **DataService.cs** in which you’ll use to process JSON data from the weather data service.  
  
4.  Replace the entire contents of **DataService.cs** with the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  Add a third class to the PCL named **Core** where you’ll put shared business logic, such as logic that forms a query string with a zip code, calls the weather data service, and populates an instance of the **Weather** class.  
  
6.  Replace the contents of **Core.cs** with the following:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
7.  Build the **WeatherApp** PCL project to make sure the code is correct.  
  
##  \<a name="uicode">\</a> Begin writing shared UI code  
 Xamarin.Forms let you implement shared UI code in the PCL. In these steps you’ll add a screen to the PCL with a button that updates its text with data returned by the weather data service code added in the previous section:  
  
1.  Add a **Forms Xaml Page** named **WeatherPage.cs** by right-clicking the **WeatherApp** project and selecting **Add > New Item...**. In the **Add New Item** dialog, search on “Forms,” select **Forms Xaml Page**, and name it **WeatherPage.cs**.  
  
     Xamarin.Forms is XAML-based, so this step creates a **WeatherPage.xaml** file along with the nested code-behind file **WeatherPage.xaml.cs**. This allows you to generate UI through either XAML or code. You’ll do some of both in this walkthrough.  
  
     ![Adding a new Xamarin.Forms XAML page](../vs140/media/crossplat-xamarin-formsguide-6.png "CrossPlat Xamarin FormsGuide 6")  
  
2.  To add a button to the WeatherPage screen, replace the contents of WeatherPage.xaml with the following:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     Notice that the name of the button must be defined using the **x:Name** attribute so that you can reference this button by name from within the code-behind file.  
  
3.  To add an event handler for the button’s **Clicked** event to update the button text, replace the contents of **WeatherPage.xaml.cs** with the code below. (Feel free to change “60601” to another zip code.)  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
4.  To open **WeatherPage** as the first screen when the app launches, replace the default constructor in **App.cs** with the following code:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
5.  Build the WeatherApp PCL project to make sure the code is correct.  
  
##  \<a name="test">\</a> Test your app using the Visual Studio Emulator for Android  
 Now you’re ready to run the app! Let’s run just the Android version for now to verify that the app is getting data from the weather service. Later you’ll also run the iOS and Windows Phone versions after you’ve added more UI elements. (Note: if you’re running Visual Studio on Windows 7, you’ll follow these same steps but will the Xamarin Player instead.)  
  
1.  Set the **WeatherApp.Droid** project as the startup project by right-clicking it and selecting **Set as Startup Project**.  
  
2.  In the Visual Studio toolbar, you’ll see **WeatherApp.Droid** listed as the target project. Select one of the Android emulators for debugging and hit **F5**. We recommend using one of the **VS Emulator** options that will run the app in the Visual Studio Emulator for Android options.  
  
     ![Selecting a VS Emulator debug target](../vs140/media/crossplat-xamarin-formsguide-7.png "CrossPlat Xamarin FormsGuide 7")  
  
3.  When the app launches in the emulator, click the **Get Weather** button. You should see the button’s text updated to **Chicago, IL**, which is the *Title* property of the data retrieved from the weather service.  
  
     ![Weather App before and after tapping the button](../vs140/media/crossplat-xamarin-formsguide-8.png "CrossPlat Xamarin FormsGuide 8")  
  
##  \<a name="finish">\</a> Finish the UI with a native look and feel across platforms  
 Xamarin.Forms renders native UI controls for each platform so that your app automatically has a native look and feel. To see this more clearly, let’s finish the UI with an input field for a zip code and then display the weather data that’s returned from the service.  
  
1.  Replace the contents of **WeatherPage.xaml** with the code below. Note that every element is named using the **x:Name** attribute as described earlier so that the element can be referenced from code. Xamarin.Forms also provides a number of [layout options](http://developer.xamarin.com/guides/xamarin-forms/controls/layouts/) (xamarin.com); here, WeatherPage is using [StackLayout](http://developer.xamarin.com/api/type/Xamarin.Forms.StackLayout/) (xamarin.com).  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     Note the use of the **OnPlatform** tag in Xamarin.Forms. **OnPlatform** selects a property value that’s specific to the current platform on which the app is running (see [External XAML Syntax](http://developer.xamarin.com/guides/xamarin-forms/user-interface/xaml-basics/essential_xaml_syntax/) (xamarin.com). We’re using it here to set a different text color for the data fields: White on Android and Windows Phone, Black on iOS. You can use **OnPlatform** for any properties and any data types to make platform-specific adjustments anywhere in your XAML. In the code-behind file, you can use the [Device.OnPlatform API](http://developer.xamarin.com/guides/xamarin-forms/platform-features/device/) for the same purpose.  
  
2.  In **WeatherPage.xaml.cs**, replace the **GetWeatherBtn_Clicked** event handler with the code below. This code verifies that there’s a zip code in the entry field, retrieves data for that zip code, sets the whole screen’s binding context to the resulting Weather instance, then sets the button text to “Search Again.” Note that each label in the UI binds to a property of the Weather class, so when you set the screen’s binding context to a **Weather** instance, those labels update automatically.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
3.  Run the app on all three platforms—Android, iOS, and Windows Phone—by right-clicking the appropriate project, selecting Set as startup project, and starting the app either on a device or in the emulator or simulator. Enter a valid United States zip code (such as 60601) and press the Get Weather button to display weather data for that region as shown below. You’ll of course need to have Visual Studio connected to a Mac OS X machine on your network for the iOS project.  
  
     ![The Weather App sample on Android, iOS, and Windows Phone](../vs140/media/crossplat-xamarin-formsguide-1.png "CrossPlat Xamarin FormsGuide 1")  
  
 The complete source code for this project is in the [xamarin-forms-samples repository on GitHub](https://github.com/xamarin/xamarin-forms-samples/tree/master/Weather).