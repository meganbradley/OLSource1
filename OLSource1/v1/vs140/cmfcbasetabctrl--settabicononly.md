---
title: "CMFCBaseTabCtrl::SetTabIconOnly"
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
  - "SetTabIconOnly"
  - "CMFCBaseTabCtrl::SetTabIconOnly"
  - "CMFCBaseTabCtrl.SetTabIconOnly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTabIconOnly method"
ms.assetid: c374c77b-a6ee-44f9-9700-546a8cb2d4e4
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::SetTabIconOnly
Enables displaying only an icon (and no text label) on a specific tab.  
  
## Syntax  
  
```  
virtual BOOL SetTabIconOnly(  
   int iTab,  
   BOOL bIconOnly = TRUE,  
   BOOL bShowTooltipAlways = FALSE  
);  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of the tab to change.  
  
 [in] `bIconOnly`  
 A Boolean parameter that determines whether to display only icons.  
  
 [in] `bShowTooltipAlways`  
 A Boolean parameter that determines whether the framework shows tooltips for a tab label that displays only icons.  
  
## Return Value  
 `TRUE` if successful; otherwise `FALSE`.  
  
## Remarks  
 By default, a tab control displays the icon and text label for each tab.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)