---
title: "is_trivially_copyable Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "is_trivially_copyable"
  - "std.is_trivially_copyable"
  - "std::is_trivially_copyable"
  - "type_traits/std::is_trivially_copyable"
dev_langs: 
  - "C++"
  - "c++"
helpviewer_keywords: 
  - "is_trivially_copyable"
ms.assetid: 89a53bf8-036c-4108-91e1-fe34adbde8b3
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_trivially_copyable Class
Tests whether the type is a trivially copyable type.  
  
## Syntax  
  
```  
template<class T>  
    struct is_trivially_copyable;  
```  
  
#### Parameters  
 `T`  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type `T` is a trivially copyable type, otherwise it holds false. Trivially copyable types have no non-trivial copy operations, move operations, or destructors. Generally, a copy operation is considered trivial if it can be implemented as a bitwise copy. Both built-in types and arrays of trivially copyable types are trivially copyable.  
  
## Requirements  
 **Header:** <type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [<type_traits>](../vs140/-type_traits-.md)