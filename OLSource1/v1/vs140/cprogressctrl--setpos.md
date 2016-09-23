---
title: "CProgressCtrl::SetPos"
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
  - CProgressCtrl.SetPos
  - CProgressCtrl::SetPos
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetPos method
ms.assetid: ce775585-cb97-4463-b11a-1ee3296802a7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CProgressCtrl::SetPos
Sets the progress bar control's current position as specified by `nPos` and redraws the bar to reflect the new position.  
  
## Syntax  
  
```  
  
      int SetPos(  
   int nPos   
);  
```  
  
#### Parameters  
 `nPos`  
 New position of the progress bar control.  
  
## Return Value  
 The previous position of the progress bar control.  
  
## Remarks  
 The position of the progress bar control is not the physical location on the screen, but rather is between the upper and lower range indicated in [SetRange](../vs140/cprogressctrl--setrange.md).  
  
## Example  
 [!code[NVC_MFC_CProgressCtrl#7](../vs140/codesnippet/CPP/cprogressctrl--setpos_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CProgressCtrl::OffsetPos](../vs140/cprogressctrl--offsetpos.md)   
 [CProgressCtrl::SetRange](../vs140/cprogressctrl--setrange.md)   
 [CProgressCtrl::StepIt](../vs140/cprogressctrl--stepit.md)