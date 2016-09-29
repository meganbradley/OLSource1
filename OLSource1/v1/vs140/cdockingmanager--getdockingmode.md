---
title: "CDockingManager::GetDockingMode"
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
  - "GetDockingMode"
  - "CDockingManager::GetDockingMode"
  - "CDockingManager.GetDockingMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDockingMode method"
ms.assetid: df5929f5-90a2-4b85-b6a2-5b3c52055cdb
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::GetDockingMode
Returns the current docking mode.  
  
## Syntax  
  
```  
static AFX_DOCK_TYPE GetDockingMode();  
```  
  
## Return Value  
 An enumerator value that represents the current docking mode. It can be one of the following values:  
  
-   `DT_STANDARD`  
  
-   `DT_IMMEDIATE`  
  
-   `DT_SMART`  
  
## Remarks  
 To set the docking mode, call [CDockingManager::SetDockingMode](../vs140/cdockingmanager--setdockingmode.md).  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)