---
title: "is_nothrow_copy_assignable Class"
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
  - "is_nothrow_copy_assignable"
  - "std.is_nothrow_copy_assignable"
  - "std::is_nothrow_copy_assignable"
  - "type_traits/std::is_nothrow_copy_assignable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_nothrow_copy_assignable"
ms.assetid: baa8abd6-4f53-489f-abba-8d5d5c53bbbc
caps.latest.revision: 25
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_nothrow_copy_assignable Class
Tests whether type has a copy assignment operator that is known to the compiler not to throw.  
  
## Syntax  
  
```  
template<class T>  
    struct is_nothrow_copy_assignable;  
```  
  
#### Parameters  
 `T`  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true for a referenceable type `T` where `is_nothrow_assignable<T&, const T&>` holds true; otherwise it holds false.  
  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_nothrow_assignable](../vs140/is_nothrow_assignable-class.md)   
 [nothrow](../vs140/nothrow--c---.md)