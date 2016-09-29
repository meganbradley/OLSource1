---
title: "CAnimationController::OnAnimationTimerRenderingTooSlow"
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
  - "OnAnimationTimerRenderingTooSlow"
  - "afxanimationcontroller/CAnimationController::OnAnimationTimerRenderingTooSlow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAnimationTimerRenderingTooSlow method"
ms.assetid: cab04f92-6a0b-4fd4-b726-8f2605e61e55
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::OnAnimationTimerRenderingTooSlow
Called by the framework when the rendering frame rate for an animation falls below a minimum desirable frame rate.  
  
## Syntax  
  
```  
virtual void OnAnimationTimerRenderingTooSlow(  
   UINT32 fps  
);  
```  
  
#### Parameters  
 `fps`  
 The current frame rate in frames per second.  
  
## Remarks  
 This method is called if you enable timer event handlers using EnableAnimationTimerEventHandler. It can be overridden in a derived class to take application-specific actions. The minimum desirable frame rate is specified by calling IUIAnimationTimer::SetFrameRateThreshold.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)