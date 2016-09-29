---
title: "hash_multiset::reverse_iterator"
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
  - "stdext::hash_multiset::reverse_iterator"
  - "std::hash_multiset::reverse_iterator"
  - "hash_multiset.reverse_iterator"
  - "stdext.hash_multiset.reverse_iterator"
  - "hash_multiset::reverse_iterator"
  - "std.hash_multiset.reverse_iterator"
  - "hash_set/stdext::hash_multiset::reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_iterator typedef"
  - "reverse_iterator method"
ms.assetid: 60c77fc5-fed2-4437-a4dc-d8b4d1043d37
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::reverse_iterator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed hash_multiset.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::reverse_iterator reverse_iterator;  
```  
  
## Remarks  
 A type `reverse_iterator` is use to iterate through the hash_multiset in reverse.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See example for [rbegin](../vs140/hash_multiset--rbegin.md) for an example of how to declare and use `reverse_iterator`.  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)