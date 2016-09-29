---
title: "hash_multimap::reverse_iterator"
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
  - "reverse_iterator"
  - "stdext.hash_multimap.reverse_iterator"
  - "std.hash_multimap.reverse_iterator"
  - "std::hash_multimap::reverse_iterator"
  - "hash_multimap.reverse_iterator"
  - "hash_map/stdext::hash_multimap::reverse_iterator"
  - "hash_multimap::reverse_iterator"
  - "stdext::hash_multimap::reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_iterator typedef"
  - "reverse_iterator method"
ms.assetid: 8c846286-e736-47e2-b956-eee305f39dc0
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::reverse_iterator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed hash_multimap.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::reverse_iterator reverse_iterator;  
```  
  
## Remarks  
 A type `reverse_iterator` is used to iterate through the hash_multimap in reverse.  
  
 The `reverse_iterator` defined by hash_multimap points to objects of [value_type](../vs140/hash_multimap--value_type.md), which are of type `pair`<**const Key, Type**>. The value of the key is available through the first member pair and the value of the mapped element is available through the second member of the pair.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [rbegin](../vs140/hash_multimap--rbegin.md) for an example of how to declare and use `reverse_iterator`.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)