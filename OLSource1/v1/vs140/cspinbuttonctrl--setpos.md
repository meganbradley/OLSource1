---
title: "CSpinButtonCtrl::SetPos"
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
  - SetPos32
  - CSpinButtonCtrl::SetPos
  - CSpinButtonCtrl.SetPos
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetPos32 method
  - SetPos method
ms.assetid: 1be7d6d6-f826-4a12-b492-eabdbe3eb9f5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSpinButtonCtrl::SetPos
Sets the current position for a spin button control.  
  
## Syntax  
  
```  
  
      int SetPos(  
   int nPos   
);  
int SetPos32(  
   int nPos   
);  
```  
  
#### Parameters  
 `nPos`  
 New position for the control. This value must be in the range specified by the upper and lower limits for the control.  
  
## Return Value  
 The previous position (16-bit precision for `SetPos`, 32-bit precision for `SetPos32`).  
  
## Remarks  
 `SetPos32` sets the 32-bit position.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSpinButtonCtrl Class](../vs140/cspinbuttonctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSpinButtonCtrl::SetRange](../vs140/cspinbuttonctrl--setrange.md)   
 [CSpinButtonCtrl::GetPos](../vs140/cspinbuttonctrl--getpos.md)