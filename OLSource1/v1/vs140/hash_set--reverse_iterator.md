---
title: "hash_set::reverse_iterator"
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
  - "std::hash_set::reverse_iterator"
  - "std.hash_set.reverse_iterator"
  - "hash_set.reverse_iterator"
  - "hash_set::reverse_iterator"
  - "hash_set/stdext::hash_set::reverse_iterator"
  - "stdext.hash_set.reverse_iterator"
  - "stdext::hash_set::reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_iterator typedef"
  - "reverse_iterator method"
ms.assetid: 5df29ccf-4591-4f1a-aa69-1dbe9003225f
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::reverse_iterator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify an element in a reversed hash_set.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::reverse_iterator reverse_iterator;  
```  
  
## Remarks  
 A type `reverse_iterator` is use to iterate through the hash_set in reverse.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [rbegin](../vs140/hash_set--rbegin.md) for an example of how to declare and use `reverse_iterator`.  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)