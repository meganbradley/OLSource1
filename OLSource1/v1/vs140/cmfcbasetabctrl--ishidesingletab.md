---
title: "CMFCBaseTabCtrl::IsHideSingleTab"
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
  - "CMFCBaseTabCtrl.IsHideSingleTab"
  - "IsHideSingleTab"
  - "CMFCBaseTabCtrl::IsHideSingleTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsHideSingleTab method"
ms.assetid: c5a65eda-5be4-4171-9491-722fc195e321
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::IsHideSingleTab
Determines whether the tab control hides the tab label if there is only one tab.  
  
## Syntax  
  
```  
virtual BOOL IsHideSingleTab() const;  
```  
  
## Return Value  
 `TRUE` if the tab control hides the tab label when it has one tab; otherwise `FALSE`.  
  
## Remarks  
 Use the method [CMFCBaseTabCtrl::HideSingleTab](../vs140/cmfcbasetabctrl--hidesingletab.md) to enable hiding the tab label when there is only one tab.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::HideSingleTab](../vs140/cmfcbasetabctrl--hidesingletab.md)