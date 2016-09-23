---
title: "CAnimationController::UpdateAnimationManager"
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
  - afxanimationcontroller/CAnimationController::UpdateAnimationManager
  - UpdateAnimationManager
dev_langs: 
  - C++
helpviewer_keywords: 
  - UpdateAnimationManager method
ms.assetid: ea5439f6-98e8-479d-86e7-8a420d46479a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationController::UpdateAnimationManager
Directs the animation manager to update the values of all animation variables.  
  
## Syntax  
  
```  
virtual void UpdateAnimationManager();  
```  
  
## Remarks  
 Calling this method advances the animation manager to current time, changing statuses of storyboards as necessary and updating any animation variables to appropriate interpolated values. Internally this method calls IUIAnimationTimer::GetTime(timeNow) and IUIAnimationManager::Update(timeNow). Override this method in a derived class to customize this behavior.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)