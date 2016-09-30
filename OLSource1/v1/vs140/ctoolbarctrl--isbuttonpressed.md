---
title: "CToolBarCtrl::IsButtonPressed"
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
  - "CToolBarCtrl.IsButtonPressed"
  - "CToolBarCtrl::IsButtonPressed"
  - "IsButtonPressed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsButtonPressed method"
ms.assetid: 455b7e24-eb87-4cb3-be45-016e50bee4ad
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::IsButtonPressed
Determines whether the specified button in a toolbar control is pressed.  
  
## Syntax  
  
```  
  
      BOOL IsButtonPressed(  
   int nID   
) const;  
```  
  
#### Parameters  
 `nID`  
 Command identifier of the button in the toolbar.  
  
## Return Value  
 Nonzero if the button is pressed, otherwise zero.  
  
## Remarks  
 Consider calling [GetState](../vs140/ctoolbarctrl--getstate.md) if you want to retrieve more than one button state.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::PressButton](../vs140/ctoolbarctrl--pressbutton.md)   
 [CToolBarCtrl::GetState](../vs140/ctoolbarctrl--getstate.md)   
 [CToolBarCtrl::SetState](../vs140/ctoolbarctrl--setstate.md)   
 [CToolBarCtrl::IsButtonEnabled](../vs140/ctoolbarctrl--isbuttonenabled.md)   
 [CToolBarCtrl::IsButtonChecked](../vs140/ctoolbarctrl--isbuttonchecked.md)   
 [CToolBarCtrl::IsButtonHidden](../vs140/ctoolbarctrl--isbuttonhidden.md)   
 [CToolBarCtrl::IsButtonIndeterminate](../vs140/ctoolbarctrl--isbuttonindeterminate.md)   
 [CToolBarCtrl::IsButtonHighlighted](../vs140/ctoolbarctrl--isbuttonhighlighted.md)