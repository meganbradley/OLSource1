---
title: "CAnimationBaseObject::EnableIntegerValueChangedEvent"
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
  - "afxanimationcontroller/CAnimationBaseObject::EnableIntegerValueChangedEvent"
  - "EnableIntegerValueChangedEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableIntegerValueChangedEvent method"
ms.assetid: e33921bb-090c-46dc-b102-63d72a894b10
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationBaseObject::EnableIntegerValueChangedEvent
Sets up Integer Value Changed event handler.  
  
## Syntax  
  
```  
virtual void EnableIntegerValueChangedEvent(  
   CAnimationController* pController,  
   BOOL bEnable  
);  
```  
  
#### Parameters  
 `pController`  
 A pointer to a parent controller.  
  
 `bEnable`  
 Specifies whether to enable, or disable Integer Value Changed event.  
  
## Remarks  
 If the Integer Value Changed event handler is enabled, you can handle this event in CAnimationController::OnAnimationIntegerValueChanged method, which should be overridden in a CAnimationController-derived class. This method is called every time the animation integer value has changed.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)