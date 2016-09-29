---
title: "CAnimationColor::AddTransition"
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
  - "afxanimationcontroller/CAnimationColor::AddTransition"
  - "AddTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTransition method"
ms.assetid: 75230c22-85f4-49d0-8e76-0c0f7d21688e
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationColor::AddTransition
Adds transitions for Red, Green and Blue components.  
  
## Syntax  
  
```  
void AddTransition(  
   CBaseTransition* pRTransition,  
   CBaseTransition* pGTransition,  
   CBaseTransition* pBTransition  
);  
```  
  
#### Parameters  
 `pRTransition`  
 Transition for Red component.  
  
 `pGTransition`  
 Transition for Green component.  
  
 `pBTransition`  
 Transition for Blue component.  
  
## Remarks  
 Call this function to add the specified transitions to the internal list of transitions to be applied to animation variables representing color components. When you add transitions, they are not applied immediately and stored in an internal list. Transitions are applied (added to a storyboard for a particular value) when you call CAnimationController::AnimateGroup. If you don't need to apply a transition to one of the color components, you can pass NULL.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationColor Class](../vs140/canimationcolor-class.md)