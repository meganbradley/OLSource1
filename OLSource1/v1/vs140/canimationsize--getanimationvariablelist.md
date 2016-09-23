---
title: "CAnimationSize::GetAnimationVariableList"
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
  - GetAnimationVariableList
  - afxanimationcontroller/CAnimationSize::GetAnimationVariableList
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetAnimationVariableList method
ms.assetid: 47dc9fcc-3bd6-432a-95a6-8ae46296cbf9
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationSize::GetAnimationVariableList
Puts the encapsulated animation variables into a list.  
  
## Syntax  
  
```  
virtual void GetAnimationVariableList(  
   CList<CAnimationVariable*,  
   CAnimationVariable*>& lst  
);  
```  
  
#### Parameters  
 `lst`  
 When the function returns, it contains pointers to two CAnimationVariable objects representing the width and height.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationSize Class](../vs140/canimationsize-class.md)