---
title: "CMFCBaseTabCtrl::GetTabByID"
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
  - "CMFCBaseTabCtrl.GetTabByID"
  - "CMFCBaseTabCtrl::GetTabByID"
  - "GetTabByID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabByID method"
ms.assetid: 45b4ca44-0c5a-4f2a-b217-4a8c2d99ce47
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetTabByID
Retrieves the index of a tab based on a tab ID.  
  
## Syntax  
  
```  
virtual int GetTabByID(  
   int id  
) const;  
```  
  
#### Parameters  
 [in] `id`  
 A tab ID.  
  
## Return Value  
 The zero-based index of a tab if it is found; -1 if the tab ID is not found.  
  
## Remarks  
 The tab IDs are assigned automatically when tabs are added to a tab control.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)