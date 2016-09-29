---
title: "restrict"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "restrict"
  - "restrict_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__declspec keyword [C++], restrict"
  - "restrict __declspec keyword"
ms.assetid: f39cf632-68d8-4362-a497-2d4c15693689
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# restrict
**Microsoft Specific**  
  
 Applied to a function declaration or definition that returns a pointer type and tells the compiler that the function returns an object that will not be aliased with any other pointers.  
  
## Syntax  
  
```  
__declspec(restrict) return_type f();  
```  
  
## Remarks  
 The compiler will propagate `__declspec(restrict)`. For example, the CRT `malloc` function is decorated with `__declspec(restrict)` and therefore, pointers initialized to memory locations with `malloc` are also implied to not be aliased.  
  
 The compiler does not check that the pointer is actually not aliased. It is the developer's responsibility to ensure the program does not alias a pointer marked with the `restrict __declspec` modifier.  
  
 For similar semantics on variables, see [__restrict](../vs140/__restrict.md).  
  
## Example  
 See [noalias](../vs140/noalias.md) for an example using `restrict`.  
  
 For information about the restrict keyword that is part of C++ AMP, see [Restriction Clause (C++ AMP)](../vs140/restrict--c---amp-.md).  
  
 **END Microsoft Specific**  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)