---
title: "CToolBarCtrl::EnableButton"
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
  - "EnableButton"
  - "CToolBarCtrl.EnableButton"
  - "CToolBarCtrl::EnableButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableButton method"
ms.assetid: dc8ece3d-5794-4c76-adc0-e551d369d063
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::EnableButton
Enables or disables the specified button in a toolbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Command identifier of the button to enable or disable.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **TRUE** to enable the button; **FALSE** to disable the button.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 When a button has been enabled, it can be pressed and checked. If you want to change more than one button state, consider calling [SetState](../vs140/ctoolbarctrl--setstate.md) instead.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::IsButtonEnabled](../vs140/ctoolbarctrl--isbuttonenabled.md)   
 [CToolBarCtrl::CheckButton](../vs140/ctoolbarctrl--checkbutton.md)   
 [CToolBarCtrl::PressButton](../vs140/ctoolbarctrl--pressbutton.md)   
 [CToolBarCtrl::HideButton](../vs140/ctoolbarctrl--hidebutton.md)   
 [CToolBarCtrl::Indeterminate](../vs140/ctoolbarctrl--indeterminate.md)   
 [CToolBarCtrl::GetState](../vs140/ctoolbarctrl--getstate.md)   
 [CToolBarCtrl::SetState](../vs140/ctoolbarctrl--setstate.md)