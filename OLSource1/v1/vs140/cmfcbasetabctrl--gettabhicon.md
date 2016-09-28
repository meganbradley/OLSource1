---
title: "CMFCBaseTabCtrl::GetTabHicon"
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
  - "GetTabHicon"
  - "CMFCBaseTabCtrl::GetTabHicon"
  - "CMFCBaseTabCtrl.GetTabHicon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabHicon method"
ms.assetid: d915b667-1041-4f57-afac-0419671ee418
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetTabHicon
Returns the HICON associated with the specified tab.  
  
## Syntax  
  
```  
virtual HICON GetTabHicon(  
   int iTab  
) const;  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index for the tab.  
  
## Return Value  
 The HICON associated with a tab label if successful; `NULL` if there is no HICON or if the method fails.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::SetTabHicon](../vs140/cmfcbasetabctrl--settabhicon.md)