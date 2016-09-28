---
title: "CDockingManager::EnableAutoHidePanes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "EnableAutoHidePanes"
  - "CDockingManager::EnableAutoHidePanes"
  - "CDockingManager.EnableAutoHidePanes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableAutoHidePanes method"
ms.assetid: ba7d4fd2-c865-4a07-812f-d92276f1e343
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::EnableAutoHidePanes
Enables docking of the pane to the main frame, creates a dock pane, and adds it to the list of control bars.  
  
## Syntax  
  
```  
BOOL EnableAutoHidePanes(  
   DWORD dwStyle  
);  
```  
  
#### Parameters  
 [in] `dwStyle`  
 The docking alignment.  
  
## Return Value  
 `TRUE` if the dock pane was created successfully; `FALSE` otherwise.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)