---
title: "CAnimationBaseObject::ContainsVariable"
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
  - afxanimationcontroller/CAnimationBaseObject::ContainsVariable
  - ContainsVariable
dev_langs: 
  - C++
helpviewer_keywords: 
  - ContainsVariable method
ms.assetid: 55cc7b32-9709-413c-ba18-85661733e119
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationBaseObject::ContainsVariable
Determines whether an animation object contains a particular animation variable.  
  
## Syntax  
  
```  
virtual BOOL ContainsVariable(  
   IUIAnimationVariable* pVariable  
);  
```  
  
#### Parameters  
 `pVariable`  
 A pointer to animation variable.  
  
## Return Value  
 TRUE if the animation variable is contained in the animation object; otherwise FALSE.  
  
## Remarks  
 This method can be used to determine whether an animation variable specified by pVariable is contained within an animation object. An animation object, depending on its type, may contain several animation variables. For example, CAnimationColor contains three variables, one for each color component (red, green and blue). When a value of animation variable has changed, Windows Animation API sends ValueChanged or IntegerValueChanged events (if enabled), and the parameter of this event is a pointer to interface IUIAnimationVariable of animation variable. This method helps to obtain a pointer to animation from a pointer to contained COM object.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)