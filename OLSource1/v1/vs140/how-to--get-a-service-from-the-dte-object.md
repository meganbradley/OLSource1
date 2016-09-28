---
title: "How to: Get a Service from the DTE Object"
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
  - "services, from the DTE object"
ms.assetid: c26a51d4-86f0-454b-9625-5443e55eec7d
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Get a Service from the DTE Object
A service can be obtained from any program that has access to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Automation <xref:EnvDTE.DTEClass*> object. For example, you can access the <xref:Microsoft.VisualStudio.Shell.Interop.SVsActivityLog*> service from a wizard through the DTE object. You can use this service to write to the activity log. For more information, see [How to: Write to the Activity Log (C#)](../vs140/how-to--use-the-activity-log.md).  
  
 The DTE object implements <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider*>, which you can use to query for a service from managed code by using [GetService](assetId:///M:Microsoft.VisualStudio.Shell.ServiceProvider.GetService(System.Type)?qualifyHint=False&autoUpgrade=True).  
  
### To get a service from the DTE object  
  
1.  The following code creates a <xref:Microsoft.VisualStudio.Shell.ServiceProvider*> from the DTE object and calls assetId:///M:Microsoft.VisualStudio.Shell.ServiceProvider.GetService(System.Type)?qualifyHint=False&autoUpgrade=True with the type of the <xref:Microsoft.VisualStudio.Shell.Interop.SVsActivityLog*> service. The service is cast to the interface <xref:Microsoft.VisualStudio.Shell.Interop.IVsActivityLog*>, which is used to write an entry in the activity log. For more information abou how to write to the activity log, see [How to: Write to the Activity Log (C#)](../vs140/how-to--use-the-activity-log.md).  
  
     [!code[GetAServiceFromTheDTEObject#1](../vs140/codesnippet/CSharp/how-to--get-a-service-from-the-dte-object_1.cs)][!code[GetAServiceFromTheDTEObject#1](../vs140/codesnippet/VisualBasic/how-to--get-a-service-from-the-dte-object_1.vb)]  
  
## See Also  
 [Services](../vs140/using-and-providing-services.md)   
 [Service Essentials](../vs140/service-essentials.md)