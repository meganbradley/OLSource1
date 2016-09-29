---
title: "CCustomTransition::Create"
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
  - "Create"
  - "afxanimationcontroller/CCustomTransition::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 9024e228-8103-4535-9def-0446dbda71d0
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCustomTransition::Create
Calls the transition library to create encapsulated transition COM object.  
  
## Syntax  
  
```  
virtual BOOL Create(  
   IUIAnimationTransitionLibrary* */,  
   IUIAnimationTransitionFactory* pFactory  
);  
```  
  
#### Parameters  
 `pFactory`  
 A pointer to transition factory, which is responsible for creation of custom transitions.  
  
## Return Value  
  
## Remarks  
 This method also can set initial value and initial velocity to be applied to an animation variable, which is associated with this transition. For this purpose you have to call SetInitialValue and SetInitialVelocity before the framework creates the encapsulated transition COM object (it happens when you call CAnimationController::AnimateGroup).  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CCustomTransition Class](../vs140/ccustomtransition-class.md)