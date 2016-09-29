---
title: "How to: Register a Service"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "services, registering"
ms.assetid: d086be78-ec3c-43cc-b799-5180a71e19f1
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Register a Service
The managed package framework (MPF) provides attributes to control the registration of managed services. The RegPkg utility uses these attributes to register a service with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
## Example  
 The code that follows is from [Reference.Services (C#) sample](../vs140/vssdk-samples.md).  
  
 [!code[VSSDKRegisterService#1](../vs140/codesnippet/VisualBasic/how-to--register-a-service_1.vb)]
[!code[VSSDKRegisterService#1](../vs140/codesnippet/CSharp/how-to--register-a-service_1.cs)]  
  
 The <xref:Microsoft.VisualStudio.Shell.ProvideServiceAttribute*> registers the SMyGlobalService service with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. For more information about <xref:Microsoft.VisualStudio.Shell.DefaultRegistryRootAttribute*> and <xref:Microsoft.VisualStudio.Shell.PackageRegistrationAttribute*>, see [How to: Register a VSPackage (C#)](../vs140/registering-and-unregistering-vspackages.md).  
  
 To register a service that replaces another service with the same name, use the <xref:Microsoft.VisualStudio.Shell.ProvideServiceOverrideAttribute*> instead of the <xref:Microsoft.VisualStudio.Shell.ProvideServiceAttribute*>.  
  
## Robust Programming  
 To make it easier to recompile a service provider without changing the service client, or vice versa, you can define the service and its interfaces in a separate assembly module. The following code is from the IMyGlobalService.cs file in the Reference.Services (C#) sample.  
  
 [!code[VSSDKRegisterService#2](../vs140/codesnippet/VisualBasic/how-to--register-a-service_2.vb)]
[!code[VSSDKRegisterService#2](../vs140/codesnippet/CSharp/how-to--register-a-service_2.cs)]  
  
 The <xref:System.Runtime.InteropServices.ComVisibleAttribute*> is required to obtain the interface from unmanaged code.  
  
> [!NOTE]
>  Although you could use the same type or GUID for both the service and the interface, we recommend that you separate the two because a service can expose different interfaces.  
  
## See Also  
 [Registering VSPackages](assetId:///31e6050f-1457-4849-944a-a3c36b76f3dd)   
 [Service Essentials](../vs140/service-essentials.md)