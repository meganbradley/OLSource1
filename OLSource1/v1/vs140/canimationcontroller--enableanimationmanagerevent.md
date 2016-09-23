---
title: "CAnimationController::EnableAnimationManagerEvent"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - EnableAnimationManagerEvent
  - afxanimationcontroller/CAnimationController::EnableAnimationManagerEvent
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnableAnimationManagerEvent method
ms.assetid: 3984791d-8d9e-4bcb-9f95-4f1c806c314f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationController::EnableAnimationManagerEvent
Sets or releases a handler to call when animation manager's status changes.  
  
## Syntax  
  
```  
virtual BOOL EnableAnimationManagerEvent(  
   BOOL bEnable = TRUE  
);  
```  
  
#### Parameters  
 `bEnable`  
 Specifies whether to set or release a handler.  
  
## Return Value  
 TRUE if the handler was successfully set or released.  
  
## Remarks  
 When a handler is set (enabled) Windows Animation calls OnAnimationManagerStatusChanged when animation manager's status changes.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)