---
title: "Troubleshooting LightSwitch Deployment"
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
  - "deployment troubleshooting [Visual Studio LightSwitch]"
ms.assetid: b5f27841-d8a3-4cae-af49-390e1b11bc7f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting LightSwitch Deployment
In this topic, you can learn about problems that may occur when you deploy a [!INCLUDE[smb_current_short](../VS_csharp/includes/smb_current_short_md.md)] applicationant the techniques that you can use to resolve those problems.  
  
> [!NOTE]
>  More information about deployment problems may be available on the [LightSwitch Forums](http://go.microsoft.com/fwlink/?LinkId=132604) on the MSDN website.  
  
## 2-tier Logon Fails and “There was a failure using the default RoleProvider” Is Displayed  
 When a newly installed application is opened, this error occurs if the application database has not been installed. If you selected the **Create a script file to install and configure the database** option on the **Specify Publishing Preference** page of the publish-application wizard, you must run the script to install the database before the application is run. You also must create the **Admin** user for the application.  
  
#### To fix this error  
  
1.  Complete the installation steps in the Install.htm file, which is located in the output folder that you specified when you published the application. The output folder also contains the Setup.exe file for the application.  
  
## See Also  
 [Deploying LightSwitch Applications](../VS_csharp/deploying-lightswitch-applications.md)   
 [Community: Connecting with Other LightSwitch Developers](../VS_csharp/community--connecting-with-other-lightswitch-developers.md)