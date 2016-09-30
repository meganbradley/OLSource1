---
title: "CToolBarCtrl::IsButtonIndeterminate"
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
  - "CToolBarCtrl.IsButtonIndeterminate"
  - "CToolBarCtrl::IsButtonIndeterminate"
  - "IsButtonIndeterminate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsButtonIndeterminate method"
ms.assetid: 5e51d32b-3278-4c2d-b107-655555359ca6
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::IsButtonIndeterminate
Determines whether the specified button in a toolbar control is indeterminate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Command identifier of the button in the toolbar.  
  
## Return Value  
 Positive integer if the button is indeterminate, zero if the button is not indeterminate, or -1 if an error occurs.  
  
## Remarks  
 Indeterminate buttons are displayed dimmed, such as the way the bold button on the toolbar of a word processor looks when the selected text contains both bold and regular characters. Consider calling [GetState](../vs140/ctoolbarctrl--getstate.md) if you want to retrieve more than one button state.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::Indeterminate](../vs140/ctoolbarctrl--indeterminate.md)   
 [CToolBarCtrl::GetState](../vs140/ctoolbarctrl--getstate.md)   
 [CToolBarCtrl::SetState](../vs140/ctoolbarctrl--setstate.md)   
 [CToolBarCtrl::IsButtonEnabled](../vs140/ctoolbarctrl--isbuttonenabled.md)   
 [CToolBarCtrl::IsButtonChecked](../vs140/ctoolbarctrl--isbuttonchecked.md)   
 [CToolBarCtrl::IsButtonPressed](../vs140/ctoolbarctrl--isbuttonpressed.md)   
 [CToolBarCtrl::IsButtonHidden](../vs140/ctoolbarctrl--isbuttonhidden.md)   
 [CToolBarCtrl::IsButtonHighlighted](../vs140/ctoolbarctrl--isbuttonhighlighted.md)