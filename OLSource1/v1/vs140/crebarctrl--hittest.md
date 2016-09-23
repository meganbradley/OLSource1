---
title: "CReBarCtrl::HitTest"
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
  - CReBarCtrl::HitTest
  - CReBarCtrl.HitTest
dev_langs: 
  - C++
helpviewer_keywords: 
  - CReBarCtrl class, operations
  - HitTest method [MFC]
ms.assetid: 1118a341-df6e-49b4-bc2c-53adc4c20756
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CReBarCtrl::HitTest
Implements the behavior of the Win32 message [RB_HITTEST](http://msdn.microsoft.com/library/windows/desktop/bb774494), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      int HitTest(  
   RBHITTESTINFO* prbht   
);  
```  
  
#### Parameters  
 *prbht*  
 A pointer to a [RBHITTESTINFO](http://msdn.microsoft.com/library/windows/desktop/bb774391) structure. Before sending the message, the **pt** member of this structure must be initialized to the point that will be tested, in client coordinates.  
  
## Return Value  
 The zero-based index of the band at the given point, or -1 if no rebar band was at the point.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)