---
title: "-APPCONTAINER"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/APPCONTAINER"
f1_keywords: 
  - "/APPCONTAINER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "APPCONTAINER editbin option"
  - "-APPCONTAINER editbin option"
  - "/APPCONTAINER editbin option"
ms.assetid: 0ca4f1ec-c8de-4a37-b3e2-deda7af0bb88
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -APPCONTAINER
Marks an executable that must run in an app container—for example, a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] or Universal Windows app.  
  
```  
  
/APPCONTAINER[:NO]  
```  
  
## Remarks  
 An executable that has the **/APPCONTAINER** option set can only be run in an app container, which is the process-isolation environment introduced in Windows 8. For [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] and Universal Windows apps, this option must be set.  
  
## See Also  
 [EDITBIN Options](../vs140/editbin-options.md)   
 [What's a Universal Windows App?](http://go.microsoft.com/fwlink/p/?LinkID=522074)