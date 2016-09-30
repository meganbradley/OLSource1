---
title: "hash_set::iterator"
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
  - "iterator"
  - "hash_set/stdext::hash_set::iterator"
  - "std::hash_set::iterator"
  - "hash_set.iterator"
  - "stdext.hash_set.iterator"
  - "std.hash_set.iterator"
  - "hash_set::iterator"
  - "stdext::hash_set::iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iterator method"
  - "iterator typedef"
ms.assetid: 60a09eac-2f3c-4525-972c-4272cb467b4a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::iterator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify any element in a hash_set.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::iterator iterator;  
```  
  
## Remarks  
 A type **iterator** can be used to modify the value of an element.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [begin](../vs140/hash_set--begin.md) for an example of how to declare and use **iterator**.  
  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)