---
title: "Prerequistes for Remote Debugging Web Applications"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging ASP.NET Web applications, remote servers"
  - "remote debugging, prerequisites"
  - "remote servers, debugging Web applications"
ms.assetid: 1cd777b5-6d20-4ca6-a0df-51653b118469
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Prerequistes for Remote Debugging Web Applications
With the [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] debugger, you can debug a Web application transparently on the local computer or a remote server. This means that the debugger functions the same way and allows you to use the same features on either computer. For remote debugging to work correctly, however, there are some prerequisites.  
  
-   [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] remote debugging components must be installed on the server you want to debug. For more information, see [Setting Up Remote Debugging](../Topic/Set%20Up%20the%20Remote%20Tools%20on%20the%20Device.md).  
  
-   By default, the [!INCLUDE[vstecasp](../VS_csharp/includes/vstecasp_md.md)] worker process runs as an ASPNET user process. As a result, you must have Administrator privileges on the computer where [!INCLUDE[vstecasp](../VS_csharp/includes/vstecasp_md.md)] runs to debug it. The name of the [!INCLUDE[vstecasp](../VS_csharp/includes/vstecasp_md.md)] worker process varies by debug scenario and version of IIS. For more information, see [How to: Find the Name of the ASP.NET Process](../VS_csharp/how-to--find-the-name-of-the-asp.net-process.md).  
  
## See Also  
 [Debugging ASP.NET and AJAX Applications](../VS_csharp/debugging-asp.net-and-ajax-applications.md)   
 [ASP.NET Debugging: System Requirements](../VS_csharp/asp.net-debugging--system-requirements.md)