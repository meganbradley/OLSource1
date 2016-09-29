---
title: "hash_multiset::const_pointer"
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
  - "hash_multiset.const_pointer"
  - "stdext.hash_multiset.const_pointer"
  - "std.hash_multiset.const_pointer"
  - "hash_multiset::const_pointer"
  - "const_pointer"
  - "std::hash_multiset::const_pointer"
  - "hash_set/stdext::hash_multiset::const_pointer"
  - "stdext::hash_multiset::const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer typedef"
  - "const_pointer method"
ms.assetid: 82f3fa6e-3120-459d-9e82-a841cbd78c9d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::const_pointer
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that provides a pointer to a **const** element in a hash_multiset.  
  
## Syntax  
  
```  
typedef list<typename _Traits::value_type, typename _Traits::allocator_type>::const_pointer const_pointer;  
```  
  
## Remarks  
 A type `const_pointer` cannot be used to modify the value of an element.  
  
 In most cases, a [const_iterator](../vs140/hash_multiset--const_iterator.md) should be used to access the elements in a **const** hash_multiset object.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)