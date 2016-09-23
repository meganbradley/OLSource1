---
title: "CBaseTransition::Create"
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
  - afxanimationcontroller/CBaseTransition::Create
  - Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method
ms.assetid: e9383405-e900-4a10-afd3-cf3e77efa4a2
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBaseTransition::Create
Creates a COM transition.  
  
## Syntax  
  
```  
virtual BOOL Create(  
   IUIAnimationTransitionLibrary* pLibrary,  
   IUIAnimationTransitionFactory* pFactory  
) = 0;  
```  
  
#### Parameters  
 `pLibrary`  
 A pointer to transition library, which creates standard transitions. It can be NULL for custom transitions.  
  
 `pFactory`  
 A pointer to transition factory, which creates custom transitions. It can be NULL for standard transitions.  
  
## Return Value  
 TRUE if a transition COM object was created successfully; otherwise FALSE.  
  
## Remarks  
 This is a pure virtual function that must be overridden in a derived class. It's called by the framework to instantiate the underlying COM transition object.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CBaseTransition Class](../vs140/cbasetransition-class.md)