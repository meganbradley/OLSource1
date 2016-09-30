---
title: "CAnimationBaseObject::EnableValueChangedEvent"
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
  - "EnableValueChangedEvent"
  - "afxanimationcontroller/CAnimationBaseObject::EnableValueChangedEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableValueChangedEvent method"
ms.assetid: bcae770b-98e3-45e4-bf6f-39542d89a62c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationBaseObject::EnableValueChangedEvent
Sets up Value Changed event handler.  
  
## Syntax  
  
```  
virtual void EnableValueChangedEvent(  
   CAnimationController* pController,  
   BOOL bEnable  
);  
```  
  
#### Parameters  
 `pController`  
 A pointer to a parent controller.  
  
 `bEnable`  
 Specifies whether to enable, or disable Value Changed event.  
  
## Remarks  
 If the Value Changed event handler is enabled, you can handle this event in CAnimationController::OnAnimationValueChanged method, which should be overridden in a CAnimationController-derived class. This method is called every time the animation value has changed.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)