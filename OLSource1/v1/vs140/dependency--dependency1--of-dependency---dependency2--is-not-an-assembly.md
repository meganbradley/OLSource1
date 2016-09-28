---
title: "Dependency &#39;dependency1&#39; of dependency &#39; dependency2&#39; is not an assembly"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.tasklisterror.notcomplusassembly2"
ms.assetid: e3b96601-458e-40de-81ea-ddcae9b42996
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dependency &#39;dependency1&#39; of dependency &#39; dependency2&#39; is not an assembly
The project system has determined that a particular dependency (dependency1) of an assembly (dependency2) is not a .NET assembly.  
  
 **To correct this error**  
  
-   Reinstall [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] (if the assembly came with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] or the .NET Framework).  
  
     \- or -  
  
-   Reinstall the appropriate third-party control.  
  
     This error will not prevent the project from building. However, a run-time error is possible.  
  
## See Also  
 [Troubleshooting Broken References](../vs140/troubleshooting-broken-references.md)   
 [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](assetId:///3bd75d61-f00c-47c0-86a2-dd1f20e231c9)   
 [Assemblies in the Common Language Runtime](assetId:///33a0bc6a-6bb3-44c7-ada7-4a046e8c0945)