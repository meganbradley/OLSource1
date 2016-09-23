---
title: "COleControl::GetFocus"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleControl::GetFocus
  - COleControl.GetFocus
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetFocus method
ms.assetid: e1c6772d-172a-4c03-9c2a-405661fbc96d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::GetFocus
Determines whether the `COleControl` object has the focus.  
  
## Syntax  
  
```  
  
CWnd* GetFocus( );  
```  
  
## Return Value  
 If the control is activated and windowless, returns **this** if the control currently has the keyboard focus (as determined by the control's container), or **NULL** if it does not have the focus.  
  
 Otherwise, returns the `CWnd` object that has the focus (same as `CWnd::GetFocus`).  
  
## Remarks  
 An activated windowless control receives the focus when [SetFocus](../vs140/colecontrol--setfocus.md) is called.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetFocus](../vs140/colecontrol--setfocus.md)