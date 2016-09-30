---
title: "Create the ToDoList Sample App"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 07692a31-5a91-4d34-8115-abf9ce73270d
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Create the ToDoList Sample App
[!INCLUDE[cordova_header](../vs140/includes/cordova_header_md.md)]  
  
 In this tutorial, you’ll learn how to create a task list sample app using AngularJS (AngularJSToDo). This app allows users to create new tasks, check them off, and remove them. The app also stores tasks using HTML5 Web Storage on the device. (The complete sample uses Microsoft Azure Mobile Services to store data, and also uses Bing Maps to provide valid addresses.) This sample uses JavaScript code, but you can also write your Cordova app in TypeScript.  
  
> [!NOTE]
>  For an overview of tasks required to build a Cordova app, see [Create Your First App](../vs140/create-your-first-app-using-visual-studio-tools-for-apache-cordova.md).  
  
 The task list sample app is available for multiple frameworks, and can be downloaded here:  
  
-   [AngularJS sample](http://go.microsoft.com/fwlink/p/?LinkID=398516)  
  
-   [WinJS sample](http://go.microsoft.com/fwlink/p/?LinkID=398518) (TypeScript sample)  
  
-   [Backbone sample](http://go.microsoft.com/fwlink/p/?LinkID=398517)  
  
 To download other samples for Visual Studio Tools for Apache Cordova that demonstrate multi-page navigation and other features, see the [Ionic SideMenu Starter Template](https://code.msdn.microsoft.com/windowsapps/Ionic-SideMenu-Starter-8e905eb5), [AngularJS Master-Detail Page sample](http://code.msdn.microsoft.com/AngularJS-Detail-Sample-7a409e5e), and [WinJS Navigation App template](http://code.msdn.microsoft.com/WinJS-Navigation-Template-50112ea9)  
  
 In this tutorial, you’ll follow these steps:  
  
1.  [Create a project](#Create)  
  
2.  [Create the UI](#UI)  
  
3.  [Add the AngularJS framework](#AddAngularJS)  
  
4.  [Register app modules](#RegisterModules)  
  
5.  [Add the data model](#DataModel)  
  
6.  [Add the view logic and data binding](#ViewLogic)  
  
7.  [Add app services](#AppServices)  
  
8.  [Build and run the ToDo List app](#BuildToDo)  
  
9. [Add Bing Maps services](#BingMaps)  
  
10. [Add Azure Mobile Services](#Azure)  
  
## Pre-requisites  
 Before you can create a new project, make sure that you’ve met all system requirements and installed the Visual Studio Tools for Apache Cordova. For more information, see [Install Visual Studio Tools for Apache Cordova](../vs140/install-visual-studio-tools-for-apache-cordova.md).  
  
##  \<a name="Create">\</a> Create a project  
 Create a new Cordova project in Visual Studio by following the steps described in [Create Your First App](../vs140/create-your-first-app-using-visual-studio-tools-for-apache-cordova.md). Alternatively, start with a new blank app by choosing **File**, **New**, and then **Project** in Visual Studio. In the New Project dialog box, choose **Installed**, **Templates**, **JavaScript**, **Apache Cordova Apps**, and then choose the **Blank App** template.  
  
##  \<a name="UI">\</a> Create the UI  
 The main UI in the task list sample app consists of the following elements:  
  
-   An \<input> element for new list items.  
  
-   An AngularJS template that will display each task in the task list.  
  
 The \<input> element looks like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When you first run the app, some of the attributes in the preceding code won't do anything. For example, the AngularJS <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> directive enables two-way data binding, and allows you to save the entered task when the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> function runs.  
  
 For the task list, we define a template using some nested \<div> elements that wrap several other elements. For example, the nested \<input> element shown here is used to display each task string.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the preceding code, the AngularJS attribute, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, allows you to define the top \<div> element as a template to display task list items. Later, when you attach actual data and run the app, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> will add the child \<div> element (templateContainer) and its child elements to the DOM for each stored task list item.  
  
> [!NOTE]
>  Because Cordova is not dependent on any particular JavaScript framework, we are not trying to provide in-depth information about [AngularJS programming](https://docs.angularjs.org/tutorial) in these steps. Instead, we are showing a good example of one way to create a cross-platform app using Visual Studio Tools for Apache Cordova.  
  
 Now, we will add the complete markup for index.html.  
  
#### Add markup for the list  
  
-   Open index.html, and replace the \<head> and \<body> element with the following code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     When you add the AngularJS framework (in later steps), other AngularJS attributes specified in index.html will become meaningful, but for now they won't have any effect when you run the app. Here are the other AngularJS attributes included in index.html:  
  
    -   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> directive to specify the root node of an AngularJS app.  
  
    -   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to specify the AngularJS controller to support MVC.  
  
#### Add CSS style information  
  
-   In the **css** folder, open index.css, and add the following CSS style information for HTML elements and templates.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can take a look at the empty task list in one of the emulators to verify that everything looks correct. In this step, you’ll run the AngularJSToDo list app on either Windows or on the Apache Ripple simulator, which have minimal setup requirements (although Ripple requires Chrome). If you prefer to test your app on another target, see the following topics: [Run your app on Android](../vs140/run-your-apache-cordova-app-on-android.md), [Install tools to build for iOS](../vs140/configure-the-visual-studio-tools-for-apache-cordova.md), and [Run your app on Windows Phone](../vs140/run-your-apache-cordova-app-on-windows-phone.md).  
  
#### To build and run the app  
  
1.  Choose Windows-x64, Windows-x86, or Android from the **Solution Platforms** list.  
  
2.  If you chose the Android platform, choose one of the Ripple simulators, as shown here.  
  
     ![Selecting the Ripple emulator](../vs140/media/cordova_ripple.png "Cordova_Ripple")  
  
     If you chose a Windows platform, you can run the app on the default deployment target, **Local Machine**.  
  
3.  Press F5 to start debugging, or Shift+F5 to start without debugging.  
  
     The following illustration shows an example of what the AngularJSToDo list app looks like in one of the Ripple simulators (with no actual data yet attached, and with some files missing at this stage).  
  
     ![Cordova&#95;ToDo&#95;List&#95;App&#95;Empty](../vs140/media/cordova_todo_list_app_empty.png "Cordova_ToDo_List_App_Empty")  
  
    > [!TIP]
    >  If you are running on a Ripple simulator and you get an error that indicates you need to install a new version of the Android SDK, use the Android SDK Manager to install it. On Windows, SDK Manager.exe is in C:\Program Files (x86)\Android\android-sdk.  
  
     If you see an error such as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, see [Re-installing vs-tac](https://msdn.microsoft.com/en-us/library/dn757054.aspx#vsmda). If you experience other problems, see [Known Issues](http://go.microsoft.com/fwlink/p/?linkid=398782) and the [FAQ](http://go.microsoft.com/fwlink/p/?linkid=398476).  
  
##  \<a name="AddAngularJS">\</a> Add the AngularJS framework to your project  
 Now that you’ve verified your setup, you can create the AngularJSToDo app. The app uses AngularJS to separate the view model (MVC), to provide data binding, and to support native UI for different platforms.  
  
#### To add AngularJS to your project  
  
1.  From the [AngularJS website](https://angularjs.org/), choose **Download**.  
  
     In the **Download AngularJS** dialog box, make sure that the minified 1.4.x version of AngularJS (the default stable version) is selected, and then choose **Download** to save the angular.min.js script to your computer.  
  
2.  In the **Download AngularJS** dialog box, choose **Browse additional modules**, and download angular-resource.min.js.  
  
3.  In the Visual Studio Solution Explorer, add a new folder under the **scripts** folder of the project and name it **frameworks**.  
  
    > [!NOTE]
    >  You cannot add this folder while the app is running. Press Shift + F5 to stop the debugger.  
  
4.  Open the shortcut menu for the **frameworks** folder, and then choose **Add**, **Existing Item**. Add the two AngularJS files from steps 1 and 2 to the project.  
  
#### Update the script references  
  
-   In index.html, add the following AngularJS references in the \<body> element, after the Cordova and platformOverrides script references.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     Your script references in the \<body> element should now look like this.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  cordova.js needs to load before the AngularJS framework files.  
  
-   Add script references for your AngularJS modules at the end of the \<body> element, after the AngularJS references. Those additional references should look like this.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="RegisterModules">\</a> Register app modules  
 In this section, you’ll register AngularJS app modules to help separate application concerns. Modules in this app include the data model (xPlat.services), the AngularJS controller (xPlat.controller), and AngularJS directives (xPlat.directives) to support data binding. To register the modules, use the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> function.  
  
#### To register angular modules  
  
1.  In Solution Explorer, open the shortcut menu for the **scripts** folder, and then choose **Add**, **New Folder**.  
  
     Use this command to add three folders under the **scripts** folder:  
  
    -   controllers  
  
    -   directives  
  
    -   services  
  
2.  In Solution Explorer, open the shortcut menu for the **controllers** folder, and then choose **Add**, **New Item**.  
  
3.  In the **Add New Item** dialog box, choose **JavaScript File**, and name it toDoCtrl.js.  
  
4.  Repeat the preceding step to add additional JavaScript files to the **directives** and **services** folders, respectively:  
  
    -   textChange.js (add it to the directives folder).  
  
    -   cordova.js, guidGenerator.js, localStorage.js, maps.js, and storage.js (add them to the services folder)  
  
5.  Open index.js, and replace the default code with the following code.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="DataModel">\</a> Add the data model  
 The data model is represented by the xPlat.services module, which you’ll implement in the files in the **services** folder. This code includes a service that provides local storage of task list items using HTML5 Web Storage (localStorage.js). In this initial implementation, the app also provides placeholder code for Bing Maps services, which can be implemented fully later on. The [complete sample app](http://go.microsoft.com/fwlink/?LinkID=398516) also uses Azure to store data.  
  
#### To add code for the data model  
  
-   In the **services** folder, open storage.js and add the following code.  
  
     In this code, we provide a generic way to add storage service. In the initial implementation, we add the localStorage service. Later, we will add an Azure service using this code.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
-   In the **services** folder, open localStorage.js and add the following code.  
  
     One thing to note here is the inclusion of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> service component in the service provider function. This object enables asynchronous programming, so that you can create a promise object using <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. Using the promise object, you can resolve the asynchronous operation when it has completed.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="ViewLogic">\</a> Add the app's view logic and implement data binding  
 In this section, you’ll implement the AngularJS controller module (<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) to handle view logic and manipulate the data model. The code implements declarative functions in the HTML such as <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, which adds a new task item to the list. In this section, you’ll also add an AngularJS directive to help implement two-way data binding.  
  
#### To add the controller  
  
-   In the **controllers** folder, open toDoCtrl.js and add the following code.  
  
     The controller name, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, is also referenced by the AngularJS <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> directive in index.html.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Next, you’ll implement the directives module. In this code, you’ll create a custom directive to specify behavior for the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> DOM event. At runtime, this code associates the correct event handler (declared in HTML markup in index.html) with the element, either the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> functions. These are implemented in toDoCtrl.js.  
  
#### To add a directive for data binding  
  
-   In the **directives** folder, open textChange.js and add the following code.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="AppServices">\</a> Add additional services  
 In this section, you’ll add additional service modules to support features such as GUID generation.  
  
#### To add other app services  
  
1.  In the **services** folder, open guidGenerator.js and add the following code.  
  
     This code generates a unique ID to associate with each task list item.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 In the **services** folder, open maps.js and add the following code.  
  
 We will use this code later to enable Bing Maps geolocation services. For now, it is used to associate the current location, if available, or a default location with the current task list item.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 In the **services** folder, open cordova.js and add the following code.  
  
 This code adds a handler for the Cordova <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> event to help make sure that the event fires before the app runs plugin code.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="BuildToDo">\</a> Build and run your app  
 In this step, you’ll run the AngularJSToDo list app on either Windows or on the Apache Ripple simulator.  
  
#### To build and run the app  
  
1.  Press F5 to run the app on the same target you specified previously. Windows and the Ripple simulator have minimal setup requirements, so we recommend initially targeting one of these two platforms.  
  
     The following illustration shows an example of what the AngularJSToDo list app looks like in one of the Ripple simulators.  
  
     ![Running the ToDo List app on Ripple Emulator](../vs140/media/cordova_todo_list_app.png "Cordova_ToDo_List_App")  
  
     Now, you can add new task list items by typing text and pressing Enter (Ripple) or tapping outside of the input box (Windows). At this point, HTML 5 Web Storage stores the task list items locally.  
  
##  \<a name="BingMaps">\</a> Add Bing Maps services  
 The [complete sample](http://go.microsoft.com/fwlink/p/?LinkID=398516) includes a Bing Maps service to associate your current address with each task list item.  
  
> [!TIP]
>  If you are more interested in setting up Azure Mobile Services, you can skip these steps and go to the next section.  
  
#### To add Bing Maps support to the app:  
  
1.  Add the Cordova Geolocation plugin to the app by double-clicking config.xml in Solution Explorer, choosing the **Plugins** tab, and then choosing **Geolocation**.  
  
     For more information, see [Manage Plugins](../vs140/manage-plugins-for-apps-built-with-visual-studio-tools-for-apache-cordova.md).  
  
2.  Choose **Add** to add the plugin.  
  
3.  [Get a Bing Maps key](http://msdn.microsoft.com/library/ff428642.aspx) and include it where instructed in the in maps.js.  
  
4.  Press F5 to start the app.  
  
     Now, Bing Maps will provide an address for your current location.  
  
##  \<a name="Azure">\</a> Add Azure Mobile Services  
 The complete sample includes additional code to store and retrieve task list items using Azure Mobile Services. This code is implemented as an additional service (named <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>) in azureStorage.js. You can obtain this code from the [complete sample app](http://go.microsoft.com/fwlink/p/?LinkID=398516), or you can follow the instructions here to add the service.  
  
#### To add Azure Mobile Services to the app  
  
1.  If you don't already have one, create a [Microsoft Azure account](http://azure.microsoft.com/pricing/free-trial/).  
  
2.  In Solution Explorer, choose **Add**, **Connected Service** from the shortcut menu for the project, and then follow instructions in [add a connected service](../vs140/add-connected-services-to-app-built-with-visual-studio-tools-for-apache-cordova.md)to add Azure Mobile Services to your app and to create a free SQL database.  
  
     When the service is added, your project gets the following updates:  
  
    -   A new services folder will be added to your project when you finish adding the connected service. The resulting code in \<*servicename*>.js will need to be replaced with code from the ToDoList sample app (code shown in the steps that follow).  
  
    -   The Azure Mobile Services plugin is added to the plugins folder.  
  
    -   The InAppBrowser plugin is added to the plugins folder.  
  
3.  Copy the Azure Mobile Service application key and URL from \<*servicename*>.js into Notepad. The key and URL are shown here.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
4.  In Solution Explorer, remove the new services folder that was added when you chose **Add**, **Connected Services** and added the service. You won’t need this code or the services folder structure that was just added.  
  
5.  In storage.js, uncomment the following lines of code to allow use of Azure as the storage service.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
     And remove the next line of code:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
     After uncommenting the code and removing the specified code, the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> function in storage.js will look like this.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
6.  In azureStorage.js, add the following code for the Azure service.  
  
     Where indicated in the code, add Azure Mobile Service application key and URL that you obtained when you added the Azure service.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
7.  Press F5 to re-run the app.  
  
     Now, task list items will be stored in Azure.  
  
 ![Download the tools](../vs140/media/cordova_install_download.png "Cordova_Install_Download") [Get the Visual Studio Tools for Apache Cordova](http://aka.ms/mchm38) or [learn more](https://www.visualstudio.com/cordova-vs.aspx)