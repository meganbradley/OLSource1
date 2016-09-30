---
title: "Cordova Sample App with O365 Discovery Service and the Files API"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a0c2883a-2320-4deb-8fb6-a675a40525a4
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cordova Sample App with O365 Discovery Service and the Files API
In this topic, you will learn how to leverage some of the new APIs in the client libraries for Office 365 in an app built using Visual Studio Tools for Apache Cordova.  
  
## Office 365 API Tools for Visual Studio 2013  
 If you are trying to consume the Office 365 APIs for the first time in a Cordova application workflow, please follow instructions in the [documentation](http://msdn.microsoft.com/library/dn771546.aspx#Office) to [install Office 365 API Tools for Visual Studio Preview](https://visualstudiogallery.msdn.microsoft.com/7e947621-ef93-4de7-93d3-d796c43ba34f) and to add the service into your project.  
  
 Office 365 provides REST-based APIs that enable developers to access Office resources such as calendar, contacts, mail, files, and more. You can program directly against the REST APIs to interact with Office 365, but if you use the REST APIs you must write and maintain code around managing authentication tokens, constructing the right URLs, querying for the API you want to access, and performing other tasks. By using Office 365 client libraries to access the Office 365 APIs instead of REST, you reduce the complexity of the code that you need to write in your Cordova application.  
  
 The latest update for [Office 365 API Tools for Visual Studio Preview](http://blogs.office.com/2014/08/05/office-365-api-tool-visual-studio-2013-summer-update/) includes support for SharePoint File services, which provides access to the MyFiles service. In addition to SharePoint services, support for the O365 Discovery service is provided which helps to find the SharePoint service endpoints for the logged in user. These services can be used to build a simple file explorer that enumerates files in OneDrive for Business.  
  
## Building a Simple File Explorer for OneDrive for Business  
 The goal of this app is to enumerate files stored in OneDrive for Business. The source for the sample is on [GitHub](http://go.microsoft.com/fwlink/?LinkID=517836).  
  
 ![Cordova&#95;0365&#95;OneDrive](../vs140/media/cordova_0365_onedrive.png "Cordova_0365_OneDrive")  
  
### Getting Started  
 The following frameworks and libraries are used in this application.  
  
-   [Bootstrap](http://getbootstrap.com/), for layout and styling.  
  
-   [AngularJS](https://angularjs.org/), for binding data with the UI.  
  
-   [Office 365 APIs](http://msdn.microsoft.com/library/office/dn605892\(v=office.15\)), for interacting with Office365 to enumerate OneDrive for Business.  
  
 The services used in the demo application to fetch files from OneDrive are:  
  
-   [O365 Discovery Services](http://msdn.microsoft.com/library/office/dn776441\(v=office.15\).aspx), to find SharePoint service endpoints for the logged in user.  
  
-   [Files API](http://msdn.microsoft.com/library/office/dn605900\(v=office.15\).aspx), to retrieve the file and folders information for the user’s OneDrive for Business.  
  
### Creating Authentication and Discovery Contexts  
 Before your app can access Office 365 services, the app must be authenticated. The [common consent framework in Azure AD](http://msdn.microsoft.com/library/office/dn605895\(v=office.15\).aspx) handles the authentication.  
  
 The basic objects that you need before you can perform any operations with O365 service are the context objects. For the demo app, the following context objects are required:  
  
-   Authentication context  
  
-   Discovery context  
  
 The code below constructs these objects as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object allows you to fetch the required ID token and access tokens, which can be used to obtain user information and to call specific services.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object allows you to fetch the Office 365 service capabilities, such as Mail or Calendar or MyFiles, along with their corresponding URL endpoints.  
  
 Once you have the required ID token, it can be used to identify the user. The ID token is a base64 encoded web token. You can use this token to retrieve the user that has currently logged in, as follows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The access token is a base64 URL-encoded web token that can be used for API access. Here is how you can get the access token that is used to call SharePoint services.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Using the Files API  
 The SharePoint capability object for "MyFiles" allows you to work with the files and folders programmatically. To do this, you must first obtain the capabilities collection and then look for the MyFiles capability in the returned collection. To obtain the capabilities object, use the discovery service by passing the access token for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Now that you have the capability object for MyFiles, you can create a SharePoint client and then call File APIs to work with user files, such as files stored on OneDrive for Business.  
  
### Create the SharePoint Client Object  
 To create the SharePoint client object we need the end point URI information stored in the capability object and the access token for the resource.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Fetch Files and Folders  
 Now we can enumerate the files by calling <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> as follows:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 In the demo application, the app fetches the information for each file and stores the information in a local JSON object. The app binds the JSON object to the UI using AngularJS.  
  
### Give it a Try!  
 The complete application is available in [Github](http://go.microsoft.com/fwlink/?LinkID=517836). Please download and try the sample and let us know your feedback. We would like to hear your opinions about the new APIs!  
  
 ![Download the tools](../vs140/media/cordova_install_download.png "Cordova_Install_Download") [Get the Visual Studio Tools for Apache Cordova](http://aka.ms/mchm38) or [learn more](https://www.visualstudio.com/cordova-vs.aspx)