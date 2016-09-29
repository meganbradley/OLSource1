---
title: "CSpinButtonCtrl::SetBuddy"
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
  - "CSpinButtonCtrl.SetBuddy"
  - "CSpinButtonCtrl::SetBuddy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBuddy method"
ms.assetid: 1b6d3583-0a3e-4296-991a-4f95904ec24e
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSpinButtonCtrl::SetBuddy
Sets the buddy window for a spin button control.  
  
## Syntax  
  
```  
  
      CWnd* SetBuddy(  
   CWnd* pWndBuddy   
);  
```  
  
#### Parameters  
 `pWndBuddy`  
 Pointer to the new buddy window.  
  
## Return Value  
 A pointer to the previous buddy window.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Remarks  
 A spin control is almost always associated with another window, such as an edit control, that displays some content. This other window is called the "buddy" of the spin control.  
  
## See Also  
 [CSpinButtonCtrl Class](../vs140/cspinbuttonctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSpinButtonCtrl::GetBuddy](../vs140/cspinbuttonctrl--getbuddy.md)