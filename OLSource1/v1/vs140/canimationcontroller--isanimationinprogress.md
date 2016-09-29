---
title: "CAnimationController::IsAnimationInProgress"
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
  - "IsAnimationInProgress"
  - "afxanimationcontroller/CAnimationController::IsAnimationInProgress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsAnimationInProgress method"
ms.assetid: d0acaed0-728c-449f-8ce1-e5b8f8688170
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::IsAnimationInProgress
Tells whether at least one group is playing animation.  
  
## Syntax  
  
```  
virtual BOOL IsAnimationInProgress();  
```  
  
## Return Value  
 TRUE if there is an animation in progress for this animation controller; otherwise FALSE.  
  
## Remarks  
 Checks status of animation manager and returns TRUE if the status is UI_ANIMATION_MANAGER_BUSY.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)