---
title: "CBaseTransition::GetTransition"
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
  - GetTransition
  - afxanimationcontroller/CBaseTransition::GetTransition
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTransition method
ms.assetid: d9f5ff9d-6e26-48b0-9cf7-3255a1844c56
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBaseTransition::GetTransition
Returns a pointer to underlying COM transition object.  
  
## Syntax  
  
```  
IUIAnimationTransition* GetTransition(  
   IUIAnimationTransitionLibrary* pLibrary,  
   IUIAnimationTransitionFactory* pFactory  
);  
IUIAnimationTransition* GetTransition();  
```  
  
#### Parameters  
 `pLibrary`  
 A pointer to transition library, which creates standard transitions. It can be NULL for custom transitions.  
  
 `pFactory`  
 A pointer to transition factory, which creates custom transitions. It can be NULL for standard transitions.  
  
## Return Value  
 A valid pointer to IUIAnimationTransition or NULL if underlying transition can't be created.  
  
## Remarks  
 This method returns a pointer to underlying COM transition object and creates it if necessary.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CBaseTransition Class](../vs140/cbasetransition-class.md)