---
title: "CCustomInterpolator::GetDependencies"
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
  - "GetDependencies"
  - "afxanimationcontroller/CCustomInterpolator::GetDependencies"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDependencies method"
ms.assetid: 47cc0eb5-1a54-4f2f-a9fa-8b1d02284314
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCustomInterpolator::GetDependencies
Gets the interpolator's dependencies.  
  
## Syntax  
  
```  
virtual BOOL GetDependencies(  
   UI_ANIMATION_DEPENDENCIES *initialValueDependencies,  
   UI_ANIMATION_DEPENDENCIES *initialVelocityDependencies,  
   UI_ANIMATION_DEPENDENCIES *durationDependencies  
);  
```  
  
#### Parameters  
 `initialValueDependencies`  
 Output. Aspects of the interpolator that depend on the initial value passed to SetInitialValueAndVelocity.  
  
 `initialVelocityDependencies`  
 Output. Aspects of the interpolator that depend on the initial velocity passed to SetInitialValueAndVelocity.  
  
 `durationDependencies`  
 Output. Aspects of the interpolator that depend on the duration passed to SetDuration.  
  
## Return Value  
 Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CCustomInterpolator Class](../vs140/ccustominterpolator-class.md)