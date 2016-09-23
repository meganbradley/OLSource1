---
title: "CMFCTasksPane::EnableGroupCollapse"
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
  - CMFCTasksPane.EnableGroupCollapse
  - CMFCTasksPane::EnableGroupCollapse
  - EnableGroupCollapse
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnableGroupCollapse method
ms.assetid: 3eef7be1-7f0d-4b06-a650-86f35452a5ae
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTasksPane::EnableGroupCollapse
Specifies whether a user can collapse task groups.  
  
## Syntax  
  
```  
void EnableGroupCollapse(  
    BOOL bEnable  
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` if users can collapse task groups; otherwise, `FALSE`.  
  
## Remarks  
 A task group that is collapsed displays only the group caption; the list of tasks is hidden.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)