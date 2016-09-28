---
title: "CCustomInterpolator::SetInitialValueAndVelocity"
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
  - "SetInitialValueAndVelocity"
  - "afxanimationcontroller/CCustomInterpolator::SetInitialValueAndVelocity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetInitialValueAndVelocity method"
ms.assetid: 3fd8e01a-7797-49d0-bf3c-840a3a698274
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCustomInterpolator::SetInitialValueAndVelocity
Sets the interpolator's initial value and velocity.  
  
## Syntax  
  
```  
virtual BOOL SetInitialValueAndVelocity(  
   DOUBLE initialValue,  
   DOUBLE initialVelocity  
);  
```  
  
#### Parameters  
 `initialValue`  
 The value of the variable at the start of the transition.  
  
 `initialVelocity`  
 The velocity of the variable at the start of the transition.  
  
## Return Value  
 The basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CCustomInterpolator Class](../vs140/ccustominterpolator-class.md)