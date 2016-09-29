---
title: "Service Essentials"
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
  - "services, essentials"
ms.assetid: fbe84ad9-efe1-48b1-aba3-b50b90424d47
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Service Essentials
A service is a contract between two VSPackages. One VSPackage provides a specific set of interfaces for another VSPackage to consume. [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] is itself a collection of VSPackages that provides services to other VSPackages.  
  
 For example, you can use the SVsActivityLog service to obtain an IVsActivityLog interface, which you can use to write to the activity log. For more information, see [How to: Write to the Activity Log (C#)](../vs140/how-to--use-the-activity-log.md).  
  
 [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] also provides some built-in services which are not registered. VSPackages can replace built-in or other services by providing a service override. Only one service override is permitted for any service.  
  
 Services have no discoverability. Therefore, you must know the service identifier (SID) of a service that you want to consume, and you must know which interfaces it provides. The reference documentation for the service provides this information.  
  
-   VSPackages that provide services are called service providers.  
  
-   Services that are provided to other VSPackages are called global services.  
  
-   Services that are available only to the VSPackage that implements them, or to any object it creates, are called local services.  
  
-   Services that replace built-in services or services provided by other packages, are called service overrides.  
  
-   Services, or service overrides, are loaded on demand, that is, the service provider is loaded when the service it provides is requested by another VSPackage.  
  
-   To support on-demand loading, a service provider registers its global services with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. For more information, see [Registering Services](../vs140/registering-services.md).  
  
-   After you obtain a service, use [QueryInterface](../vs140/queryinterface.md) (unmanaged code) or casting (managed code) to get the desired interface, for example:  
  
    ```vb#  
    TryCast(GetService(GetType(SVsActivityLog)), IVsActivityLog)  
    ```  
  
    ```c#  
    GetService(typeof(SVsActivityLog)) as IVsActivityLog;  
  
    ```  
  
-   Managed code refers to a service by its type, whereas unmanaged code refers to a service by its GUID.  
  
-   When [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] loads a VSPackage, it passes a service provider to the VSPackage to give the VSPackage access to global services. This is referred to as "siting" the VSPackage.  
  
-   VSPackages can be service providers for the objects they create. For example, a form might send a request for a color service to its frame, which might pass the request to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
-   Managed objects that are deeply nested, or not sited at all, may call <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService*> for direct access to global services. For more information, see [How to: Use GetGlobalService](../vs140/how-to--use-getglobalservice.md).  
  
## See Also  
 [List of Available Services](../vs140/list-of-available-services.md)   
 [Services](../vs140/using-and-providing-services.md)   
 [Casting (C#)](../vs140/casting-and-type-conversions--csharp-programming-guide-.md)   
 [Casting (C++)](../vs140/casting.md)