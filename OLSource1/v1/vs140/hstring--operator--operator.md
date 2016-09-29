---
title: "HString::Operator&lt; Operator"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HString::operator<"
dev_langs: 
  - "C++"
ms.assetid: 48a051cb-4609-42be-b48c-d35fc99d1eab
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HString::Operator&lt; Operator
Indicates whether the first parameter is less than the second parameter.  
  
## Syntax  
  
```cpp  
  
inline bool operator<(  
    const HString& lhs,   
    const HString& rhs) throw()  
  
```  
  
#### Parameters  
 `lhs`  
 The first parameter to compare. `lhs` can be a reference to an HString.  
  
 `rhs`  
 The second parameter to compare. `rhs` can be a reference to an HString.  
  
## Return Value  
 `true` if the `lhs` parameter is less than the `rhs` parameter; otherwise, `false`.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [HString Class](../vs140/hstring-class.md)