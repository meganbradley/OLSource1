---
title: "CMFCBaseTabCtrl::GetTabRect"
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
  - "GetTabRect"
  - "CMFCBaseTabCtrl.GetTabRect"
  - "CMFCBaseTabCtrl::GetTabRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabRect method"
ms.assetid: 412d4e52-dbbf-4b8a-8174-6fb98e377af6
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetTabRect
Retrieves the size and position of the specified tab.  
  
## Syntax  
  
```  
virtual BOOL GetTabRect(  
   int iTab,  
   CRect& rect  
) const;  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of the tab.  
  
 [out] `rect`  
 A reference to a `CRect` object. This method stores the size and position of the tab in this parameter.  
  
## Return Value  
 `TRUE` if successful; `FALSE` if the tab index is invalid.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)