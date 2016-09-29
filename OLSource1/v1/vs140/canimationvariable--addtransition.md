---
title: "CAnimationVariable::AddTransition"
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
  - "afxanimationcontroller/CAnimationVariable::AddTransition"
  - "AddTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTransition method"
ms.assetid: 198e5bf3-ee6a-492a-8700-d3cadc9310a4
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationVariable::AddTransition
Adds a transition.  
  
## Syntax  
  
```  
void AddTransition(  
   CBaseTransition* pTransition  
);  
```  
  
#### Parameters  
 `pTransition`  
 A pointer to a transition to add.  
  
## Remarks  
 This method is called to add a transition to the internal list of transitions to be applied to the animation variable. This list should be cleared when an animation has been scheduled.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationVariable Class](../vs140/canimationvariable-class.md)