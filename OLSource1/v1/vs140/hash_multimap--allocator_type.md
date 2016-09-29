---
title: "hash_multimap::allocator_type"
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
  - "std.hash_multimap.allocator_type"
  - "allocator_type"
  - "hash_multimap::allocator_type"
  - "stdext.hash_multimap.allocator_type"
  - "stdext::hash_multimap::allocator_type"
  - "std::hash_multimap::allocator_type"
  - "hash_multimap.allocator_type"
  - "hash_map/stdext::hash_multimap::allocator_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocator_type typedef"
ms.assetid: 2832216c-b26a-4cb2-b1d4-27b02f43fb5d
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::allocator_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that represents the allocator class for the hash_multimap object.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::allocator_type allocator_type;  
```  
  
## Remarks  
 `allocator_type` is a synonym for the template parameter `Allocator`.  
  
 For more information on `Allocator`, see the Remarks section of the [hash_multimap Class](../vs140/hash_multimap-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [get_allocator](../vs140/hash_multimap--get_allocator.md) for an example using `allocator_type`.  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)