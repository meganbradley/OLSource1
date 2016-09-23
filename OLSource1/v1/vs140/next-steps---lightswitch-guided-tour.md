---
title: "Next Steps - LightSwitch Guided Tour"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8bc4e958-2910-46ba-b074-53e251a98d9a
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Next Steps - LightSwitch Guided Tour
If you have completed the lessons in the LightSwitch guided tour, congratulations! The lessons showed how to use the basic capabilities of LightSwitch to create and modify an application. There’s a lot more you can do with LightSwitch, and now you may be ready to create an application of your own. Here are some of the things you might want to try:  
  
##  <a name="publish"></a>   
-   [Extend Your Application with JavaScript](../vs140/next-steps---lightswitch-guided-tour.md#extend)  
  
-   [Use Another Source of Data](../vs140/next-steps---lightswitch-guided-tour.md#data)  
  
-   [Add a Desktop Client](../vs140/next-steps---lightswitch-guided-tour.md#client)  
  
-   [Expose Your Data](../vs140/next-steps---lightswitch-guided-tour.md#expose)  
  
-   [Create an app for SharePoint](../vs140/next-steps---lightswitch-guided-tour.md#app)  
  
-   [Get Some Help](../vs140/next-steps---lightswitch-guided-tour.md#help)  
  
### Publish Your Application  
 Before other users can use your application, you’ll need to publish it. You can publish to Internet Information Services (IIS) or to Microsoft Azure. When your application is published, users can access it from any desktop or mobile browser by entering the URL for your IIS or Azure server plus the name of your application. For example, for the application that you just created you would enter `http://mywebserver.com/MyFirstApplication`.  
  
 To learn about publishing to IIS, see [How to: Deploy a Three-Tier LightSwitch Application](../vs140/how-to--deploy-a-three-tier-lightswitch-application.md).  
  
 To learn about publishing to Microsoft Azure, see [How to: Publish a LightSwitch Application to Azure](http://msdn.microsoft.com/en-us/library/jj131261.aspx).  
  
###  <a name="extend"></a> Extend Your Application with JavaScript  
 In the guided tour you saw some basic tasks that can be accomplished by writing JavaScript code, but there’s much more that you can do. If the default controls on a screen don’t meet your needs, you can add custom JavaScript-based controls, or even create your own controls. For example, instead of using a text box to enter numbers, you might use a slider control.  
  
 You also saw how to modify the appearance of a screen by setting properties. You can also modify the appearance of a screen by writing JavaScript code that runs when a screen is created or when a control is rendered. For example, you might write code to set an initial value, change the color of an item based on a condition, or even pinpoint a user’s location on a map.  
  
 To learn about custom controls, see [How to: Add a Custom Control to an HTML Screen for a LightSwitch App](../vs140/how-to--add-a-custom-control-to-an-html-screen-for-a-lightswitch-app.md).  
  
 To learn about JavaScript, see [How to: Modify an HTML Screen by Using Code](../vs140/how-to--modify-an-html-screen-by-using-code.md).  
  
###  <a name="data"></a> Use Another Source of Data  
 The guided tour used both the intrinsic SQL Server database and the Northwind Open Data Protocol (OData) endpoint as sources of data. In addition to these two data sources, you can connect to SQL Server databases hosted on a server or on Microsoft Azure, to a SharePoint list, to an SAP NetWeaver Gateway, or to a Windows Communication Foundation (WCF) Rich Internet Application (RIA) service.  
  
 To learn about connecting to data, see [How to: Connect to Data](../vs140/how-to--connect-to-data.md).  
  
###  <a name="client"></a> Add a Desktop Client  
 As you’ve seen, LightSwitch HTML client applications are optimized for mobile devices. For some tasks such as heavy data entry, a mobile client may not be the best choice. You can also create a more traditional desktop application by adding a **Desktop Client** to your application project. Desktop client screens are based on Silverlight and also run in a browser, but are optimized for full-sized screens and keyboard entry.  
  
 To learn about desktop clients, see [Silverlight Client Screens for LightSwitch Apps](../vs140/silverlight-client-screens-for-lightswitch-apps.md).  
  
###  <a name="expose"></a> Expose Your Data  
 In addition to using LightSwitch to create applications, you can use it as the middle tier to provide data to other applications. When you publish application data from LightSwitch to a web server or to Microsoft Azure, that data is exposed as an Open Data Protocol (OData) service. OData provides a standard for communicating with data services over the web. Because OData is a standard protocol, other client applications on almost any platform or device can access the data that you create or expose through LightSwitch.  
  
 To learn about exposing your data, see [LightSwitch as a Data Source](../vs140/lightswitch-as-a-data-source.md).  
  
###  <a name="app"></a> Create an app for SharePoint  
 You can also create an app for SharePoint that users can install to and start from a SharePoint site. When you enable an app for SharePoint, you gain access to the SharePoint client object model (CSOM), which you can use to write code that works with assets on your SharePoint site. For example, you might write code that initiates a workflow in SharePoint when a value in your application has changed.  
  
 To learn about SharePoint-enabled LightSwitch apps, see [LightSwitch Apps for Sharepoint](../vs140/lightswitch-apps-for-sharepoint.md).  
  
###  <a name="help"></a> Get Some Help  
 The following topic contains some resources for getting help and learning more about LightSwitch: [Additional Resources](../vs140/additional-resources-for-developing-lightswitch-applications.md).  
  
## See Also  
 [LightSwitch Guided Tour](../vs140/lightswitch-guided-tour.md)