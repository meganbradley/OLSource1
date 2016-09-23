---
title: "CDockingManager::IsOLEContainerMode"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDockingManager.IsOLEContainerMode
  - IsOLEContainerMode
  - CDockingManager::IsOLEContainerMode
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsOLEContainerMode method
ms.assetid: fa75d58c-d592-4359-a0fa-10fff5a9ce3d
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockingManager::IsOLEContainerMode
Specifies whether the docking manager is in OLE container mode.  
  
## Syntax  
  
```  
BOOL IsOLEContainerMode() const;  
```  
  
## Return Value  
 `TRUE` if the docking manager is in OLE container mode; otherwise, `FALSE`.  
  
## Remarks  
 In OLE container mode, all docking panes and application toolbars are hidden. The panes are also hidden in this mode if you have set [CDockingManager::m_bHideDockingBarsInContainerMode](../vs140/cdockingmanager--m_bhidedockingbarsincontainermode.md) to `TRUE`.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)