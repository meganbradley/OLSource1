---
title: "CSpinButtonCtrl::GetAccel"
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
  - "CSpinButtonCtrl::GetAccel"
  - "GetAccel"
  - "CSpinButtonCtrl.GetAccel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAccel method"
ms.assetid: c196b125-c694-44ae-aeac-6ed460c239d7
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSpinButtonCtrl::GetAccel
Retrieves acceleration information for a spin button control.  
  
## Syntax  
  
```  
  
      UINT GetAccel(  
   int nAccel,  
   UDACCEL* pAccel   
) const;  
```  
  
#### Parameters  
 `nAccel`  
 Number of elements in the array specified by `pAccel`.  
  
 `pAccel`  
 Pointer to an array of [UDACCEL](http://msdn.microsoft.com/library/windows/desktop/bb759897) structures that receives acceleration information.  
  
## Return Value  
 Number of accelerator structures retrieved.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CSpinButtonCtrl Class](../vs140/cspinbuttonctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSpinButtonCtrl::SetAccel](../vs140/cspinbuttonctrl--setaccel.md)