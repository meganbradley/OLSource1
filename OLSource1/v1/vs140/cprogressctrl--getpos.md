---
title: "CProgressCtrl::GetPos"
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
  - CProgressCtrl.GetPos
  - CProgressCtrl::GetPos
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetPos method
ms.assetid: c784969b-7d68-4cee-a031-5ad77a5da04a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CProgressCtrl::GetPos
Retrieves the current position of the progress bar.  
  
## Syntax  
  
```  
  
int GetPos( );  
  
```  
  
## Return Value  
 The position of the progress bar control.  
  
## Remarks  
 The position of the progress bar control is not the physical location on the screen, but rather is between the upper and lower range indicated in [SetRange](../vs140/cprogressctrl--setrange.md).  
  
## Example  
 [!code[NVC_MFC_CProgressCtrl#3](../vs140/codesnippet/CPP/cprogressctrl--getpos_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CProgressCtrl::SetPos](../vs140/cprogressctrl--setpos.md)