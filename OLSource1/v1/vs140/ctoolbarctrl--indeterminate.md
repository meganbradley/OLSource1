---
title: "CToolBarCtrl::Indeterminate"
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
  - "CToolBarCtrl.Indeterminate"
  - "CToolBarCtrl::Indeterminate"
  - "Indeterminate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Indeterminate method"
ms.assetid: 5b47e478-0779-4332-add1-4f163ed2adbb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::Indeterminate
Sets or clears the indeterminate state of the specified button in a toolbar control.  
  
## Syntax  
  
```  
  
      BOOL Indeterminate(  
   int nID,  
   BOOL bIndeterminate = TRUE   
);  
```  
  
#### Parameters  
 `nID`  
 Command identifier of the button whose indeterminate state is to be set or cleared.  
  
 *bIndeterminate*  
 **TRUE** to set the indeterminate state for the specified button, **FALSE** to clear it.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 Indeterminate buttons are displayed grayed, such as the way the bold button on the toolbar of a word processor would look when the text selected contains both bold and regular characters. If you want to change more than one button state, consider calling [SetState](../vs140/ctoolbarctrl--setstate.md) instead.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md)   
 [CToolBarCtrl::IsButtonIndeterminate](../vs140/ctoolbarctrl--isbuttonindeterminate.md)   
 [CToolBarCtrl::EnableButton](../vs140/ctoolbarctrl--enablebutton.md)   
 [CToolBarCtrl::CheckButton](../vs140/ctoolbarctrl--checkbutton.md)   
 [CToolBarCtrl::PressButton](../vs140/ctoolbarctrl--pressbutton.md)   
 [CToolBarCtrl::HideButton](../vs140/ctoolbarctrl--hidebutton.md)   
 [CToolBarCtrl::GetState](../vs140/ctoolbarctrl--getstate.md)   
 [CToolBarCtrl::SetState](../vs140/ctoolbarctrl--setstate.md)