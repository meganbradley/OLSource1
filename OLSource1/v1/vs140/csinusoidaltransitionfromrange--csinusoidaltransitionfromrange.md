---
title: "CSinusoidalTransitionFromRange::CSinusoidalTransitionFromRange"
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
  - "afxanimationcontroller/CSinusoidalTransitionFromRange::CSinusoidalTransitionFromRange"
  - "CSinusoidalTransitionFromRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSinusoidalTransitionFromRange class, constructor"
ms.assetid: 775d68df-fa06-472b-9658-28556534d374
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSinusoidalTransitionFromRange::CSinusoidalTransitionFromRange
Constructs a transition object.  
  
## Syntax  
  
```  
CSinusoidalTransitionFromRange(  
   UI_ANIMATION_SECONDS duration,  
   DOUBLE dblMinimumValue,  
   DOUBLE dblMaximumValue,  
   UI_ANIMATION_SECONDS period,  
   UI_ANIMATION_SLOPE slope  
);  
```  
  
#### Parameters  
 `duration`  
 The duration of the transition.  
  
 `dblMinimumValue`  
 The value of the animation variable at a trough of the sinusoidal wave.  
  
 `dblMaximumValue`  
 The value of the animation variable at a peak of the sinusoidal wave.  
  
 `period`  
 The period of oscillation of the sinusoidal wave in seconds.  
  
 `slope`  
 The slope at the start of the transition.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CSinusoidalTransitionFromRange Class](../vs140/csinusoidaltransitionfromrange-class.md)