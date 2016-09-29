---
title: "CInterpolatorBase::InterpolateValue"
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
  - "InterpolateValue"
  - "afxanimationcontroller/CInterpolatorBase::InterpolateValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InterpolateValue method"
ms.assetid: dd4c72a5-300d-4bb9-ba13-abe407e60815
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInterpolatorBase::InterpolateValue
Interpolates the value at a given offset  
  
## Syntax  
  
```  
IFACEMETHOD(  
   InterpolateValue  
)(__in UI_ANIMATION_SECONDS offset, __out DOUBLE *value);  
```  
  
#### Parameters  
 `offset`  
 The offset from the start of the transition. The offset is always greater than or equal to zero and less than the duration of the transition. This method is not called if the duration of the transition is zero.  
  
 `value`  
 Output. The interpolated value.  
  
## Return Value  
 If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not set, or custom implementation returns FALSE from the InterpolateValue method.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CInterpolatorBase Class](../vs140/cinterpolatorbase-class.md)