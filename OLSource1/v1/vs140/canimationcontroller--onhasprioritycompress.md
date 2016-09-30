---
title: "CAnimationController::OnHasPriorityCompress"
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
  - "afxanimationcontroller/CAnimationController::OnHasPriorityCompress"
  - "OnHasPriorityCompress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHasPriorityCompress method"
ms.assetid: bd9be1ba-0cb6-4141-a996-01e1d8a168f3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::OnHasPriorityCompress
Called by the framework to resolve scheduling conflicts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The group that owns the currently scheduled storyboard.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The group that owns the new storyboard that is in scheduling conflict with the scheduled storyboard owned by pGroupScheduled.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The potential effect on pGroupNew if pGroupScheduled has a higher priority.  
  
## Return Value  
 Should return TRUE if storyboard owned by pGroupNew has priority. Should return FALSE if storyboard owned by pGroupScheduled has priority.  
  
## Remarks  
 This method is called if you enable priority comparison events using CAnimationController::EnablePriorityComparisonHandler and specify UI_ANIMATION_PHT_COMPRESS. It can be overridden in a derived class to take application-specific actions. Read Windows Animation API documentation for more information about Conflict Management (http://msdn.microsoft.com/library/dd371759(VS.85).aspx).  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)