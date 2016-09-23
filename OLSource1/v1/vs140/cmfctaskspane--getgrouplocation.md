---
title: "CMFCTasksPane::GetGroupLocation"
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
  - CMFCTasksPane::GetGroupLocation
  - CMFCTasksPane.GetGroupLocation
  - GetGroupLocation
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetGroupLocation method
ms.assetid: 29df134d-f648-49e3-8205-bb9087309024
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTasksPane::GetGroupLocation
Returns the internal group index for the specified group.  
  
## Syntax  
  
```  
BOOL GetGroupLocation(  
    CMFCTasksPaneTaskGroup* pGroup,  
    int& nGroup   
) const;  
```  
  
#### Parameters  
 [in] `pGroup`  
 Specifies the task group whose location is retrieved.  
  
 [out] `nGroup`  
 Contains the zero-based index of the task group.  
  
## Return Value  
 `TRUE` if the task group was found; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCTasksPane::GetTaskGroup](../vs140/cmfctaskspane--gettaskgroup.md)