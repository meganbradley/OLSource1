---
title: "CSinusoidalTransitionFromRange::Create"
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
  - afxanimationcontroller/CSinusoidalTransitionFromRange::Create
  - Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method
ms.assetid: c74efa81-a669-4b96-9e55-e0051eb85af9
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSinusoidalTransitionFromRange::Create
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
 [CSinusoidalTransitionFromRange Class](../vs140/csinusoidaltransitionfromrange-class.md)