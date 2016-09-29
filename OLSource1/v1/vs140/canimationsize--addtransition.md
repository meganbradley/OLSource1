---
title: "CAnimationSize::AddTransition"
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
  - "AddTransition"
  - "afxanimationcontroller/CAnimationSize::AddTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTransition method"
ms.assetid: dc13988c-ca71-4433-aaa2-aff39cfb6211
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationSize::AddTransition
Adds transitions for Width and Height.  
  
## Syntax  
  
```  
void AddTransition(  
   CBaseTransition* pCXTransition,  
   CBaseTransition* pCYTransition  
);  
```  
  
#### Parameters  
 `pCXTransition`  
 A pointer to transition for Width.  
  
 `pCYTransition`  
 A pointer to transition for Height.  
  
## Remarks  
 Call this function to add the specified transitions to the internal list of transitions to be applied to animation variables for Width and Height. When you add transitions, they are not applied immediately and stored in an internal list. Transitions are applied (added to a storyboard for a particular value) when you call CAnimationController::AnimateGroup. If you don't need to apply a transition to one of dimensions, you can pass NULL.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationSize Class](../vs140/canimationsize-class.md)