---
title: "CMFCTasksPane::SetActivePage"
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
  - "CMFCTasksPane::SetActivePage"
  - "CMFCTasksPane.SetActivePage"
  - "SetActivePage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetActivePage method"
ms.assetid: 61a86e1f-931f-4a92-af4c-82801ebaae8a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::SetActivePage
Makes the specified page in the task pane active.  
  
## Syntax  
  
```  
void SetActivePage(  
    int nPageIdx  
);  
```  
  
#### Parameters  
 [in] `nPageIdx`  
 Specifies the zero-based index of the page to display.  
  
## Remarks  
 This method asserts if the `nPageIdx` is invalid.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)