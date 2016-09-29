---
title: "Projects: The Container for Your LightSwitch Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "projects [Visual Studio LightSwitch]"
ms.assetid: 773fe798-c373-463d-9fb8-86245c02817d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Projects: The Container for Your LightSwitch Application
You store and organize the pieces of your application by using projects in Visual Studio LightSwitch. Each application that you create has its own project, which contains the data entities, screens, queries, and resources that are required to build the application.  
  
 All these pieces are stored in files, but you don't have to think of a project in terms of files. In fact, the default view of a project in **Solution Explorer** provides a logical view of the application.  
  
## Project Types  
 You can create the following types of projects by using LightSwitch in [!INCLUDE[vs_dev12](../VS_csharp/includes/vs_dev12_md.md)]:  
  
|Project Template|Description|Uses New Solution Model|  
|----------------------|-----------------|-----------------------------|  
|LightSwitch Desktop Application (Visual Basic)|Creates an application with a Silverlight client, using Visual Basic code for both the server and client components.|No|  
|LightSwitch Desktop Application (Visual C#)|Creates an application with a Silverlight client, using C# code for both the server and client components.|No|  
|LightSwitch HTML Application (Visual Basic)|Creates an application with an HTML 5 client, using Visual Basic code for the server component and JavaScript code for the client component.|Yes|  
|LightSwitch HTML Application (Visual C#)|Creates an application with an HTML 5 client, using C# code for the server component and JavaScript code for the client component.|Yes|  
  
 The project template that you choose is just a starting point. You can add an HTML client to a **LightSwitch Desktop Application** project, and you can add a Silverlight client to a **Lightswitch HTML Application** project. The server code and entity model are shared between clients, and you can’t change the language.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[How to: Create, Open, Save, or Delete a Project](../VS_csharp/how-to--create--open--save--or-delete-a-lightswitch-project.md)|Describes common tasks for working with projects.|  
|[Managing Settings in LightSwitch](../VS_csharp/managing-settings-in-lightswitch.md)|Contains links to topics about how to set project properties.|  
|[Creating Secure Applications](../VS_csharp/security-considerations-for-lightswitch.md)|Describes security features and considerations.|  
|[How to: Create a Role-based Application](../VS_csharp/how-to--enable-authentication-in-a-silverlight-client-app.md)|Describes how to create an application that implements authentication and authorization.|  
|[Walkthrough: Localizing a LightSwitch Application](../VS_csharp/walkthrough--localizing-a-lightswitch-application.md)|Demonstrates how to create an application that supports multiple languages.|  
|[Exporting Data to Microsoft Excel](../VS_csharp/exporting-data-to-microsoft-excel.md)|Describes how to export data from an application.|  
|[Upgrading Projects Created in Earlier Versions of LightSwitch](../VS_csharp/upgrading-projects-created-in-earlier-versions-of-lightswitch.md)|Provides information about compatibility between versions of LightSwitch.|  
  
## See Also  
 [Visual Studio LightSwitch](../VS_csharp/visual-studio-lightswitch.md)