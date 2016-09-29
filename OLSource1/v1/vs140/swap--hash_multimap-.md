---
title: "swap (hash_multimap)"
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
  - "std.swap"
  - "std::swap"
  - "hash_map/stdext::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function"
ms.assetid: e7108c6f-f946-42f3-ade6-dfcce792bdbe
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap (hash_multimap)
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Exchanges the elements of two hash_multimaps.  
  
## Syntax  
  
```  
void swap(  
   hash_multimap <Key, Type, Traits, Alloctor>& _Left,  
   hash_multimap <Key, Type, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The hash_multimap whose elements are to be exchanged with those of the map `_Left`.  
  
 `_Left`  
 The hash_multimap whose elements are to be exchanged with those of the map `_Right`.  
  
## Remarks  
 The template function is an algorithm specialized on the container class hash_multimap to execute the member function `_Left.`[swap](../vs140/hash_multimap--swap.md)*(_Right*`)`. This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function, **template <class T\> void swap(T&, T&)**, in the algorithm header file works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for the member function [hash_multimap::swap](../vs140/hash_multimap--swap.md) for an example of the use of the template version of `swap`.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)