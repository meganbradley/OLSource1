---
title: "CToolBarCtrl::HideButton"
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
  - "HideButton"
  - "CToolBarCtrl.HideButton"
  - "CToolBarCtrl::HideButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HideButton method"
ms.assetid: 0fcac56f-4437-49df-972d-23325b153edc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::HideButton
Hides or shows the specified button in a toolbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Command identifier of the button to hide or show.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **TRUE** to hide the button, **FALSE** to show it.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 If you want to change more than one button state, consider calling [SetState](../vs140/ctoolbarctrl--setstate.md) instead.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::IsButtonHidden](../vs140/ctoolbarctrl--isbuttonhidden.md)   
 [CToolBarCtrl::EnableButton](../vs140/ctoolbarctrl--enablebutton.md)   
 [CToolBarCtrl::CheckButton](../vs140/ctoolbarctrl--checkbutton.md)   
 [CToolBarCtrl::PressButton](../vs140/ctoolbarctrl--pressbutton.md)   
 [CToolBarCtrl::Indeterminate](../vs140/ctoolbarctrl--indeterminate.md)   
 [CToolBarCtrl::GetState](../vs140/ctoolbarctrl--getstate.md)   
 [CToolBarCtrl::SetState](../vs140/ctoolbarctrl--setstate.md)