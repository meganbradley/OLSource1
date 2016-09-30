---
title: "CAnimationController::OnStoryboardStatusChanged"
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
  - "afxanimationcontroller/CAnimationController::OnStoryboardStatusChanged"
  - "OnStoryboardStatusChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnStoryboardStatusChanged method"
ms.assetid: 04aec149-bd9c-4813-968e-c6d978098cbc
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::OnStoryboardStatusChanged
Called by the framework when storyboard status has changed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an animation group that owns the storyboard whose status has changed.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the new status.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the previous status.  
  
## Remarks  
 This method is called if you enable storyboard events using CAnimationController::EnableStoryboardEventHandler. It can be overridden in a derived class to take application-specific actions.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)