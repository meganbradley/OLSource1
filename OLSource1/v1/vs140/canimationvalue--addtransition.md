---
title: "CAnimationValue::AddTransition"
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
  - "afxanimationcontroller/CAnimationValue::AddTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTransition method"
ms.assetid: 09cfa7fc-585a-4bd5-bf78-561074a98b33
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationValue::AddTransition
Adds a transition to be applied to a value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to transition object.  
  
## Remarks  
 Call this function to add a transition to internal list of transitions to be applied to an animation variable. When you add transitions, they are not applied immediately and stored in an internal list. Transitions are applied (added to a storyboard for a particular value) when you call CAnimationController::AnimateGroup.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationValue Class](../vs140/canimationvalue-class.md)