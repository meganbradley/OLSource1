---
title: "How to: Configure a Server to Host LightSwitch Applications"
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
  - "ls.UseLightSwitchWebDeploymentProvider"
helpviewer_keywords: 
  - "hosting [Visual Studio LightSwitch]"
  - "application hosting [Visual Studio LightSwitch]"
  - "server configuration [Visual Studio LightSwitch]"
ms.assetid: ef1cdbec-8e4d-4014-ab54-03f1eb1e92ff
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Configure a Server to Host LightSwitch Applications
Before a server can host a three-tier LightSwitch application, you must install the LightSwitch server runtime and configure both Internet Information Services (IIS) and SQL Server.  
  
> [!NOTE]
>  SQL Server doesn’t have to be installed on the same server as IIS. They both must be installed, but they can be located on different servers.  
  
 You can use a Web Platform Installer feed to download and install any missing prerequisites, including IIS and SQL Server, and configure the server. Both IIS 7.0 and IIS 6.0 are supported; if IIS 6.0 is already installed, IIS 7.0 won’t be installed.  
  
## Install prerequisites  
 You’ll use the [Web Platform Installer](http://go.microsoft.com/fwlink/?LinkId=786550), which you can download from the Microsoft website, to install server prerequisites for LightSwitch.  
  
#### To install prerequisites  
  
1.  In **Web Platform Installer**, on the menu bar, choose **Products**, **Tools**.  
  
2.  In the search text box, enter `Hosting Servers`, and then choose the Enter key.  
  
3.  Choose the **Web Deploy 3.6 for Hosting Servers** list item (or a later version of Web Deploy, if available),  choose the **Add** button, and then choose the **Install** button.  
  
4.  If you agree to the license terms, choose the **I Accept** button.  
  
     The prerequisites will be installed, and the necessary settings will be configured. When the installation is complete, you can close Web Platform Installer and publish your application to the server.  
  
## See Also  
 [How to: Deploy a 3-tier Application](../VS_csharp/how-to--deploy-a-three-tier-lightswitch-application.md)   
 [Deploying LightSwitch Applications](../VS_csharp/deploying-lightswitch-applications.md)   
 [Deployment: Distributing and Maintaining Your Application](../VS_csharp/deployment--distributing-and-maintaining-your-application.md)