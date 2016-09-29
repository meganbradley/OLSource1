---
title: "CAnimationController::AnimateGroup"
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
  - "afxanimationcontroller/CAnimationController::AnimateGroup"
  - "AnimateGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AnimateGroup method"
ms.assetid: 4c1b8c78-2a0c-4e66-91d0-c7b26a45595f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::AnimateGroup
Prepares a group to run animation and optionally schedules it.  
  
## Syntax  
  
```  
BOOL AnimateGroup(  
   UINT32 nGroupID,  
   BOOL bScheduleNow = TRUE  
);  
```  
  
#### Parameters  
 `nGroupID`  
 Specifies GroupID.  
  
 `bScheduleNow`  
 Specifies whether to run animation right away.  
  
## Return Value  
 TRUE if animation was successfully scheduled and run.  
  
## Remarks  
 This method does the actual work creating storyboard, adding animation variables, applying transitions and setting keyframes. It's possible to delay scheduling if you set bScheduleNow to FALSE. In this case the specified group will hold a storyboard that has been set up for animation. At that point you can setup events for the storyboard and animation variables. When you actually need to run the animation call CAnimationController::ScheduleGroup.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)