---
title: "CMFCBaseTabCtrl::IsTabIconOnly"
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
  - "IsTabIconOnly"
  - "CMFCBaseTabCtrl.IsTabIconOnly"
  - "CMFCBaseTabCtrl::IsTabIconOnly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsTabIconOnly method"
ms.assetid: 9dbaf623-a35a-4980-a184-3621b63fd73d
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::IsTabIconOnly
Determines whether a tab label contains only icons and no text.  
  
## Syntax  
  
```  
virtual BOOL IsTabIconOnly(  
   int iTab  
) const;  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of the tab.  
  
## Return Value  
 `TRUE` if a tab label has only icons; `FALSE` otherwise.  
  
## Remarks  
 To set the tabs in your application to display only icons, call the method [CMFCBaseTabCtrl::SetTabIconOnly](../vs140/cmfcbasetabctrl--settabicononly.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::SetTabIconOnly](../vs140/cmfcbasetabctrl--settabicononly.md)