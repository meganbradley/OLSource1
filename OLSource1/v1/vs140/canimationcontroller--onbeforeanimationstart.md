---
title: "CAnimationController::OnBeforeAnimationStart"
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
  - OnBeforeAnimationStart
  - afxanimationcontroller/CAnimationController::OnBeforeAnimationStart
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnBeforeAnimationStart method
ms.assetid: 4f31bcec-1355-4068-a4f0-2dc21f2b9c62
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationController::OnBeforeAnimationStart
Called by the framework right before the animation is scheduled.  
  
## Syntax  
  
```  
virtual void OnBeforeAnimationStart(  
   CAnimationGroup* pGroup  
);  
```  
  
#### Parameters  
 `pGroup`  
 A pointer to an animation group whose animation is about to start.  
  
## Remarks  
 This call is routed to related CWnd and can be overridden in a derived class to perform any additional actions before the animation starts for the specified group.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)