---
title: "Differences Between Sandboxed and Farm Solutions"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, sandboxed solutions"
  - "sandboxed solutions [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, farm solutions"
  - "farm solutions [SharePoint development in Visual Studio]"
ms.assetid: 43beb7e7-0cd9-4a8f-bb72-6b1e0cba5be8
caps.latest.revision: 12
ms.author: "kempb"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Differences Between Sandboxed and Farm Solutions
  When you compile a SharePoint solution, it deploys to the SharePoint server and a debugger attaches to debug it. The process used to debug the solution depends on the setting of the Sandboxed Solution property: sandboxed solution or farm solution.  
  
 For more information, see [Sandboxed Solution Considerations](../VS_officedev/sandboxed-solution-considerations.md).  
  
## Farm Solutions  
 Farm solutions, which are hosted in the IIS worker process (W3WP.exe), run code that can affect the whole farm. When you debug a SharePoint project whose Sandboxed Solution property is set to "farm solution," the system's IIS application pool recycles before SharePoint retracts or deploys the feature so as to release any files locked by the IIS worker process. Only the IIS application pool serving the SharePoint project's site URL is recycled.  
  
## Sandboxed Solutions  
 Sandboxed solutions, which are hosted in the SharePoint user code solution worker process (SPUCWorkerProcess.exe), run code that can only affect the site collection of the solution. Because sandboxed solutions do not run in the IIS worker process, neither the IIS application pool nor the IIS server must restart. [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] attaches the debugger to the SPUCWorkerProcess process that the SPUserCodeV4 service in SharePoint automatically triggers and controls. It is not necessary for the SPUCWorkerProcess process to recycle to load the latest version of the solution.  
  
## Either Type of Solution  
 With either solution type, [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] also attaches the debugger to the browser to enable client-side script debugging. [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] uses the script debugging engine for this purpose. To enable script debugging, you must change the default browser settings when you are prompted.  
  
 [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] attaches the debugger only to the W3WP or SPUCWorkerProcess processes running the current site. [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] also attaches the managed COM Plus and workflow debugging engines.  
  
## See Also  
 [Debugging SharePoint Solutions](../VS_officedev/debugging-sharepoint-solutions.md)   
 [Building and Debugging SharePoint Solutions](../VS_officedev/building-and-debugging-sharepoint-solutions.md)   
 [Sandboxed Solution Considerations](../VS_officedev/sandboxed-solution-considerations.md)  
  
  