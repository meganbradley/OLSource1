---
title: "CAnimationController::OnStoryboardUpdated"
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
  - "OnStoryboardUpdated"
  - "afxanimationcontroller/CAnimationController::OnStoryboardUpdated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnStoryboardUpdated method"
ms.assetid: 550a8b49-cf8c-4cb5-8eb8-4cfbc2e028e3
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::OnStoryboardUpdated
Called by the framework when storyboard has been updated.  
  
## Syntax  
  
```  
virtual void OnStoryboardUpdated(  
   CAnimationGroup* pGroup  
);  
```  
  
#### Parameters  
 `pGroup`  
 A pointer to a group that owns the storyboard.  
  
## Remarks  
 This method is called if you enable storyboard events using CAnimationController::EnableStoryboardEventHandler. It can be overridden in a derived class to take application-specific actions.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)