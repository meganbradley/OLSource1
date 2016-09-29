---
title: "LightSwitch Apps for SharePoint"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ls.EnableSharePoint"
ms.assetid: 6521b01f-15e2-4ea0-958e-6638ce839513
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LightSwitch Apps for SharePoint
By using LightSwitch, you can easily create an app for SharePoint that users can install to and start from a SharePoint site. Users are authenticated automatically based on their SharePoint identities and permissions. For more information about apps for SharePoint, see [Build apps for SharePoint](http://go.microsoft.com/fwlink/?LinkId=285362).  
  
 LightSwitch apps can be hosted in SharePoint 2013, either on your premises or at an external provider. Users discover and download apps from either the SharePoint Store or their organization's private app catalog and install them on their SharePoint sites.  
  
 When you enable an app for SharePoint, you gain access to the SharePoint client object model (CSOM), which you can use to write code that works with assets on your SharePoint site. For example, you might write code that initiates a workflow in SharePoint when a value in your app has changed. For more information about SharePoint client APIs, see [How to: Complete basic operations using SharePoint 2013 client library code](http://go.microsoft.com/fwlink/?LinkId=285361).  
  
 You can create either a Silverlight-based client or an HTML client for each LightSwitch app for SharePoint. If a LightSwitch project contains more than one type of client, you can’t enable the project for SharePoint.  
  
> [!NOTE]
>  You can also use the Cloud Business App project template in Visual Studio to create an app for SharePoint. Cloud Business Apps are automatically enabled for SharePoint, and only support an HTML client. See [Create Cloud Business Apps](http://msdn.microsoft.com/library/office/dn584076\(v=office.15\).aspx).  
  
## Enabling SharePoint  
 To create an app for SharePoint, you enable the SharePoint features in LightSwitch. This step adds a project and references to your solution that allow LightSwitch to communicate with SharePoint. When you debug your app, it’s deployed to the app web on SharePoint and then run locally in your browser.  
  
#### To enable an application for SharePoint  
  
1.  In **Solution Explorer**, choose the *Application* node (where *Application* is the name of your application).  
  
2.  On the menu bar, choose **Project**,  **Enable SharePoint**.  
  
3.  In the **Enabling SharePoint** wizard, enter the URL for your SharePoint site or the Office 365 Developer site, and then choose the **Finish** button.  
  
     The URL for an Office 365 Developer site should take the form https://*MySite*.sharepoint.com/sites/Developer/.  
  
     References to several SharePoint assemblies are added to your LightSwitch project, and a project for a SharePoint web app is added to the solution.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Walkthrough: Creating an App for SharePoint by using LightSwitch](../VS_csharp/walkthrough--creating-an-app-for-sharepoint-by-using-lightswitch.md)|Provides an end-to-end example of creating an app for SharePoint that's hosted on Office 365.|  
|[Walkthrough: Accessing a SharePoint Workflow from a LightSwitch Mobile App](assetId:///eff72039-ecf4-4836-acfa-6a79148fb388)|Demonstrates how to create a SharePoint workflow for a LightSwitch client app that's written in HTML.|  
|[How to: Enable SharePoint Social Feeds in a LightSwitch App](../VS_csharp/how-to--enable-sharepoint-social-feeds-in-a-lightswitch-app.md)|Describes how to enable social collaboration features in a LightSwitch App for SharePoint.|  
|[How to: associate a document library with an entity](http://msdn.microsoft.com/library/office/dn592160\(v=office.15\).aspx)|By using the document library feature in SharePoint, you can create or upload documents associated with individual items in a list or entity. For example, you might use a document library to store sales literature and product manuals for each product in a list.|  
|[How to: Host a LightSwitch HTML Client Application on Sharepoint](../VS_csharp/how-to--host-a-lightswitch-html-client-application-on-sharepoint.md)|HTML client apps are hosted on SharePoint for debugging and can also be published to a SharePoint site.|  
|[How to: Upgrade a SharePoint-enabled LightSwitch App](../VS_csharp/how-to--upgrade-a-sharepoint-enabled-lightswitch-app.md)|Autohosted SharePoint apps created in earlier versions of LightSwitch may need to be upgraded.|