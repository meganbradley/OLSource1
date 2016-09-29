---
title: "location::operator== Operator"
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
  - "concrt/concurrency::location::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator== operator"
ms.assetid: e4df2dbb-2bfc-4556-a638-2de6096b4317
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# location::operator== Operator
Determines whether two `location` objects represent the same location.  
  
## Syntax  
  
```  
bool operator==(  
   const location& _Rhs  
) const;  
```  
  
#### Parameters  
 `_Rhs`  
  
## Return Value  
 `true` if the two locations are identical, and `false` otherwise.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [location Class](../vs140/location-class.md)