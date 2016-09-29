---
title: "CAnimationController::AddAnimationObject"
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
  - "afxanimationcontroller/CAnimationController::AddAnimationObject"
  - "AddAnimationObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddAnimationObject method"
ms.assetid: 12ddb918-bba1-4f2e-8c3b-09c0603a147c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::AddAnimationObject
Adds an animation object to a group that belongs to the animation controller.  
  
## Syntax  
  
```  
CAnimationGroup* AddAnimationObject(  
   CAnimationBaseObject* pObject  
);  
```  
  
#### Parameters  
 `pObject`  
 A pointer to an animation object.  
  
## Return Value  
 A pointer to existing or new animation group where pObject has been added if function succeeds; NULL if pObject has already been added to a group that belongs to another animation controller.  
  
## Remarks  
 Call this method to add an animation object to the animation controller. An object will be added to a group according to object's GroupID (see CAnimationBaseObject::SetID). The animation controller will create a new group if it's the first object being added with the specified GroupID. An animation object can be added to one animation controller only. If you need to add an object to another controller, call RemoveAnimationObject first. If you call SetID with new GroupID for an object that has been already added to a group, the object will be removed from the old group and added to another group with specified ID.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)