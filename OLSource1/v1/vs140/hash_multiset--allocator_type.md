---
title: "hash_multiset::allocator_type"
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
  - "stdext.hash_multiset.allocator_type"
  - "hash_set/stdext::hash_multiset::allocator_type"
  - "hash_multiset.allocator_type"
  - "allocator_type"
  - "hash_multiset::allocator_type"
  - "std::hash_multiset::allocator_type"
  - "stdext::hash_multiset::allocator_type"
  - "std.hash_multiset.allocator_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocator_type typedef"
ms.assetid: bf9268b8-3f3f-48c8-907d-4ca28d144c07
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::allocator_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that represents the allocator class for the hash_multiset object.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::allocator_type allocator_type;  
```  
  
## Remark  
 `allocator_type` is a synonym for the template parameter `Allocator`.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
 For more information on `Allocator`, see the Remarks section of the [hash_multiset Class](../vs140/hash_multiset-class.md).  
  
## Example  
 See example for [get_allocator](../vs140/hash_multiset--get_allocator.md) for an example using `allocator_type`  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)