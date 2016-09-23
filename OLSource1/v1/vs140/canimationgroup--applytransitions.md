---
title: "CAnimationGroup::ApplyTransitions"
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
  - afxanimationcontroller/CAnimationGroup::ApplyTransitions
  - ApplyTransitions
dev_langs: 
  - C++
helpviewer_keywords: 
  - ApplyTransitions method
ms.assetid: 2461ac03-4613-40c6-853a-7803a3bdf88f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationGroup::ApplyTransitions
Applies transitions to animation objects.  
  
## Syntax  
  
```  
void ApplyTransitions();  
```  
  
## Remarks  
 This method ASSERTS in debug mode if storyboard has not been created. It creates all transitions first, then adds "static" keyframes (keyframes that depend on offsets), adds transitions that do not depend on keyframes, adds keyframes depending on transitions and other keyframes, and at last adds transitions that depend on keyframes.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationGroup Class](../vs140/canimationgroup-class.md)