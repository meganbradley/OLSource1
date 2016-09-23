---
title: "CMonthCalCtrl::HitTest"
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
  - CMonthCalCtrl.HitTest
  - CMonthCalCtrl::HitTest
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMonthCalCtrl class, operations
  - HitTest method [MFC]
ms.assetid: 7bbefc19-18b2-4be1-baaa-59515680d697
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMonthCalCtrl::HitTest
Determines which month calendar control, if any, is at a specified position.  
  
## Syntax  
  
```  
  
      DWORD HitTest(  
   PMCHITTESTINFO pMCHitTest   
);  
```  
  
#### Parameters  
 *pMCHitTest*  
 A pointer to a [MCHITTESTINFO](http://msdn.microsoft.com/library/windows/desktop/bb760927) structure containing hit testing points for the month calendar control.  
  
## Return Value  
 A `DWORD` value. Equal to the **uHit** member of the **MCHITTESTINFO** structure.  
  
## Remarks  
 `HitTest` uses the **MCHITTESTINFO** structure, which contains information about the hit test.  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)