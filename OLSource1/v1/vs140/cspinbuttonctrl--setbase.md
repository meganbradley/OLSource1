---
title: "CSpinButtonCtrl::SetBase"
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
  - CSpinButtonCtrl::SetBase
  - SetBase
  - CSpinButtonCtrl.SetBase
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetBase method
ms.assetid: e6048a4f-2ce1-4455-b061-8c1b5f6d0f4f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSpinButtonCtrl::SetBase
Sets the base for a spin button control.  
  
## Syntax  
  
```  
  
      int SetBase(  
   int nBase   
);  
```  
  
#### Parameters  
 `nBase`  
 New base value for the control. It can be 10 for decimal or 16 for hexadecimal.  
  
## Return Value  
 The previous base value if successful, or zero if an invalid base is given.  
  
## Remarks  
 The base value determines whether the buddy window displays numbers in decimal or hexadecimal digits. Hexadecimal numbers are always unsigned; decimal numbers are signed.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSpinButtonCtrl Class](../vs140/cspinbuttonctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSpinButtonCtrl::GetBase](../vs140/cspinbuttonctrl--getbase.md)