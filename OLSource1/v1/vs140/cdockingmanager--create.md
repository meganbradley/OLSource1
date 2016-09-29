---
title: "CDockingManager::Create"
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
  - "CDockingManager::Create"
  - "Create"
  - "CDockingManager.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 491f54d8-2b2c-4f3c-8433-78471112c536
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::Create
Creates a docking manager.  
  
## Syntax  
  
```  
BOOL Create(  
   CFrameWnd* pParentWnd  
);  
```  
  
#### Parameters  
 [in] `pParentWnd`  
 A pointer to the parent frame of the docking manager. This value must not be `NULL`.  
  
## Return Value  
 `TRUE` always.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)