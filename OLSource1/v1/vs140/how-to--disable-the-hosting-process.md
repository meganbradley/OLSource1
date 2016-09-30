---
title: "How to: Disable the Hosting Process"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "hosting process, disabling"
  - "vshost.exe, disabling the hosting process"
ms.assetid: 9157488d-737f-454b-8d8d-36f99de38bb0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Disable the Hosting Process
Calls to certain APIs can be affected when the hosting process is enabled. In these cases, it is necessary to disable the hosting process to return the correct results.  
  
### To disable the hosting process  
  
1.  Open an executable project in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. Projects that do not produce executables (for example, class library or service projects) do not have this option.  
  
2.  On the **Project** menu, click **Properties**.  
  
3.  Click the **Debug** tab.  
  
4.  Clear the **Enable the Visual Studio hosting process** check box.  
  
 When the hosting process is disabled, several debugging features are unavailable or experience decreased performance. For more information, see [Debugging and the Hosting Process](../vs140/debugging-and-the-hosting-process.md).  
  
 In general, when the hosting process is disabled:  
  
-   The time needed to begin debugging [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] applications increases.  
  
-   Design-time expression evaluation is unavailable.  
  
-   Partial trust debugging is unavailable.  
  
## See Also  
 [Debugging and the Hosting Process](../vs140/debugging-and-the-hosting-process.md)   
 [Hosting Process](../vs140/hosting-process--vshost.exe-.md)   
 [Builds During Application Development](assetId:///c9497d62-3b7b-4449-88e8-cf27acc9efe6)