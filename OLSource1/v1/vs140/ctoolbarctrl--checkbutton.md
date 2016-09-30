---
title: "CToolBarCtrl::CheckButton"
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
  - "CheckButton"
  - "CToolBarCtrl.CheckButton"
  - "CToolBarCtrl::CheckButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CheckButton method"
ms.assetid: 74d1a6c8-7400-4322-aa95-c2729df74083
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::CheckButton
Checks or clears a given button in a toolbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Command identifier of the button to check or clear.  
  
 *bCheck*  
 **TRUE** to check the button, **FALSE** to clear it.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 When a button has been checked, it appears to have been pressed. If you want to change more than one button state, consider calling [SetState](../vs140/ctoolbarctrl--setstate.md) instead.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::IsButtonChecked](../vs140/ctoolbarctrl--isbuttonchecked.md)   
 [CToolBarCtrl::EnableButton](../vs140/ctoolbarctrl--enablebutton.md)   
 [CToolBarCtrl::PressButton](../vs140/ctoolbarctrl--pressbutton.md)   
 [CToolBarCtrl::HideButton](../vs140/ctoolbarctrl--hidebutton.md)   
 [CToolBarCtrl::Indeterminate](../vs140/ctoolbarctrl--indeterminate.md)   
 [CToolBarCtrl::GetState](../vs140/ctoolbarctrl--getstate.md)   
 [CToolBarCtrl::SetState](../vs140/ctoolbarctrl--setstate.md)