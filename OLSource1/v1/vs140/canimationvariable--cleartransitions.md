---
title: "CAnimationVariable::ClearTransitions"
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
  - afxanimationcontroller/CAnimationVariable::ClearTransitions
  - ClearTransitions
dev_langs: 
  - C++
helpviewer_keywords: 
  - ClearTransitions method
ms.assetid: 4b505ed4-7c0d-428a-b584-fa8ce1dab20e
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationVariable::ClearTransitions
Clears transitions.  
  
## Syntax  
  
```  
void ClearTransitions(  
   BOOL bAutodestroy  
);  
```  
  
#### Parameters  
 `bAutodestroy`  
 Specifies whether this method should delete transition objects.  
  
## Remarks  
 This method removes all transitions from the internal list of transitions. If bAutodestroy is TRUE, or m_bAutodestroyTransitions is TRUE, then transitions are deleted. Otherwise the caller should deallocate the transition objects.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationVariable Class](../vs140/canimationvariable-class.md)