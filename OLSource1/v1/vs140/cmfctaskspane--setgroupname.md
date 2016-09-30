---
title: "CMFCTasksPane::SetGroupName"
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
  - "CMFCTasksPane::SetGroupName"
  - "SetGroupName"
  - "CMFCTasksPane.SetGroupName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetGroupName method"
ms.assetid: d877cee9-c1a9-471e-8345-8cbd5d6c03c5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::SetGroupName
Sets a group name.  
  
## Syntax  
  
```  
BOOL SetGroupName(  
    int nGroup,  
    LPCTSTR lpszGroupName  
);  
```  
  
#### Parameters  
 [in] `nGroup`  
 Specifies the zero-based index of the group.  
  
 [in] `lpszGroupName`  
 Specifies the name of the group.  
  
## Return Value  
 `TRUE` if the group name was successfully set; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)