---
title: "CMFCBaseTabCtrl::SetActiveTab"
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
  - "SetActiveTab"
  - "CMFCBaseTabCtrl.SetActiveTab"
  - "CMFCBaseTabCtrl::SetActiveTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetActiveTab method"
ms.assetid: 1c096034-2785-4002-a2a4-b0c81cb6dbc1
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::SetActiveTab
Activates the specified tab.  
  
## Syntax  
  
```  
virtual BOOL SetActiveTab(  
   int iTab  
) = 0;  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of a tab. `SetActiveTab` makes the tab with this index active.  
  
## Return Value  
 `TRUE` if successful; otherwise `FALSE`.  
  
## Remarks  
 In the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md), this method is a pure virtual function. If you derive a class from `CMFCBaseTabCtrl`, you have to implement this function.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)