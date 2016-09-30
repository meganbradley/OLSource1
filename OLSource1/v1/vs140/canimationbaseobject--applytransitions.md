---
title: "CAnimationBaseObject::ApplyTransitions"
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
  - "afxanimationcontroller/CAnimationBaseObject::ApplyTransitions"
  - "ApplyTransitions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ApplyTransitions method"
ms.assetid: 5a85f3ed-61fa-4a7e-b74a-ba91dca607b8
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationBaseObject::ApplyTransitions
Adds transitions to storyboard with encapsulated animation variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a storyboard.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 With FALSE this method adds only those transitions that do not depend on keyframes.  
  
## Return Value  
 TRUE if transitions were added successfully.  
  
## Remarks  
 Adds related transitions, that have been added with AddTransition (overloaded methods in derived classes), to storyboard.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)