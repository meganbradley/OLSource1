---
title: "CAnimationRect::AddTransition"
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
  - "afxanimationcontroller/CAnimationRect::AddTransition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTransition method"
ms.assetid: f3529081-ed50-451b-a787-ddad28a7cb35
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationRect::AddTransition
Adds transitions for left, top, right and bottom coordinates.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies transition for the left side.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies transition for the top side.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies transition for the right side.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies transition for the bottom side.  
  
## Remarks  
 Call this function to add the specified transitions to the internal list of transitions to be applied to animation variables for each rectangle sides. When you add transitions, they are not applied immediately and stored in an internal list. Transitions are applied (added to a storyboard for a particular value) when you call CAnimationController::AnimateGroup. If you don't need to apply a transition to one of the rectangle sides, you can pass NULL.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationRect Class](../vs140/canimationrect-class.md)