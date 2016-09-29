---
title: "How to: Change the Type of a LightSwitch Application"
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
  - "application type [Visual Studio LightSwitch]"
  - "deployment topology [Visual Studio LightSwitch]"
ms.assetid: e3667659-b19a-4881-8994-7ff330a5ad55
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Change the Type of a LightSwitch Application
By using LightSwitch, you can create 2-tier desktop applications, 3-tier desktop applications, and 3-tier Web applications. You can switch the application type for your LightSwitch application at any time.  
  
-   A 2-tier desktop application runs on an end-user Windows desktop. The database and server components are deployed to the end-user computer.  
  
-   A 3-tier desktop application runs on an end-user Windows desktop. The database and server components are deployed to an Internet Information Services (IIS) server or to Microsoft Azure.  
  
-   A 3-tier Web application runs in an end-user web browser. The database and server components are deployed to an Internet Information Services (IIS) server or to Microsoft Azure.  
  
### To change the application type  
  
1.  In **Solution Explorer**, choose the **ProjectName.DesktopClient** node, where *ProjectName* is the name of your project.  
  
2.  On the menu bar, choose **Project**, **ProjectName.DesktopClient Properties**.  
  
3.  In the **DesktopClient** designer, choose the **Client Type** tab.  
  
4.  Under **Client**, choose either the **Desktop** or **Web** option button.  
  
## See Also  
 [Deployment: Distributing and Maintaining Your Application](../VS_csharp/deployment--distributing-and-maintaining-your-application.md)   
 [Deploying LightSwitch Applications](../VS_csharp/deploying-lightswitch-applications.md)   
 [How to: Deploy a LightSwitch Application](../VS_csharp/how-to--deploy-a-two-tier-lightswitch-application.md)   
 [How to: Manage Application Settings](../VS_csharp/how-to--manage-application-settings-in-lightswitch.md)