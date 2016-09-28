---
title: "location::operator!= Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "concrt/concurrency::location::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!= operator"
ms.assetid: 61b1b282-294b-4856-b526-c8b76484c302
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# location::operator!= Operator
Determines whether two `location` objects represent different location.  
  
## Syntax  
  
```  
bool operator!=(  
   const location& _Rhs  
) const;  
```  
  
#### Parameters  
 `_Rhs`  
  
## Return Value  
 `true` if the two locations are different, `false` otherwise.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [location Class](../vs140/location-class.md)