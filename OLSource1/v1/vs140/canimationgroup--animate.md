---
title: "CAnimationGroup::Animate"
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
  - "Animate"
  - "afxanimationcontroller/CAnimationGroup::Animate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Animate method"
ms.assetid: f40a8706-8111-44de-a0fb-d51bc8d33fa9
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationGroup::Animate
Animates a group.  
  
## Syntax  
  
```  
BOOL Animate(  
   IUIAnimationManager* pManager,  
   IUIAnimationTimer* pTimer,  
   BOOL bScheduleNow  
);  
```  
  
#### Parameters  
 `pManager`  
 `pTimer`  
 `bScheduleNow`  
  
## Return Value  
 TRUE if the method succeeds; otherwise FALSE.  
  
## Remarks  
 This method creates an internal storyboard, creates and applies transitions and schedules an animation if bScheduleNow is TRUE. If bScheduleNow is FALSE, you need to call Schedule to start animation at the specified time.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationGroup Class](../vs140/canimationgroup-class.md)