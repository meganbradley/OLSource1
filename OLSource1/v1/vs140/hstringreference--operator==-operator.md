---
title: "HStringReference::Operator== Operator"
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
  - corewrappers/Microsoft::WRL::Wrappers::HStringReference::operator==
dev_langs: 
  - C++
ms.assetid: cad3d52d-cd67-4194-a270-5239b1121a09
caps.latest.revision: 6
translation.priority.ht: 
  - de-de
  - ja-jp
---
# HStringReference::Operator== Operator
Indicates whether the two parameters are equal.  
  
## Syntax  
  
```cpp  
  
inline bool operator==(  
               const HStringReference& lhs,   
               const HStringReference& rhs) throw()  
  
inline bool operator==(  
               const HSTRING& lhs,   
               const HStringReference& rhs) throw()  
  
inline bool operator==(  
               const HStringReference& lhs,   
               const HSTRING& rhs) throw()  
  
```  
  
#### Parameters  
 `lhs`  
 The first parameter to compare. `lhs` can be an HStringReference object or an HSTRING handle.  
  
 `rhs`  
 The second parameter to compare.  `rhs` can be an HStringReference object or an HSTRING handle.  
  
## Return Value  
 `true` if the `lhs` and `rhs` parameters are equal; otherwise, `false`.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [HStringReference Class](../vs140/hstringreference-class.md)