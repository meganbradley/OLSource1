---
title: "Using and Providing Services"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "examples [Visual Studio SDK], services"
  - "Visual Studio, services"
  - "services"
ms.assetid: c0b415ba-b825-4da0-9faf-8a60a663e302
caps.latest.revision: 45
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Using and Providing Services
A service is a contract between two VSPackages. One VSPackage offers a specific set of interfaces for another VSPackage to consume. For example, [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] offers the <xref:Microsoft.VisualStudio.Shell.Interop.SVsActivityLog*> service to any VSPackage it loads. This service provides the <xref:Microsoft.VisualStudio.Shell.Interop.IVsActivityLog*> interface, which can be used to write to the activity log. For more information, see [How to: Write to the Activity Log (C#)](../VS_csharp/how-to--use-the-activity-log.md).  
  
 VSPackages can offer services of their own by using the <xref:Microsoft.VisualStudio.Shell.Interop.IProfferService*> interface..  
  
 Visual Studio offers important services, such as the following:  
  
|IDE service|Description|  
|-----------------|-----------------|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsShell*>|Provides access to IDE services dealing with basic functionality, VSPackages, and the registry.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell*>|Provides basic windowing and UI-related functionality in the IDE, such as the ability to create tools and document windows.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsSolution*>|Provides basic solution-related functionality, such as the ability to enumerate projects, create new projects, and monitor project changes.|  
  
## In This Section  
 [Service Essentials](../VS_csharp/service-essentials.md)  
 Presents the important elements of a Visual Studio service.  
  
 [How to: Consume a Service (C#)](../VS_csharp/how-to--get-a-service.md)  
 Discusses how to request (consume) a service.  
  
 [How to: Provide a Service (C#)](../VS_csharp/how-to--provide-a-service.md)  
 Discusses how to provide a service.  
  
 [How to: Provide an Asynchronous Visual Studio Service](../VS_csharp/how-to--provide-an-asynchronous-visual-studio-service.md)  
 Discusses how to provide an asynchronous service.  
  
 [How to: Troubleshoot Services](../VS_csharp/how-to--troubleshoot-services.md)  
 Discusses common problems and presents solutions to them.  
  
## Related Sections  
 [Visual Studio SDK](../VS_csharp/visual-studio-sdk.md)