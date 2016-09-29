---
title: "CAnimationPoint::GetAnimationVariableList"
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
  - "afxanimationcontroller/CAnimationPoint::GetAnimationVariableList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAnimationVariableList method"
ms.assetid: b35d03f5-40c3-41a2-8e0d-7a8fbce15143
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationPoint::GetAnimationVariableList
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
 When the function returns, it contains pointers to two CAnimationVariable objects representing the X and Y coordinates.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationPoint Class](../vs140/canimationpoint-class.md)