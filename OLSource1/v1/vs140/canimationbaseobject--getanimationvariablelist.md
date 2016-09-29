---
title: "CAnimationBaseObject::GetAnimationVariableList"
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
  - "GetAnimationVariableList"
  - "afxanimationcontroller/CAnimationBaseObject::GetAnimationVariableList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAnimationVariableList method"
ms.assetid: 122d9412-731a-4e50-8a3f-e42362fdfc61
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationBaseObject::GetAnimationVariableList
Collects pointers to contained animation variables.  
  
## Syntax  
  
```  
virtual void GetAnimationVariableList(  
   CList<CAnimationVariable*,  
   CAnimationVariable*>& lst  
) = 0;  
```  
  
#### Parameters  
 `lst`  
 A list that must be filled with animation variables contained in an animation object.  
  
## Remarks  
 This is a pure virtual method that must be overridden in a derived class. An animation object, depending on its type, contains one or more animation variables. For example, CAnimationPoint contains two variables, for X and Y coordinates respectively. The base class CAnimationBaseObject implements some generic methods, which act on a list of animation variables: ApplyTransitions, ClearTransitions, EnableValueChangedEvent, EnableIntegerValueChangedEvent. These methods call GetAnimationVariableList, which is filled in a derived class with actual animation variables contained in a particular animation object, then loop over the list and perform necessary actions. If you create a custom animation object, you must add to lst all animation variables contained in that object.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationBaseObject Class](../vs140/canimationbaseobject-class.md)