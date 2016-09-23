---
title: "CProgressCtrl::SetRange"
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
  - CProgressCtrl::SetRange
  - CProgressCtrl.SetRange
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetRange32 method
  - SetRange method
ms.assetid: adb494b8-ac8a-4d1f-b953-41944d32cd5a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CProgressCtrl::SetRange
Sets the upper and lower limits of the progress bar control's range and redraws the bar to reflect the new ranges.  
  
## Syntax  
  
```  
  
      void SetRange(  
   short nLower,  
   short nUpper   
);  
void SetRange32(  
   int nLower,  
   int nUpper   
);  
```  
  
#### Parameters  
 `nLower`  
 Specifies the lower limit of the range (default is zero).  
  
 `nUpper`  
 Specifies the upper limit of the range (default is 100).  
  
## Remarks  
 The member function `SetRange32` sets the 32-bit range for the progress control.  
  
## Example  
 [!code[NVC_MFC_CProgressCtrl#8](../vs140/codesnippet/CPP/cprogressctrl--setrange_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CProgressCtrl::OffsetPos](../vs140/cprogressctrl--offsetpos.md)   
 [CProgressCtrl::SetPos](../vs140/cprogressctrl--setpos.md)   
 [CProgressCtrl::StepIt](../vs140/cprogressctrl--stepit.md)