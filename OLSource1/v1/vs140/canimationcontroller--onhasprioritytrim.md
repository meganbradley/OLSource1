---
title: "CAnimationController::OnHasPriorityTrim"
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
  - "OnHasPriorityTrim"
  - "afxanimationcontroller/CAnimationController::OnHasPriorityTrim"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHasPriorityTrim method"
ms.assetid: be18f786-beaf-4447-97d6-36a499bf18a7
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::OnHasPriorityTrim
Called by the framework to resolve scheduling conflicts.  
  
## Syntax  
  
```  
virtual BOOL OnHasPriorityTrim(  
   CAnimationGroup* pGroupScheduled,  
   CAnimationGroup* pGroupNew,  
   UI_ANIMATION_PRIORITY_EFFECT priorityEffect  
);  
```  
  
#### Parameters  
 `pGroupScheduled`  
 The group that owns the currently scheduled storyboard.  
  
 `pGroupNew`  
 The group that owns the new storyboard that is in scheduling conflict with the scheduled storyboard owned by pGroupScheduled.  
  
 `priorityEffect`  
 The potential effect on pGroupNew if pGroupScheduled has a higher priority.  
  
## Return Value  
 Should return TRUE if storyboard owned by pGroupNew has priority. Should return FALSE if storyboard owned by pGroupScheduled has priority.  
  
## Remarks  
 This method is called if you enable priority comparison events using CAnimationController::EnablePriorityComparisonHandler and specify UI_ANIMATION_PHT_TRIM. It can be overridden in a derived class to take application-specific actions. Read Windows Animation API documentation for more information about Conflict Management (http://msdn.microsoft.com/library/dd371759(VS.85).aspx).  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)