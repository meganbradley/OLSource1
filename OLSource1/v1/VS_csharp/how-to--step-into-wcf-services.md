---
title: "How to: Step into WCF Services"
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
  - "debugging, WCF"
  - "WCF, debugging"
ms.assetid: 9893ad01-54af-499f-85a6-9d1cfe6eb640
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Step into WCF Services
In [!INCLUDE[vs_dev11_long](../VS_csharp/includes/vs_dev11_long_md.md)], you can step into a WCF service. If the WCF service is in the same [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] solution as the client, you can hit breakpoints inside the WCF Service.  
  
 For stepping to work, you must have debugging enabled in the app.config or Web.config file. For information about how to enable debugging and for limitations on stepping into WCF services, see [Limitations on WCF Debugging](../VS_csharp/limitations-on-wcf-debugging.md).  
  
### To step into a WCF Service  
  
1.  Create a [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] solution that contains both the WCF client and WCF service projects.  
  
2.  In Solution Explorer, right-click the WCF Client project and then click **Set as Startup Project**.  
  
3.  Enable debugging in the app.config or web.config file. For more information, see [Limitations on WCF Debugging](../VS_csharp/limitations-on-wcf-debugging.md).  
  
4.  Set a breakpoint at the location in the client project where you want to start stepping. Typically, this will be just before the WCF service call.  
  
5.  Run to the breakpoint, then begin stepping. The debugger will step into the service automatically.  
  
## See Also  
 [Debugging WCF Services](../VS_csharp/debugging-wcf-services.md)   
 [Limitations on WCF Debugging](../VS_csharp/limitations-on-wcf-debugging.md)   
 [How to: Debug a Self-Hosted WCF Service](../VS_csharp/how-to--debug-a-self-hosted-wcf-service.md)