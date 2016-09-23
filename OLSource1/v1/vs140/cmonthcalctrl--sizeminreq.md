---
title: "CMonthCalCtrl::SizeMinReq"
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
  - SizeMinReq
  - CMonthCalCtrl::SizeMinReq
  - CMonthCalCtrl.SizeMinReq
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMonthCalCtrl class, operations
  - SizeMinReq method
ms.assetid: 595ecfe7-e08b-4830-b6d0-37e2e3d46692
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMonthCalCtrl::SizeMinReq
Displays the month calendar control to the minimum size that displays one month.  
  
## Syntax  
  
```  
  
      BOOL SizeMinReq(  
   BOOL bRepaint = TRUE   
);  
```  
  
#### Parameters  
 `bRepaint`  
 Specifies whether the control is to be repainted. By default, **TRUE**. If **FALSE**, no repainting occurs.  
  
## Return Value  
 Nonzero if the month calendar control is sized to its minimum; otherwise 0.  
  
## Remarks  
 Calling `SizeMinReq` successfully displays the entire month calendar control for one month's calendar.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::GetMinReqRect](../vs140/cmonthcalctrl--getminreqrect.md)