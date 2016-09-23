---
title: "CAnimationController::OnAfterSchedule"
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
  - OnAfterSchedule
  - afxanimationcontroller/CAnimationController::OnAfterSchedule
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnAfterSchedule method
ms.assetid: 0d8e6ccd-09d4-4cde-9728-8a433cbfc73f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationController::OnAfterSchedule
Called by the framework when an animation for the specified group has just been scheduled.  
  
## Syntax  
  
```  
virtual void OnAfterSchedule(  
   CAnimationGroup* pGroup  
);  
```  
  
#### Parameters  
 `pGroup`  
 A pointer to an animation group, which has been scheduled.  
  
## Remarks  
 The default implementation removes keyframes from the specified group and transitions from animation variables that belong to the specified group. Can be overridden in a derived class to take any additional actions upon animation schedule.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)