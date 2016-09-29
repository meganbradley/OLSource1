---
title: "CToolBarCtrl::IsButtonHighlighted"
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
  - "CToolBarCtrl::IsButtonHighlighted"
  - "IsButtonHighlighted"
  - "CToolBarCtrl.IsButtonHighlighted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsButtonHighlighted method"
ms.assetid: 3b8864f7-32ad-4c8f-8442-8f747c9e2785
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::IsButtonHighlighted
Checks the highlight state of a toolbar button.  
  
## Syntax  
  
```  
BOOL IsButtonHighlighted(  
   int nID   
) const;  
```  
  
#### Parameters  
 [in] `nID`  
 The command ID for the toolbar button.  
  
## Return Value  
 Positive integer if the button is highlighted, 0 if the button is not highlighted, or -1 if an error occurs.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::IsButtonChecked](../vs140/ctoolbarctrl--isbuttonchecked.md)   
 [CToolBarCtrl::IsButtonIndeterminate](../vs140/ctoolbarctrl--isbuttonindeterminate.md)   
 [CToolBarCtrl::IsButtonHidden](../vs140/ctoolbarctrl--isbuttonhidden.md)   
 [CToolBarCtrl::IsButtonEnabled](../vs140/ctoolbarctrl--isbuttonenabled.md)   
 [CToolBarCtrl::IsButtonPressed](../vs140/ctoolbarctrl--isbuttonpressed.md)   
 [CToolBarCtrl::MarkButton](../vs140/ctoolbarctrl--markbutton.md)