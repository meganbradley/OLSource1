---
title: "CAnimationController::ScheduleGroup"
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
  - "afxanimationcontroller/CAnimationController::ScheduleGroup"
  - "ScheduleGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ScheduleGroup method"
ms.assetid: 9b3fdc85-8416-4b2a-9f8d-65807f65abe1
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::ScheduleGroup
Schedules an animation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies animation Group ID to schedule.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies time to schedule.  
  
## Return Value  
 TRUE if animation was scheduled successfully. FALSE if storyboard has not been created, or other error occurs.  
  
## Remarks  
 You must call AnimateGroup with parameter bScheduleNow set to FALSE prior ScheduleGroup. You can specify the desired animation time obtained from IUIAnimationTimer::GetTime. If the time parameter is 0.0, the animation is scheduled for the current time.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)