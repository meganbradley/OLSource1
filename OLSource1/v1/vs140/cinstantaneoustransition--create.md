---
title: "CInstantaneousTransition::Create"
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
  - afxanimationcontroller/CInstantaneousTransition::Create
  - Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method
ms.assetid: 748159f8-519c-401b-8e23-6e7bc459aa4c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CInstantaneousTransition::Create
Calls the transition library to create encapsulated transition COM object.  
  
## Syntax  
  
```  
virtual BOOL Create(  
   IUIAnimationTransitionLibrary* pLibrary,  
   IUIAnimationTransitionFactory* */  
);  
```  
  
#### Parameters  
 `pLibrary`  
 A pointer to transition library, which is responsible for creation of standard transitions.  
  
## Return Value  
 TRUE if transition is created successfully; otherwise FALSE.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CInstantaneousTransition Class](../vs140/cinstantaneoustransition-class.md)