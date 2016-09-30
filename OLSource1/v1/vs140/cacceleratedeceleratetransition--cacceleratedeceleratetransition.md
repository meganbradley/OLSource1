---
title: "CAccelerateDecelerateTransition::CAccelerateDecelerateTransition"
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
  - "CAccelerateDecelerateTransition"
  - "afxanimationcontroller/CAccelerateDecelerateTransition::CAccelerateDecelerateTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAccelerateDecelerateTransition class, constructor"
ms.assetid: 4e3678d5-003f-4fa4-93b5-31aa6588324f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccelerateDecelerateTransition::CAccelerateDecelerateTransition
Constructs a transition object.  
  
## Syntax  
  
```  
CAccelerateDecelerateTransition(  
   UI_ANIMATION_SECONDS duration,  
   DOUBLE finalValue,  
   DOUBLE accelerationRatio = 0.3,  
   DOUBLE decelerationRatio = 0.3  
);  
```  
  
#### Parameters  
 `duration`  
 The duration of the transition.  
  
 `finalValue`  
 The value of the animation variable at the end of the transition.  
  
 `accelerationRatio`  
 The ratio of the time spent accelerating to the duration.  
  
 `decelerationRatio`  
 The ratio of the time spent decelerating to the duration.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAccelerateDecelerateTransition Class](../vs140/cacceleratedeceleratetransition-class1.md)