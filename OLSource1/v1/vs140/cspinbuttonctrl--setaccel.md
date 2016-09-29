---
title: "CSpinButtonCtrl::SetAccel"
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
  - "SetAccel"
  - "CSpinButtonCtrl.SetAccel"
  - "CSpinButtonCtrl::SetAccel"
  - "UDACCEL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UDACCEL"
  - "SetAccel method"
ms.assetid: 241acfd6-e2de-4468-aa3e-b36b5c52a8c0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSpinButtonCtrl::SetAccel
Sets the acceleration for a spin button control.  
  
## Syntax  
  
```  
  
      BOOL SetAccel(  
   int nAccel,  
   UDACCEL* pAccel   
);  
```  
  
#### Parameters  
 `nAccel`  
 Number of [UDACCEL](http://msdn.microsoft.com/library/windows/desktop/bb759897) structures specified by `pAccel`.  
  
 `pAccel`  
 Pointer to an array of `UDACCEL` structures, which contain acceleration information. Elements should be sorted in ascending order based on the **nSec** member.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSpinButtonCtrl Class](../vs140/cspinbuttonctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSpinButtonCtrl::GetAccel](../vs140/cspinbuttonctrl--getaccel.md)