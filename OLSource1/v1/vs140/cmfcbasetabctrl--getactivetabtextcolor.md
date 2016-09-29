---
title: "CMFCBaseTabCtrl::GetActiveTabTextColor"
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
  - "CMFCBaseTabCtrl::GetActiveTabTextColor"
  - "CMFCBaseTabCtrl.GetActiveTabTextColor"
  - "GetActiveTabTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActiveTabTextColor method"
ms.assetid: 8f1ed372-bd39-43c7-87ab-5ecea455fa11
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetActiveTabTextColor
Retrieves the text color for the active tab.  
  
## Syntax  
  
```  
virtual COLORREF GetActiveTabTextColor() const;  
```  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that specifies the text color of the active tab.  
  
## Remarks  
 By default, the text color for active tabs is `COLOR_WINDOWTEXT`. You can change the text color with the method [CMFCBaseTabCtrl::SetActiveTabTextColor](../vs140/cmfcbasetabctrl--setactivetabtextcolor.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::SetActiveTabTextColor](../vs140/cmfcbasetabctrl--setactivetabtextcolor.md)