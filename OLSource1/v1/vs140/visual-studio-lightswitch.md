---
title: "Visual Studio LightSwitch"
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
  - "lightswitchstart"
helpviewer_keywords: 
  - "Visual Studio LightSwitch"
  - "LightSwitch [Visual Studio]"
ms.assetid: 2021a2cf-f684-493f-8d1b-4cdf39bc6eb3
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual Studio LightSwitch
You can build business applications quickly by using the Visual Studio LightSwitch development tool. LightSwitch provides a simplified development environment so that you can concentrate on the business logic instead of the application infrastructure.  
  
## Introducing Lightswitch  
 Most business applications are forms-over-data applications that provide a UI for viewing, adding, and modifying data. When you use other development tools to build forms-over-data applications, much of your time is spent on repetitive tasks. You write code to interact with a database, you write code for the user interface, and you write code for the business logic. When you use LightSwitch, much of the repetitive work is done for you and, in fact, you can create a LightSwitch application without writing any code at all! For most applications, the only code you have to write is the code that only you can write: the business logic.  
  
### Features of Business Applications  
 Modern business applications require many features, such as search capabilities, the ability to sort and rearrange grids, and the ability to export data.  LightSwitch applications have those features, and more, already built in. In addition, typical data operations such as adding, updating, saving, and deleting are also built in, as is basic data validation logic.  
  
 By using the extensibility features in LightSwitch, you can change the appearance of your applications by applying themes, by using custom controls, and by using shell extensions to change the layout. You can use the custom business types to reduce the amount of code that you write and to simplify formatting in the user interface.  
  
### Data Entities and Screens  
 LightSwitch simplifies the development of business applications by using *data entities* and *screens*.  
  
 Data entities, or tables, are how LightSwitch represents data. You create data entities by using the built-in application database, or by importing data from an external database, a SharePoint list, or other data source. You can create relationships between entities, even when entities are from different data sources. You can also create queries over the data by using a graphical designer, and you can further modify the queries in code.  
  
 Screens, or forms, are how LightSwitch displays data. Screens are based on predefined templates. All you have to do to bind data to a screen is specify the entities or queries to be displayed. After you create a screen, you can modify its appearance in the designer; no code is required. You can create screens that are optimized for the desktop, for web browsers, or for mobile devices such as tablets or phones.  
  
### Data Validation, Testing, and Deployment  
 You can handle basic validation in the IDE by using required fields and string lengths. For more complex validation based on business logic, you have to write code. At run time, the user interface to handle validation is built into the screens.  
  
 To test your application, just run it. You can change the user interface directly in the running application. By impersonating a role under debug permissions, you can test authentication and authorization. When your application is complete, you can deploy it to an individual computer, to Internet Information Services (IIS), Microsoft Azure, SharePoint, or Office 365.  
  
### System Requirements  
 You must install the following technologies to run a LightSwitch application:  
  
|||||  
|-|-|-|-|  
|**Prerequisite**|Server Tier|Silverlight Client|HTML Client|  
|.NET Framework 4|Yes|No|No|  
|Silverlight 5|No|Yes|No|  
  
## Related Topics  
  
|[Exploring LightSwitch Architecture](http://go.microsoft.com/fwlink/?LinkId=288853)|Describes the architecture of LightSwitch applications.|  
|-----------------------------------------------------------------------------------------|-------------------------------------------------------------|  
|[Getting Started with LightSwitch](../vs140/getting-started-with-lightswitch.md)|Provides links to introductory and learning topics.|  
|[LightSwitch as a Data Source](../vs140/lightswitch-as-a-data-source.md)|Describes how to access and consume the OData feeds created by LightSwitch.|  
|[LightSwitch Apps for SharePoint](../vs140/lightswitch-apps-for-sharepoint.md)|Describes how to create and deploy apps for SharePoint.|  
|[Projects: The Container for Your Application](../vs140/projects--the-container-for-your-lightswitch-application.md)|Describes basic tasks for working with projects.|  
|[Data and Entities: The Information Behind Your Application](../vs140/data--the-information-behind-your-application.md)|Describes the Entity Designer and related tasks.|  
|[Screens: What the User Sees](../vs140/screens--the-user-interface-of-your-lightswitch-application.md)|Describes the Screen Designer and related tasks.|  
|[Queries: Retrieving Information From a Data Source](../vs140/queries--retrieving-information-from-a-data-source.md)|Describes the Query Designer and related tasks.|  
|[Debugging: Finding and Fixing Errors](../vs140/debugging--finding-and-fixing-errors.md)|Describes basic tasks for debugging an application.|  
|[Extensions: Adding New Capabilities to LightSwitch](../vs140/extensions--adding-new-capabilities-to-lightswitch.md)|Describes tasks related to extensions.|  
|[Deployment: Distributing and Maintaining Your Application](../vs140/deployment--distributing-and-maintaining-your-application.md)|Describes basic tasks for deploying an application.|