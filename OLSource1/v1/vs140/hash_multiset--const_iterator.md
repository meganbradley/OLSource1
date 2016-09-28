---
title: "hash_multiset::const_iterator"
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
  - "std::hash_multiset::const_iterator"
  - "stdext.hash_multiset.const_iterator"
  - "const_iterator"
  - "hash_multiset::const_iterator"
  - "hash_multiset.const_iterator"
  - "hash_set/stdext::hash_multiset::const_iterator"
  - "std.hash_multiset.const_iterator"
  - "stdext::hash_multiset::const_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_iterator method"
  - "const_iterator typedef"
ms.assetid: 59cd2dce-0a99-4878-bded-b12ae86bd8a5
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::const_iterator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a bidirectional iterator that can read a **const** element in the hash_multiset.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::const_iterator const_iterator;  
```  
  
## Remarks  
 A type `const_iterator` cannot be used to modify the value of an element.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See example for [begin](../vs140/hash_multiset--begin.md) for an example using `const_iterator`.  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)