---
title: "CAnimationGroup::Schedule"
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
  - "Schedule"
  - "afxanimationcontroller/CAnimationGroup::Schedule"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Schedule method"
ms.assetid: 3a3c1bd4-9294-40ce-afc7-51143db95eb5
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationGroup::Schedule
Schedules an animation at the specified time.  
  
## Syntax  
  
```  
BOOL Schedule(  
   IUIAnimationTimer* pTimer,  
   UI_ANIMATION_SECONDS time  
);  
```  
  
#### Parameters  
 `pTimer`  
 A pointer to animation timer.  
  
 `time`  
 Specifies time to schedule the animation.  
  
## Return Value  
 TRUE if the method succeeds; FALSE if the method fails or if Animate has not been called with bScheduleNow set to FALSE.  
  
## Remarks  
 Call this function to schedule an animation at the specified time. You must call Animate with bScheduleNow set to FALSE first.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationGroup Class](../vs140/canimationgroup-class.md)