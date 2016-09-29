---
title: "CAnimationTimerEventHandler::OnRenderingTooSlow"
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
  - "OnRenderingTooSlow"
  - "afxanimationcontroller/CAnimationTimerEventHandler::OnRenderingTooSlow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRenderingTooSlow method"
ms.assetid: 35f5604b-a803-45da-bee3-d3769fe17142
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationTimerEventHandler::OnRenderingTooSlow
Handles events that occur when the rendering frame rate for an animation falls below the minimum desirable frame rate.  
  
## Syntax  
  
```  
IFACEMETHOD(  
   OnRenderingTooSlow  
)(UINT32 fps);  
```  
  
#### Parameters  
 `fps`  
  
## Return Value  
 S_OK if the method succeeds; otherwise E_FAIL.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationTimerEventHandler Class](../vs140/canimationtimereventhandler-class.md)