---
title: "hash_set::const_reverse_iterator"
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
  - "hash_set::const_reverse_iterator"
  - "hash_set/stdext::hash_set::const_reverse_iterator"
  - "stdext.hash_set.const_reverse_iterator"
  - "stdext::hash_set::const_reverse_iterator"
  - "hash_set.const_reverse_iterator"
  - "const_reverse_iterator"
  - "std.hash_set.const_reverse_iterator"
  - "std::hash_set::const_reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_reverse_iterator method"
  - "const_reverse_iterator typedef"
ms.assetid: f84fd310-6df8-40ce-b1bd-ff2705e17fac
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::const_reverse_iterator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a bidirectional iterator that can read any **const** element in the hash_set.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::const_reverse_iterator const_reverse_iterator;  
```  
  
## Remarks  
 A type `const_reverse_iterator` cannot modify the value of an element and is use to iterate through the hash_set in reverse.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [rend](../vs140/hash_set--rend.md) for an example of how to declare and use the `const_reverse_iterator`  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)