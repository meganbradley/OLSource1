---
title: "CMFCTasksPane::CollapseGroup"
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
  - "CMFCTasksPane::CollapseGroup"
  - "CollapseGroup"
  - "CMFCTasksPane.CollapseGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CollapseGroup method"
ms.assetid: dd28a041-649b-44e9-bfe1-c10568f16c50
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::CollapseGroup
Collapses or expands a group.  
  
## Syntax  
  
```  
BOOL CollapseGroup(  
    CMFCTasksPaneTaskGroup* pGroup,  
    BOOL bCollapse = TRUE  
);  
BOOL CollapseGroup(  
    int nGroup,  
    BOOL bCollapse = TRUE  
);  
```  
  
#### Parameters  
 [in] `pGroup`  
 Specifies the group to collapse.  
  
 [in] `bCollapse`  
 `TRUE` to collapse the group; `FALSE` to expand the group.  
  
 [in] `nGroup`  
 Specifies the zero-based index of the group to collapse in the internal list of groups.  
  
## Return Value  
 `TRUE` if the group collapses or expands successfully; otherwise, `FALSE`.  
  
## Remarks  
 A collapsed group shows only the group caption; the list of tasks is hidden.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)