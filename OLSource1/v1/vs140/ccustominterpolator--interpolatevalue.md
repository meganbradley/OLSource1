---
title: "CCustomInterpolator::InterpolateValue"
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
  - "afxanimationcontroller/CCustomInterpolator::InterpolateValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InterpolateValue method"
ms.assetid: 7778f750-f7f7-47f0-8135-1551bf23276a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCustomInterpolator::InterpolateValue
Interpolates the value at a given offset.  
  
## Syntax  
  
```  
virtual BOOL InterpolateValue(  
   UI_ANIMATION_SECONDS */,  
   DOUBLE *value  
);  
```  
  
#### Parameters  
 `value`  
 Output. The interpolated value.  
  
## Return Value  
 Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CCustomInterpolator Class](../vs140/ccustominterpolator-class.md)