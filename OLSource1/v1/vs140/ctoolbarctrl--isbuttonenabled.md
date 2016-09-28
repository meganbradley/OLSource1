---
title: "CToolBarCtrl::IsButtonEnabled"
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
  - "CToolBarCtrl.IsButtonEnabled"
  - "IsButtonEnabled"
  - "CToolBarCtrl::IsButtonEnabled"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsButtonEnabled method"
ms.assetid: ea16aba1-ffd1-4683-817e-f60270c698d8
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::IsButtonEnabled
Determines whether the specified button in a toolbar control is enabled.  
  
## Syntax  
  
```  
  
      BOOL IsButtonEnabled(  
   int nID   
) const;  
```  
  
#### Parameters  
 `nID`  
 Command identifier of the button in the toolbar.  
  
## Return Value  
 Nonzero if the button is enabled; otherwise zero.  
  
## Remarks  
 Consider calling [GetState](../vs140/ctoolbarctrl--getstate.md) if you want to retrieve more than one button state.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::EnableButton](../vs140/ctoolbarctrl--enablebutton.md)   
 [CToolBarCtrl::GetState](../vs140/ctoolbarctrl--getstate.md)   
 [CToolBarCtrl::SetState](../vs140/ctoolbarctrl--setstate.md)   
 [CToolBarCtrl::IsButtonChecked](../vs140/ctoolbarctrl--isbuttonchecked.md)   
 [CToolBarCtrl::IsButtonPressed](../vs140/ctoolbarctrl--isbuttonpressed.md)   
 [CToolBarCtrl::IsButtonHidden](../vs140/ctoolbarctrl--isbuttonhidden.md)   
 [CToolBarCtrl::IsButtonIndeterminate](../vs140/ctoolbarctrl--isbuttonindeterminate.md)   
 [CToolBarCtrl::IsButtonHighlighted](../vs140/ctoolbarctrl--isbuttonhighlighted.md)