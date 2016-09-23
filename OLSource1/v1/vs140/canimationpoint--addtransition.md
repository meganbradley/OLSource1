---
title: "CAnimationPoint::AddTransition"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - afxanimationcontroller/CAnimationPoint::AddTransition
  - AddTransition
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddTransition method
ms.assetid: 97808550-0b6b-4f76-90a5-2a7947bcc2b3
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationPoint::AddTransition
Adds transitions for X and Y coordinates.  
  
## Syntax  
  
```  
void AddTransition(  
   CBaseTransition* pXTransition,  
   CBaseTransition* pYTransition  
);  
```  
  
#### Parameters  
 `pXTransition`  
 A pointer to transition for X coordinates.  
  
 `pYTransition`  
 A pointer to transition for Y coordinate.  
  
## Remarks  
 Call this function to add the specified transitions to the internal list of transitions to be applied to animation variables for X and Y coordinates. When you add transitions, they are not applied immediately and stored in an internal list. Transitions are applied (added to a storyboard for a particular value) when you call CAnimationController::AnimateGroup. If you don't need to apply a transition to one of coordinates, you can pass NULL.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationPoint Class](../vs140/canimationpoint-class.md)