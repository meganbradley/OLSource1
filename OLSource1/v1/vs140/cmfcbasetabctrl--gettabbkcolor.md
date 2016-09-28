---
title: "CMFCBaseTabCtrl::GetTabBkColor"
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
  - "GetTabBkColor"
  - "CMFCBaseTabCtrl::GetTabBkColor"
  - "CMFCBaseTabCtrl.GetTabBkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabBkColor method"
ms.assetid: 1a7da8f8-1b92-4ca0-973a-f984bcce0eb5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetTabBkColor
Retrieves the background color of the specified tab.  
  
## Syntax  
  
```  
virtual COLORREF GetTabBkColor(  
   int iTab  
) const;  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of the tab.  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that indicates the background color of the specified tab; -1 if `iTab` is out of range.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)