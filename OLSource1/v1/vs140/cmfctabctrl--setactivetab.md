---
title: "CMFCTabCtrl::SetActiveTab"
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
  - "CMFCTabCtrl::SetActiveTab"
  - "CMFCTabCtrl.SetActiveTab"
  - "SetActiveTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetActiveTab method"
ms.assetid: eb59aebd-74b9-4ffd-9d5e-ca6a7d6c667f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::SetActiveTab
Activates a tab.  
  
## Syntax  
  
```  
virtual BOOL SetActiveTab(  
   int iTab   
);  
```  
  
#### Parameters  
 [in] `iTab`  
 Specifies the zero-based index of the tab to activate.  
  
## Return Value  
 `TRUE` if the specified tab was made active; `FALSE` if the specified `iTab` parameter value is invalid.  
  
## Remarks  
 This method does not send the `AFX_WM_CHANGE_ACTIVE_TAB` notification to the parent window of the tab control.  
  
 The `SetActiveTab` method automatically calls the [CMFCTabCtrl::HideActiveWindowHorzScrollBar](../vs140/cmfctabctrl--hideactivewindowhorzscrollbar.md) method to prevent the screen from blinking.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)