---
title: "CCustomInterpolator::InterpolateVelocity"
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
  - "InterpolateVelocity"
  - "afxanimationcontroller/CCustomInterpolator::InterpolateVelocity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InterpolateVelocity method"
ms.assetid: ed083488-ec24-4b47-b852-c7f983e62d9f
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCustomInterpolator::InterpolateVelocity
Interpolates the velocity at a given offset  
  
## Syntax  
  
```  
virtual BOOL InterpolateVelocity(  
   UI_ANIMATION_SECONDS */,  
   DOUBLE *velocity  
);  
```  
  
#### Parameters  
 `velocity`  
 Output. The velocity of the variable at the offset.  
  
## Return Value  
 Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CCustomInterpolator Class](../vs140/ccustominterpolator-class.md)