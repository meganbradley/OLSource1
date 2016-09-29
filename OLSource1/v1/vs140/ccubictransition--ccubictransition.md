---
title: "CCubicTransition::CCubicTransition"
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
  - "afxanimationcontroller/CCubicTransition::CCubicTransition"
  - "CCubicTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CCubicTransition class, constructor"
ms.assetid: 551f7f7b-5e09-4ad2-b391-50a094457396
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCubicTransition::CCubicTransition
Constructs a transition object and initializes its parameters.  
  
## Syntax  
  
```  
CCubicTransition(  
   UI_ANIMATION_SECONDS duration,  
   DOUBLE finalValue,  
   DOUBLE finalVelocity  
);  
```  
  
#### Parameters  
 `duration`  
 The duration of the transition.  
  
 `finalValue`  
 The value of the animation variable at the end of the transition.  
  
 `finalVelocity`  
 The velocity of the variable at the end of the transition.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CCubicTransition Class](../vs140/ccubictransition-class.md)