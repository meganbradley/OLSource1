---
title: "CAnimationController::OnAnimationManagerStatusChanged"
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
  - "afxanimationcontroller/CAnimationController::OnAnimationManagerStatusChanged"
  - "OnAnimationManagerStatusChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAnimationManagerStatusChanged method"
ms.assetid: 3c8b856e-29af-42d4-8a04-ab13736f665d
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::OnAnimationManagerStatusChanged
Called by the framework in response to StatusChanged event from animation manager.  
  
## Syntax  
  
```  
virtual void OnAnimationManagerStatusChanged(  
   UI_ANIMATION_MANAGER_STATUS newStatus,  
   UI_ANIMATION_MANAGER_STATUS previousStatus  
);  
```  
  
#### Parameters  
 `newStatus`  
 New animation manager status.  
  
 `previousStatus`  
 Previous animation manager status.  
  
## Remarks  
 This method is called if you enable animation manager events with EnableAnimationManagerEvent. It can be overridden in a derived class to take application-specific actions. The default implementation updates a related window if it has been set with SetRelatedWnd.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)