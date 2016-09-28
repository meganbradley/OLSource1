---
title: "CMFCTasksPane::GetPageByGroup"
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
  - "GetPageByGroup"
  - "CMFCTasksPane.GetPageByGroup"
  - "CMFCTasksPane::GetPageByGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPageByGroup method"
ms.assetid: d164b805-7231-4072-ae61-c35e5ed004f5
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::GetPageByGroup
Retrieves the page index for a specified group.  
  
## Syntax  
  
```  
BOOL GetPageByGroup(  
    int nGroup,  
    int& nPage  
) const;  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the zero-based index of the task group.  
  
 [out] `nPage`  
 Contains the page index for the specified group. If the task group only contains a default page, the returned value is 0.  
  
## Return Value  
 `TRUE` if the group `nGroup` exists; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)