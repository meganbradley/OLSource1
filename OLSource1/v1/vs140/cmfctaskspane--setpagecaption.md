---
title: "CMFCTasksPane::SetPageCaption"
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
  - CMFCTasksPane::SetPageCaption
  - CMFCTasksPane.SetPageCaption
  - SetPageCaption
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetPageCaption method
ms.assetid: b67a497e-f788-4dfb-9b64-646f5c0ed976
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCTasksPane::SetPageCaption
Sets the caption text for a task pane page.  
  
## Syntax  
  
```  
void SetPageCaption(  
    int nPageIdx,  
    LPCTSTR lpszName  
);  
```  
  
#### Parameters  
 [in] `nPageIdx`  
 Specifies the zero-based index of the page.  
  
 [in] `lpszName`  
 Specifies the caption text to display on the page.  
  
## Remarks  
 If a task pane has multiple pages, the default page has the caption that was set by using this method.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)