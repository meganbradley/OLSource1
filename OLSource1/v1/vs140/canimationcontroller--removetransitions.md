---
title: "CAnimationController::RemoveTransitions"
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
  - "RemoveTransitions"
  - "afxanimationcontroller/CAnimationController::RemoveTransitions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveTransitions method"
ms.assetid: ac3c2c87-033b-4747-a4e6-1a10ee097227
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::RemoveTransitions
Removes transitions from animation objects that belong to the specified group.  
  
## Syntax  
  
```  
void RemoveTransitions(  
   UINT32 nGroupID  
);  
```  
  
#### Parameters  
 `nGroupID`  
 Specifies Group ID.  
  
## Remarks  
 The group loops over its animation objects and calls ClearTransitions(FALSE) for each animation object. This method is called by the framework after animation has been scheduled.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)