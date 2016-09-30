---
title: "CMFCBaseTabCtrl::GetTabTextColor"
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
  - "GetTabTextColor"
  - "CMFCBaseTabCtrl::GetTabTextColor"
  - "CMFCBaseTabCtrl.GetTabTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabTextColor method"
ms.assetid: ea560797-403c-4aeb-aef6-320364f70b47
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetTabTextColor
Retrieves the text color for the specified tab.  
  
## Syntax  
  
```  
virtual COLORREF GetTabTextColor(  
   int iTab  
) const;  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of the tab.  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the text color of the specified tab; -1 if `iTab` is out of range.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::SetTabTextColor](../vs140/cmfcbasetabctrl--settabtextcolor.md)