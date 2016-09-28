---
title: "CToolBarCtrl::SetState"
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
  - "CToolBarCtrl.SetState"
  - "CToolBarCtrl::SetState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetState method"
ms.assetid: 8497e6ec-7b8c-4077-a51c-2d7d86602a64
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetState
Sets the state for the specified button in a toolbar control.  
  
## Syntax  
  
```  
  
      BOOL SetState(  
   int nID,  
   UINT nState   
);  
```  
  
#### Parameters  
 `nID`  
 Command identifier of the button.  
  
 `nState`  
 State flags. It can be a combination of the values listed for button states in [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md).  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 This function is especially handy if you want to set more than one of the button states. To just set one state, use one of the following member functions: [EnableButton](../vs140/ctoolbarctrl--enablebutton.md), [CheckButton](../vs140/ctoolbarctrl--checkbutton.md), [HideButton](../vs140/ctoolbarctrl--hidebutton.md), [Indeterminate](../vs140/ctoolbarctrl--indeterminate.md), or [PressButton](../vs140/ctoolbarctrl--pressbutton.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetState](../vs140/ctoolbarctrl--getstate.md)   
 [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md)   
 [CToolBarCtrl::EnableButton](../vs140/ctoolbarctrl--enablebutton.md)   
 [CToolBarCtrl::CheckButton](../vs140/ctoolbarctrl--checkbutton.md)   
 [CToolBarCtrl::HideButton](../vs140/ctoolbarctrl--hidebutton.md)   
 [CToolBarCtrl::Indeterminate](../vs140/ctoolbarctrl--indeterminate.md)   
 [CToolBarCtrl::PressButton](../vs140/ctoolbarctrl--pressbutton.md)